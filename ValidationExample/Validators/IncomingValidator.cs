using FluentValidation;
using FluentValidation.Results;
using System;
using System.Globalization;
using ValidationExample.Models;

namespace ValidationExample.Validators
{
    public class IncomingValidator : AbstractValidator<Incoming>
    {

        public IncomingValidator()
        {
            RuleFor(incoming => incoming.Workflow).NotEmpty();
            RuleFor(incoming => incoming.LastName).NotEmpty();
            RuleFor(incoming => incoming.BirthDate)
                .Must(BeDateCompatible)
                .WithMessage("'{PropertyName}' must have a date format (MM/DD/YYYY).");

        }


        private bool BeDateCompatible(string date)
        {
            if (string.IsNullOrEmpty(date))
                return false;

            string[] formats = { "M/d/yyyy", "yyyy-MM-ddTHH:mm:ssZ" };
            DateTime dateTime;
            return DateTime.TryParseExact(date, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
        }

        public override ValidationResult Validate(ValidationContext<Incoming> context)
        {
            return context == null
                ? new ValidationResult(new[] { new ValidationFailure("Incoming", "Incoming parameter cannot be null.") })
                : base.Validate(context);
        }


    }
}

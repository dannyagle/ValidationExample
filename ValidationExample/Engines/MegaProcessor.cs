using FluentValidation;
using ValidationExample.Models;
using ValidationExample.Validators;

namespace ValidationExample.Engines
{
    public class MegaProcessor
    {
        public void Process(Incoming incoming)
        {
            var validator = new IncomingValidator();
            validator.ValidateAndThrow(incoming);

            // Do some awesome work ...

        }
    }
}

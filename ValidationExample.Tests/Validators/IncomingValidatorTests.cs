using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ValidationExample.Models;
using ValidationExample.Validators;

namespace ValidationExample.Tests.Validators
{
    [TestClass]
    public class IncomingValidatorTests
    {

        [TestMethod]
        public void Workflow_WhenNull_ThrowsValidationError()
        {
            // setup
            var validator = new IncomingValidator();
            var model = new Incoming();

            // test
            try
            {
                validator.ValidateAndThrow(model);
            }
            // assert
            catch(ValidationException ex)
            {
                Assert.IsTrue(ex.Errors.Any(error => error.ErrorMessage.Contains("'Workflow'")));
            }
        }

        [TestMethod]
        public void Workflow_WhenEmpty_ThrowsValidationError()
        {
            // setup
            var validator = new IncomingValidator();
            var model = new Incoming();

            // test
            try
            {
                validator.ValidateAndThrow(model);
            }
            // assert
            catch (ValidationException ex)
            {
                Assert.IsTrue(ex.Errors.Any(error => error.ErrorMessage.Contains("'Workflow'")));
            }
        }

        [TestMethod]
        public void Workflow_WhenHasValue_NotInValidationError()
        {
            // setup
            var validator = new IncomingValidator();
            var model = new Incoming()
            {
                Workflow = "foo"
            };

            // test
            try
            {
                validator.ValidateAndThrow(model);
            }
            // assert
            catch (ValidationException ex)
            {
                Assert.IsFalse(ex.Errors.Any(error => error.ErrorMessage.Contains("'Workflow'")));
            }
        }

        [TestMethod]
        public void Incoming_WhenHasValues_NoExceptions()
        {
            // setup
            var validator = new IncomingValidator();
            var model = new Incoming
            {
                Workflow = "Good",
                FirstName = "Joe",
                LastName = "Coolio",
                Nickname = "Joey",
                BirthDate = "01/31/1980"
            };

            // test
            try
            {
                validator.ValidateAndThrow(model);
            }
            // assert
            catch (ValidationException ex)
            {
                Assert.Fail();
            }
        }

    }
}

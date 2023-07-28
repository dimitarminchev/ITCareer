using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Data
{
    public abstract class BaseService
    {
        protected bool IsEntityStateValid(object model)
        {
            var validationContext = new ValidationContext(model);
            var validationResults = new List<ValidationResult>();

            return Validator.TryValidateObject(model, validationContext, validationResults,
                validateAllProperties: true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq; 
using System.Text;
using System.Threading.Tasks; 

namespace MedID.Lib
{
    public  static class ObjectValidator
    {
        public static void ValidateObject(IValidatableObject value)
        {
            Validator.ValidateObject(value, new ValidationContext(value), true); 

        }
        public static IEnumerable<ValidationResult>TryValidateObject(IValidatableObject value)
        {
            var results = new List<ValidationResult>();
            if (Validator.TryValidateObject(value, new ValidationContext(value), results))
                return results;

            return Enumerable.Empty<ValidationResult>(); 
        }
    }
}

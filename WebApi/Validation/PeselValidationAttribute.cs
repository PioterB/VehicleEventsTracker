using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class VinValidator : ValidationAttribute
    {
        public VinValidator()
        {
        }

        public override bool IsValid(object value)
        {
            var serialized = value.ToString();

            return serialized.Length == 17;
        }
    }
}

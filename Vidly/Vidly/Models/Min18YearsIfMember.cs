using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Vidly.Models
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class Min18YearsIfMember : ValidationAttribute, IClientValidatable
    {

        protected  override ValidationResult IsValid(object value, ValidationContext context)
        {
            var customer = (Customer) context.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.UNKNOWN || customer.MembershipTypeId == MembershipType.PAYASYOUGO)
            {
                return ValidationResult.Success;
            }
            
                if (customer.BirthDate == null)
                {
                    return new ValidationResult("Birthdate is required");
                }

                var age = DateTime.Today.Year - customer.BirthDate.Value.Year;

                if (age >= 18)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Customer should be at least 18 years old to register  this membership");
                }
            
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var clientValidationRule = new ModelClientValidationRule
            {
                ValidationType = "minagerequired",
                ErrorMessage = "Customer should be at least 18 years old to register with this membership"
                
            };

            yield return clientValidationRule;
        }
    }
}

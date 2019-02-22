using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidRental.Models
{
    public class Min18Years : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //return base.IsValid(value, validationContext);
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == 1)
                return ValidationResult.Success;
            if (customer.DateOfBirth == null)
                return new ValidationResult("Date of Birth is rquired.");
            var age = DateTime.Today.Year - customer.DateOfBirth.Value.Year;
            return (age >= 18) ? ValidationResult.Success : 
                new ValidationResult("Customer should be at least 18 years old to go on a Membership");

        }
    }
}
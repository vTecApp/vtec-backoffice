using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VerticalTec.Backoffice.Models
{
    public class VerifyAgeAttribute : ValidationAttribute, IClientModelValidator
    {

        public VerifyAgeAttribute(int age)
        {
            Age = age;
        }

        public int Age { get; private set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((DateTime?)value <= DateTime.Now.AddYears(-Age))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        }

        void IClientModelValidator.AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-custom-verifyage", FormatErrorMessage(context.ModelMetadata.GetDisplayName()));
            context.Attributes.Add(
                "data-val-custom-verifyage-validationcallback",
                $@"function(options) {{
                    var now = new Date();
                    return options.value && options.value <= now.setFullYear(now.getFullYear() - {Age});
                }}");
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, name, Age);
        }
    }

    public class FormValidationModel
    {
        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        [RegularExpression(@"^[\d\w._-]+@[\d\w._-]+\.[\w]+$", ErrorMessage = "Email is invalid")]
        [Remote("CheckEmailAddress", "RemoteValidation", ErrorMessage = "Email is already registered", HttpMethod = "POST")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [RegularExpression(@"^[^0-9]+$", ErrorMessage = "Do not use digits in the Name.")]
        [StringLength(int.MaxValue, MinimumLength = 2, ErrorMessage = "Name must have at least 2 symbols")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Role is required")]
        [Display(Name = "Role")]
        public int RoleID { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "'Password' and 'Confirm Password' do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Phone")]
        [RegularExpression(@"^[02-9]\d{9}$", ErrorMessage = "The phone must have a correct USA phone format")]
        public string Phone { get; set; }

        public string Extension { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        public string Description { get; set; }

        public int Age { get; set; }

        public string Drink { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City is required")]
        [RegularExpression("^[^0-9]+$", ErrorMessage = "Do not use digits in the City name.")]
        [StringLength(int.MaxValue, MinimumLength = 2, ErrorMessage = "City must have at least 2 symbols")]
        public string City { get; set; }

        public IEnumerable<string> Colors { get; set; }

        public IEnumerable<string> SelectedColors { get; set; }

        public string Color { get; set; }

        [Display(Name = "Date of birth")]
        [Required(ErrorMessage = "Date of birth is required")]
        [VerifyAge(21, ErrorMessage = "You must be at least {1} years old")]
        public DateTime? Date { get; set; }

        [DevExtremeRequired(ErrorMessage = "You must agree to the Terms and Conditions")]
        public bool Accepted { get; set; }

        [Display(Name = "Number")]
        [Required(ErrorMessage = "Please input number")]
        [RegularExpression("[0-9]", ErrorMessage = "Input only number")]
        public decimal Number { get; set; }
    }
}

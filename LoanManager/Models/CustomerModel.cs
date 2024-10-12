using System.ComponentModel.DataAnnotations;

public class CustomerModel
{
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
    public string Email { get; set; }

    public DateTime CustomerBirthday { get; set; }


    [Key]
    public int customerID { get; set; }

    [Required(ErrorMessage = "Customer name is required.")]
    [RegularExpression(@"^([a-zA-Z]{2,}\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\s?([a-zA-Z]{1,})?)", ErrorMessage = "Invalid Name")]
    [StringLength(100)]
    public string customerName { get; set; }

    [Required(ErrorMessage = "Birthday is Required.")]
    [AgeValidation(18, 65, ErrorMessage = "Customer must be between 18 and 65 years old.")]
    public DateTime customerBirthday { get; set; }
   

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [StringLength(100)]
    public string email { get; set; }

    public class AgeValidationAttribute : ValidationAttribute
    {
        private readonly int _minAge;
        private readonly int _maxAge;

        public AgeValidationAttribute(int minAge, int maxAge)
        {
            _minAge = minAge;
            _maxAge = maxAge;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime birthDate)
            {
                var age = DateTime.Today.Year - birthDate.Year;

                if (birthDate > DateTime.Today.AddYears(-age))
                {
                    age--;
                }

                if (age < _minAge || age > _maxAge)
                {
                    return new ValidationResult(ErrorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}

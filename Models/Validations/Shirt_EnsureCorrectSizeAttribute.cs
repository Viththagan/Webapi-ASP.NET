using System.ComponentModel.DataAnnotations;

namespace webapi_frakliu.Models.Validations;

public class Shirt_EnsureCorrectSizeAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var shirt = validationContext.ObjectInstance as Shirt;

        if (shirt != null && shirt.Gender != null)
        {
            if (shirt.Gender == Gender.Male && shirt.Size < 8)
            {
                return new ValidationResult("For men's shirts, the size has to be greater or equal to 8");
            }
            else if (shirt.Gender == Gender.Female && shirt.Size < 6)
            {
                return new ValidationResult("For women's shirts, the size has to be greater or equal to 6");
            }
        }
        return ValidationResult.Success;
        // return base.IsValid(value, validationContext);
    }

}

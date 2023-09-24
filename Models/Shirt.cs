using System.ComponentModel.DataAnnotations;
using webapi_frakliu.Models.Validations;

namespace webapi_frakliu.Models;

public enum Gender
{
    Female = 0,
    Male = 1
}

public class Shirt
{
    public int Id { get; init; }

    public string? Brand { get; set; }

    [Required]
    public string? Color { get; set; }

    [Required]
    [Shirt_EnsureCorrectSize]
    public double? Size { get; set; }

    [Required]
    public Gender? Gender { get; set; }
    public double? Price { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace MachineProblem1.Models
{
    public class CookBookRecipe_Tbl
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Food name is required.")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Food name must be between 2 and 200 characters.")]
        public string Food_Name { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Ingredients are required.")]
        [MinLength(5, ErrorMessage = "Ingredients must be at least 5 characters long.")]
        public string Ingredients { get; set; } = string.Empty;

        [Required(ErrorMessage = "Instructions are required.")]
        [MinLength(10, ErrorMessage = "Instructions must be at least 10 characters long.")]
        public string Instructions { get; set; } = string.Empty;
    }
}
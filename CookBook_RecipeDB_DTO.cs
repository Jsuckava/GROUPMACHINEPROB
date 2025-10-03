namespace MachineProblem1.DTO
{
    public class CookBook_RecipeReadDTO
    {
        public string Food_Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Ingredients { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
    }

    public class CookBook_RecipeCreateDTO
    {
        public string Food_Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Ingredients { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
    }

    public class CookBook_RecipeUpdateDTO
    {
        public string Food_Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Ingredients { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
    }
}


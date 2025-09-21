namespace MachineProblem1.DTO
{
    public class CookBook_RecipeReadMapper
    {
        public string Food_Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Ingredients { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
    }

    public class CookBook_RecipeCreateMapper
    {
        public string Food_Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Ingredients { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
    }

    public class CookBook_RecipeUpdateMapper
    {
        public string Food_Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Ingredients { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
    }
}

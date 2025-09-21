using MachineProblem1.Models;
using MachineProblem1.DTO;
using AutoMapper;
namespace MachineProblem1.Profiles
{
    public class CookBook_RecipeDBProfile : Profile
    {
        public CookBook_RecipeDBProfile() {
            CreateMap<CookBookRecipe_Tbl, CookBook_RecipeReadMapper>();
            CreateMap<CookBook_RecipeCreateMapper, CookBookRecipe_Tbl>();
            CreateMap<CookBook_RecipeUpdateMapper, CookBookRecipe_Tbl>();
        }
    }
}
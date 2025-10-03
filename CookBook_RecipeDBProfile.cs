using MachineProblem1.Models;
using MachineProblem1.DTO;
using AutoMapper;
namespace MachineProblem1.Profiles
{
    public class CookBook_RecipeDBProfile : Profile
    {
        public CookBook_RecipeDBProfile() {
            CreateMap<CookBookRecipe_Tbl, CookBook_RecipeReadDTO>();
            CreateMap<CookBook_RecipeCreateDTO, CookBookRecipe_Tbl>();
            CreateMap<CookBook_RecipeUpdateDTO, CookBookRecipe_Tbl>();
        }
    }

}

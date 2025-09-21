using AutoMapper;
using MachineProblem1.DTO;
using MachineProblem1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class RecipesController : ControllerBase
{
    private readonly CookBookRecipeDbContext _context;
    private readonly IMapper _mapper;

    public RecipesController(CookBookRecipeDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CookBook_RecipeReadMapper>>> GetAll()
    {
        var recipes = await _context.RecipesTB.ToListAsync();
        var result = _mapper.Map<IEnumerable<CookBook_RecipeReadMapper>>(recipes);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CookBook_RecipeReadMapper>> GetById(int id)
    {
        var recipe = await _context.RecipesTB.FindAsync(id);
        if (recipe is null) return NotFound();
        return Ok(_mapper.Map<CookBook_RecipeReadMapper>(recipe));
    }

    [HttpPost]
    public async Task<ActionResult<CookBook_RecipeReadMapper>> Create(CookBook_RecipeCreateMapper recipeDto)
    {
        var recipe = _mapper.Map<CookBookRecipe_Tbl>(recipeDto);
        _context.RecipesTB.Add(recipe);
        await _context.SaveChangesAsync();

        var readDto = _mapper.Map<CookBook_RecipeReadMapper>(recipe);
        return CreatedAtAction(nameof(GetById), new { id = recipe.Id }, readDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, CookBook_RecipeUpdateMapper recipeDto)
    {
        var recipe = await _context.RecipesTB.FindAsync(id);
        if (recipe is null) return NotFound();

        _mapper.Map(recipeDto, recipe);
        if (!TryValidateModel(recipe)) return BadRequest(ModelState);

        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var recipe = await _context.RecipesTB.FindAsync(id);
        if (recipe is null) return NotFound();

        _context.RecipesTB.Remove(recipe);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}

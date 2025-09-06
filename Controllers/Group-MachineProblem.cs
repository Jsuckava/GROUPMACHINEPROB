using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MachineProblem1.Models;

namespace MachineProblem.Controller;

[ApiController]
[Route("api/[controller]")]
public class CrudforMachineProb : ControllerBase
{
    private readonly TeachersDbContext _context;

    public CrudforMachineProb(TeachersDbContext context) => _context = context;

    [HttpGet]
    public async Task<IEnumerable<TblTeacher>> GetAll() =>
        await _context.TblTeachers.ToListAsync();

    [HttpGet("{id}")]
    public async Task<ActionResult<TblTeacher>> GetById(int id)
    {
        var teacher = await _context.TblTeachers.FindAsync(id);
        return teacher is null ? NotFound() : teacher;
    }

    [HttpPost]
    public async Task<ActionResult<TblTeacher>> Create(TblTeacher teacher)
    {
        _context.TblTeachers.Add(teacher);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = teacher.Id }, teacher);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, TblTeacher teacher)
    {
        if (id != teacher.Id) return BadRequest();
        _context.Entry(teacher).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var teacher = await _context.TblTeachers.FindAsync(id);
        if (teacher is null) return NotFound();
        _context.TblTeachers.Remove(teacher);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}

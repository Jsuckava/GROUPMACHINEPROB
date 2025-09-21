using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MachineProblem1.Models;

public partial class CookBookRecipeDbContext : DbContext
{
    public CookBookRecipeDbContext()
    {
    }

    public CookBookRecipeDbContext(DbContextOptions<CookBookRecipeDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<CookBookRecipe_Tbl> RecipesTB { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CookBook_RecipeDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

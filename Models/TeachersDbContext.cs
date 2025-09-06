using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MachineProblem1.Models;

public partial class TeachersDbContext : DbContext
{
    public TeachersDbContext()
    {
    }

    public TeachersDbContext(DbContextOptions<TeachersDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblTeacher> TblTeachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=TeachersDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblTeacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbl_Teac__3214EC07C0D7EBF2");

            entity.ToTable("tbl_Teachers");

            entity.Property(e => e.TeacherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teacherName");
            entity.Property(e => e.YearOfExperience).HasColumnName("yearOfExperience");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

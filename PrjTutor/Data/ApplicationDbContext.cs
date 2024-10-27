using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrjTutor;
using PrjTutor.Models;
using SQLitePCL;

namespace PrjTutor.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        var admin = new IdentityRole("admin")
        {
            NormalizedName = "ADMIN"
        };

        var tutor = new IdentityRole("tutor")
        {
            NormalizedName = "TUTOR"
        };

        builder.Entity<IdentityRole>().HasData(admin, tutor);
        
    }
    public DbSet<PrjTutor.Student> Student { get; set; } = default!;
    public DbSet<PrjTutor.Assignment> Assignment { get; set; } = default!;
    public DbSet<PrjTutor.Feedback> Feedback { get; set; } = default!;
    public DbSet<PrjTutor.Evaluation> Evaluation { get; set; } = default!;
}


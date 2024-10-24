using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrjTutor;

namespace PrjTutor.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<PrjTutor.Student> Student { get; set; } = default!;
    public DbSet<PrjTutor.Assignment> Assignment { get; set; } = default!;
    public DbSet<PrjTutor.Feedback> Feedback { get; set; } = default!;
    public DbSet<PrjTutor.Evaluation> Evaluation { get; set; } = default!;
}


using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace UniversityManagementV2.Data
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext() { }

        public UniversityDbContext(DbContextOptions<UniversityDbContext> dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExamResult>().HasKey(er => new { er.StudentId, er.ExamId});
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

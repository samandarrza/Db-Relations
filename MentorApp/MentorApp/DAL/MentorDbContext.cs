using MentorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.DAL
{
    public class MentorDbContext : DbContext
    {
        public MentorDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<CourseTeacher> CourseTeachers { get; set; }
    }
}

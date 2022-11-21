using Microsoft.EntityFrameworkCore;
using YummyApp.Models;

namespace YummyApp.DAL
{
    public class YummyDbContext : DbContext
    {
        public YummyDbContext(DbContextOptions<YummyDbContext> options) : base(options)
        {

        }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<MealIngredient> MealIngredients { get; set; }
    }
}

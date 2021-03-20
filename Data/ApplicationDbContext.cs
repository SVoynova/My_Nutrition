using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace My_Nutrition.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<MyNutritionApp.Models.FoodModel> FoodModel { get; set; }
        public DbSet<MyNutritionApp.Models.UserPlan> User { get; set; }
        public DbSet<My_Nutrition.Models.JournalModel> JournalModel { get; set; }
        public DbSet<My_Nutrition.Models.UserProgress> UserProgress { get; set; }
    }
}

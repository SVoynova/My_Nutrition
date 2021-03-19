using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MyNutritionApp.Models;
using My_Nutrition.Models;

namespace My_Nutrition.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MyNutritionApp.Models.FoodModel> FoodModel { get; set; }
        public DbSet<MyNutritionApp.Models.UserProgress> User { get; set; }
        public DbSet<My_Nutrition.Models.JournalModel> JournalModel { get; set; }
    }
}

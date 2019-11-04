using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TrainingManagementSystem.Models;

namespace TrainingManagementSystem.DatabaseContext
{
    public class TrainingDbContext:DbContext
    {
        public TrainingDbContext()
        {
            
        }
        public DbSet<Course> Courses { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=TrainingDb11;Integrated Security=true");
         }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             base.OnModelCreating(modelBuilder);
         }
    }
}

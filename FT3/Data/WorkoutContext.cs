using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FT3.Models;

    public class WorkoutContext : DbContext
    {
        public WorkoutContext (DbContextOptions<WorkoutContext> options)
            : base(options)
        {
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exercise>().HasData(
            new Exercise {exerciseID=357, exerciseName = "Bench Press", exerciseType="Strength", exerciseMax = 205 },
            new Exercise { exerciseID = 358, exerciseName = "Squat", exerciseType = "Strength", exerciseMax = 305 },
            new Exercise { exerciseID = 359, exerciseName = "Deadlift", exerciseType = "Strength", exerciseMax = 325 }
            );
    }
        public DbSet<FT3.Models.Workout> Workout { get; set; }

        public DbSet<FT3.Models.Exercise> Exercise { get; set; }

        public DbSet<FT3.Models.Set> Set { get; set; }

        public DbSet<FT3.Models.Session> Session { get; set; }

    
    }

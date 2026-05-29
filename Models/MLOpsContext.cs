using Microsoft.EntityFrameworkCore;
using System;

namespace MLOps_Dashboard.Models
{
    public class MLOpsContext : DbContext
    {
        public MLOpsContext(DbContextOptions<MLOpsContext> options) : base(options) { }

        public DbSet<Dataset> Datasets { get; set; }
        public DbSet<Architecture> Architectures { get; set; }
        public DbSet<Hyperparameter> Hyperparameters { get; set; }
        public DbSet<TrainingRun> TrainingRuns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 1. Seed Datasets
            modelBuilder.Entity<Dataset>().HasData(
                new Dataset { Id = 1, Name = "MNIST", Rows = 70000, FeaturesCount = 784 },
                new Dataset { Id = 2, Name = "Titanic", Rows = 891, FeaturesCount = 12 }
            );

            // 2. Seed Architectures
            modelBuilder.Entity<Architecture>().HasData(
                new Architecture { Id = 1, Name = "Random Forest", Description = "Ensemble decision trees" },
                new Architecture { Id = 2, Name = "Convolutional Neural Network", Description = "Standard CNN for image classification" }
            );

            // 3. Seed a Hyperparameter
            modelBuilder.Entity<Hyperparameter>().HasData(
                new Hyperparameter { Id = 1, ArchitectureId = 1, Key = "n_estimators", Value = "100" }
            );

            // 4. Seed Training Runs
            modelBuilder.Entity<TrainingRun>().HasData(
                new TrainingRun { Id = 1, DatasetId = 1, ArchitectureId = 2, Accuracy = 0.985, TrainingTimeMs = 45000, Timestamp = new DateTime(2026, 1, 1) },
                new TrainingRun { Id = 2, DatasetId = 2, ArchitectureId = 1, Accuracy = 0.821, TrainingTimeMs = 1200, Timestamp = new DateTime(2026, 1, 2) }
            );
        }
    }
}
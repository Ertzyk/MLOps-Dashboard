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
            // 1. Datasets
            modelBuilder.Entity<Dataset>().HasData(
                new Dataset { Id = 1, Name = "MNIST (Digits)", Rows = 70000, FeaturesCount = 784 },
                new Dataset { Id = 2, Name = "Titanic Survival", Rows = 891, FeaturesCount = 12 },
                new Dataset { Id = 3, Name = "S&P 500 Daily Options", Rows = 250000, FeaturesCount = 45 },
                new Dataset { Id = 4, Name = "CIFAR-10", Rows = 60000, FeaturesCount = 3072 },
                new Dataset { Id = 5, Name = "Credit Card Fraud", Rows = 284807, FeaturesCount = 30 }
            );

            // 2. Architectures
            modelBuilder.Entity<Architecture>().HasData(
                new Architecture { Id = 1, Name = "Random Forest", Description = "Ensemble decision trees" },
                new Architecture { Id = 2, Name = "CNN (ResNet-18)", Description = "Deep residual network" },
                new Architecture { Id = 3, Name = "XGBoost", Description = "Gradient boosted trees" },
                new Architecture { Id = 4, Name = "LSTM", Description = "Time-series recurrent network" },
                new Architecture { Id = 5, Name = "Transformer (BERT)", Description = "Attention-based NLP model" },
                new Architecture { Id = 6, Name = "SVM (Linear)", Description = "Support Vector Machine" }
            );

            // 3. Hyperparameters
            modelBuilder.Entity<Hyperparameter>().HasData(
                // Random Forest params
                new Hyperparameter { Id = 1, ArchitectureId = 1, Key = "n_estimators", Value = "500" },
                new Hyperparameter { Id = 2, ArchitectureId = 1, Key = "max_depth", Value = "25" },
                
                // CNN (ResNet-18) params
                new Hyperparameter { Id = 3, ArchitectureId = 2, Key = "learning_rate", Value = "0.001" },
                new Hyperparameter { Id = 4, ArchitectureId = 2, Key = "batch_size", Value = "64" },
                
                // XGBoost params
                new Hyperparameter { Id = 5, ArchitectureId = 3, Key = "eta", Value = "0.05" },
                new Hyperparameter { Id = 6, ArchitectureId = 3, Key = "subsample", Value = "0.8" },
                
                // LSTM params
                new Hyperparameter { Id = 7, ArchitectureId = 4, Key = "hidden_units", Value = "256" },
                
                // SVM params
                new Hyperparameter { Id = 8, ArchitectureId = 6, Key = "C", Value = "1.0" },
                new Hyperparameter { Id = 9, ArchitectureId = 6, Key = "kernel", Value = "linear" }
            );

            // 4. Training Runs
            modelBuilder.Entity<TrainingRun>().HasData(
                // MNIST
                new TrainingRun { Id = 1, DatasetId = 1, ArchitectureId = 1, Accuracy = 0.941, TrainingTimeMs = 12000, Timestamp = new DateTime(2026, 5, 10) },
                new TrainingRun { Id = 2, DatasetId = 1, ArchitectureId = 2, Accuracy = 0.993, TrainingTimeMs = 340000, Timestamp = new DateTime(2026, 5, 11) },
                new TrainingRun { Id = 3, DatasetId = 1, ArchitectureId = 6, Accuracy = 0.915, TrainingTimeMs = 4500, Timestamp = new DateTime(2026, 5, 12) },
                
                // Titanic
                new TrainingRun { Id = 4, DatasetId = 2, ArchitectureId = 1, Accuracy = 0.821, TrainingTimeMs = 800, Timestamp = new DateTime(2026, 5, 13) },
                new TrainingRun { Id = 5, DatasetId = 2, ArchitectureId = 3, Accuracy = 0.845, TrainingTimeMs = 1200, Timestamp = new DateTime(2026, 5, 14) },
                
                // S&P 500 
                new TrainingRun { Id = 6, DatasetId = 3, ArchitectureId = 1, Accuracy = 0.531, TrainingTimeMs = 85000, Timestamp = new DateTime(2026, 5, 15) },
                new TrainingRun { Id = 7, DatasetId = 3, ArchitectureId = 4, Accuracy = 0.592, TrainingTimeMs = 920000, Timestamp = new DateTime(2026, 5, 16) },
                new TrainingRun { Id = 8, DatasetId = 3, ArchitectureId = 3, Accuracy = 0.565, TrainingTimeMs = 110000, Timestamp = new DateTime(2026, 5, 17) },

                // CIFAR-10
                new TrainingRun { Id = 9, DatasetId = 4, ArchitectureId = 2, Accuracy = 0.942, TrainingTimeMs = 1850000, Timestamp = new DateTime(2026, 5, 18) },
                new TrainingRun { Id = 10, DatasetId = 4, ArchitectureId = 1, Accuracy = 0.450, TrainingTimeMs = 45000, Timestamp = new DateTime(2026, 5, 19) },

                // Credit Card Fraud
                new TrainingRun { Id = 11, DatasetId = 5, ArchitectureId = 3, Accuracy = 0.999, TrainingTimeMs = 34000, Timestamp = new DateTime(2026, 5, 20) },
                new TrainingRun { Id = 12, DatasetId = 5, ArchitectureId = 6, Accuracy = 0.985, TrainingTimeMs = 12000, Timestamp = new DateTime(2026, 5, 21) }
            );
        }
    }
}
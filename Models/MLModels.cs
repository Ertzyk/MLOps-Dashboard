#nullable disable
using System;
using System.Collections.Generic;

namespace MLOps_Dashboard.Models
{
    public class Dataset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rows { get; set; }
        public int FeaturesCount { get; set; }
        
        // Navigation property for 1-to-Many relationship
        public List<TrainingRun> TrainingRuns { get; set; }
    }

    public class Architecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        // Navigation properties
        public List<Hyperparameter> Hyperparameters { get; set; }
        public List<TrainingRun> TrainingRuns { get; set; }
    }

    public class Hyperparameter
    {
        public int Id { get; set; }
        public int ArchitectureId { get; set; } // Foreign Key
        public string Key { get; set; }
        public string Value { get; set; }
        
        // Navigation property
        public Architecture Architecture { get; set; }
    }

    public class TrainingRun
    {
        public int Id { get; set; }
        public int DatasetId { get; set; } // Foreign Key
        public int ArchitectureId { get; set; } // Foreign Key
        public double Accuracy { get; set; }
        public double TrainingTimeMs { get; set; }
        public DateTime Timestamp { get; set; }
        
        // Navigation properties
        public Dataset Dataset { get; set; }
        public Architecture Architecture { get; set; }
    }
}
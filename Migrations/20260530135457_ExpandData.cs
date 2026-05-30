using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MLOps_Dashboard.Migrations
{
    /// <inheritdoc />
    public partial class ExpandData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hyperparameters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Architectures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Deep residual network", "CNN (ResNet-18)" });

            migrationBuilder.InsertData(
                table: "Architectures",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 3, "Gradient boosted trees", "XGBoost" },
                    { 4, "Time-series recurrent network", "LSTM" },
                    { 5, "Attention-based NLP model", "Transformer (BERT)" },
                    { 6, "Support Vector Machine", "SVM (Linear)" }
                });

            migrationBuilder.UpdateData(
                table: "Datasets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "MNIST (Digits)");

            migrationBuilder.UpdateData(
                table: "Datasets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Titanic Survival");

            migrationBuilder.InsertData(
                table: "Datasets",
                columns: new[] { "Id", "FeaturesCount", "Name", "Rows" },
                values: new object[,]
                {
                    { 3, 45, "S&P 500 Daily Options", 250000 },
                    { 4, 3072, "CIFAR-10", 60000 },
                    { 5, 30, "Credit Card Fraud", 284807 }
                });

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Accuracy", "ArchitectureId", "Timestamp", "TrainingTimeMs" },
                values: new object[] { 0.94099999999999995, 1, new DateTime(2026, 5, 20, 15, 54, 56, 42, DateTimeKind.Local).AddTicks(6426), 12000.0 });

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Accuracy", "ArchitectureId", "DatasetId", "Timestamp", "TrainingTimeMs" },
                values: new object[] { 0.99299999999999999, 2, 1, new DateTime(2026, 5, 21, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(546), 340000.0 });

            migrationBuilder.InsertData(
                table: "TrainingRuns",
                columns: new[] { "Id", "Accuracy", "ArchitectureId", "DatasetId", "Timestamp", "TrainingTimeMs" },
                values: new object[,]
                {
                    { 4, 0.82099999999999995, 1, 2, new DateTime(2026, 5, 23, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(601), 800.0 },
                    { 3, 0.91500000000000004, 6, 1, new DateTime(2026, 5, 22, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(593), 4500.0 },
                    { 5, 0.84499999999999997, 3, 2, new DateTime(2026, 5, 24, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(607), 1200.0 },
                    { 6, 0.53100000000000003, 1, 3, new DateTime(2026, 5, 25, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(612), 85000.0 },
                    { 7, 0.59199999999999997, 4, 3, new DateTime(2026, 5, 26, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(616), 920000.0 },
                    { 8, 0.56499999999999995, 3, 3, new DateTime(2026, 5, 27, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(621), 110000.0 },
                    { 9, 0.94199999999999995, 2, 4, new DateTime(2026, 5, 28, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(626), 1850000.0 },
                    { 10, 0.45000000000000001, 1, 4, new DateTime(2026, 5, 29, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(630), 45000.0 },
                    { 11, 0.999, 3, 5, new DateTime(2026, 5, 30, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(635), 34000.0 },
                    { 12, 0.98499999999999999, 6, 5, new DateTime(2026, 5, 30, 10, 54, 56, 48, DateTimeKind.Local).AddTicks(639), 12000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architectures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Architectures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Architectures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Architectures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Datasets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Datasets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Datasets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Architectures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Standard CNN for image classification", "Convolutional Neural Network" });

            migrationBuilder.UpdateData(
                table: "Datasets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "MNIST");

            migrationBuilder.UpdateData(
                table: "Datasets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Titanic");

            migrationBuilder.InsertData(
                table: "Hyperparameters",
                columns: new[] { "Id", "ArchitectureId", "Key", "Value" },
                values: new object[] { 1, 1, "n_estimators", "100" });

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Accuracy", "ArchitectureId", "Timestamp", "TrainingTimeMs" },
                values: new object[] { 0.98499999999999999, 2, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45000.0 });

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Accuracy", "ArchitectureId", "DatasetId", "Timestamp", "TrainingTimeMs" },
                values: new object[] { 0.82099999999999995, 1, 2, new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200.0 });
        }
    }
}

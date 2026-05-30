using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MLOps_Dashboard.Migrations
{
    /// <inheritdoc />
    public partial class StaticMockData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hyperparameters",
                columns: new[] { "Id", "ArchitectureId", "Key", "Value" },
                values: new object[,]
                {
                    { 1, 1, "n_estimators", "500" },
                    { 2, 1, "max_depth", "25" },
                    { 3, 2, "learning_rate", "0.001" },
                    { 4, 2, "batch_size", "64" },
                    { 5, 3, "eta", "0.05" },
                    { 6, 3, "subsample", "0.8" },
                    { 7, 4, "hidden_units", "256" },
                    { 8, 6, "C", "1.0" },
                    { 9, 6, "kernel", "linear" }
                });

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2026, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2026, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateTime(2026, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateTime(2026, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 6,
                column: "Timestamp",
                value: new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 7,
                column: "Timestamp",
                value: new DateTime(2026, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timestamp",
                value: new DateTime(2026, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 9,
                column: "Timestamp",
                value: new DateTime(2026, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timestamp",
                value: new DateTime(2026, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 11,
                column: "Timestamp",
                value: new DateTime(2026, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 12,
                column: "Timestamp",
                value: new DateTime(2026, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hyperparameters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hyperparameters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hyperparameters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hyperparameters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hyperparameters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hyperparameters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hyperparameters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hyperparameters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hyperparameters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2026, 5, 20, 15, 54, 56, 42, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2026, 5, 21, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2026, 5, 22, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateTime(2026, 5, 23, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateTime(2026, 5, 24, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 6,
                column: "Timestamp",
                value: new DateTime(2026, 5, 25, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 7,
                column: "Timestamp",
                value: new DateTime(2026, 5, 26, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timestamp",
                value: new DateTime(2026, 5, 27, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 9,
                column: "Timestamp",
                value: new DateTime(2026, 5, 28, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timestamp",
                value: new DateTime(2026, 5, 29, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 11,
                column: "Timestamp",
                value: new DateTime(2026, 5, 30, 15, 54, 56, 48, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "TrainingRuns",
                keyColumn: "Id",
                keyValue: 12,
                column: "Timestamp",
                value: new DateTime(2026, 5, 30, 10, 54, 56, 48, DateTimeKind.Local).AddTicks(639));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class addedNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_Apointments_ApointmentId",
                        column: x => x.ApointmentId,
                        principalTable: "Apointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 7, 22, 13, 20, 44, 897, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20dfb7b8-bc0c-4714-92e2-0acb41719ca7", new DateTime(2023, 7, 19, 13, 20, 44, 897, DateTimeKind.Local).AddTicks(6690), "AHp4iObg9AVU6fJ138aURGEmp7haEZHkValQByQ3Gj4sYcXz1U4m46voVBFB4+xi/g==", "37e14955-4195-4f6b-af57-80f983e2f6ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "998195d3-4f18-4a32-bcbb-9a73cc42fa16", new DateTime(2023, 7, 19, 13, 20, 44, 898, DateTimeKind.Local).AddTicks(1779), "AL++d9EUBzb9t+QH4LRUwjpjKTw8srTquy9TBBWFo83IyYETgbw5OfK1OJJ74dJx9Q==", "2f13cb6b-01b1-4793-8fd4-937f59859433" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ba4b72b-bc9f-4e9a-966c-af8267fb5d36", new DateTime(2023, 7, 19, 13, 20, 44, 899, DateTimeKind.Local).AddTicks(4738), "AKaXc/3P5VqO66MZyC4cTsLbtOTMa+XzX3/uDlN1hAhNbOWU5Vn1G8xCvp1ILpu2pg==", "a28a6632-b58c-433d-b357-47421db5fbc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "838af1cb-5fc4-4b5b-b93d-da756528456a", new DateTime(2023, 7, 19, 13, 20, 44, 898, DateTimeKind.Local).AddTicks(6658), "AL524ZqJTJC+0dgOuOgY1XblypH/gPtNrtFbO2gazVGat18uUFARk99nXGBDhYOujQ==", "bf09ebdf-5377-45d3-9025-177dc05e9e4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bafd27bc-5de5-4f6a-b66b-e98f0e03d08d", new DateTime(2023, 7, 19, 13, 20, 44, 899, DateTimeKind.Local).AddTicks(9339), "ACY/Rs5tfcRGUfQe2ClaAsbJaRohRNWqzC3AOJKqvPg8XHhuLuxLwdHMPtXVrqRW3Q==", "2a5036a1-2e06-4852-9179-fea6d2b0ed71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9cbd95e-9ed1-48ce-8fad-d5bd685248fd", new DateTime(2023, 7, 19, 13, 20, 44, 897, DateTimeKind.Local).AddTicks(964), "AL7dShTQ8Maf4oOXqg6sgUUbmcqc8cDa+N11z2AnTjMnCuxtGH9PH2HxFg5G4CX7YQ==", "d4194cee-52e2-46e0-bb64-21233cd1ee94" });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_ApointmentId",
                table: "Notes",
                column: "ApointmentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 7, 21, 17, 11, 41, 891, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04c842ee-a864-4649-85c4-b7f64a9b41da", new DateTime(2023, 7, 18, 17, 11, 41, 892, DateTimeKind.Local).AddTicks(8634), "AExp5guvxxNfFyCoslCbXLeInkLPfj6Lru/T8DjsDzpNGtS6MMAba63+hZIMD9+MZQ==", "27b4743a-989d-41ea-8283-278dc4e7cc0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "360f08c3-0fda-4b09-8e77-99dca48cecd5", new DateTime(2023, 7, 18, 17, 11, 41, 893, DateTimeKind.Local).AddTicks(5666), "APIYXYPGwrbLr+D3LLX989PdabgypSdhK10Kx8DKJiKGIh5rv/u6i+WGkeMfnOarsQ==", "a1903987-297d-4b0c-a070-c4b47d4b1a92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45d37733-9974-412c-9824-340187a799fc", new DateTime(2023, 7, 18, 17, 11, 41, 894, DateTimeKind.Local).AddTicks(8976), "ANMEc/CsS8FVEgPb1L+YWG/5Pl2T180ZN79TD5lyL2cbRa2SRJpZSWE6a422sFUsnA==", "ba84a557-5aec-43c3-8114-754b3cf764cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45c9bec1-d999-47b0-a802-ce8a36f2a19d", new DateTime(2023, 7, 18, 17, 11, 41, 894, DateTimeKind.Local).AddTicks(2510), "AEmQsmjZ4ud5JIojx9S7L8bkWS1ydr0KFJqzRHSWFubEZ1gWtIv0XF1OaTA/Y/iX1w==", "b5297bb5-8aed-4acd-bb8f-1835f2fd456b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4339c162-bd80-430b-a0c9-dcfc4a1cfb5f", new DateTime(2023, 7, 18, 17, 11, 41, 895, DateTimeKind.Local).AddTicks(5329), "AJGJ++KWeXLSe1G2urdG8Tu8xzTeVi6Ia45ISbMNLuynzbkJ9nryK9nQC9jfF0mH7w==", "cc567a41-629e-40f5-a402-bcba1084fe80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e27bd545-113b-4d9a-92ec-60ecbc8980ce", new DateTime(2023, 7, 18, 17, 11, 41, 891, DateTimeKind.Local).AddTicks(7619), "AE1NXcU2X1yIVS4HtyB/tZafLlgQNLOnB56nXJrtUhrQ1Rei0JzNWydnJAFKWg4KHg==", "2a8869c8-d656-4e12-8225-877657955751" });
        }
    }
}

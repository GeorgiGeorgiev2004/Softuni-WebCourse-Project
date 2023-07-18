using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class AddedABoolVariableToCheckIfTheAppointementIsConfirmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "Apointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "Apointments");

            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 7, 18, 13, 25, 7, 807, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35e9dca7-973b-4a48-bab6-3c5f7d136920", new DateTime(2023, 7, 15, 13, 25, 7, 808, DateTimeKind.Local).AddTicks(3346), "AFg11ujtBDInCWFQV8W5OAcDO63u23YJ54PZEqMICKEbS6ksBnJ9BN4d/vij7fGOPw==", "91ff241b-7578-4db1-a6f7-534277f21614" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65e56ac3-06c5-4507-90d3-049de7360f76", new DateTime(2023, 7, 15, 13, 25, 7, 808, DateTimeKind.Local).AddTicks(8356), "AKK59rkKB8vQ9pgsy3oVEJmzPG7rq6w2JEzVEgOOdwMpzVpW8NtZvrzKn/ARMb6KjQ==", "c6d88a1b-2dd8-45c7-8000-f3e8a7d22b36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5209554b-f035-4c6a-99cf-caacd6d052b2", new DateTime(2023, 7, 15, 13, 25, 7, 809, DateTimeKind.Local).AddTicks(7555), "ACLBiSSKszdZdIwAm6I5WSKTlayi8JD3L7xAqFfUIMpPMMFDuC0Y/u6AcQOF9tNjtw==", "13763a29-c735-4dec-ab81-a665799020d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b15806ee-1031-4d14-9ec0-0a8506b13406", new DateTime(2023, 7, 15, 13, 25, 7, 809, DateTimeKind.Local).AddTicks(3075), "AMnJlYlUP4kaiaN4rTKPPIulw6D+zN+5nmM8P6mid57W+2cyGiqETev/DF/bndcWRw==", "a2f55b05-fde1-48e2-9100-f45d12658d1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b8ba1ce-9d1a-4f99-b999-f94950e7bff3", new DateTime(2023, 7, 15, 13, 25, 7, 810, DateTimeKind.Local).AddTicks(2003), "AFs6PxnYs/FobKZiQtkWXpVpaPDjR5BoMTU5diyyClQa4d2WxQwD0c2dBtTqW42RRg==", "2b777686-5ea5-4835-a8c6-314bee47a0c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da2914c9-0622-470f-bd1c-24a228d89db2", new DateTime(2023, 7, 15, 13, 25, 7, 807, DateTimeKind.Local).AddTicks(8734), "AGMkSMt50/JgngAN53l0VVHSObqLv2AaOngJRqLCPNJiyybt0josESTDc4Z4crMHww==", "2059f20b-4362-4f64-8f83-970f5e1deb4e" });
        }
    }
}

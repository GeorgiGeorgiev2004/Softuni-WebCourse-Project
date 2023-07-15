using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class fixedUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "35e9dca7-973b-4a48-bab6-3c5f7d136920", new DateTime(2023, 7, 15, 13, 25, 7, 808, DateTimeKind.Local).AddTicks(3346), "ILIQ STELIOV", "AFg11ujtBDInCWFQV8W5OAcDO63u23YJ54PZEqMICKEbS6ksBnJ9BN4d/vij7fGOPw==", "91ff241b-7578-4db1-a6f7-534277f21614", "Iliq Steliov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "65e56ac3-06c5-4507-90d3-049de7360f76", new DateTime(2023, 7, 15, 13, 25, 7, 808, DateTimeKind.Local).AddTicks(8356), "IVAN IVANOV", "AKK59rkKB8vQ9pgsy3oVEJmzPG7rq6w2JEzVEgOOdwMpzVpW8NtZvrzKn/ARMb6KjQ==", "c6d88a1b-2dd8-45c7-8000-f3e8a7d22b36", "Ivan Ivanov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5209554b-f035-4c6a-99cf-caacd6d052b2", new DateTime(2023, 7, 15, 13, 25, 7, 809, DateTimeKind.Local).AddTicks(7555), "NIKOLA ZEMELYARSKI", "ACLBiSSKszdZdIwAm6I5WSKTlayi8JD3L7xAqFfUIMpPMMFDuC0Y/u6AcQOF9tNjtw==", "13763a29-c735-4dec-ab81-a665799020d9", "Nikola Zemelyarski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b15806ee-1031-4d14-9ec0-0a8506b13406", new DateTime(2023, 7, 15, 13, 25, 7, 809, DateTimeKind.Local).AddTicks(3075), "LILIAL IZBRANNIKOV", "AMnJlYlUP4kaiaN4rTKPPIulw6D+zN+5nmM8P6mid57W+2cyGiqETev/DF/bndcWRw==", "a2f55b05-fde1-48e2-9100-f45d12658d1e", "Lilial Izbrannikov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3b8ba1ce-9d1a-4f99-b999-f94950e7bff3", new DateTime(2023, 7, 15, 13, 25, 7, 810, DateTimeKind.Local).AddTicks(2003), "DEMBE REDGLADE", "AFs6PxnYs/FobKZiQtkWXpVpaPDjR5BoMTU5diyyClQa4d2WxQwD0c2dBtTqW42RRg==", "2b777686-5ea5-4835-a8c6-314bee47a0c4", "Dembe Redglade" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "da2914c9-0622-470f-bd1c-24a228d89db2", new DateTime(2023, 7, 15, 13, 25, 7, 807, DateTimeKind.Local).AddTicks(8734), "GEORGI GEORGIEV", "AGMkSMt50/JgngAN53l0VVHSObqLv2AaOngJRqLCPNJiyybt0josESTDc4Z4crMHww==", "2059f20b-4362-4f64-8f83-970f5e1deb4e", "Georgi Georgiev" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 7, 18, 12, 13, 54, 835, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4f87e09e-e22f-4b10-9347-7aa3fca58501", new DateTime(2023, 7, 15, 12, 13, 54, 836, DateTimeKind.Local).AddTicks(4189), "ILIQ_STELIOV", "AEJXJzEdJFIt+075kj3KIJEGA8HWAV3NOQ8PVnEy2PZ9HBIOAnMuq6sYP2hhjLzSYQ==", "a4046a54-4267-43e4-bbd2-b4d5eb37fefb", "Iliq_Steliov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3dc176fb-1792-4dee-a6dc-668162e9580e", new DateTime(2023, 7, 15, 12, 13, 54, 836, DateTimeKind.Local).AddTicks(8919), "IVAN_IVANOV", "AHW0GbAzQkHV0T2H6XUrZwUAgIWvXF2tti4neDx5FO8AB8WJCBSj31s/7j235vCIwg==", "86bed827-281b-41f8-9671-60fe909207bd", "Ivan_Ivanov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "65fc96f1-9c6c-4608-b70f-d289d81856c9", new DateTime(2023, 7, 15, 12, 13, 54, 837, DateTimeKind.Local).AddTicks(8369), "NIKOLA_ZEMELYARSKI", "AKQMmPdwJxDaiVJbDBjm9K9AGezuBWc8146s2qWTUQdJhrF1q2pFO4HRVRXcyszvhg==", "1f901e8e-8bf6-48a6-a1e9-fbe47318ff98", "Nikola_Zemelyarski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0aed490e-3dd0-49f3-8493-65a473366ccd", new DateTime(2023, 7, 15, 12, 13, 54, 837, DateTimeKind.Local).AddTicks(3675), "LILIAL_IZBRANNIKOV", "AC7CWhb57mJLz97W3uvuYVz2RB2AvUfZ0rgC2uwVfuefT2/0rTzELa8Uwnm8THbeLg==", "b024b507-982f-4986-9dc8-236bb2e63e72", "Lilial_Izbrannikov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ad19efa9-6bb1-473c-af52-7ea3207641af", new DateTime(2023, 7, 15, 12, 13, 54, 838, DateTimeKind.Local).AddTicks(3078), "DEMBE_REDGLADE", "AIeVQ57A1uT3GnbQfvAP9XnX+OD5Et9BxjvW8ckG3PGBypoSkvndr4YhNsEOgF2Oiw==", "51c51e0c-4f35-41d1-aee8-c4691ccd3e9d", "Dembe_Redglade" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "290950c7-8b6d-420e-bb18-e21c84aed0d1", new DateTime(2023, 7, 15, 12, 13, 54, 835, DateTimeKind.Local).AddTicks(9250), "GEORGI_GEORGIEV", "AN6LupnnkigAecn+s+r301NNuBD/Fiqij+AISo0yvltjqnMz9sqmIrzFBs8OLbg2AA==", "806a7241-70a8-4da5-9226-73591a2dc4b5", "Georgi_Georgiev" });
        }
    }
}

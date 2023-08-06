using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class FixingTheMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbf4e751-ee98-4682-9b1c-956b19c197b4", new DateTime(2023, 8, 6, 21, 53, 45, 925, DateTimeKind.Local).AddTicks(5412), "APJYvntAy3wP2W1n9h/f5lwpGtvMEKx5/xqLsIwVftUVGSGR8zDTz0nAKSOycn+Zrw==", "3ebe6772-806b-478b-a704-0c1e3449a677" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28b645fd-8e93-47a6-aab2-50f4bee4f63d", new DateTime(2023, 8, 6, 21, 53, 45, 926, DateTimeKind.Local).AddTicks(241), "AAa2NXerFof9vZRvEiYGbl6WqMzjbjpZHC5LQvv0Fd8tYqI2e50ncYafDlqwlwJMMg==", "79364946-5c25-4fb3-8ff5-11b5a7535917" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a890fa31-075e-4992-8cd4-9a60f9a83a14", new DateTime(2023, 8, 6, 21, 53, 45, 926, DateTimeKind.Local).AddTicks(9869), "AMHtenza7pkDEtv69jh0JqbKjszJBS3meHPIh49QSDEwyLZZoyXgcCYhWgkS22U9Yw==", "d791e46d-f166-4b4e-b9ce-539b3b5b692c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f11d8809-9611-4bf7-83d7-cd2e0ae3464e", new DateTime(2023, 8, 6, 21, 53, 45, 926, DateTimeKind.Local).AddTicks(5043), "AO5sz2shKxgrsWW3rV3Uf2U9v4Yzhr8A3zQEpV6sp/Yi/0QfOmgnTPPk0GDRf7PE3Q==", "3c10c12f-21f8-49df-9cda-d2ce3f3e664a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f987a134-a461-4ae4-a373-afd89f58d6ad", new DateTime(2023, 8, 6, 21, 53, 45, 927, DateTimeKind.Local).AddTicks(4711), "AMBNlWisdo4vibrohP2Si6EWtHvtnJtyVgpYBjKriWU3AjGw2ypnUbJ/eWYO9dkpAA==", "9cbef09d-805c-4026-a98f-46a53e4cd67e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a63f5e21-7fc5-44ce-8bfa-d942f4bb954f", new DateTime(2023, 8, 6, 21, 53, 45, 925, DateTimeKind.Local).AddTicks(365), "ALNr1LnsLDKGAsvxsROLSj/4ZOh8+qdwF3eWz7RT5Z4+qrrDIuNcIq2ltP/C7c5I7Q==", "a3d4fbbe-f6c5-4001-ae90-5712f1b80459" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "TypeOfUser",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd740442-fb76-40e5-a18f-1cdd208f28d1", new DateTime(2023, 8, 6, 21, 46, 52, 734, DateTimeKind.Local).AddTicks(6455), "AEcA/ejqnNTjV3xFnntuRUnjXbNsDUdIklVALGmK6JlA4bQUA/1/0mxEOuWOne1vKg==", "51b233d0-7288-40d4-9a52-da1d251a84b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c79887e6-0a85-4b7e-8e29-f63cf28f9a95", new DateTime(2023, 8, 6, 21, 46, 52, 735, DateTimeKind.Local).AddTicks(9354), "ALXWdkXClJAw/zhAHWksfub/nDnjnyi/4PvrEEHjEsbUHISLW6hPuvwDMnRDOLhi6A==", "627aa816-6a80-420d-84d2-c8aa987efc62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2618b071-54ed-49f7-92b5-4f6d15d535ea", new DateTime(2023, 8, 6, 21, 46, 52, 737, DateTimeKind.Local).AddTicks(723), "AMt9zf0fNFMmf3azrRysAoQk0qrF03qRRWoe97+9ehDQaXPWSezF7qWAAtXg93r27Q==", "a7f32d1e-4829-4a97-9c4d-c13f53fe8f58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e30b91f-ba06-445c-a1ac-12910b5beb93", new DateTime(2023, 8, 6, 21, 46, 52, 736, DateTimeKind.Local).AddTicks(5103), "APbykox6zCDwE36narFJtcwsyONMgGETXqwb1NDL6lbTXGX3Q9KDMSGKv2GCFPHVhg==", "37d235b6-9809-48b3-a354-7aa5ed864338" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "510dd830-ffd2-4ad3-8f5d-0606ad42830e", new DateTime(2023, 8, 6, 21, 46, 52, 737, DateTimeKind.Local).AddTicks(6341), "AP0CdOZl3vTR/8TFPtO8fdvhw0qOcX9uokOoGarGe88DhOK4UtLG58xVukKX427o+w==", "e683bb38-e0cf-4564-8e0b-9b2b4b86eed4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "762aeb0d-0d04-40a4-bfdc-8765a323b014", new DateTime(2023, 8, 6, 21, 46, 52, 733, DateTimeKind.Local).AddTicks(9837), "AEafGIyNEempmpjhUa8KxLl2xOKaPhC7dDxHXQPcTQomCZHaLpVg5eXch7PrJ/z9Nw==", "fed208ea-9c8d-4ee2-b61b-1b1f2156f6ab" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "TypeOfUser",
                value: 0);
        }
    }
}

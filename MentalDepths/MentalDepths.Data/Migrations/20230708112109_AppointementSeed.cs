using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class AppointementSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Apointments",
                columns: new[] { "Id", "Address", "ApplicationUserId", "DateAndTime", "SpecialistId" },
                values: new object[] { new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"), "Office", new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"), new DateTime(2023, 7, 11, 14, 21, 8, 385, DateTimeKind.Local).AddTicks(6938), new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d153388-2984-42c1-bfd6-6bf47247cc3d", new DateTime(2023, 7, 8, 14, 21, 8, 386, DateTimeKind.Local).AddTicks(5185), "ALyYg/MtbXApm7vKaSuKe8EysfgMlLecKAksmNiLi1ZPAl8aUxf9PNoLuXwlyStMaw==", "0b4887d5-53ec-4322-a365-6be9e3f237f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d37450b9-99f9-4b22-ac9e-4a6393c9305a", new DateTime(2023, 7, 8, 14, 21, 8, 387, DateTimeKind.Local).AddTicks(3359), "AFZiEn91sueKp73RGpwAEGz+w7tDrcLoUdqDVWSYlmDmv086mC6LyXJ0CvgJBPojwA==", "83cf51a3-10ad-405d-834f-bf53b4a4d2f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "821d3eff-0199-49fb-b420-795aa2521f0a", new DateTime(2023, 7, 8, 14, 21, 8, 388, DateTimeKind.Local).AddTicks(9380), "AE/1lGfryL3l5zY27sVU1/4H+w5M9mbnj5T72CtrkG+K1GqZ7fNNBmRHSPp/Awo/sg==", "9d0e9e5a-05e1-418d-ba1b-a1ed0e632996" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6fdb78e-76cc-450f-a8fd-b7e5b382ab20", new DateTime(2023, 7, 8, 14, 21, 8, 388, DateTimeKind.Local).AddTicks(1259), "ABYfIJvJkLkvpvOrkXs13Y6a9lwxPpVMk1DXWNG1sNI3TbCEtqyGHrMrJQIDRxUpCg==", "96f26e4f-f359-4769-b393-c3ae9278d12a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "244b762f-7dac-4cc7-a8bb-7d99061fdbcd", new DateTime(2023, 7, 8, 14, 21, 8, 389, DateTimeKind.Local).AddTicks(6637), "AAu1ZJ6PGbgglhsqTbl0AQPmS7Ok7W1YDk9zNjnuEX6BLaAPVcGM4RIEQN5mjj1V6w==", "654f3397-9930-4fcf-8c6b-89b83d096fb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d00ea2d-4f3b-49ac-8979-ea1d5689567e", new DateTime(2023, 7, 8, 14, 21, 8, 385, DateTimeKind.Local).AddTicks(7151), "AMSCQPYHMJeKbC4k4lvISmHDpj8yLSvsnnuyk7LedNCfXm9hJZfMvnmQU0zfe/qiyQ==", "85756270-0354-4c75-8c41-668634c4c631" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22ea5948-ceac-4c95-9dad-9f455ef7693f", new DateTime(2023, 7, 8, 13, 52, 54, 236, DateTimeKind.Local).AddTicks(3069), "AIn4TEuhOmdRC03NsQUeEs4JlJ2pSuLpYLDHz9zAXLB2XyJud2hb4gD2vnSCFLTYpw==", "573bdc9a-87e5-4305-9c97-37089e52ef1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7ca3edf-690f-4a59-ac18-b35d91aea744", new DateTime(2023, 7, 8, 13, 52, 54, 237, DateTimeKind.Local).AddTicks(662), "AAVLPCU5n6TJBYWKfjHtq5GBQfD21K3qwyWof1i9zCzN8wYNUkO5O8U+LIdo/AJRkw==", "7bdaa8ce-aae9-4090-9025-455a5771c8f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "befc14c4-64d4-46af-99be-d33f33de1360", new DateTime(2023, 7, 8, 13, 52, 54, 238, DateTimeKind.Local).AddTicks(5712), "ABgYk+FZs8GNI/ADIxUaHmn5sz4vh5c00xITy86/2pbP3lVC6h1muK8DY9PeKWsKLw==", "c110be23-76bb-4a00-a11f-4880492090f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8471f2b6-644e-452c-8437-e6a450f72c07", new DateTime(2023, 7, 8, 13, 52, 54, 237, DateTimeKind.Local).AddTicks(8476), "AOM151TS4M9NQOnLZwD7PMxBAf3XZQntyXzC6NuJWMgRG+izvjPq4vi7gIXMIPukqA==", "3c85f2a3-131a-4cfc-bab8-2f2cff0bb489" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77d012de-d878-4b30-a7b6-b0cce5931abc", new DateTime(2023, 7, 8, 13, 52, 54, 239, DateTimeKind.Local).AddTicks(2951), "AD11LSfL9I58/nSCK9aHZCm15+UQGK7292cxyDvK9k7SOgNRC7R3u4ekEIe/4xOQXA==", "4b817e56-13a3-4551-8580-64558b298d0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c86341c4-e3f7-46aa-b5b1-a80e2719542f", new DateTime(2023, 7, 8, 13, 52, 54, 235, DateTimeKind.Local).AddTicks(5580), "ABeY++4678dQE4bO8F3QFj4mxgl6hwTkfEGlcSH9/ebeIKmUBTKB04IaMtoqO53vgA==", "4174e564-1f71-4b5c-89da-f62e0cfb741b" });
        }
    }
}
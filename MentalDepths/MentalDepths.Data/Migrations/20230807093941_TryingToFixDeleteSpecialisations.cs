using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class TryingToFixDeleteSpecialisations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0de25f4e-1853-4561-812c-e3d7aa13bedf", new DateTime(2023, 8, 7, 12, 39, 39, 661, DateTimeKind.Local).AddTicks(3991), "AERemxvxVw8sK3hY0ap508v52tMWpG1SSEIHI+S3K3Ye8G69DIe3J3XmPqbH0keuqw==", "7ba60120-9283-4b02-8459-7d14ceb55161" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4e8dd73-ccd6-45e2-a3f9-aeb93c6954ee", new DateTime(2023, 8, 7, 12, 39, 39, 662, DateTimeKind.Local).AddTicks(1946), "AHe6Dfc4xS7cPxeWqxaVSvKs8lsFhKi4aSZdr7BUw1Fyv6dIB3AWjyEFjL3vaKMdcA==", "dbf5f276-b502-4cf8-adc7-810f115ee2f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39d2d21d-6c44-4b7c-9529-75a4bd0331c3", new DateTime(2023, 8, 7, 12, 39, 39, 663, DateTimeKind.Local).AddTicks(6917), "AKov8wL2Sqj0VWWCUexw/jyqEwAVsAE1J9OBXB6Q7kbVz0ezrZPeH08yVh+iDpFB0w==", "7ecb3b69-6342-4a00-beea-411818a76ff6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55ccf7e9-9496-46d9-9af9-81c2b2c5bb46", new DateTime(2023, 8, 7, 12, 39, 39, 662, DateTimeKind.Local).AddTicks(9176), "AFEWbGjFAqc5mdtzcxS59Reuq1XSpKluxUPehZMLhWaZd4oTWEBYfkgBGa3GOMPD0g==", "ce50ba5f-d62a-4252-a733-fb517fd97ec8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af7e68d6-36b7-417a-b57c-44bbd64bc4ef", new DateTime(2023, 8, 7, 12, 39, 39, 664, DateTimeKind.Local).AddTicks(4762), "AO51nl8+hyToH+nnR3mBl7F9kmdmaeyakT+PZy9EQdzm4DQSu+2i2FJauHdtLys5TA==", "04c0d527-8898-4845-8198-5e90b6f35f02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c22667c-d268-4040-8f28-8e1c971cea72", new DateTime(2023, 8, 7, 12, 39, 39, 660, DateTimeKind.Local).AddTicks(4812), "AAKiSxvbLITSwgMSUhAPn+lu06OJ1fVia0/iv9vCWeZlIL1YfzeEuL3imwBFbYdMxA==", "c1cdbbcc-3ba2-4083-83b4-323c6559b115" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class Trynumer2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecondName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("11ec3631-f87a-4c3a-823e-c8713aaad84a"), 0, 5, "1e63008e-deea-4701-a3f4-f99a3514c053", new DateTime(2023, 7, 7, 23, 32, 36, 313, DateTimeKind.Local).AddTicks(9802), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ScaryHaxer@yahoo.com", false, "Iliq", false, "Steliov", false, null, "SCARYHAXER@YAHOO.COM", "ILIQ_STELIOV", "ABXkRxK+93o8vksguHkaQiY/GH8TCod2cI1m84qojujPeLCLqA79IO8pNcerp3CyPw==", null, false, "", "f6c5204e-7a80-4c6c-aff5-3861b7b218c0", false, "Iliq_Steliov" },
                    { new Guid("3410c43f-0266-4b48-999e-e4e19391f554"), 0, 13, "5db713f8-43f0-45af-9c32-7c53bd1aec78", new DateTime(2023, 7, 7, 23, 32, 36, 315, DateTimeKind.Local).AddTicks(4261), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lilial_Izbora@abv.bg", false, "Lilial", false, "Izbrannikov", false, null, "LILIAL_IZBORA@ABV.BG", "LILIAL_IZBRANNIKOV", "AKMeHGYyOb5+oyTCms7ok/AcxVKxphEPlavaGoE+5al54nQj0XoMQjd+igZsgf3rpg==", null, false, "Sabiev", "009dc9ca-b478-4ee5-a8b4-cf2a2a80807e", false, "Lilial_Izbrannikov" },
                    { new Guid("8883d37b-43bd-4256-9f46-adecfe2d997d"), 0, 17, "16b88bce-aafd-4446-accc-6545a4d2ca38", new DateTime(2023, 7, 7, 23, 32, 36, 316, DateTimeKind.Local).AddTicks(8876), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DembeRed@alo.net", false, "Dembe", false, "Redglade", false, null, "DEMBERED@ALO.NET", "DEMBE_REDGLADE", "AFWvGuhUN33m7Zc92aZVkjgzg1dgIsg9w7qj3Ajmb051z7WS5mdOxdRxxqUOBGsRww==", null, false, "Nisantimetarottebe", "900c434d-5324-4a7b-8fcc-b6eab4d532d3", false, "Dembe_Redglade" },
                    { new Guid("a632be87-766f-4049-9b89-1f4055ec5f30"), 0, 27, "c09ceefe-7cad-418e-bd1e-1fb665e2edc2", new DateTime(2023, 7, 7, 23, 32, 36, 314, DateTimeKind.Local).AddTicks(7028), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan.Ivanov234@gmail.bg", true, "Ivan", false, "Ivanov", false, null, "IVAN.IVANOV234@GMAIL.BG", "IVAN_IVANOV", "AHiKBBYm7vEMdfMFzR0njf3Xl6qi4Tv0VJIVrwwXLVGHk6wQFfRHaVAXyusKlwvjlQ==", null, false, "Sirov", "51faae4f-c5fc-4817-aebf-df9f2da18dbf", false, "Ivan_Ivanov" },
                    { new Guid("e84a2911-5c9c-4014-86ee-9e171362c65c"), 0, 2, "5b1054f1-1c57-4b96-a844-89607fc14ac4", new DateTime(2023, 7, 7, 23, 32, 36, 313, DateTimeKind.Local).AddTicks(1890), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "gogo_5a@abv.bg", true, "Georgi", false, "Georgiev", false, null, "GOGO_5A@ABV.BG", "GEORGI_GEORGIEV", "AB7FHxFKRuKFt2QYvJtwSCwYS4WRXxnoCRJs5BQV+tUKQ+f9KIfn7JLYfkxy/W470w==", null, false, "Lyubenov", "a37835aa-d3c0-421d-8bac-c33844231267", false, "Georgi_Georgiev" },
                    { new Guid("f6911c58-9478-4da1-97e6-ecb9b04e29ed"), 0, 22, "978b04c6-a43f-4385-a309-2cf89ed0c109", new DateTime(2023, 7, 7, 23, 32, 36, 316, DateTimeKind.Local).AddTicks(1491), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kolio_Zemev@gmail.com", true, "Nikola", false, "Zemelyarski", false, null, "KOLIO_ZEMEV@GMAIL.COM", "NIKOLA_ZEMELYARSKI", "AMTxVhSuVASeQSmVMyqzC+lig9pC8CskFbDOkB4GEMKmhsPZjvlw26QQL0bmC+9RQQ==", null, false, "", "4d28234a-6a95-4511-b96d-039b0d21bcaa", false, "Nikola_Zemelyarski" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("11ec3631-f87a-4c3a-823e-c8713aaad84a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3410c43f-0266-4b48-999e-e4e19391f554"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8883d37b-43bd-4256-9f46-adecfe2d997d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a632be87-766f-4049-9b89-1f4055ec5f30"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e84a2911-5c9c-4014-86ee-9e171362c65c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6911c58-9478-4da1-97e6-ecb9b04e29ed"));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class AddingCustomRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 8, 2, 18, 14, 18, 651, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6739ea41-06f7-42e3-969a-b879c3f83657", new DateTime(2023, 7, 30, 18, 14, 18, 652, DateTimeKind.Local).AddTicks(2844), "ILIQ_STELIOV", "ADb0C9rYboFPHAArl41xbgMPP7fg2RbB1Mqo+swLa/yF1jPTfX+CYTYKo4Gp9iXk4A==", "d4fbb0b1-d9fe-488d-8012-30be4084ade3", "Iliq_Steliov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bd4ac0aa-0656-43cc-a784-e7423a0aee02", new DateTime(2023, 7, 30, 18, 14, 18, 652, DateTimeKind.Local).AddTicks(7221), "IVAN_IVANOV", "ADpP7MrJrbj/pH+7jYsNjp0Xi0dJOVFBYhurZfw9SqQ+JWffG+kv5cTLZj6D1zubTQ==", "76386193-5922-4757-a689-1044a3199c5b", "Ivan_Ivanov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "776d5bdd-4e6a-413b-979a-1cf202a9b2c8", new DateTime(2023, 7, 30, 18, 14, 18, 653, DateTimeKind.Local).AddTicks(6021), "AD8+Gh994sM4BZUR2JEr3Rs3Z3xFKRvSj820ZDLdrlhKeyu12mRsy6Yhf+vaXZkqnw==", "69b1986e-cb05-45d2-a50a-54f2620f1b73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d92d5245-02d6-4d18-8600-2bb05629d5ef", new DateTime(2023, 7, 30, 18, 14, 18, 653, DateTimeKind.Local).AddTicks(1625), "LILIAL_IZBRANNIKOV", "AKND1xAWx2u0UPjdduWNu7GiGP4Lr9hAuy1RsF5aUCTW1gVo0yElVLnHzivMySyI9A==", "51f7d163-52d6-453d-95fe-ab5d57e6372b", "Lilial_Izbrannikov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bbfd7b4f-0ffb-4c5f-a812-36a25309af8e", new DateTime(2023, 7, 30, 18, 14, 18, 654, DateTimeKind.Local).AddTicks(410), "DEMBE_REDGLADE", "AFTtnnMUcwKQERgs98wRAc5evokfs4uw2/AmMJjA3+z9GMx6bcKvNT4uVM6NdEYIuw==", "679a99b0-a0cb-44cd-8d0b-a3ab5ab2143c", "Dembe_Redglade" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "46e8e5ba-0d7e-442c-9935-75861bb9203e", new DateTime(2023, 7, 30, 18, 14, 18, 651, DateTimeKind.Local).AddTicks(8245), "GEORGI_GEORGIEV", "AB8/JnPanwvtu7KdcO1d+goNpFAVn1g8TUqKvGerNKWQVh5sh4xBOY7pDCXYI6Y6sA==", "c791de29-b44f-4e0e-8977-ad46e4ce069f", "Georgi_Georgiev" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 8, 2, 14, 55, 44, 857, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "efef9d31-5018-4f1a-b782-2d265293c191", new DateTime(2023, 7, 30, 14, 55, 44, 858, DateTimeKind.Local).AddTicks(4643), "ILIQ STELIOV", "ADP1OsUvuqAKUH3amEhMEwHT3JetCHOc/0TVnzui+vv1eCognPUMUxZdFMb4ncS6IA==", "18b748ba-3fab-4bf1-9cd8-9da0976b7261", "Iliq Steliov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bc0a35c5-f956-4d84-81ca-fb34260c7f98", new DateTime(2023, 7, 30, 14, 55, 44, 858, DateTimeKind.Local).AddTicks(9037), "IVAN IVANOV", "AKbarcuYkx+XKWpBS4aKeS44drd01NPT19iUuRoOQlnpOwFJ5fhI267DuTS2FolmzQ==", "3b20c2ee-fb60-4aeb-8b7a-92a11e6d3d8d", "Ivan Ivanov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9a2d3d3-d78d-42dd-b29d-841b619bbe65", new DateTime(2023, 7, 30, 14, 55, 44, 859, DateTimeKind.Local).AddTicks(8334), "AG6GdbvvGQAdmDsmcZn7ak+uNGXwOyb6jtkkI+uh3jWB4o7hdm+WD2jOUrIp4ZyH6Q==", "521ca682-2aaa-4222-b7ba-315f84093e87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cc1f607c-78b3-4806-8813-015c0c9d8308", new DateTime(2023, 7, 30, 14, 55, 44, 859, DateTimeKind.Local).AddTicks(3461), "LILIAL IZBRANNIKOV", "AIllWNtuWrj8z6gOsOz+L1qHNOpQ3FqnVs3lMKZgxrGIW4OLqCwbaQuqOXA0BH3hWg==", "bb17b77c-8e1e-4625-91ce-1efa7a986bbe", "Lilial Izbrannikov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d50a3315-fb99-4838-9733-2b5120ac1fb8", new DateTime(2023, 7, 30, 14, 55, 44, 860, DateTimeKind.Local).AddTicks(5527), "DEMBE REDGLADE", "AAWwHizGsZA5KryVCTLzQgHMU55X2SATKWTUxYqlRCKhAMMYJcpaiIkvwy/tqS1GYw==", "5057384a-7f4e-48a9-8edd-5b2e96745b51", "Dembe Redglade" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3ab3d893-3ed8-48e8-a96e-125c5c3c5d26", new DateTime(2023, 7, 30, 14, 55, 44, 858, DateTimeKind.Local).AddTicks(86), "GEORGI GEORGIEV", "ANYsFCRRcfDnbSC14SxVjWQVhO67rb7OMfOcmABk4YZEBBbKEOUgw+pp26jo9cSsZw==", "34b013fe-c8a0-4c87-aa01-89e7d4a3bcc9", "Georgi Georgiev" });
        }
    }
}

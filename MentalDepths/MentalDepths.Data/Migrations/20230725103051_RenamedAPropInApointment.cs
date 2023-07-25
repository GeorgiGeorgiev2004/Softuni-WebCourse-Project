using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class RenamedAPropInApointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsConfirmed",
                table: "Apointments",
                newName: "HasPassed");

            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 7, 28, 13, 30, 51, 374, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd063a6b-cc50-4142-813e-bda9ce70a765", new DateTime(2023, 7, 25, 13, 30, 51, 374, DateTimeKind.Local).AddTicks(8057), "ACVM7cZrUTzkHdt0D1CSZqlvSuN2W4C1thucb2sFxVc8Y5v/aFVXakdrrQPXAxdLiA==", "be0c6242-0473-4a9e-9902-a2f20c29fc10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b77be76d-1837-4661-a732-7e206fe1630f", new DateTime(2023, 7, 25, 13, 30, 51, 375, DateTimeKind.Local).AddTicks(2514), "AN2go2mwOKwwds1q5lxUqgxJHm/RTtQGGxtYgnjgYjmJZSSvOCASv6pGdziuAWdcMw==", "a6c8c5ac-696d-4103-84e3-f5cb1534cc14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ed4cd89-34c6-458a-9441-788ba704da84", new DateTime(2023, 7, 25, 13, 30, 51, 376, DateTimeKind.Local).AddTicks(1443), "APkQNxtnwEZH+3Sg5XZsItqTM5PzdHn5nkrgkVtDtBN3sSyMjT938LZvlG+0sziduA==", "7f506934-0507-497d-a2ba-c40859a99d99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dda733bd-72f0-4bb5-a55e-0d7d54b1ebda", new DateTime(2023, 7, 25, 13, 30, 51, 375, DateTimeKind.Local).AddTicks(6946), "ADexlP6JBbCs/ttbdQmFSwesV35sRzjoartW0CwbCVMVvBoUenfTccSMy13oyjYF3A==", "72e4b961-934a-4954-bda9-f9568635ebc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "030ab307-ee7d-4807-ba8d-93c89f45be4f", new DateTime(2023, 7, 25, 13, 30, 51, 376, DateTimeKind.Local).AddTicks(5876), "AKhqSOzxPbffMRQSmd/18We2rTUjigNfT072cp6NpXkQtrlxbPqjWJwokjqCSB+Ypg==", "676e0587-bcf2-4312-a133-f367ee893912" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a6ee73c-a13a-4115-a503-6c7294ebd862", new DateTime(2023, 7, 25, 13, 30, 51, 374, DateTimeKind.Local).AddTicks(3448), "AAreF+9NChbO/folRLcRq5S406QSeW/v+RouJ8byblwK8sZVMl58rHzdAyKx8PPCuQ==", "bd04c87f-16b4-4767-8d96-0820dfc7626a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HasPassed",
                table: "Apointments",
                newName: "IsConfirmed");

            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 7, 24, 16, 16, 27, 565, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0397a018-0f2e-45c0-b5c5-a21c3bf7fe64", new DateTime(2023, 7, 21, 16, 16, 27, 566, DateTimeKind.Local).AddTicks(3952), "AA7/NLisF18nR4ggSh4nxL8Z58B7B8LrjlRuh/DMV8/ZopPFnZ10e2BVXJZo4gluiA==", "156fe437-0b54-437d-891c-05ba71d01043" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "674eaff3-e1ac-43d4-82b1-bfd17f814e0e", new DateTime(2023, 7, 21, 16, 16, 27, 567, DateTimeKind.Local).AddTicks(1348), "AE7QZqETWYorewWDNU9sEGpVvyDZzJW6P+W6Oys74a3lD9rYVNP6qwIqbsurw2Z3Ag==", "b7fbfd07-f43b-474e-89df-0daf3628f5ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cdf0c22-c44a-4344-9bc9-bb0ef9ce4965", new DateTime(2023, 7, 21, 16, 16, 27, 568, DateTimeKind.Local).AddTicks(6168), "ANHMTvfOdjZJkbU+ZHk4/o4ahz3yagTgBD9wRjXRst7A+2GD7hp0l4ZihGiT8mf6lw==", "1a537de8-7787-4965-bcbf-04da69c7b62c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c55c9a43-ae15-48ea-9e82-012b0fc0ae57", new DateTime(2023, 7, 21, 16, 16, 27, 567, DateTimeKind.Local).AddTicks(8795), "AI9b0dHYhUw874JpScVzOrmusiAnEpL2L/5ME8zd74wn5pFoRPQTGWjA1FP1FTCEiw==", "a6c56ab9-25aa-4e32-b22e-a6e748f1619e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e15e970-7bfb-4333-b8fc-436327e93301", new DateTime(2023, 7, 21, 16, 16, 27, 569, DateTimeKind.Local).AddTicks(3520), "APYzT8pej8aIRp2Hl6MDwwjFkCHVgEsYarnn8eVWHD/XTd+VXDhg7xVU5PBnSLIJDg==", "04d8ae8d-fd89-41f0-84db-9848fb14a598" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5951f3e2-3bb1-4385-85a8-dfd578ef7881", new DateTime(2023, 7, 21, 16, 16, 27, 565, DateTimeKind.Local).AddTicks(6325), "AGyHis1+ukALA6uLegiVGl+CfRur1ChFb2QHUp/1FOC54xpiVq26z1AyKJuO969A/A==", "e4841524-702a-4881-888b-b995f85045cb" });
        }
    }
}

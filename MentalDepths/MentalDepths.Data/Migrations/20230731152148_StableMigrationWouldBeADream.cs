using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class StableMigrationWouldBeADream : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 8, 3, 18, 21, 47, 916, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "295b326f-3dea-4eee-b81b-8b4a9380df57", new DateTime(2023, 7, 31, 18, 21, 47, 916, DateTimeKind.Local).AddTicks(7517), "AOIC5GdTpaogdS6KBW0pyOuIEiStSu5WTbKNfU4L+8pGdgFmNjwyubMHhjEjc/F+/A==", "e6f9ab92-28d1-4e73-bd28-933a13cd582e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b4612e6-dc63-43b5-b9fb-066f4f79a9df", new DateTime(2023, 7, 31, 18, 21, 47, 917, DateTimeKind.Local).AddTicks(2362), "AB6C1FHmpavOIzyHXdtqXAZF/CoKuUi2kR14dV4l62gihTeXed30092VC13jBy/j4g==", "e36dd3a8-f6a2-4879-95d1-5d9c11bc6cb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c115ea6-69e7-44fd-b00a-09533a524294", new DateTime(2023, 7, 31, 18, 21, 47, 918, DateTimeKind.Local).AddTicks(2074), "AJ5YLptCnx5O++J37xXOsSiNITALb4C7JkPDwNBbCxCUEnbOfQ+6xUSd6i+kMuWxwQ==", "ae92b36a-fead-4e86-a954-2226bf1e9e1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f07f24d-d38e-456c-8d8a-258e640794e3", new DateTime(2023, 7, 31, 18, 21, 47, 917, DateTimeKind.Local).AddTicks(7215), "ABIto7UuPe9o0aXoI5jDBwiXwYosyRN4zlxWo4Dm3hbbhCVZ4LuGJV0H/VUKMj0heg==", "3e8b1da0-2e98-447b-9d1a-ffd8446abc98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ce38cd0-12d6-4fc8-be0e-2fdb9b62dd34", new DateTime(2023, 7, 31, 18, 21, 47, 918, DateTimeKind.Local).AddTicks(6951), "AEHot6pgszNzjaWyvJ7QPCP5aPHmxk/z0nhBRek+fg7Xrx7/q//hkpFY60mWagSh8Q==", "579d85ca-427f-40df-878a-86c9a04cbef3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9f3f8ca-b0dc-4b1e-9f99-8953173a8036", new DateTime(2023, 7, 31, 18, 21, 47, 916, DateTimeKind.Local).AddTicks(2571), "AGJZqjhQlwLWIOk1sfLRV56/J9briUrLhLcme+L9TB9eyiOMbHt8Y6rxvxmsBKpPww==", "c865121f-e238-4517-a724-773ee36645a7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 8, 3, 17, 26, 0, 578, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b46c074d-f257-4514-87a7-03367ce4b30d", new DateTime(2023, 7, 31, 17, 26, 0, 579, DateTimeKind.Local).AddTicks(3365), "ANZ2wVsY3TRBgGWvlmmOMlpXFehUXyzCp0DxYcwQingZvkk2REW6H3ht9/EOQ4+ReQ==", "3a2b9b7c-cf9f-495d-8ccb-60fb5c4f3eed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8a52a93-dd7e-493c-9fc7-483f5a97b5c7", new DateTime(2023, 7, 31, 17, 26, 0, 579, DateTimeKind.Local).AddTicks(7857), "AE24tkR8XcSkn3K+9HTtyuPCAzO86GRsxdSbDXkHi5TX12yPrdZ1l9ffGUs4o8C+gg==", "7baa5fb9-71d8-4538-ac4f-c0282b743276" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fe2731b-7c39-4409-9cb8-2afce25564b6", new DateTime(2023, 7, 31, 17, 26, 0, 580, DateTimeKind.Local).AddTicks(6929), "AJM8PnHNhWxoDLA70wApDo1wc+/ag2+gG2uYKMjd+P1q7EJAU4UMHpEdFqliX8G7QA==", "e38cd50e-eb30-4073-af13-bfdafe185983" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e954efab-ec62-4569-8681-14d42af7e2ca", new DateTime(2023, 7, 31, 17, 26, 0, 580, DateTimeKind.Local).AddTicks(2275), "ABWIz+0PBfShkBJPxCG5k6dOay35gW/suvYe9+ueLa6THWyn7OABQUUQqWbuPkD2qA==", "fae0e101-289a-4ed7-9064-0e71d04c828d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b38766d4-a96e-4d4c-83fc-3973b98f04e8", new DateTime(2023, 7, 31, 17, 26, 0, 581, DateTimeKind.Local).AddTicks(1643), "AOEVmWY/TxHj3YklQ4ADhRy3FW/Ag5MPfph+36UwaLhoRJXUS0ZzwOG47LzizQKrwQ==", "cf257ae7-6141-43b5-925f-dabec2f9925c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddc0de16-fb57-4455-8f86-df4c681c0c4c", new DateTime(2023, 7, 31, 17, 26, 0, 578, DateTimeKind.Local).AddTicks(8772), "AO6l62KnsORtHdT/gT/tTk5IhcUuxbRbDUOZ+OnPlmdO+L2JMAqEnySD6plKwm3wTg==", "539b7ec1-f400-42fe-9937-fabf37ca3243" });
        }
    }
}

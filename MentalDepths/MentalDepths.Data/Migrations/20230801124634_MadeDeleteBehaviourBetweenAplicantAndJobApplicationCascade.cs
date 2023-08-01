using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class MadeDeleteBehaviourBetweenAplicantAndJobApplicationCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aplicants_JobApplicationForms_JobApplicationId",
                table: "Aplicants");

            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 8, 4, 15, 46, 33, 962, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d4317e5-a283-4633-a825-42a7162cd09d", new DateTime(2023, 8, 1, 15, 46, 33, 963, DateTimeKind.Local).AddTicks(5226), "ALPqx1AmFDOKL1O9ESzzDe71UbWClaacPPjeN3wO6kur8IPBVF/kmHOr9c77hXVo6g==", "3147428a-b3e3-40ac-99d2-7b268dc656fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08ab34ef-d738-47db-95b6-212335c147fa", new DateTime(2023, 8, 1, 15, 46, 33, 964, DateTimeKind.Local).AddTicks(4110), "ALm+jtOoX/JsrBWZvAp7psI91JSSU8xGRRkYkH4LJUzGreT/NI2L3lcVxgbMfEAUHQ==", "5d1dd9a5-e1df-4b2c-98e4-431ea6e44311" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbd1cc64-34c3-40d3-b3a9-7e4b66c7e524", new DateTime(2023, 8, 1, 15, 46, 33, 966, DateTimeKind.Local).AddTicks(2137), "AIrakSWySwf7eRyGUT2nvJE6UWJF0NnSJDwuWylzwa96XQ741ElhnBvEXSywpY1UqA==", "824c278f-9c74-41df-afd1-9ba15694d8e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6543684e-e891-4234-93e7-ea371bc02a63", new DateTime(2023, 8, 1, 15, 46, 33, 965, DateTimeKind.Local).AddTicks(3012), "AMHCcObr7v/F3FN112wytaa8T1k/EG7leqnuYpnDc6G702rE6XaF+R8W2hy3vp+EAw==", "99301622-23fe-4eb5-8194-c39379e4a39d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdbde529-3afc-4afd-8fcc-eb8e449b84f5", new DateTime(2023, 8, 1, 15, 46, 33, 967, DateTimeKind.Local).AddTicks(3846), "ABn/L1QT2C81py4liYAwPaZ8YwDW0FQYIg+H+qTHWHv5GsYGY4Zx7zpQbvgs+P+PLw==", "aa563c90-7870-4fa5-b1e8-703f0d510a92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bfa1fc0-3e4b-4058-bd4b-9a3478e6912f", new DateTime(2023, 8, 1, 15, 46, 33, 962, DateTimeKind.Local).AddTicks(5503), "AEURYT5Om/vAWq4WUwpcczVDGpG1kYUvNBlK8qjWEnjcs8I+7o6akHoUKN6N+md18A==", "661650d7-543b-4720-888e-6e28500f2ffb" });

            migrationBuilder.AddForeignKey(
                name: "FK_Aplicants_JobApplicationForms_JobApplicationId",
                table: "Aplicants",
                column: "JobApplicationId",
                principalTable: "JobApplicationForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aplicants_JobApplicationForms_JobApplicationId",
                table: "Aplicants");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Aplicants_JobApplicationForms_JobApplicationId",
                table: "Aplicants",
                column: "JobApplicationId",
                principalTable: "JobApplicationForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

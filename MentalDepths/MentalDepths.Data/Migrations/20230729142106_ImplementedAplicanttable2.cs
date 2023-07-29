using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class ImplementedAplicanttable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 8, 1, 17, 21, 5, 980, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc74593a-e1e9-4566-a7df-2e0513ea10f2", new DateTime(2023, 7, 29, 17, 21, 5, 981, DateTimeKind.Local).AddTicks(4368), "AE5zyD8LrHdBC80+q0dU9z+MsHar8rgZSnbjdAWuq5Yox0rhaorBTj8srJ05SKl6RQ==", "08850da2-f0c8-4ff0-96c7-913c18d96997" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b499db2d-9176-4197-b4dd-acdc86a64176", new DateTime(2023, 7, 29, 17, 21, 5, 981, DateTimeKind.Local).AddTicks(8787), "AB2zjtiEUVqu6TP6b/8ESZBpzTKXuBBgM5E4Y6pBSmnkkiWLAl+8Z+51g01yMp47iA==", "3c72a36c-e5b9-4bd1-b056-7ba012ba6f55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afe17e98-36ad-4228-9e99-0a5aaf3bd465", new DateTime(2023, 7, 29, 17, 21, 5, 982, DateTimeKind.Local).AddTicks(7685), "AOu+XSk9fuKKuEAIIcmqWMkElcN7MCFeg86iaER9lAHFY7FkWh0H6Yxy4f8w8Osxwg==", "50c23a36-c8fb-487c-8531-d034dc301ab3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfff9de7-a056-4b5f-beaf-a9a349c9881e", new DateTime(2023, 7, 29, 17, 21, 5, 982, DateTimeKind.Local).AddTicks(3211), "AL4ZxR55xBNsTHtL0mpmmol7qhlv5/qfMI54PzlxE146+t4MBfyHcYmmlO5pRPn10Q==", "0a2cc2e9-0180-4238-8f5c-5fd92a011820" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9861f401-16cb-4643-a7c7-d268136dcbf7", new DateTime(2023, 7, 29, 17, 21, 5, 983, DateTimeKind.Local).AddTicks(2103), "AH7RbJaDvbKnnDT7qnJWXVGmvcfAIRTR801ypGGkstEMvW4ztK9lVRslGjX24z3eRQ==", "b36e24e9-878d-4f30-a11b-5c2550ce9f60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45001be7-b70e-49c3-b786-aa8e4a14fb41", new DateTime(2023, 7, 29, 17, 21, 5, 980, DateTimeKind.Local).AddTicks(9768), "AIfehdEePFGruLqvNdRCXzvJejy+PFHoO9aQXCEkcLzMLNlRm1+vAAftedyWWNOMlQ==", "71b4c35f-6248-444c-a8d5-d0cd953f10c9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 8, 1, 15, 58, 51, 233, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b006c870-8091-4eef-b273-f72529050553", new DateTime(2023, 7, 29, 15, 58, 51, 234, DateTimeKind.Local).AddTicks(510), "ALNTVkOwsX2KidL6xI/C/Q12AQBXIp/P/VCkOrCs04LV2LZXvG9j+g/gefzd+YVB0g==", "768d0aa3-d216-4300-a7de-eccf6c4758da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2740b608-048f-4858-b73e-66fcde690da5", new DateTime(2023, 7, 29, 15, 58, 51, 234, DateTimeKind.Local).AddTicks(4906), "AAOLybAyjDJSg9MBZR1OxPhZ6+/ZVdnqSn8TJXrk9s/oVi7o1xBt9McWKbyU7GHlVA==", "79db3076-9968-482d-aff6-dacdaf419c25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d57dfc79-c38c-4ad9-940c-8eb902f5aa4d", new DateTime(2023, 7, 29, 15, 58, 51, 235, DateTimeKind.Local).AddTicks(7684), "AA7DAGiqFTpo1J3UfgdgDSCdTPfPCwy/5hboGEoKqJ5R7IqQZnkkCANmt22enxhRXg==", "72de5da4-c7db-49fd-b5c9-a60a9b2df24a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d490aa48-7abd-41d2-86a6-c52f40e1f1e5", new DateTime(2023, 7, 29, 15, 58, 51, 234, DateTimeKind.Local).AddTicks(9391), "ALSQkkzENE7Uw96waDifdCQOADcyyKCx7Pvub98KhGwZWdZy+trMx2ra6rSYnlb8TQ==", "ba57d730-e3d6-4bc3-b348-b0f2fab6184d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f59ea66-67fb-4eba-a9f3-5c06225e8a40", new DateTime(2023, 7, 29, 15, 58, 51, 236, DateTimeKind.Local).AddTicks(2243), "ANId5SXbA+J9/fWuD90p2c/MEqreIKzfbD8ncJipd+E5JfqtVerMXswdjwVbYBmwWQ==", "6236dfc7-dfe9-4b93-84b4-39944d52ae5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0696093d-3cf8-4ce4-af0c-981cabe45ae8", new DateTime(2023, 7, 29, 15, 58, 51, 233, DateTimeKind.Local).AddTicks(5938), "AHHDoQPQDb6i8ag/t0IoL5UaguvNqo20zsWmHJdIYUJVAdQaAfDr4jc8s3JRubSGMw==", "2a91b9a4-2c38-4639-84e0-c5d602ce1d6a" });
        }
    }
}

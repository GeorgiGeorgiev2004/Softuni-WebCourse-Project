using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class FixingSpecialists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efef9d31-5018-4f1a-b782-2d265293c191", new DateTime(2023, 7, 30, 14, 55, 44, 858, DateTimeKind.Local).AddTicks(4643), "ADP1OsUvuqAKUH3amEhMEwHT3JetCHOc/0TVnzui+vv1eCognPUMUxZdFMb4ncS6IA==", "18b748ba-3fab-4bf1-9cd8-9da0976b7261" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc0a35c5-f956-4d84-81ca-fb34260c7f98", new DateTime(2023, 7, 30, 14, 55, 44, 858, DateTimeKind.Local).AddTicks(9037), "AKbarcuYkx+XKWpBS4aKeS44drd01NPT19iUuRoOQlnpOwFJ5fhI267DuTS2FolmzQ==", "3b20c2ee-fb60-4aeb-8b7a-92a11e6d3d8d" });

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
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc1f607c-78b3-4806-8813-015c0c9d8308", new DateTime(2023, 7, 30, 14, 55, 44, 859, DateTimeKind.Local).AddTicks(3461), "AIllWNtuWrj8z6gOsOz+L1qHNOpQ3FqnVs3lMKZgxrGIW4OLqCwbaQuqOXA0BH3hWg==", "bb17b77c-8e1e-4625-91ce-1efa7a986bbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d50a3315-fb99-4838-9733-2b5120ac1fb8", new DateTime(2023, 7, 30, 14, 55, 44, 860, DateTimeKind.Local).AddTicks(5527), "AAWwHizGsZA5KryVCTLzQgHMU55X2SATKWTUxYqlRCKhAMMYJcpaiIkvwy/tqS1GYw==", "5057384a-7f4e-48a9-8edd-5b2e96745b51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ab3d893-3ed8-48e8-a96e-125c5c3c5d26", new DateTime(2023, 7, 30, 14, 55, 44, 858, DateTimeKind.Local).AddTicks(86), "ANYsFCRRcfDnbSC14SxVjWQVhO67rb7OMfOcmABk4YZEBBbKEOUgw+pp26jo9cSsZw==", "34b013fe-c8a0-4c87-aa01-89e7d4a3bcc9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

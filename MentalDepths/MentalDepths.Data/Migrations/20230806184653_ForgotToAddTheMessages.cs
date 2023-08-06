using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class ForgotToAddTheMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ConversationId", "Text", "TimeOfSend", "TypeOfUser" },
                values: new object[,]
                {
                    { 1, new Guid("a14b7ac6-7feb-4c32-8e5c-813c9b45b559"), "Hello doctor Ivanov! I have had seizures for quite some time now. I don't think that talking to a shrink will work but I'm left with no alternative.It all started when one day i was watching the ducks.", new DateTime(2023, 8, 10, 12, 25, 12, 0, DateTimeKind.Unspecified), 0 },
                    { 2, new Guid("a14b7ac6-7feb-4c32-8e5c-813c9b45b559"), "Good day to you Tony(hope it is ok for me to use your first name). I would love to help but for this to work we need to arrange a meeting and I would need you to come to my office", new DateTime(2023, 8, 10, 12, 45, 17, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new Guid("a14b7ac6-7feb-4c32-8e5c-813c9b45b559"), "Doc I can come by tomorrow around 9 40.", new DateTime(2023, 8, 10, 12, 58, 55, 0, DateTimeKind.Unspecified), 0 },
                    { 4, new Guid("a14b7ac6-7feb-4c32-8e5c-813c9b45b559"), "Check your apointments page It should say that we have a session arranged for tomorrow at 9:40", new DateTime(2023, 8, 10, 12, 58, 55, 0, DateTimeKind.Unspecified), 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d1e352e-121e-4fdb-ac05-31994f947946", new DateTime(2023, 8, 6, 20, 45, 50, 730, DateTimeKind.Local).AddTicks(521), "ABt5USmdrXdxRnr6ebEzyvCY2xcuV7mlle3GM85EOQE24QOTDVHOKk9IhreeNS7rJw==", "2f48dd4d-3174-4a07-946a-bfae3a740bbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea0288ce-0754-4ba8-9baf-1371d5a220b6", new DateTime(2023, 8, 6, 20, 45, 50, 730, DateTimeKind.Local).AddTicks(6595), "ANnFfgUrhE3cATyNpOG4Hg5mYcAyfRY50bQTZbiENXM+VGw5ejfbrDhFOE8S6AK5xA==", "e1e32467-05b7-44f2-8b40-2b228cdc3550" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f31dadcb-f66d-44ac-83d8-a0f64c7c6264", new DateTime(2023, 8, 6, 20, 45, 50, 731, DateTimeKind.Local).AddTicks(7108), "AOYLdcUxL6BLRtiuoCSOdTmiB23X9Jn63P9HmiKjCh8/s/Knh//dPETwNof4Yuun0w==", "d39f2d47-3fbf-440e-8681-f96366913e02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e58a149-26e8-43a0-95c3-207ecbe17e68", new DateTime(2023, 8, 6, 20, 45, 50, 731, DateTimeKind.Local).AddTicks(1937), "AGzpzlcfRU1CIcgf4P1NdXW+977a2prH9nuCQiuCkqtB+NkC4mL5JQCyz9d87st85Q==", "87ba868a-4fcb-4af3-9767-3936f629dabb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f58bbf98-a655-4009-b591-d94fab54876f", new DateTime(2023, 8, 6, 20, 45, 50, 732, DateTimeKind.Local).AddTicks(2012), "AINqayKq+hb6cv/0Mgd1n8+qnGrBv3xlUkefHyO0eQFI/hFOVqIdejwBnppavnxpkQ==", "a74f55f8-96cb-40bc-9fdd-0bf6937669f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "753a65a8-0e0d-4bed-b08a-52543233d0ee", new DateTime(2023, 8, 6, 20, 45, 50, 729, DateTimeKind.Local).AddTicks(3942), "AKgPlHHDv7FwXqU00I0Nt86upyBwqr1J2DCvgYk1Kol5/RUUkoIA58t7Fe6otowvAQ==", "80c39973-4898-4bc0-bbfd-4c161b46d136" });
        }
    }
}

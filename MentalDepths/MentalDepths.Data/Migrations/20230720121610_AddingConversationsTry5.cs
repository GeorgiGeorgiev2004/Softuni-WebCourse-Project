using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class AddingConversationsTry5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Apointments_ApointmentId",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "ApointmentId",
                table: "Notes",
                newName: "ConversationtId");

            migrationBuilder.RenameIndex(
                name: "IX_Notes_ApointmentId",
                table: "Notes",
                newName: "IX_Notes_ConversationtId");

            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 7, 23, 15, 16, 9, 909, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f36b4bca-a88a-4b96-a2f9-f8f132833289", new DateTime(2023, 7, 20, 15, 16, 9, 909, DateTimeKind.Local).AddTicks(8088), "AMSG2VM9iWWt2Z7uwmhiE/HrXeP7Xxf5Jrb0zy/Lieuv3lEStv8SH5pbgrdV9ODvQg==", "c5b06056-1248-4eb7-8d7f-33fdc14fd74b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92db1c51-5510-42a8-9123-55984274bba8", new DateTime(2023, 7, 20, 15, 16, 9, 910, DateTimeKind.Local).AddTicks(2582), "AKE2y6DfvfG6NZe5MZuZqxKlgWVCuz4tD5+15gBPBvM+ckCBqxPCLRah6txlX7yplg==", "5f529cbf-1b42-4250-bf3c-8f214cab6d42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5622a30b-fdc9-405b-a6b9-6ea197fda277", new DateTime(2023, 7, 20, 15, 16, 9, 911, DateTimeKind.Local).AddTicks(1736), "ALg6FhwmimXhe350cw6k05JtxTvGsKD9h0O+yd0vI7VITSXgyr7GqadXeiOSym8DZA==", "57a9b75b-ecce-477e-a09e-614e96d3f621" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ef91059-e4a3-47bf-8067-fd76c742e042", new DateTime(2023, 7, 20, 15, 16, 9, 910, DateTimeKind.Local).AddTicks(7146), "ADADshnv3xCJfY09C2za2xvKCh59Pf995AoWtLRVrr5n+XhSaUxBXSzrK8WDDyDM/A==", "032f43ee-2241-4539-8272-6c66b99e026d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51ce3358-8cb8-40c1-832b-99778177f133", new DateTime(2023, 7, 20, 15, 16, 9, 911, DateTimeKind.Local).AddTicks(6196), "AMOJZMv05rnjJPeeAlt1QMf3Bq3jjbkGCuinM2AcdKlJlovlrBqs/Jnp8wPKUolJSg==", "6e5dbc0d-56f3-4dd0-a9fb-acd411afe882" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54f3c275-f6cc-4bb6-acff-4cb790addec6", new DateTime(2023, 7, 20, 15, 16, 9, 909, DateTimeKind.Local).AddTicks(3388), "AA+UPL4FAVwX9u5RnJF6MqMBtOwNbEz/WVWBoH3iz8tz8U7LWeE0G1xJ7foKowFKuA==", "a29424cb-a2ca-463c-9f4c-f4f89c0ed74e" });

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Conversations_ConversationtId",
                table: "Notes",
                column: "ConversationtId",
                principalTable: "Conversations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Conversations_ConversationtId",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "ConversationtId",
                table: "Notes",
                newName: "ApointmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Notes_ConversationtId",
                table: "Notes",
                newName: "IX_Notes_ApointmentId");

            migrationBuilder.UpdateData(
                table: "Apointments",
                keyColumn: "Id",
                keyValue: new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                column: "DateAndTime",
                value: new DateTime(2023, 7, 23, 13, 30, 56, 626, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30bb2cc7-f517-4518-b6c0-77dee7a476ea", new DateTime(2023, 7, 20, 13, 30, 56, 627, DateTimeKind.Local).AddTicks(3237), "AC3MSL8LnWXjpB8I2yQV9+H8dWFLXRKBrHKcVx4tvl4B9CIt+BVXjJnwN3Px9LFGJA==", "8075c96b-9d58-4bbf-b717-50a9cff96669" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("308508b8-ce9e-470b-a122-8a77f576532e"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e76f38c-ca8e-4f5c-804a-53317a03ed17", new DateTime(2023, 7, 20, 13, 30, 56, 627, DateTimeKind.Local).AddTicks(7928), "AM/j40x2kGVc0YJ54jFe+/SB34oZsalLWBnkPGDBaDwt1HIL3aZyANUycUsFTSUKjg==", "5e841d86-bd85-47f3-9e35-9f41559e6861" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ea90ed8-6077-4337-a770-6f45700011bd", new DateTime(2023, 7, 20, 13, 30, 56, 628, DateTimeKind.Local).AddTicks(7281), "AEMuBSThJrtQhWZogXRQvh0AoVtWnt8Q8/HyIQ5GKcKzzhPV+qJH0Deroj5GrzpSYg==", "b431aaf8-da50-44c3-8319-c9b6dc6d4dcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc3b4d57-bb10-488b-8d3d-797c16b1b9f9", new DateTime(2023, 7, 20, 13, 30, 56, 628, DateTimeKind.Local).AddTicks(2595), "AGANVp+mTcuytvkr33p90OPtIK4kKJqmf28ZjGbaLlcI8fjq1ez8OwhWOvMz3zPlxQ==", "4d5976ca-e2e4-451a-b628-700c2d351b87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d6be4d6-1236-4ed8-a824-238556770556", new DateTime(2023, 7, 20, 13, 30, 56, 629, DateTimeKind.Local).AddTicks(2009), "AMxISIJBizaVFwRG7KZMOFzLTeAUy/PsrdjIqx+pXeaY5Xgux6vJSbKBbzAvnKSGXw==", "e999c35d-3b00-495a-b712-2699a6841642" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f9239cf-bb90-4208-a5c8-b67c16c26168", new DateTime(2023, 7, 20, 13, 30, 56, 626, DateTimeKind.Local).AddTicks(8404), "AF7nmNruqD9LiStcvfbRb64BfZIJh/gwKYztUE1wufTJTF0z79BLTAaKrfBvIpEJxg==", "345af71b-1363-4691-b128-ee58f7673bd0" });

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Apointments_ApointmentId",
                table: "Notes",
                column: "ApointmentId",
                principalTable: "Apointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

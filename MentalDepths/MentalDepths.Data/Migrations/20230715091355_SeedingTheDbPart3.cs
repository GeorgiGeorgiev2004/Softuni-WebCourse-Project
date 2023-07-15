using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class SeedingTheDbPart3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialisations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialisations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specialists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    JobApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specialists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apointments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apointments_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Apointments_Specialists_SpecialistId",
                        column: x => x.SpecialistId,
                        principalTable: "Specialists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobApplicationForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CV = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ScannedDiploma = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Certification = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplicationForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobApplicationForms_Specialists_SpecialistId",
                        column: x => x.SpecialistId,
                        principalTable: "Specialists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicationName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MedicationDescription = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAOneTimePrescription = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Specialists_SpecialistId",
                        column: x => x.SpecialistId,
                        principalTable: "Specialists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpecialistsSpecialisations",
                columns: table => new
                {
                    SpecialistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialisationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialistsSpecialisations", x => new { x.SpecialistId, x.SpecialisationId });
                    table.ForeignKey(
                        name: "FK_SpecialistsSpecialisations_Specialisations_SpecialisationId",
                        column: x => x.SpecialisationId,
                        principalTable: "Specialisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpecialistsSpecialisations_Specialists_SpecialistId",
                        column: x => x.SpecialistId,
                        principalTable: "Specialists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminJobApplicationMT",
                columns: table => new
                {
                    AdminId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminJobApplicationMT", x => new { x.AdminId, x.JobApplicationId });
                    table.ForeignKey(
                        name: "FK_AdminJobApplicationMT_Admins_JobApplicationId",
                        column: x => x.JobApplicationId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminJobApplicationMT_JobApplicationForms_JobApplicationId",
                        column: x => x.JobApplicationId,
                        principalTable: "JobApplicationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "" },
                    { 2, "Blagoevgrad" },
                    { 3, "Burgas" },
                    { 4, "Dobrich" },
                    { 5, "Gabrovo" },
                    { 6, "Haskovo" },
                    { 7, "Kardzhali" },
                    { 8, "Kyustendil" },
                    { 9, "Lovech" },
                    { 10, "Montana" },
                    { 11, "Pazardzhik" },
                    { 12, "Pernik" },
                    { 13, "Pleven" },
                    { 14, "Razgrad" },
                    { 15, "Ruse" },
                    { 16, "Shumen" },
                    { 17, "Silistra" },
                    { 18, "Sliven" },
                    { 19, "Smolyan" },
                    { 20, "Sofia City" },
                    { 21, "Sofia (province)" },
                    { 22, "Stara Zagora" },
                    { 23, "Targovishte" },
                    { 24, "Varna" },
                    { 25, "Veliko Tarnovo" },
                    { 26, "Vidin" },
                    { 27, "Vratsa" },
                    { 28, "Yambol" }
                });

            migrationBuilder.InsertData(
                table: "Specialisations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Psychiatrist" },
                    { 2, "Adolescent psycology" },
                    { 3, "Prepubescent psycology" },
                    { 4, "Post-war trauma" },
                    { 5, "Abnormal psychology" },
                    { 6, "Biological psychology" },
                    { 7, "Cognitive psychology " },
                    { 8, "Developmental psychology" },
                    { 9, "Forensic psychology" },
                    { 10, "Counselling psychology" },
                    { 11, "Industrial-organizational psychology" },
                    { 12, "Forensic psychology" },
                    { 13, "Personality psychology" },
                    { 14, "Social psychology" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecondName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"), 0, 5, "4f87e09e-e22f-4b10-9347-7aa3fca58501", new DateTime(2023, 7, 15, 12, 13, 54, 836, DateTimeKind.Local).AddTicks(4189), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ScaryHaxer@yahoo.com", false, "Iliq", false, "Steliov", false, null, "SCARYHAXER@YAHOO.COM", "ILIQ_STELIOV", "AEJXJzEdJFIt+075kj3KIJEGA8HWAV3NOQ8PVnEy2PZ9HBIOAnMuq6sYP2hhjLzSYQ==", null, false, "", "a4046a54-4267-43e4-bbd2-b4d5eb37fefb", false, "Iliq_Steliov" },
                    { new Guid("308508b8-ce9e-470b-a122-8a77f576532e"), 0, 27, "3dc176fb-1792-4dee-a6dc-668162e9580e", new DateTime(2023, 7, 15, 12, 13, 54, 836, DateTimeKind.Local).AddTicks(8919), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan.Ivanov234@gmail.com", true, "Ivan", false, "Ivanov", false, null, "IVAN.IVANOV234@GMAIL.COM", "IVAN_IVANOV", "AHW0GbAzQkHV0T2H6XUrZwUAgIWvXF2tti4neDx5FO8AB8WJCBSj31s/7j235vCIwg==", null, false, "Sirov", "86bed827-281b-41f8-9671-60fe909207bd", false, "Ivan_Ivanov" },
                    { new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"), 0, 22, "65fc96f1-9c6c-4608-b70f-d289d81856c9", new DateTime(2023, 7, 15, 12, 13, 54, 837, DateTimeKind.Local).AddTicks(8369), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kolio_Zemev@gmail.com", true, "Nikola", false, "Zemelyarski", false, null, "KOLIO_ZEMEV@GMAIL.COM", "NIKOLA_ZEMELYARSKI", "AKQMmPdwJxDaiVJbDBjm9K9AGezuBWc8146s2qWTUQdJhrF1q2pFO4HRVRXcyszvhg==", null, false, "", "1f901e8e-8bf6-48a6-a1e9-fbe47318ff98", false, "Nikola_Zemelyarski" },
                    { new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"), 0, 13, "0aed490e-3dd0-49f3-8493-65a473366ccd", new DateTime(2023, 7, 15, 12, 13, 54, 837, DateTimeKind.Local).AddTicks(3675), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lilial_Izbora@abv.bg", false, "Lilial", false, "Izbrannikov", false, null, "LILIAL_IZBORA@ABV.BG", "LILIAL_IZBRANNIKOV", "AC7CWhb57mJLz97W3uvuYVz2RB2AvUfZ0rgC2uwVfuefT2/0rTzELa8Uwnm8THbeLg==", null, false, "Sabiev", "b024b507-982f-4986-9dc8-236bb2e63e72", false, "Lilial_Izbrannikov" },
                    { new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"), 0, 17, "ad19efa9-6bb1-473c-af52-7ea3207641af", new DateTime(2023, 7, 15, 12, 13, 54, 838, DateTimeKind.Local).AddTicks(3078), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DembeRed@alo.net", false, "Dembe", false, "Redglade", false, null, "DEMBERED@ALO.NET", "DEMBE_REDGLADE", "AIeVQ57A1uT3GnbQfvAP9XnX+OD5Et9BxjvW8ckG3PGBypoSkvndr4YhNsEOgF2Oiw==", null, false, "Nisantimetarottebe", "51c51e0c-4f35-41d1-aee8-c4691ccd3e9d", false, "Dembe_Redglade" },
                    { new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"), 0, 2, "290950c7-8b6d-420e-bb18-e21c84aed0d1", new DateTime(2023, 7, 15, 12, 13, 54, 835, DateTimeKind.Local).AddTicks(9250), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "gogo_5a@abv.bg", true, "Georgi", false, "Georgiev", false, null, "GOGO_5A@ABV.BG", "GEORGI_GEORGIEV", "AN6LupnnkigAecn+s+r301NNuBD/Fiqij+AISo0yvltjqnMz9sqmIrzFBs8OLbg2AA==", null, false, "Lyubenov", "806a7241-70a8-4da5-9226-73591a2dc4b5", false, "Georgi_Georgiev" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "UserId", "Username" },
                values: new object[] { new Guid("d947f5ab-75ae-4ebe-9f26-9af2671d77ac"), new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"), "Big Boss" });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "Id", "Address", "Age", "Description", "ImageURL", "JobApplicationId", "UserId" },
                values: new object[] { new Guid("33713803-661e-4fad-a041-cf526fbc83e4"), "ul.\"Sergei Kirov\" vh.34", 56, "Talanted, young and abnormaly ambitious he will obliterate your expectations!", "https://images.pexels.com/photos/1936854/pexels-photo-1936854.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("59a88704-3ae3-4554-ad39-81b1f0304069") });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "Id", "Address", "Age", "Description", "ImageURL", "JobApplicationId", "UserId" },
                values: new object[] { new Guid("550184af-0284-4a1c-bc3e-223cb9198e62"), "AlenMak bl.14 vh.6", 23, "Talanted, young and abnormaly ambitious she will obliterate your expectations!", "https://images.pexels.com/photos/3538028/pexels-photo-3538028.jpeg?cs=srgb&dl=pexels-jeys-tubianosa-3538028.jpg&fm=jpg", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("308508b8-ce9e-470b-a122-8a77f576532e") });

            migrationBuilder.InsertData(
                table: "Apointments",
                columns: new[] { "Id", "Address", "ApplicationUserId", "DateAndTime", "SpecialistId" },
                values: new object[] { new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"), "Office", new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"), new DateTime(2023, 7, 18, 12, 13, 54, 835, DateTimeKind.Local).AddTicks(9106), new Guid("33713803-661e-4fad-a041-cf526fbc83e4") });

            migrationBuilder.InsertData(
                table: "SpecialistsSpecialisations",
                columns: new[] { "SpecialisationId", "SpecialistId" },
                values: new object[,]
                {
                    { 4, new Guid("33713803-661e-4fad-a041-cf526fbc83e4") },
                    { 8, new Guid("33713803-661e-4fad-a041-cf526fbc83e4") },
                    { 3, new Guid("550184af-0284-4a1c-bc3e-223cb9198e62") },
                    { 6, new Guid("550184af-0284-4a1c-bc3e-223cb9198e62") },
                    { 13, new Guid("550184af-0284-4a1c-bc3e-223cb9198e62") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminJobApplicationMT_JobApplicationId",
                table: "AdminJobApplicationMT",
                column: "JobApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Apointments_ApplicationUserId",
                table: "Apointments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Apointments_SpecialistId",
                table: "Apointments",
                column: "SpecialistId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplicationForms_SpecialistId",
                table: "JobApplicationForms",
                column: "SpecialistId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_ApplicationUserId",
                table: "Prescriptions",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_SpecialistId",
                table: "Prescriptions",
                column: "SpecialistId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialists_UserId",
                table: "Specialists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialistsSpecialisations_SpecialisationId",
                table: "SpecialistsSpecialisations",
                column: "SpecialisationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminJobApplicationMT");

            migrationBuilder.DropTable(
                name: "Apointments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "SpecialistsSpecialisations");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "JobApplicationForms");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Specialisations");

            migrationBuilder.DropTable(
                name: "Specialists");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}

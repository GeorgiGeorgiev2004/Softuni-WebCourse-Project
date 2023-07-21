using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalDepths.Data.Migrations
{
    public partial class MakingSureeverythingIsClean : Migration
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
                    Address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false)
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
                name: "Conversations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsClosed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conversations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Conversations_Specialists_SpecialistId",
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
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfUser = table.Column<int>(type: "int", nullable: false),
                    TimeOfSend = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConversationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "Conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConversationtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_Conversations_ConversationtId",
                        column: x => x.ConversationtId,
                        principalTable: "Conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"), 0, 5, "0397a018-0f2e-45c0-b5c5-a21c3bf7fe64", new DateTime(2023, 7, 21, 16, 16, 27, 566, DateTimeKind.Local).AddTicks(3952), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ScaryHaxer@yahoo.com", false, "Iliq", false, "Steliov", false, null, "SCARYHAXER@YAHOO.COM", "ILIQ STELIOV", "AA7/NLisF18nR4ggSh4nxL8Z58B7B8LrjlRuh/DMV8/ZopPFnZ10e2BVXJZo4gluiA==", null, false, "", "156fe437-0b54-437d-891c-05ba71d01043", false, "Iliq Steliov" },
                    { new Guid("308508b8-ce9e-470b-a122-8a77f576532e"), 0, 27, "674eaff3-e1ac-43d4-82b1-bfd17f814e0e", new DateTime(2023, 7, 21, 16, 16, 27, 567, DateTimeKind.Local).AddTicks(1348), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan.Ivanov234@gmail.com", true, "Ivan", false, "Ivanov", false, null, "IVAN.IVANOV234@GMAIL.COM", "IVAN IVANOV", "AE7QZqETWYorewWDNU9sEGpVvyDZzJW6P+W6Oys74a3lD9rYVNP6qwIqbsurw2Z3Ag==", null, false, "Sirov", "b7fbfd07-f43b-474e-89df-0daf3628f5ca", false, "Ivan Ivanov" },
                    { new Guid("59a88704-3ae3-4554-ad39-81b1f0304069"), 0, 22, "8cdf0c22-c44a-4344-9bc9-bb0ef9ce4965", new DateTime(2023, 7, 21, 16, 16, 27, 568, DateTimeKind.Local).AddTicks(6168), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kolio_Zemev@gmail.com", true, "Nikola", false, "Zemelyarski", false, null, "KOLIO_ZEMEV@GMAIL.COM", "NIKOLA ZEMELYARSKI", "ANHMTvfOdjZJkbU+ZHk4/o4ahz3yagTgBD9wRjXRst7A+2GD7hp0l4ZihGiT8mf6lw==", null, false, "", "1a537de8-7787-4965-bcbf-04da69c7b62c", false, "Nikola Zemelyarski" },
                    { new Guid("9953dce8-25f6-45f2-bf8c-816b92bb0e28"), 0, 13, "c55c9a43-ae15-48ea-9e82-012b0fc0ae57", new DateTime(2023, 7, 21, 16, 16, 27, 567, DateTimeKind.Local).AddTicks(8795), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lilial_Izbora@abv.bg", false, "Lilial", false, "Izbrannikov", false, null, "LILIAL_IZBORA@ABV.BG", "LILIAL IZBRANNIKOV", "AI9b0dHYhUw874JpScVzOrmusiAnEpL2L/5ME8zd74wn5pFoRPQTGWjA1FP1FTCEiw==", null, false, "Sabiev", "a6c56ab9-25aa-4e32-b22e-a6e748f1619e", false, "Lilial Izbrannikov" },
                    { new Guid("a63c570e-8c25-449f-b89c-3df89bc0d17c"), 0, 17, "7e15e970-7bfb-4333-b8fc-436327e93301", new DateTime(2023, 7, 21, 16, 16, 27, 569, DateTimeKind.Local).AddTicks(3520), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DembeRed@alo.net", false, "Dembe", false, "Redglade", false, null, "DEMBERED@ALO.NET", "DEMBE REDGLADE", "APYzT8pej8aIRp2Hl6MDwwjFkCHVgEsYarnn8eVWHD/XTd+VXDhg7xVU5PBnSLIJDg==", null, false, "Nisantimetarottebe", "04d8ae8d-fd89-41f0-84db-9848fb14a598", false, "Dembe Redglade" },
                    { new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"), 0, 2, "5951f3e2-3bb1-4385-85a8-dfd578ef7881", new DateTime(2023, 7, 21, 16, 16, 27, 565, DateTimeKind.Local).AddTicks(6325), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "gogo_5a@abv.bg", true, "Georgi", false, "Georgiev", false, null, "GOGO_5A@ABV.BG", "GEORGI GEORGIEV", "AGyHis1+ukALA6uLegiVGl+CfRur1ChFb2QHUp/1FOC54xpiVq26z1AyKJuO969A/A==", null, false, "Lyubenov", "e4841524-702a-4881-888b-b995f85045cb", false, "Georgi Georgiev" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "UserId", "Username" },
                values: new object[] { new Guid("d947f5ab-75ae-4ebe-9f26-9af2671d77ac"), new Guid("f957a45a-d8df-439e-a50a-b1c0f87a69f2"), "Big Boss" });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "Id", "Address", "Age", "Description", "ImageURL", "JobApplicationId", "UserId" },
                values: new object[] { new Guid("33713803-661e-4fad-a041-cf526fbc83e4"), "ul.\"Sergei Kirov\" vh.34", 56, "Talanted, not so young and rather slackish he will obliterate your expectations(in a bad way)!", "https://images.pexels.com/photos/1936854/pexels-photo-1936854.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("59a88704-3ae3-4554-ad39-81b1f0304069") });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "Id", "Address", "Age", "Description", "ImageURL", "JobApplicationId", "UserId" },
                values: new object[] { new Guid("550184af-0284-4a1c-bc3e-223cb9198e62"), "AlenMak bl.14 vh.6", 23, "Talanted, young and abnormaly ambitious she will obliterate your expectations!", "https://images.pexels.com/photos/3538028/pexels-photo-3538028.jpeg?cs=srgb&dl=pexels-jeys-tubianosa-3538028.jpg&fm=jpg", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("308508b8-ce9e-470b-a122-8a77f576532e") });

            migrationBuilder.InsertData(
                table: "Apointments",
                columns: new[] { "Id", "Address", "ApplicationUserId", "DateAndTime", "IsConfirmed", "SpecialistId" },
                values: new object[] { new Guid("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"), "Office", new Guid("010d67b6-964d-4248-9c9a-ad83215eaa4a"), new DateTime(2023, 7, 24, 16, 16, 27, 565, DateTimeKind.Local).AddTicks(6145), false, new Guid("33713803-661e-4fad-a041-cf526fbc83e4") });

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
                name: "IX_Conversations_SpecialistId",
                table: "Conversations",
                column: "SpecialistId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_UserId",
                table: "Conversations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplicationForms_SpecialistId",
                table: "JobApplicationForms",
                column: "SpecialistId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ConversationId",
                table: "Messages",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_ConversationtId",
                table: "Notes",
                column: "ConversationtId",
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
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Notes");

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
                name: "Conversations");

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

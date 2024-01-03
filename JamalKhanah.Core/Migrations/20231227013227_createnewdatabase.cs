using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JamalKhanah.Core.Migrations
{
    /// <inheritdoc />
    public partial class createnewdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CountryAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsShow = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WhatsAppNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaceBookLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TermsAndConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TermsAndConditionsAr = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiscountType = table.Column<int>(type: "int", nullable: false),
                    CouponType = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsShow = table.Column<bool>(type: "bit", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionsAndAnswersSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsAndAnswersSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SlidePhotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsShow = table.Column<bool>(type: "bit", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlidePhotos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserConnections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Connection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConnectionTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserConnections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ShowServices = table.Column<bool>(type: "bit", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    FreelanceFormImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeviceToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lat = table.Column<float>(type: "real", nullable: true),
                    Lng = table.Column<float>(type: "real", nullable: true),
                    RandomCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MainSectionCoupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainSectionId = table.Column<int>(type: "int", nullable: false),
                    CouponId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainSectionCoupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainSectionCoupons_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MainSectionCoupons_MainSections_MainSectionId",
                        column: x => x.MainSectionId,
                        principalTable: "MainSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionsAndAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    QuestionsAndAnswersSectionId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsAndAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionsAndAnswers_QuestionsAndAnswersSections_QuestionsAndAnswersSectionId",
                        column: x => x.QuestionsAndAnswersSectionId,
                        principalTable: "QuestionsAndAnswersSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Region = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BuildingNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FlatNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commissions_Users_ProviderId",
                        column: x => x.ProviderId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complaints_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationProviders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NumberOfStars = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluationProviders_Users_ProviderId",
                        column: x => x.ProviderId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EvaluationProviders_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteProviders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteProviders_Users_ProviderId",
                        column: x => x.ProviderId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FavoriteProviders_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MessageChats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SendUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReceiveUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsImg = table.Column<bool>(type: "bit", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageChats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageChats_Users_ReceiveUserId",
                        column: x => x.ReceiveUserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MessageChats_Users_SendUserId",
                        column: x => x.SendUserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NotificationsConfirmed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationsConfirmed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationsConfirmed_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationsConfirmed_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Prizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prizes_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProviderPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProviderPhotos_Users_ProviderId",
                        column: x => x.ProviderId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceType = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    FinalPrice = table.Column<float>(type: "real", nullable: false),
                    PriceUnit = table.Column<int>(type: "int", nullable: false),
                    EmployeesNumber = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsShow = table.Column<bool>(type: "bit", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    InHome = table.Column<bool>(type: "bit", nullable: false),
                    InCenter = table.Column<bool>(type: "bit", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    MainSectionId = table.Column<int>(type: "int", nullable: false),
                    ProviderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_MainSections_MainSectionId",
                        column: x => x.MainSectionId,
                        principalTable: "MainSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Services_Users_ProviderId",
                        column: x => x.ProviderId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaim_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCoupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CouponId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCoupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCoupons_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCoupons_Users_ProviderId",
                        column: x => x.ProviderId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                schema: "dbo",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogin_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorksHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<int>(type: "int", nullable: false),
                    From = table.Column<TimeSpan>(type: "time", nullable: false),
                    To = table.Column<TimeSpan>(type: "time", nullable: false),
                    MoreData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorksHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorksHours_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NumberOfStars = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluationServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvaluationServices_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FavoriteServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteServices_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryFees = table.Column<float>(type: "real", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartingOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InHome = table.Column<bool>(type: "bit", nullable: false),
                    HaveCoupon = table.Column<bool>(type: "bit", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BuildingNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FlatNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CouponId = table.Column<int>(type: "int", nullable: true),
                    PaymentUrlIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServiceCoupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    CouponId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCoupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceCoupons_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceCoupons_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Refunded = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Refunded_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Captured = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Captured_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Voided_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Invoice_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount_format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fee_format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Refunded_format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Captured_format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Callback_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Source_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source_Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source_Gateway_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source_Reference_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source_Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source_Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source_Transaction_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionNumber = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PaymentUrlIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentHistories_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Commissions_ProviderId",
                table: "Commissions",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_UserId",
                table: "Complaints",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationProviders_ProviderId",
                table: "EvaluationProviders",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationProviders_UserId",
                table: "EvaluationProviders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationServices_ServiceId",
                table: "EvaluationServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationServices_UserId",
                table: "EvaluationServices",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_UserId",
                table: "Experiences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProviders_ProviderId",
                table: "FavoriteProviders",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProviders_UserId",
                table: "FavoriteProviders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteServices_ServiceId",
                table: "FavoriteServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteServices_UserId",
                table: "FavoriteServices",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MainSectionCoupons_CouponId",
                table: "MainSectionCoupons",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_MainSectionCoupons_MainSectionId",
                table: "MainSectionCoupons",
                column: "MainSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageChats_ReceiveUserId",
                table: "MessageChats",
                column: "ReceiveUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageChats_SendUserId",
                table: "MessageChats",
                column: "SendUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationsConfirmed_NotificationId",
                table: "NotificationsConfirmed",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationsConfirmed_UserId",
                table: "NotificationsConfirmed",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CityId",
                table: "Orders",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CouponId",
                table: "Orders",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ServiceId",
                table: "Orders",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentHistories_OrderId",
                table: "PaymentHistories",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Prizes_UserId",
                table: "Prizes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderPhotos_ProviderId",
                table: "ProviderPhotos",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionsAndAnswers_QuestionsAndAnswersSectionId",
                table: "QuestionsAndAnswers",
                column: "QuestionsAndAnswersSectionId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "dbo",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "dbo",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCoupons_CouponId",
                table: "ServiceCoupons",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCoupons_ServiceId",
                table: "ServiceCoupons",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_MainSectionId",
                table: "Services",
                column: "MainSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ProviderId",
                table: "Services",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaim_UserId",
                schema: "dbo",
                table: "UserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCoupons_CouponId",
                table: "UserCoupons",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCoupons_ProviderId",
                table: "UserCoupons",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_UserId",
                schema: "dbo",
                table: "UserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                schema: "dbo",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "dbo",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                schema: "dbo",
                table: "Users",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "dbo",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WorksHours_UserId",
                table: "WorksHours",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Commissions");

            migrationBuilder.DropTable(
                name: "Complaints");

            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "EvaluationProviders");

            migrationBuilder.DropTable(
                name: "EvaluationServices");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "FavoriteProviders");

            migrationBuilder.DropTable(
                name: "FavoriteServices");

            migrationBuilder.DropTable(
                name: "MainSectionCoupons");

            migrationBuilder.DropTable(
                name: "MessageChats");

            migrationBuilder.DropTable(
                name: "NotificationsConfirmed");

            migrationBuilder.DropTable(
                name: "PaymentHistories");

            migrationBuilder.DropTable(
                name: "Prizes");

            migrationBuilder.DropTable(
                name: "ProviderPhotos");

            migrationBuilder.DropTable(
                name: "QuestionsAndAnswers");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ServiceCoupons");

            migrationBuilder.DropTable(
                name: "SlidePhotos");

            migrationBuilder.DropTable(
                name: "UserClaim",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserConnections");

            migrationBuilder.DropTable(
                name: "UserCoupons");

            migrationBuilder.DropTable(
                name: "UserLogin",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserTokens",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "WorksHours");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "QuestionsAndAnswersSections");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "MainSections");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}

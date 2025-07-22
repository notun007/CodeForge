using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Common");

            migrationBuilder.EnsureSchema(
                name: "Saving");

            migrationBuilder.EnsureSchema(
                name: "Accounting");

            migrationBuilder.EnsureSchema(
                name: "Loan");

            migrationBuilder.EnsureSchema(
                name: "Member");

            migrationBuilder.EnsureSchema(
                name: "Membership");

            migrationBuilder.CreateTable(
                name: "ApplicationStatuses",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationLevels",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseType",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialServiceProviderTypes",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialServiceProviderTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatuses",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MembershipTypes",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileBankings",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileBankings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Occupations",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentChannels",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentChannels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceDepartments",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDepartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceDivisions",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDivisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tenures",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<short>(type: "smallint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unregistrations",
                schema: "Membership",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unregistrations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CountryId = table.Column<short>(type: "smallint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divisions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Common",
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinancialServiceProviders",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinancialServiceProviderTypeId = table.Column<short>(type: "smallint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialServiceProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinancialServiceProviders_FinancialServiceProviderTypes_FinancialServiceProviderTypeId",
                        column: x => x.FinancialServiceProviderTypeId,
                        principalSchema: "Common",
                        principalTable: "FinancialServiceProviderTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DivisionId = table.Column<short>(type: "smallint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalSchema: "Common",
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FinancialServiceProviderId = table.Column<short>(type: "smallint", nullable: true),
                    PaymentChannelId = table.Column<short>(type: "smallint", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentChargePercent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_FinancialServiceProviders_FinancialServiceProviderId",
                        column: x => x.FinancialServiceProviderId,
                        principalSchema: "Common",
                        principalTable: "FinancialServiceProviders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethods_PaymentChannels_PaymentChannelId",
                        column: x => x.PaymentChannelId,
                        principalSchema: "Common",
                        principalTable: "PaymentChannels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Upazilas",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DistrictId = table.Column<short>(type: "smallint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upazilas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Upazilas_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Common",
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                schema: "Accounting",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseTypeId = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethodId = table.Column<short>(type: "smallint", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PaidTo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ApprovedBy = table.Column<int>(type: "int", nullable: true),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRecurring = table.Column<bool>(type: "bit", nullable: false),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_ExpenseType_ExpenseTypeId",
                        column: x => x.ExpenseTypeId,
                        principalTable: "ExpenseType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expenses_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalSchema: "Common",
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Unions",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UpazilaId = table.Column<short>(type: "smallint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unions_Upazilas_UpazilaId",
                        column: x => x.UpazilaId,
                        principalSchema: "Common",
                        principalTable: "Upazilas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Memberships",
                schema: "Member",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SpouseName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MembershipNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    AlternatePhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShareCapital = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MembershipDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MembershipStatusId = table.Column<short>(type: "smallint", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NomineeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NomineeAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NomineePhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    IntroducedByMemberId = table.Column<long>(type: "bigint", nullable: true),
                    NationalIdentificationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GenderId = table.Column<short>(type: "smallint", nullable: false),
                    MaritalStatusId = table.Column<short>(type: "smallint", nullable: false),
                    MembershipTypeId = table.Column<short>(type: "smallint", nullable: false),
                    ReligionId = table.Column<short>(type: "smallint", nullable: false),
                    MobileBankingId = table.Column<short>(type: "smallint", nullable: true),
                    CountryId = table.Column<short>(type: "smallint", nullable: true),
                    DivisionId = table.Column<short>(type: "smallint", nullable: true),
                    DistrictId = table.Column<short>(type: "smallint", nullable: true),
                    UpazilaId = table.Column<short>(type: "smallint", nullable: true),
                    UnionId = table.Column<short>(type: "smallint", nullable: true),
                    VillageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationLevelId = table.Column<short>(type: "smallint", nullable: false),
                    DesignationId = table.Column<short>(type: "smallint", nullable: false),
                    ServiceDepartmentId = table.Column<short>(type: "smallint", nullable: false),
                    ServiceDivisionId = table.Column<short>(type: "smallint", nullable: false),
                    ServiceLocationCountryId = table.Column<short>(type: "smallint", nullable: true),
                    ServiceLocationDivisionId = table.Column<short>(type: "smallint", nullable: true),
                    ServiceLocationDistrictId = table.Column<short>(type: "smallint", nullable: true),
                    ServiceLocationUpazilaId = table.Column<short>(type: "smallint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memberships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Memberships_Countries_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Common",
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Memberships_Countries_ServiceLocationCountryId",
                        column: x => x.ServiceLocationCountryId,
                        principalSchema: "Common",
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Memberships_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalSchema: "Common",
                        principalTable: "Designations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Common",
                        principalTable: "Districts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Memberships_Districts_ServiceLocationDistrictId",
                        column: x => x.ServiceLocationDistrictId,
                        principalSchema: "Common",
                        principalTable: "Districts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Memberships_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalSchema: "Common",
                        principalTable: "Divisions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Memberships_Divisions_ServiceLocationDivisionId",
                        column: x => x.ServiceLocationDivisionId,
                        principalSchema: "Common",
                        principalTable: "Divisions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Memberships_EducationLevels_EducationLevelId",
                        column: x => x.EducationLevelId,
                        principalSchema: "Common",
                        principalTable: "EducationLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_Genders_GenderId",
                        column: x => x.GenderId,
                        principalSchema: "Common",
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_MaritalStatuses_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalSchema: "Common",
                        principalTable: "MaritalStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_MembershipTypes_MembershipTypeId",
                        column: x => x.MembershipTypeId,
                        principalSchema: "Common",
                        principalTable: "MembershipTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_Memberships_IntroducedByMemberId",
                        column: x => x.IntroducedByMemberId,
                        principalSchema: "Member",
                        principalTable: "Memberships",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Memberships_MobileBankings_MobileBankingId",
                        column: x => x.MobileBankingId,
                        principalSchema: "Common",
                        principalTable: "MobileBankings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Memberships_Religions_ReligionId",
                        column: x => x.ReligionId,
                        principalSchema: "Common",
                        principalTable: "Religions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_ServiceDepartments_ServiceDepartmentId",
                        column: x => x.ServiceDepartmentId,
                        principalSchema: "Common",
                        principalTable: "ServiceDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_ServiceDivisions_ServiceDivisionId",
                        column: x => x.ServiceDivisionId,
                        principalSchema: "Common",
                        principalTable: "ServiceDivisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_Unions_UnionId",
                        column: x => x.UnionId,
                        principalSchema: "Common",
                        principalTable: "Unions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Memberships_Upazilas_ServiceLocationUpazilaId",
                        column: x => x.ServiceLocationUpazilaId,
                        principalSchema: "Common",
                        principalTable: "Upazilas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Memberships_Upazilas_UpazilaId",
                        column: x => x.UpazilaId,
                        principalSchema: "Common",
                        principalTable: "Upazilas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Deposits",
                schema: "Saving",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipId = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepositDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethodId = table.Column<short>(type: "smallint", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deposits_Memberships_MembershipId",
                        column: x => x.MembershipId,
                        principalSchema: "Member",
                        principalTable: "Memberships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deposits_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalSchema: "Common",
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanApplications",
                schema: "Loan",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipId = table.Column<long>(type: "bigint", nullable: false),
                    LoanAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TenureId = table.Column<short>(type: "smallint", nullable: true),
                    LoanPurpose = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationStatusId = table.Column<short>(type: "smallint", nullable: false),
                    ApprovedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApprovedBy = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanApplications_ApplicationStatuses_ApplicationStatusId",
                        column: x => x.ApplicationStatusId,
                        principalSchema: "Common",
                        principalTable: "ApplicationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanApplications_Memberships_MembershipId",
                        column: x => x.MembershipId,
                        principalSchema: "Member",
                        principalTable: "Memberships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanApplications_Tenures_TenureId",
                        column: x => x.TenureId,
                        principalSchema: "Common",
                        principalTable: "Tenures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LoanDisbursements",
                schema: "Loan",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipId = table.Column<long>(type: "bigint", nullable: false),
                    LoanNumber = table.Column<int>(type: "int", nullable: false),
                    LoanAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TenureId = table.Column<short>(type: "smallint", nullable: false),
                    InstallmentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethodId = table.Column<short>(type: "smallint", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DisbursedBy = table.Column<int>(type: "int", nullable: false),
                    DisbursementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovedBy = table.Column<int>(type: "int", nullable: true),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanDisbursements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanDisbursements_Memberships_MembershipId",
                        column: x => x.MembershipId,
                        principalSchema: "Member",
                        principalTable: "Memberships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanDisbursements_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalSchema: "Common",
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanDisbursements_Tenures_TenureId",
                        column: x => x.TenureId,
                        principalSchema: "Common",
                        principalTable: "Tenures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanCollections",
                schema: "Loan",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanDisbursementId = table.Column<long>(type: "bigint", nullable: false),
                    CollectionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PenaltyAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentMethodId = table.Column<short>(type: "smallint", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CollectedBy = table.Column<int>(type: "int", nullable: false),
                    CollectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsAdvancePayment = table.Column<bool>(type: "bit", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanCollections_LoanDisbursements_LoanDisbursementId",
                        column: x => x.LoanDisbursementId,
                        principalSchema: "Loan",
                        principalTable: "LoanDisbursements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanCollections_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalSchema: "Common",
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_MembershipId",
                schema: "Saving",
                table: "Deposits",
                column: "MembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_PaymentMethodId",
                schema: "Saving",
                table: "Deposits",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_DivisionId",
                schema: "Common",
                table: "Districts",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_CountryId",
                schema: "Common",
                table: "Divisions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseTypeId",
                schema: "Accounting",
                table: "Expenses",
                column: "ExpenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_PaymentMethodId",
                schema: "Accounting",
                table: "Expenses",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialServiceProviders_FinancialServiceProviderTypeId",
                schema: "Common",
                table: "FinancialServiceProviders",
                column: "FinancialServiceProviderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanApplications_ApplicationStatusId",
                schema: "Loan",
                table: "LoanApplications",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanApplications_MembershipId",
                schema: "Loan",
                table: "LoanApplications",
                column: "MembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanApplications_TenureId",
                schema: "Loan",
                table: "LoanApplications",
                column: "TenureId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanCollections_LoanDisbursementId",
                schema: "Loan",
                table: "LoanCollections",
                column: "LoanDisbursementId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanCollections_PaymentMethodId",
                schema: "Loan",
                table: "LoanCollections",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanDisbursements_MembershipId",
                schema: "Loan",
                table: "LoanDisbursements",
                column: "MembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanDisbursements_PaymentMethodId",
                schema: "Loan",
                table: "LoanDisbursements",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanDisbursements_TenureId",
                schema: "Loan",
                table: "LoanDisbursements",
                column: "TenureId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_CountryId",
                schema: "Member",
                table: "Memberships",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_DesignationId",
                schema: "Member",
                table: "Memberships",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_DistrictId",
                schema: "Member",
                table: "Memberships",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_DivisionId",
                schema: "Member",
                table: "Memberships",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_EducationLevelId",
                schema: "Member",
                table: "Memberships",
                column: "EducationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_GenderId",
                schema: "Member",
                table: "Memberships",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_IntroducedByMemberId",
                schema: "Member",
                table: "Memberships",
                column: "IntroducedByMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_MaritalStatusId",
                schema: "Member",
                table: "Memberships",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_MembershipTypeId",
                schema: "Member",
                table: "Memberships",
                column: "MembershipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_MobileBankingId",
                schema: "Member",
                table: "Memberships",
                column: "MobileBankingId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_ReligionId",
                schema: "Member",
                table: "Memberships",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_ServiceDepartmentId",
                schema: "Member",
                table: "Memberships",
                column: "ServiceDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_ServiceDivisionId",
                schema: "Member",
                table: "Memberships",
                column: "ServiceDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_ServiceLocationCountryId",
                schema: "Member",
                table: "Memberships",
                column: "ServiceLocationCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_ServiceLocationDistrictId",
                schema: "Member",
                table: "Memberships",
                column: "ServiceLocationDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_ServiceLocationDivisionId",
                schema: "Member",
                table: "Memberships",
                column: "ServiceLocationDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_ServiceLocationUpazilaId",
                schema: "Member",
                table: "Memberships",
                column: "ServiceLocationUpazilaId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_UnionId",
                schema: "Member",
                table: "Memberships",
                column: "UnionId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_UpazilaId",
                schema: "Member",
                table: "Memberships",
                column: "UpazilaId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_FinancialServiceProviderId",
                schema: "Common",
                table: "PaymentMethods",
                column: "FinancialServiceProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_PaymentChannelId",
                schema: "Common",
                table: "PaymentMethods",
                column: "PaymentChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_Unions_UpazilaId",
                schema: "Common",
                table: "Unions",
                column: "UpazilaId");

            migrationBuilder.CreateIndex(
                name: "IX_Upazilas_DistrictId",
                schema: "Common",
                table: "Upazilas",
                column: "DistrictId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deposits",
                schema: "Saving");

            migrationBuilder.DropTable(
                name: "Expenses",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "LoanApplications",
                schema: "Loan");

            migrationBuilder.DropTable(
                name: "LoanCollections",
                schema: "Loan");

            migrationBuilder.DropTable(
                name: "Occupations",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Unregistrations",
                schema: "Membership");

            migrationBuilder.DropTable(
                name: "ExpenseType");

            migrationBuilder.DropTable(
                name: "ApplicationStatuses",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "LoanDisbursements",
                schema: "Loan");

            migrationBuilder.DropTable(
                name: "Memberships",
                schema: "Member");

            migrationBuilder.DropTable(
                name: "PaymentMethods",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Tenures",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Designations",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "EducationLevels",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Genders",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "MaritalStatuses",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "MembershipTypes",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "MobileBankings",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Religions",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "ServiceDepartments",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "ServiceDivisions",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Unions",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "FinancialServiceProviders",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "PaymentChannels",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Upazilas",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "FinancialServiceProviderTypes",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Districts",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Divisions",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "Common");
        }
    }
}

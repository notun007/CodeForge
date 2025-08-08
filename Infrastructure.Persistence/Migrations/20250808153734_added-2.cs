using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class added2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "Upazilas",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Membership",
                table: "Unregistrations",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "Unions",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "Tenures",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "ServiceDivisions",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "ServiceDepartments",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "Religions",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "PaymentMethods",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "PaymentChannels",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "Occupations",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "MobileBankings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "MembershipTypes",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Member",
                table: "Memberships",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "MaritalStatuses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Loan",
                table: "LoanDisbursements",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Loan",
                table: "LoanCollections",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Loan",
                table: "LoanApplications",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "Genders",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "FinancialServiceProviderTypes",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "FinancialServiceProviders",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ExpenseType",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Accounting",
                table: "Expenses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "EducationLevels",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "Divisions",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "Districts",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "Designations",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Saving",
                table: "Deposits",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "Countries",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "ApplicationStatuses",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "Upazilas");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Membership",
                table: "Unregistrations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "Unions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "Tenures");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "ServiceDivisions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "ServiceDepartments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "Religions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "PaymentChannels");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "Occupations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "MobileBankings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "MembershipTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Member",
                table: "Memberships");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "MaritalStatuses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Loan",
                table: "LoanDisbursements");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Loan",
                table: "LoanCollections");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Loan",
                table: "LoanApplications");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "FinancialServiceProviderTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "FinancialServiceProviders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ExpenseType");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Accounting",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "EducationLevels");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "Divisions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Saving",
                table: "Deposits");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "ApplicationStatuses");
        }
    }
}

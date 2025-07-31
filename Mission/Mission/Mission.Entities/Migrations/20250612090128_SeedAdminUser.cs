using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission.Entities.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email_address", "first_name", "password", "phone_number" },
                values: new object[] { "admin@gmail.com", "Dharm", "admin", "8733006744" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email_address", "first_name", "password", "phone_number" },
                values: new object[] { "admin@tatvasoft.com", "Tatva", "Tatva@123", "9876543210" });
        }
    }
}

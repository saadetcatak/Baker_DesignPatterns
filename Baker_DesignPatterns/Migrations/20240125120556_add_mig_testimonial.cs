using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baker_DesignPatterns.Migrations
{
    /// <inheritdoc />
    public partial class add_mig_testimonial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHome",
                table: "Testimonials",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHome",
                table: "Testimonials");
        }
    }
}

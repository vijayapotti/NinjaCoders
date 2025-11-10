using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NinjaCoders.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
              name: "IX_CourseStudent_CoursesId",
              table: "CourseStudent",
              column: "CoursesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

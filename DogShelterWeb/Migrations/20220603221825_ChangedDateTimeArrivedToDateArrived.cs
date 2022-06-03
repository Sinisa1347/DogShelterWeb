using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogShelterWeb.Migrations
{
    public partial class ChangedDateTimeArrivedToDateArrived : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTimeArrived",
                table: "Categories",
                newName: "DateArrived");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateArrived",
                table: "Categories",
                newName: "DateTimeArrived");
        }
    }
}

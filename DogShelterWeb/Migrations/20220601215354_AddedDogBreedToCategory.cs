using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogShelterWeb.Migrations
{
    public partial class AddedDogBreedToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Dog_Breed",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dog_Breed",
                table: "Categories");
        }
    }
}

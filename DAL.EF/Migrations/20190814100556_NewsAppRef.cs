using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.EF.Migrations
{
    public partial class NewsAppRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "News");

            migrationBuilder.AddColumn<string>(
                name: "NewsAppRef",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewsAppRef",
                table: "News");

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "News",
                nullable: false,
                defaultValue: 0);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCPortableEbookItem_PCPortables_PCPortableId",
                table: "PCPortableEbookItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PCPortableEbookItem",
                table: "PCPortableEbookItem");

            migrationBuilder.RenameTable(
                name: "PCPortableEbookItem",
                newName: "PCPortableEbookItems");

            migrationBuilder.RenameIndex(
                name: "IX_PCPortableEbookItem_PCPortableId",
                table: "PCPortableEbookItems",
                newName: "IX_PCPortableEbookItems_PCPortableId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PCPortableEbookItems",
                table: "PCPortableEbookItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PCPortableEbookItems_PCPortables_PCPortableId",
                table: "PCPortableEbookItems",
                column: "PCPortableId",
                principalTable: "PCPortables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCPortableEbookItems_PCPortables_PCPortableId",
                table: "PCPortableEbookItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PCPortableEbookItems",
                table: "PCPortableEbookItems");

            migrationBuilder.RenameTable(
                name: "PCPortableEbookItems",
                newName: "PCPortableEbookItem");

            migrationBuilder.RenameIndex(
                name: "IX_PCPortableEbookItems_PCPortableId",
                table: "PCPortableEbookItem",
                newName: "IX_PCPortableEbookItem_PCPortableId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PCPortableEbookItem",
                table: "PCPortableEbookItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PCPortableEbookItem_PCPortables_PCPortableId",
                table: "PCPortableEbookItem",
                column: "PCPortableId",
                principalTable: "PCPortables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

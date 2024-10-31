using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewSCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Author_AuthorId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Cataloges_CatalogId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_AuthorId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_CatalogId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "News");

            migrationBuilder.CreateIndex(
                name: "IX_News_auth_id",
                table: "News",
                column: "auth_id");

            migrationBuilder.CreateIndex(
                name: "IX_News_cat_id",
                table: "News",
                column: "cat_id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Author_auth_id",
                table: "News",
                column: "auth_id",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Cataloges_cat_id",
                table: "News",
                column: "cat_id",
                principalTable: "Cataloges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Author_auth_id",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Cataloges_cat_id",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_auth_id",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_cat_id",
                table: "News");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CatalogId",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorId",
                table: "News",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CatalogId",
                table: "News",
                column: "CatalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Author_AuthorId",
                table: "News",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Cataloges_CatalogId",
                table: "News",
                column: "CatalogId",
                principalTable: "Cataloges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

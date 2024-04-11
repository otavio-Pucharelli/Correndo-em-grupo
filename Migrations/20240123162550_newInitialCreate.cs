using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorrendoEmGrupo.Migrations
{
    /// <inheritdoc />
    public partial class newInitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_Addresses_Addresid",
                table: "AppUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Addresses_Addresid",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Addresses_Addresid",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_Addresid",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Clubs_Addresid",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "Addresid",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "Addresid",
                table: "Clubs");

            migrationBuilder.RenameColumn(
                name: "Addresid",
                table: "AppUser",
                newName: "Addressid");

            migrationBuilder.RenameIndex(
                name: "IX_AppUser_Addresid",
                table: "AppUser",
                newName: "IX_AppUser_Addressid");

            migrationBuilder.CreateIndex(
                name: "IX_Races_AddressId",
                table: "Races",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_AddressId",
                table: "Clubs",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_Addresses_Addressid",
                table: "AppUser",
                column: "Addressid",
                principalTable: "Addresses",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Addresses_AddressId",
                table: "Clubs",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Addresses_AddressId",
                table: "Races",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_Addresses_Addressid",
                table: "AppUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Addresses_AddressId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Addresses_AddressId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_AddressId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Clubs_AddressId",
                table: "Clubs");

            migrationBuilder.RenameColumn(
                name: "Addressid",
                table: "AppUser",
                newName: "Addresid");

            migrationBuilder.RenameIndex(
                name: "IX_AppUser_Addressid",
                table: "AppUser",
                newName: "IX_AppUser_Addresid");

            migrationBuilder.AddColumn<int>(
                name: "Addresid",
                table: "Races",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Addresid",
                table: "Clubs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Races_Addresid",
                table: "Races",
                column: "Addresid");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_Addresid",
                table: "Clubs",
                column: "Addresid");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_Addresses_Addresid",
                table: "AppUser",
                column: "Addresid",
                principalTable: "Addresses",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Addresses_Addresid",
                table: "Clubs",
                column: "Addresid",
                principalTable: "Addresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Addresses_Addresid",
                table: "Races",
                column: "Addresid",
                principalTable: "Addresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

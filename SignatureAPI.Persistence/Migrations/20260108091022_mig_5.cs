using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignatureAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Signatures_Companies_CompanyId",
                table: "Signatures");

            migrationBuilder.DropColumn(
                name: "SignatureType",
                table: "Signatures");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyId",
                table: "Signatures",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "FK_Signatures_Companies_CompanyId",
                table: "Signatures",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Signatures_Companies_CompanyId",
                table: "Signatures");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyId",
                table: "Signatures",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "SignatureType",
                table: "Signatures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Signatures_Companies_CompanyId",
                table: "Signatures",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignatureAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignatureAssets_Signatures_SignatureId",
                table: "SignatureAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_SignatureLinks_Signatures_SignatureId",
                table: "SignatureLinks");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "SignatureId",
                table: "SignatureLinks",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "SignatureId",
                table: "SignatureAssets",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "SignatureId",
                table: "Companies",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "FK_SignatureAssets_Signatures_SignatureId",
                table: "SignatureAssets",
                column: "SignatureId",
                principalTable: "Signatures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignatureLinks_Signatures_SignatureId",
                table: "SignatureLinks",
                column: "SignatureId",
                principalTable: "Signatures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Signatures_Companies_CompanyId",
                table: "Signatures",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignatureAssets_Signatures_SignatureId",
                table: "SignatureAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_SignatureLinks_Signatures_SignatureId",
                table: "SignatureLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Signatures_Companies_CompanyId",
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

            migrationBuilder.AlterColumn<Guid>(
                name: "SignatureId",
                table: "SignatureLinks",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "SignatureId",
                table: "SignatureAssets",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "SignatureId",
                table: "Companies",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "FK_SignatureAssets_Signatures_SignatureId",
                table: "SignatureAssets",
                column: "SignatureId",
                principalTable: "Signatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignatureLinks_Signatures_SignatureId",
                table: "SignatureLinks",
                column: "SignatureId",
                principalTable: "Signatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Signatures_Companies_CompanyId",
                table: "Signatures",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestao.Empresarial.Infrastructure.Migrations
{
    public partial class companiesdbmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CorporateName = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    CNPJ = table.Column<int>(type: "int", maxLength: 14, nullable: false),
                    CEP = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    Address = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    AddressNumber = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    Email = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    Phone = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    Site = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}

using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace HoustonMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Rampa",
                columns: table => new
                {
                    RampaID = table.Column(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", "true"),
                    Lokacija = table.Column(type: "TEXT", nullable: true),
                    fourSquareID = table.Column(type: "TEXT", nullable: true),
                    imeRampe = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rampa", x => x.RampaID);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Rampa");
        }
    }
}

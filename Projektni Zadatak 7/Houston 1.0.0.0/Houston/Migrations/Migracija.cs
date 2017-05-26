using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using Windows.Storage;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Houston.HoustonBaza.Models;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;
using JetBrains.Annotations;

namespace Houston.Migrations
{
    public partial class Migracija : Migration
    {
        public override string Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Rampa",
                columns: table => new
                {
                    RampaID = table.Column(type: "INTEGER", nullable: false),
                   //.Annotation("Sqlite:Autoincrement", "true"),
                   Lokacija = table.Column(type: "TEXT", nullable: true),
                    fourSquareID = table.Column(type: "TEXT", nullable: true),
                    imeRampe = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoustonCentralBase", x => x.RampaID);
                });
        }
        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Rampa");
        }
    }
    
}

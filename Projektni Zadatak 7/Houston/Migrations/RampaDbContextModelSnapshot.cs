using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Houston.HoustonBaza.Models;

namespace HoustonMigrations
{
    [ContextType(typeof(RampaDbContext))]
    partial class RampaDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Houston.HoustonBaza.Models.Rampa", b =>
                {
                    b.Property<int>("RampaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Lokacija");

                    b.Property<string>("fourSquareID");

                    b.Property<string>("imeRampe");

                    b.Key("RampaID");
                });
        }
    }
}

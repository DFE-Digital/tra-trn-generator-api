// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TrnGeneratorApi.BenchmarkTests.Models;

#nullable disable

namespace TrnGeneratorApi.BenchmarkTests.Migrations
{
    [DbContext(typeof(TrnGeneratorDbContext))]
    [Migration("20221103140236_AddGenerateTrnFunction")]
    partial class AddGenerateTrnFunction
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TrnGeneratorApi.Models.TrnInfo", b =>
                {
                    b.Property<int>("Trn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("trn");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Trn"));

                    b.Property<bool>("IsClaimed")
                        .HasColumnType("boolean")
                        .HasColumnName("is_claimed");

                    b.HasKey("Trn")
                        .HasName("pk_trn_info");

                    b.HasIndex("Trn")
                        .HasDatabaseName("ix_trn_info_unclaimed_trns")
                        .HasFilter("is_claimed IS FALSE");

                    b.ToTable("trn_info", (string)null);
                });

            modelBuilder.Entity("TrnGeneratorApi.Models.TrnRange", b =>
                {
                    b.Property<int>("FromTrn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("from_trn");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("FromTrn"));

                    b.Property<bool>("IsExhausted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_exhausted");

                    b.Property<int>("NextTrn")
                        .HasColumnType("integer")
                        .HasColumnName("next_trn");

                    b.Property<int>("ToTrn")
                        .HasColumnType("integer")
                        .HasColumnName("to_trn");

                    b.HasKey("FromTrn")
                        .HasName("pk_trn_range");

                    b.HasIndex("FromTrn")
                        .HasDatabaseName("ix_trn_range_unexhausted_trn_ranges")
                        .HasFilter("is_exhausted IS FALSE");

                    b.ToTable("trn_range", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

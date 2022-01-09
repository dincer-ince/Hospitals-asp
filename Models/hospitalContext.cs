using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace covid_backend.Models
{
    public partial class hospitalContext : DbContext
    {
        public hospitalContext()
        {
        }

        public hospitalContext(DbContextOptions<hospitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hospital> Hospitals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=2801;Database=hospital;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "English_Europe.1252");

            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("hospitals_pkey");

                entity.ToTable("hospitals");

                entity.Property(e => e.Fid)
                    .ValueGeneratedNever()
                    .HasColumnName("FID");

                entity.Property(e => e.Address).HasColumnName("ADDRESS");

                entity.Property(e => e.AltName).HasColumnName("ALT_NAME");

                entity.Property(e => e.Beds).HasColumnName("BEDS");

                entity.Property(e => e.City).HasColumnName("CITY");

                entity.Property(e => e.Country).HasColumnName("COUNTRY");

                entity.Property(e => e.County).HasColumnName("COUNTY");

                entity.Property(e => e.Countyfips).HasColumnName("COUNTYFIPS");

                entity.Property(e => e.Helipad)
                    .HasColumnType("char(1)")
                    .HasColumnName("HELIPAD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Latitude).HasColumnName("LATITUDE");

                entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");

                entity.Property(e => e.NaicsCode).HasColumnName("NAICS_CODE");

                entity.Property(e => e.NaicsDesc).HasColumnName("NAICS_DESC");

                entity.Property(e => e.Name).HasColumnName("NAME");

                entity.Property(e => e.Owner).HasColumnName("OWNER");

                entity.Property(e => e.Population).HasColumnName("POPULATION");

                entity.Property(e => e.Source).HasColumnName("SOURCE");

                entity.Property(e => e.Sourcedate).HasColumnName("SOURCEDATE");

                entity.Property(e => e.StFips).HasColumnName("ST_FIPS");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.StateId).HasColumnName("STATE_ID");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Telephone).HasColumnName("TELEPHONE");

                entity.Property(e => e.Trauma).HasColumnName("TRAUMA");

                entity.Property(e => e.TtlStaff).HasColumnName("TTL_STAFF");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.ValDate).HasColumnName("VAL_DATE");

                entity.Property(e => e.ValMethod).HasColumnName("VAL_METHOD");

                entity.Property(e => e.Website).HasColumnName("WEBSITE");

                entity.Property(e => e.Zip).HasColumnName("ZIP");

                entity.Property(e => e.Zip4).HasColumnName("ZIP4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

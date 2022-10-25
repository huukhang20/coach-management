using System;
using System.Collections.Generic;
using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public partial class CoachManagementContext : DbContext
    {
        public CoachManagementContext()
        {
        }

        public CoachManagementContext(DbContextOptions<CoachManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coach> Coaches { get; set; } = null!;
        public virtual DbSet<Driver> Drivers { get; set; } = null!;
        public virtual DbSet<Passenger> Passengers { get; set; } = null!;
        public virtual DbSet<Route> Routes { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<Trip> Trips { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
            var strConn = config["ConnectionStrings:CoachManagement"];
            return strConn;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coach>(entity =>
            {
                entity.HasKey(e => e.NumberPlate);

                entity.ToTable("Coach");

                entity.Property(e => e.NumberPlate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brand).HasMaxLength(100);

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.HasMany(d => d.Trips)
                    .WithMany(p => p.NumberPlates)
                    .UsingEntity<Dictionary<string, object>>(
                        "CoachTrip",
                        l => l.HasOne<Trip>().WithMany().HasForeignKey("TripId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CoachTrip_Trip"),
                        r => r.HasOne<Coach>().WithMany().HasForeignKey("NumberPlate").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CoachTrip_Coach"),
                        j =>
                        {
                            j.HasKey("NumberPlate", "TripId");

                            j.ToTable("CoachTrip");

                            j.IndexerProperty<string>("NumberPlate").HasMaxLength(50).IsUnicode(false);
                        });
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.ToTable("Driver");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NumberPlate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.NumberPlateNavigation)
                    .WithMany(p => p.Drivers)
                    .HasForeignKey(d => d.NumberPlate)
                    .HasConstraintName("FK_Driver_Coach");
            });

            modelBuilder.Entity<Passenger>(entity =>
            {
                entity.ToTable("Passenger");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.ToTable("Route");

                entity.Property(e => e.From).HasMaxLength(200);

                entity.Property(e => e.To).HasMaxLength(200);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.PassengerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Passenger)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.PassengerId)
                    .HasConstraintName("FK_Ticket_Passenger");

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.TripId)
                    .HasConstraintName("FK_Ticket_Trip");
            });

            modelBuilder.Entity<Trip>(entity =>
            {
                entity.ToTable("Trip");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_Trip_Route");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

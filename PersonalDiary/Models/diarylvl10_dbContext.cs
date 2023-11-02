using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace PersonalDiary.Models
{
    public partial class diarylvl10_dbContext : DbContext
    {
        public diarylvl10_dbContext()
        {
        }

        public diarylvl10_dbContext(DbContextOptions<diarylvl10_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DiaryEntry> DiaryEntries { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyCnn"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiaryEntry>(entity =>
            {
                entity.HasKey(e => e.EntryId)
                    .HasName("PK__DiaryEnt__F57BD2D7A0C4634D");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DiaryEntryCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DiaryEntr__Creat__4D94879B");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.DiaryEntryUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__DiaryEntr__Updat__4E88ABD4");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DiaryEntryUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DiaryEntr__UserI__4CA06362");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

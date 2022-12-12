using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Dictionary_EF.Models
{
    public partial class MyDB2Context : DbContext
    {
        public MyDB2Context()
        {
        }

        public MyDB2Context(DbContextOptions<MyDB2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Dictionary> Dictionaries { get; set; } = null!;
        public virtual DbSet<WordType> WordTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyDict"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dictionary>(entity =>
            {
                entity.HasKey(e => e.WordId)
                    .HasName("PK__Dictiona__2C20F046BC412C34");

                entity.ToTable("Dictionary");

                entity.Property(e => e.WordId).HasColumnName("WordID");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Word).HasMaxLength(30);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Dictionaries)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Dictionary__ID__267ABA7A");
            });

            modelBuilder.Entity<WordType>(entity =>
            {
                entity.ToTable("WordType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TypeName).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

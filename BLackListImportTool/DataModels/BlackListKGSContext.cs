using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BLackListImportTool.DataModels
{
    public partial class BlackListKGSContext : DbContext
    {
        public BlackListKGSContext()
        {
        }

        public BlackListKGSContext(DbContextOptions<BlackListKGSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BlacklisTkg> BlacklisTkgs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-VLIDHQB\\YUNUS;Database=BlackListKGS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlacklisTkg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BlacklisTKGS");

                entity.Property(e => e.CityId).HasColumnName("City_id");

                entity.Property(e => e.İlçeAdı)
                    .HasMaxLength(50)
                    .HasColumnName("İlçe_Adı");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AspCoreWebApiGetRecords.Models
{
    public partial class codefirstDBContext : DbContext
    {
        public codefirstDBContext()
        {
        }

        public codefirstDBContext(DbContextOptions<codefirstDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=HRITIKNAGPURE\\SQLEXPRESS;Database=codefirstDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Studentgender)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("studentgender");

                entity.Property(e => e.Studentname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("studentname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

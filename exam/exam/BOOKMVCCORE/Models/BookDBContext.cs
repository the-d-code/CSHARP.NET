using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOOKMVCCORE.Models
{
    public partial class BookDBContext : DbContext
    {
        public BookDBContext()
        {
        }

        public BookDBContext(DbContextOptions<BookDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Auther> Auther { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Publicsh> Publicsh { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-E4O1G2O\\SQLEXPRESS;Initial Catalog=BookDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auther>(entity =>
            {
                entity.Property(e => e.AutherId)
                    .HasColumnName("AutherID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutherName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.BookAccId);

                entity.Property(e => e.BookAccId).ValueGeneratedNever();

                entity.Property(e => e.AutherId).HasColumnName("AutherID");

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublicingYear)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublicsId).HasColumnName("PublicsID");

                entity.HasOne(d => d.Auther)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.AutherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_Auther");

                entity.HasOne(d => d.Publics)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.PublicsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_Publicsh");
            });

            modelBuilder.Entity<Publicsh>(entity =>
            {
                entity.HasKey(e => e.PublicsId);

                entity.Property(e => e.PublicsId)
                    .HasColumnName("PublicsID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublisherName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

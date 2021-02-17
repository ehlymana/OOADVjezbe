using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebAPI
{
    public partial class StudentskaSluzbaContext : DbContext
    {
        public StudentskaSluzbaContext()
        {
        }

        public StudentskaSluzbaContext(DbContextOptions<StudentskaSluzbaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Predmet> Predmets { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<UpisNaPredmet> UpisNaPredmets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=sql11.freesqldatabase.com;Port=3306;Database=sql11392600;User=sql11392600;Password=;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Predmet>(entity =>
            {
                entity.ToTable("Predmet");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Ects).HasColumnName("ECTS");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Ime)
                    .HasName("PRIMARY");

                entity.ToTable("Student");

                entity.Property(e => e.BrojIndeksa).HasColumnType("int(11)");

                entity.Property(e => e.GodinaStudija).HasColumnType("int(11)");

                entity.Property(e => e.Prezime).IsRequired();
            });

            modelBuilder.Entity<UpisNaPredmet>(entity =>
            {
                entity.HasKey(e => e.BrojProtokola)
                    .HasName("PRIMARY");

                entity.ToTable("UpisNaPredmet");

                entity.Property(e => e.AkademskaGodina).HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

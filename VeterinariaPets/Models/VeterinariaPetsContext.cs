using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VeterinariaPets.Models
{
    public partial class VeterinariaPetsContext : DbContext
    {
        public VeterinariaPetsContext()
        {
        }

        public VeterinariaPetsContext(DbContextOptions<VeterinariaPetsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Pet> Pet { get; set; }
        public virtual DbSet<PetBreed> PetBreed { get; set; }
        public virtual DbSet<PetType> PetType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<ProductXprovider> ProductXprovider { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;User ID=vetpetadmin;Password=vetpetadmin;TrustServerCertificate=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.HasOne(d => d.IdDepartmentNavigation)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.IdDepartment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_Department");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Document");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Idcity).HasColumnName("IDCity");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.HasOne(d => d.IdcityNavigation)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.Idcity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_City");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<Pet>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Idbreed).HasColumnName("IDBreed");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Pet)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pet_Client");

                entity.HasOne(d => d.IdbreedNavigation)
                    .WithMany(p => p.Pet)
                    .HasForeignKey(d => d.Idbreed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pet_PetBreed");
            });

            modelBuilder.Entity<PetBreed>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.HasOne(d => d.IdPetTypeNavigation)
                    .WithMany(p => p.PetBreed)
                    .HasForeignKey(d => d.IdPetType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PetBreed_PetType");
            });

            modelBuilder.Entity<PetType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdproductType).HasColumnName("IDProductType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.HasOne(d => d.IdproductTypeNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.IdproductType)
                    .HasConstraintName("FK_Product_ProductType");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<ProductXprovider>(entity =>
            {
                entity.HasKey(e => new { e.Idprovider, e.Idproduct });

                entity.ToTable("ProductXProvider");

                entity.Property(e => e.Idprovider).HasColumnName("IDProvider");

                entity.Property(e => e.Idproduct).HasColumnName("IDProduct");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.HasOne(d => d.IdproductNavigation)
                    .WithMany(p => p.ProductXprovider)
                    .HasForeignKey(d => d.Idproduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductXProvider_Product");

                entity.HasOne(d => d.IdproviderNavigation)
                    .WithMany(p => p.ProductXprovider)
                    .HasForeignKey(d => d.Idprovider)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductXProvider_Providers");
            });

            modelBuilder.Entity<Providers>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("NIT");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Providers)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Providers_City");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Idrol).HasColumnName("IDRol");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsFixedLength();

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.HasOne(d => d.IdrolNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Idrol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Rol");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

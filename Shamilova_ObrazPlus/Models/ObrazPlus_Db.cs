using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Shamilova_ObrazPlus.Models
{
    public partial class ObrazPlus_Db : DbContext
    {
        public ObrazPlus_Db()
            : base("name=ObrazPlus_Db")
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientDirector> ClientDirector { get; set; }
        public virtual DbSet<ClientType> ClientType { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EntranceType> EntranceType { get; set; }
        public virtual DbSet<JobTitle> JobTitle { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MaterialProduct> MaterialProduct { get; set; }
        public virtual DbSet<MaterialType> MaterialType { get; set; }
        public virtual DbSet<PostalCode> PostalCode { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Street> Street { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasMany(e => e.Client)
                .WithRequired(e => e.Address)
                .HasForeignKey(e => e.AddressId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Street)
                .WithRequired(e => e.City)
                .HasForeignKey(e => e.CityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClientDirector>()
                .HasMany(e => e.Client)
                .WithOptional(e => e.ClientDirector)
                .HasForeignKey(e => e.DirectorId);

            modelBuilder.Entity<ClientType>()
                .HasMany(e => e.Client)
                .WithRequired(e => e.ClientType)
                .HasForeignKey(e => e.ClientTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EntranceType>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.EntranceType)
                .HasForeignKey(e => e.EntranceTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobTitle>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.JobTitle)
                .HasForeignKey(e => e.JobTitleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Material>()
                .HasMany(e => e.MaterialProduct)
                .WithRequired(e => e.Material)
                .HasForeignKey(e => e.MateriaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaterialType>()
                .HasMany(e => e.Material)
                .WithRequired(e => e.MaterialType)
                .HasForeignKey(e => e.MaterialTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PostalCode>()
                .HasMany(e => e.Address)
                .WithRequired(e => e.PostalCode)
                .HasForeignKey(e => e.PostalCodeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.MaterialProduct)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductType>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.ProductType)
                .HasForeignKey(e => e.ProductTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Region>()
                .HasMany(e => e.City)
                .WithRequired(e => e.Region)
                .HasForeignKey(e => e.RegionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Street>()
                .HasMany(e => e.Address)
                .WithRequired(e => e.Street)
                .HasForeignKey(e => e.StreetId)
                .WillCascadeOnDelete(false);
        }
    }
}

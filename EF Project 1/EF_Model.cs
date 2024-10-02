using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EF_Project_1
{
    public partial class EF_Model : DbContext
    {
        public EF_Model()
            : base("name=EF_Model")
        {
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Items_Receipt> Items_Receipt { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasMany(e => e.Items_Receipt)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.Item_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Items_Receipt)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.Person_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receipt>()
                .HasMany(e => e.Items_Receipt)
                .WithRequired(e => e.Receipt)
                .HasForeignKey(e => e.Receipt_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Receipts)
                .WithRequired(e => e.Warehouse)
                .HasForeignKey(e => e.Wearhouse_ID)
                .WillCascadeOnDelete(false);
        }
    }
}

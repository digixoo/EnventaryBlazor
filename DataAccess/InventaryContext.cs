using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InputOutputs { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WareHouseEntity> WhereHouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Server=LAPTOP-TD9UQMQP\SQLEXPRESS;Database=DbInventary;Trusted_Connection=True;");
            }
        }
    }
}

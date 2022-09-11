using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Repository_Ajax.Models
{
    public class DbInv:DbContext
    {
        public DbInv(DbContextOptions<DbInv> options ) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                        .HasData(
                        new Product
                        {
                             Id = 1,
                             ProductCode="P001",
                             ProductName="Water Bottle",
                             UnitPrice=500
                        },
                         new Product
                         {
                             Id = 2,
                             ProductCode = "P002",
                             ProductName = "Hot Water Pot",
                             UnitPrice = 1000
                         },
                          new Product
                          {
                              Id = 3,
                              ProductCode = "P003",
                              ProductName = "Mum Pot",
                              UnitPrice = 500
                          }
                        );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<SalesMaster> SalesMasters { get; set; }
        public DbSet<SalesDetail> SalesDetails { get; set; }
    }

    public class SalesDetail
    {
        public int Id { get; set; }
        [ForeignKey("SalesMaster")]
        public int SalesMasterID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
       
        public decimal TotalPrice { get; set; }
        public decimal Qty { get; set; }
        public SalesMaster SalesMaster { get; set; }
        public Product Product { get; set; }
    }

    public class SalesMaster
    {
        public int Id { get; set; }
        public string InvoiceNO { get; set; }
        //public int ProductID { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalQty { get; set; }

        public ICollection<SalesDetail> SalesDetails { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string  ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public ICollection<SalesDetail> SalesDetails { get; set; }
    }
}

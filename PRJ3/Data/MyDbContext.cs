using Microsoft.EntityFrameworkCore;
using PRJ3.Models.Entities;

namespace PRJ3.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }
        DbSet<Users> Users { get; set; }
        DbSet<PaymentMethods> paymentMethods { get; set; }
        DbSet<Orders> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<Images> Images { get; set; }
    }
}

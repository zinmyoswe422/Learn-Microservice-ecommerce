using Microsoft.EntityFrameworkCore;
using Orange.Services.CouponAPI.Models;

namespace Orange.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Coupon> Coupons { get; set; }
    }
}

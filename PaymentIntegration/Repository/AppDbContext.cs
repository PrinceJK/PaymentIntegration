using Microsoft.EntityFrameworkCore;
using PaymentIntegration.Models;

namespace PaymentIntegration.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<TransactionsModel> Transactions { get; set; }
    }
}

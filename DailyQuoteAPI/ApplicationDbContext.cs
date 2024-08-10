using DailyQuoteAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace DailyQuoteAPI

{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<QuoteModel> Quotes { get; set; }
    }
}

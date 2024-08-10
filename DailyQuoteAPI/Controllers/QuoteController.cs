using DailyQuoteAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DailyQuoteAPI.Controllers
{
    [ApiController]
    [Route("api/quotes")]
    public class QuoteController:ControllerBase {
        private readonly ApplicationDbContext _context;

        public QuoteController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("quote")]
        public async Task<ActionResult<QuoteModel>> GetRandomQuote()
        {
            var quotes = await _context.Quotes.ToListAsync();
            var randomQuote = quotes.OrderBy(q => System.Guid.NewGuid()).FirstOrDefault();
            return Ok(randomQuote);
        }
    }
}

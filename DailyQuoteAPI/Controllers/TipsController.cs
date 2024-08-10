using DailyQuoteAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DailyQuoteAPI.Controllers
{
    [ApiController]
    [Route("api/tips")]
    public class TipsController:ControllerBase
    {
        private static readonly List<TipsModel> tips = new List<TipsModel> {
            new TipsModel{ID=1,Text="šukej děvky",Author="Josef Botka"}
        };
        [HttpGet("tip")]
        public ActionResult<TipsModel> GetRandomQuote()
        {
            var randomQuote = tips.OrderBy(q => System.Guid.NewGuid()).FirstOrDefault();
            return Ok(randomQuote);
        } 
    }
}

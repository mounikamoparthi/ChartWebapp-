using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Chartwebapp.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<StockPrice> GetQuote()
        {
            var rng = new Random();
            return Enumerable.Range(1, 24*60).Select(index => new StockPrice
            {
                DateFormatted = DateTime.Now.AddMinutes(-index).ToString("yyyy-MM-dd HH:mm"),
                Price = rng.Next(0, 55),
               
            });
        }
        public StockPrice GetLastQuote()
        {
            var rng = new Random();
            return new StockPrice
            {
                DateFormatted = DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
                Price = rng.Next(0, 55),

            };
        }

        public class StockPrice
        {
            public string DateFormatted { get; set; }
            public int Price { get; set; }
           
 
          
        }
    }
}

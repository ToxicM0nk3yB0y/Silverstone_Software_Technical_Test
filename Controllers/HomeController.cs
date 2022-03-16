using Newtonsoft.Json;
using Silverstone_Software_Technical_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Silverstone_Software_Technical_Test.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult SearchWeather()
        {
            var x = new AllDTO();
            return View(x);
        }


        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> SearchWeather(string WeatherSearchBar)
        {
            var returnmodle = new AllDTO();


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.weatherapi.com/v1/");
                var key = "61c5a003c4bc41ec96e200534221503";
                var json = "forecast.json?";
                HttpResponseMessage responseTask = await client.GetAsync($"{json}key={key}&q={WeatherSearchBar}&days=1&aqi=yes&alerts=no");

                if (responseTask.IsSuccessStatusCode)
                {
                    
                    returnmodle.WeatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(await responseTask.Content.ReadAsStringAsync());

                }
                else
                {
                    returnmodle.FullErrorDTO = JsonConvert.DeserializeObject<FullErrorDTO>(await responseTask.Content.ReadAsStringAsync());

                    
                }

            }
            return View(returnmodle);
            
        }



            public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}
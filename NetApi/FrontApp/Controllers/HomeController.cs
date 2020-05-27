using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FrontApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace SkyAgencyFront.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {

            List<Flight> flightsInfo = new List<Flight>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri("https://localhost:44351");

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllFlights using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Flight");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var flightRes = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Flight list  
                    flightsInfo = JsonConvert.DeserializeObject<List<Flight>>(flightRes);

                }
                //returning the Flight list to view  
                return View(flightsInfo);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Diagnostics;

namespace FrontApp.Controllers
{
    public class RegisterController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

        private readonly ILogger<RegisterController> _logger;

        public RegisterController(ILogger<RegisterController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> RegisterPage(String firstname, String lastname, int age, String password, String email, String gender, String phoneNumber, String status)
        {

            User userInfo = new User();

            User usr = new User();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri("https://localhost:44351");

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                usr.firstname = firstname;
                usr.lastname = lastname;
                usr.age = age;
                usr.password = password;
                usr.email = email;
                usr.gender = gender;
                usr.phoneNumber = phoneNumber;
                usr.status = status;

                var myContent = JsonConvert.SerializeObject(usr);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                //Sending request to find web api REST service resource create User using HttpClient  
                var Res = await client.PostAsync("api/User", byteContent);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                  //  var userRes = Res.Result.Content.ReadAsByteArrayAsync.

                    //Deserializing the response recieved from web api and storing into the Flight list  
                 //   userInfo = JsonConvert.DeserializeObject<User>(userRes);

                }
                //returning the user info view  
                return View();
            }
        }

        public ActionResult RegisterPage()
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
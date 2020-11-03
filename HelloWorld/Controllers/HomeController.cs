using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Common;
using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloWorld.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;


namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private readonly IHttpClientFactory _httpClientFactory;
       
       


        public HomeController(ILogger<HomeController> logger,  IHttpClientFactory httpClientFactory)
        {
           
            _logger = logger;
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));

        }

        public async Task<IActionResult> Index()
        {
            
            IMyMessage msg = new MyMessage();

            using (var httpClient = _httpClientFactory.CreateClient("Greetings"))
            {
                using (var response = await httpClient.GetAsync("Message"))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        msg = JsonConvert.DeserializeObject<MyMessage>(apiResponse);
                    }
            }


            return View((MyMessage)msg);
        }

        public  async Task<IActionResult> Privacy()
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

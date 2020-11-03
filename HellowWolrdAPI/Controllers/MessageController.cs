using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Common.Models;
using HellowWolrdAPI.IRepository;
using HellowWolrdAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HellowWolrdAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
    

        // could add logging and such.
        public MessageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        /// <summary>
        /// Returns "Hellow World" 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string SayHelloWorld()
        {
            return JsonSerializer.Serialize(new  MyMessage() {Greeting = _unitOfWork.Msgs.SayHelloWorld()});
        }



    }
}

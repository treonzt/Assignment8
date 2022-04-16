using Assignment8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrintNameController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PrintNameController> _logger;

        public PrintNameController(ILogger<PrintNameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
           var personName = new PrintName{PersonName = "Zachary Treon" };
            return Ok(personName);
        }
    }
}

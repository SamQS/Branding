using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace branding.Controllers 
{
    public class QuienesController : Controller
    {
     private readonly ILogger<HomeController> _logger;

        public QuienesController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }       
        public IActionResult Somos()
        {
            return View();
        }

        }
    }
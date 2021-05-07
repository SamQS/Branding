using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace branding.Controllers 
{
    public class PrecioController : Controller
    {
     private readonly ILogger<HomeController> _logger;

        public PrecioController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }       
         public IActionResult Precios()
         {
            return View();
        }

        }
    }
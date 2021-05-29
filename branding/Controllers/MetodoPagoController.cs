
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace branding.Controllers
{
    public class MetodoPagoController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public MetodoPagoController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }       
         public IActionResult metodopago()
         {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using branding.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using branding.Models;

namespace branding.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public ConsultaController(ILogger<HomeController> logger,  ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }       
         public IActionResult consultas()
         {
            return View();
        }
        [HttpPost]
        public IActionResult consultas(Consulta c)
        {
            if(ModelState.IsValid){
                _context.Add(c);
                _context.SaveChanges();
                return RedirectToAction("confirmacion");
            }
            return View(c);
        } 
        public IActionResult confirmacion()
        {
            return View();
        }

        public IActionResult ListarConsultas(){
            var conssultas = _context.Consultas.ToList();
            return View(conssultas);

        }

        }
    }


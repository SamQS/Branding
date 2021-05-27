using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using branding.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using branding.Models;

namespace branding.Controllers 
{
    public class PrecioController : Controller
    {
     private readonly ILogger<HomeController> _logger;
     private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

        public PrecioController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }       
         public IActionResult Precios()
         {
            return View();
        }
        public IActionResult PreciosCliente()
         {
            return View();
        }
        public async Task<IActionResult> Precio()
         {
            var productos = from o in _context.Producto select o;
            productos = productos.Where(s => s.Status.Equals("A"));
            return View(await productos.ToListAsync());
        }

         public async Task<IActionResult> Add(int? id)
        {
            var userID = _userManager.GetUserName(User);
            if(userID == null){
                ViewData["Message"] = "Por favor debe loguearse antes de agregar un producto";
                List<Producto> productos = new List<Producto>();
                return  View("Precio",productos);
            }else{

                var producto = await _context.Producto.FindAsync(id);
                Proforma proforma = new Proforma();
                proforma.UserID = userID;       
                proforma.Price = producto.Price;
                proforma.Producto = producto;                 
                _context.Add(proforma);
                await _context.SaveChangesAsync();
                return  RedirectToAction(nameof(Precio));
             }
        }        
        }
    }
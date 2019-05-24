using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobStore.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MobStore.Controllers
{
    public class PhoneController : Controller
    {
        ApplicationDbContext _context;
        public PhoneController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult List()
        {
            ViewData["Title"] = "Show all phones";
            var phone = _context.Phones;
            return View(phone);
        }
    }
}

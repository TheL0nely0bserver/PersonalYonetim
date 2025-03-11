using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalYonetim.Data;

namespace PersonalYonetim.Controllers
{
   // [Route("[controller]")]
    public class OgrenciController : Controller
    {
        private readonly ILogger<OgrenciController> _logger;
        private readonly SanalVeriTabani2 context2;

        public OgrenciController(ILogger<OgrenciController> logger, SanalVeriTabani2 context2)
        {
            _logger = logger;
            this.context2 = context2;
        }

        public IActionResult Index()
        {
            return View(context2.Students);
        }
       public IActionResult Ekle(Ogrenci p1)
        {
            context2.Students.Add(p1);
            return RedirectToAction("Index");
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
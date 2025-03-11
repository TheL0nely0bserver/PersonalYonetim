using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalYonetim.Data;
using PersonalYonetim.Models;

namespace PersonalYonetim.Controllers
{
    //[Route("[controller]")]
    public class PersonalYonetimiController : Controller
    {
        private readonly ILogger<PersonalYonetimiController> _logger;
        private readonly Sanalveritabani context;

        public PersonalYonetimiController(ILogger<PersonalYonetimiController> logger, Sanalveritabani context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.personals);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Personal p1)
        {
            context.personals.Add(p1);
            return RedirectToAction("Index");
        }

        public IActionResult Detay(int id)
        {
            var kisi =context.personals.SingleOrDefault(x => x.PersonalNo==id);
            return View(kisi);
        }
        [HttpGet]
        public IActionResult Duzenle(int id)
        {
            var Duzenle =context.personals.SingleOrDefault(x => x.PersonalNo==id);
            return View(Duzenle);
        }
        [HttpPost]
        public IActionResult Duzenle(Personal y)
        {
           
            var Bul =context.personals.SingleOrDefault(x => x.PersonalNo==y.PersonalNo);
            Bul.Ad = y.Ad;
            Bul.Soyad = y.Soyad;
            Bul.Adres = y.Adres;
            Bul.Maas = y.Maas;
           

            return RedirectToAction("Index");
        }


        public IActionResult Remove(int id)
        {
            var Silinecek =context.personals.SingleOrDefault(x => x.PersonalNo==id);
            context.personals.Remove(Silinecek);
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
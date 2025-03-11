using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonalYonetim.Models;

namespace PersonalYonetim.Data
{
    public class Sanalveritabani
    {
        public List<Personal> personals = new(){
            new Personal { PersonalNo = 1, Ad ="abdi", Soyad="Şenol", Adres="İZMİR", Maas=5000, Resim="ahmet.jpg"},
            new Personal { PersonalNo = 2, Ad ="mehmet", Soyad="cici", Adres="İZMİR", Maas=5000, Resim="mehmet.jpg"},
            new Personal { PersonalNo = 3, Ad ="hasan", Soyad="kahraman", Adres="İZMİR", Maas=5000, Resim="hasan.jpg"}
        };
    }
}
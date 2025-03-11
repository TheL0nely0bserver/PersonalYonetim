using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalYonetim.Models
{
    public class Personal
    {
        public int PersonalNo { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Adres { get; set; }
        public decimal Maas { get; set; }
        public string? Resim { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class IletisimForm
    {
        public int ID { get; set; }
        public String Ad { get; set; }
        public String Soyad { get; set; }
        public String Mesaj { get; set; }
        public DateTime Tarih { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class Adres
    {
        public int ID { get; set; }
        public int MusteriID { get; set; }
        public int UlkeID { get; set; }
        public int SehirID { get; set; }
        public int IlceID { get; set; }
        public String Adress { get; set; }
    }
}
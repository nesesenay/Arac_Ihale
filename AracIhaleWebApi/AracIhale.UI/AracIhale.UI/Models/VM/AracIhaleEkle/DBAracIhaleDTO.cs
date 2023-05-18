using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;

namespace AracIhale.UI.Models.VM.AracIhaleEkle
{
    public class DBAracIhaleDTO
    {
        public string IhaleAdi { get; set; }
        public DateTime IhaleBaslangicTarihi { get; set; }
        public DateTime IhaleBitisTarihi { get; set; }
        public string IhaleBaslangicSaati { get; set; }
        public string IhaleBitisSaati { get; set; }
        public DateTime KaydetmeTarihi { get; set; }
        public int RolID { get; set; }
        public int SirketID { get; set; }
        public int IhaleStatuID { get; set; }


        public List<SelectListItem> Roller { get; set; }
        public List<SelectListItem> Sirketler { get; set; }
        public List<SelectListItem> IhaleStatuleri { get; set; }
    }
}

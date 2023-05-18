using System.ComponentModel.DataAnnotations;
using System;
using AracIhale.Apis.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AracIhale.Apis.Models.DTO.Ihale
{
    public class AracIhaleDTO
    {
        public int AracIhaleID { get; set; }
        public string IhaleAdi { get; set; }
        public DateTime IhaleBaslangicTarihi { get; set; }
        public DateTime IhaleBitisTarihi { get; set; }
        public string IhaleBaslangicSaati { get; set; }
        public string IhaleBitisSaati { get; set; }
        public DateTime KaydetmeTarihi { get; set; } 
        public int RolID { get; set; }
        public int SirketID { get; set; }
        public int KullaniciID { get; set; }
        public int IhaleStatuID { get; set; }

    }
}

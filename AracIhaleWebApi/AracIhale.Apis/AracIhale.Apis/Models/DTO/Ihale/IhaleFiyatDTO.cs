﻿using AracIhale.Apis.Models.Entities;

namespace AracIhale.Apis.Models.DTO.Ihale
{
    public class IhaleFiyatDTO
    {
        public int KurumsalIhaleFiyatID { get; set; }
        public decimal Fiyat { get; set; }
        public decimal BelirlenenMaksimumFiyat { get; set; }
        public decimal ArttırılacakFiyat { get; set; }
        public int KullaniciID { get; set; }
        public int AracID { get; set; }
        public int ParaBirimID { get; set; }
        public bool OnaylandiMi { get; set; }
    }
}

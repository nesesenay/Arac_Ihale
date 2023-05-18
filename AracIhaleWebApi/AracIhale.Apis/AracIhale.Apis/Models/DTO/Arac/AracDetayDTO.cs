using System.ComponentModel.DataAnnotations;
using System;

namespace AracIhale.Apis.Models.DTO
{
    public class AracDetayDTO
    {
        public int AracID { get; set; }
        public string MotorGucu { get; set; }
        public string MotorHacmi { get; set; }
        public string Yıl { get; set; }
        public decimal KmBilgisi { get; set; }
        public string Aciklama { get; set; }
        public int AracFotoID { get; set; }
        public string OpsiyonelDonanim { get; set; }
        public string Versiyon { get; set; }
        public string Renk { get; set; }
        public string VitesTip { get; set; }
        public string YakitTip { get; set; }
        public string GovdeTip { get; set; }
    }
}

using System;

namespace AracIhale.Apis.Models.DTO.Arac
{
    public class AracDTO
    {
        public int AracID { get; set; }
        public int AracNo { get; set; }
        public bool GarantiliMi { get; set; }
        public string Plaka { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public string Admin { get; set; }
        public DateTime KaydedilenTarih { get; set; }
    }
}

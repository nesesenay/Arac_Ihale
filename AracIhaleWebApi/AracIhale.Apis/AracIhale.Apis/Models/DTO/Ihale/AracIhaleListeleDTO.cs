using System;

namespace AracIhale.Apis.Models.DTO.Ihale
{
    public class AracIhaleListeleDTO
    {
        public int AracIhaleID { get; set; }
        public int AracID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Rol { get; set; }
        public string Statu { get; set; }
        public string KaydedenKul { get; set; }
        public DateTime KaydedilenZaman { get; set; }
        public decimal Fiyat { get; set; }
    }
}

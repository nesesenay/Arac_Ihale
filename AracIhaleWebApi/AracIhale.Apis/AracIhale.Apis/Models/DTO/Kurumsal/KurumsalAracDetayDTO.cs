using AracIhale.Apis.Models.Entities;

namespace AracIhale.Apis.Models.DTO.Kurumsal
{
    public class KurumsalAracDetayDTO
    {
        public decimal Fiyat { get; set; }
        public string ParaBirim { get; set; }
        public int AracID { get; set; }
        public string Sirket { get; set; }
        public int SirketID { get; set; }
        public string AracStatu { get; set; }
    }
}

using System;

namespace AracIhale.UI.Models.VM.AracIhaleEkle
{
    public class IhaleListeleDTO
    {
        public int AracIhaleID { get; set; }
        public string IhaleAdi { get; set; }
        public DateTime IhaleBaslangicTarihi { get; set; }
        public DateTime IhaleBitisTarihi { get; set; }
        public string IhaleBaslangicSaati { get; set; }
        public string IhaleBitisSaati { get; set; }
        public DateTime KaydetmeTarihi { get; set; }
        public string Rol { get; set; }
        public string Sirket { get; set; }
        public string Kullanici { get; set; }
        public string IhaleStatu { get; set; }
    }
}

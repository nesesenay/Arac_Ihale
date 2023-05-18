using System.ComponentModel.DataAnnotations;

namespace AracIhale.Apis.Models.Entities
{
    public class IhaleFiyat : IEntity
    {
        [Key]
        public int KurumsalIhaleFiyatID { get; set; }
        public decimal Fiyat { get; set; }
        public decimal BelirlenenMaksimumFiyat { get; set; }
        public decimal ArttırılacakFiyat { get; set; }
        public bool OnaylandiMi { get; set; }

        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        public int AracID { get; set; }
        public Arac Arac { get; set; }
        public int ParaBirimID { get; set; }
        public ParaBirim ParaBirim { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.Apis.Models.Entities
{
    public class KurumsalKullaniciAracDetay : IEntity
    {
        [Key, ForeignKey("Arac")]
        public int AracID { get; set; }
        public decimal Fiyat { get; set; }

        public int SirketID { get; set; }
        public Sirket Sirket { get; set; }
        public int ParaBirimID { get; set; }
        public ParaBirim ParaBirim { get; set; }
        public int AracStatuID { get; set; } 
        public AracStatu AracStatu { get; set; }


        public Arac Arac { get; set; }
    }
}

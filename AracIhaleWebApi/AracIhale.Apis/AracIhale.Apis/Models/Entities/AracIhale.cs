using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AracIhale.Apis.Models.Entities
{
    public class AracIhale : IEntity
    {
        [Key]
        public int AracIhaleID { get; set; }
        [StringLength(50)]
        public string IhaleAdi { get; set; }
        [StringLength(10)]
        public DateTime IhaleBaslangicTarihi { get; set; } 
        public DateTime IhaleBitisTarihi { get; set; }
        [StringLength(5)]
        public string IhaleBaslangicSaati { get; set; }
        [StringLength(5)]
        public string IhaleBitisSaati { get; set; }
        public DateTime KaydetmeTarihi { get; set; }


        public int RolID { get; set; }
        [ForeignKey("RolID")]
        public Rol Rol { get; set; }
        public int SirketID { get; set; }
        [ForeignKey("SirketID")]
        public Sirket Sirket { get; set; }
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        public int IhaleStatuID { get; set; }
        public IhaleStatu IhaleStatu { get; set; }


        public List<IhaleyeAracEkleme> IhaleyeAracEkleme { get; set; }
        public List<AracIhaleSahip> AracIhaleSahipleri { get; set; }

    }
}

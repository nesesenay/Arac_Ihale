using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.Apis.Models.Entities
{
    public class AracStatu : IEntity
    {
        [Key]
        public int AracStatuID { get; set; }
        [Required]
        [StringLength(50)]
        public string AracStatusu { get; set; }

        public List<KurumsalKullaniciAracDetay> KurumsalKullaniciAracDetaylari { get; set; }
    }
}

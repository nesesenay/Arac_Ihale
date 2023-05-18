using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.Apis.Models.Entities
{
    public class ParaBirim : IEntity
    {
        [Key]
        public int ParaBirimID { get; set; }
        [Required]
        [StringLength(10)]
        public string ParaninBirimi { get; set; }


        public List<KurumsalKullaniciAracDetay> KurumsalKullaniciAracDetaylari { get; set; }
        public List<IhaleFiyatBelirleme> IhaleFiyatBelirlemeleri { get; set; }
        public List<IhaleFiyat> IhaleFiyatlari { get; set; }
    }
}

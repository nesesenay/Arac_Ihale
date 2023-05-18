using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.Apis.Models.Entities
{
    public class IhaleFiyatBelirleme : IEntity
    {
        [Key, ForeignKey("Arac")]
        public int AracID { get; set; }
        public decimal IhaleBaslangicFiyati { get; set; }
        public decimal MinimumAlimFiyati { get; set; }

        public int ParaBirimID { get; set; }
        public ParaBirim ParaBirim { get; set; }
        public Arac Arac { get; set; }
    }
}

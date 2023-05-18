using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AracIhale.Apis.Models.Entities
{
    public class IhaleyeAracEkleme : IEntity
    {
        public int AracID { get; set; }
        public int AracIhaleID { get; set; }

        [ForeignKey("AracID")]
        public Arac Arac { get; set; }

        [ForeignKey("AracIhaleID")]
        public AracIhale AracIhale { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace AracIhale.Apis.Models.Entities
{
    public class OpsiyonelDonanim : IEntity
    {
        public int OpsiyonelDonanimID { get; set; }
        public string AracOpsiyonelDonanim { get; set; }
    }
}

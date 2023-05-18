using System.ComponentModel.DataAnnotations;

namespace AracIhale.Apis.Models.Entities
{
    public class GovdeTip : IEntity
    {
        public int GovdeTipID { get; set; }
        public string AracGovdeTipi { get; set; }
    }
}

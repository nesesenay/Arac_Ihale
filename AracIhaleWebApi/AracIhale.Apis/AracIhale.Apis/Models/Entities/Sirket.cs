using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AracIhale.Apis.Models.Entities
{
    public class Sirket : IEntity
    {
        public int SirketID { get; set; }
        public string SirketAdi { get; set; }

        public List<AracIhale> AracIhaleleri { get; set; }
    }
}

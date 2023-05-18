using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AracIhale.UI.Models.VM.AracIhaleEkle
{
    public class DBIhaleFiyatBelirlemeDTO
    {
        public int AracID { get; set; }
        public decimal IhaleBaslangicFiyati { get; set; }
        public decimal MinimumAlimFiyati { get; set; }
        public int ParaBirimID { get; set; }

        public List<SelectListItem> Araclar { get; set; }
    }
}

using AracIhale.UI.Models.VM.Kullanici;
using System.Collections.Generic;

namespace AracIhale.UI.Models.VM.AracIhaleEkle
{
    public class OnaylanacakIhaleFiyatDTO
    {
        public List<IhaleFiyatDTO> IhaleFiyatlari { get; set; }
        public AracIhaleDTO AracIhale { get; set; }
        public List<KullaniciDTO> Kullanici { get; set; }
    }
}

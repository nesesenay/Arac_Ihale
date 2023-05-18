using AracIhale.UI.Models.VM.Arac;
using System.Collections.Generic;

namespace AracIhale.UI.Models.VM.AracIhaleEkle
{
    public class IhaleIcerigiDTO
    {
        public AracDTO AracBilgisi { get; set; }
        public AracDetayDTO AracDetayBilgisi { get; set; }
        public KurumsalAracDetayDTO KurumsalAracDetayBilgisi { get; set; }
        public AracIhaleDTO AracIhaleBilgisi { get; set; }
        public AracFotoDTO AracFoto { get; set; }
    }
}

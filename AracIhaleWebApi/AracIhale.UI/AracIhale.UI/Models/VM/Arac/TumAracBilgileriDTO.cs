using System.Collections.Generic;

namespace AracIhale.UI.Models.VM.Arac
{
    public class TumAracBilgileriDTO
    {
        public List<AracDTO> Araclar { get; set; }
        public List<AracDetayDTO> AracDetaylari { get; set; }
        public List<KurumsalAracDetayDTO> KurumsalAracDetaylari { get; set; }
        public List<AracFotoDTO> AracFotolari { get; set; }
    }
}

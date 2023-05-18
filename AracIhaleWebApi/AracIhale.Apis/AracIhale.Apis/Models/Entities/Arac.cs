using System;
using System.Collections.Generic;

namespace AracIhale.Apis.Models.Entities
{
    public class Arac : IEntity
    {
        public int AracID { get; set; }
        public int AracNo { get; set; }
        public bool GarantiliMi { get; set; }
        public DateTime KaydedilenTarih { get; set; }


        public int PlakaID { get; set; }
        public Plaka Plaka { get; set; }
        public int ModelID { get; set; }
        public Model Model { get; set; }
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }

        public KurumsalKullaniciAracDetay KurumsalKullaniciAracDetay { get; set; }
        public IhaleFiyatBelirleme IhaleFiyatBelirleme { get; set; }
        public AracDetay AracDetay { get; set; }
        public List<IhaleyeAracEkleme> IhaleyeAracEkleme { get; set; }
        public List<IhaleFiyat> KurumsalIhaleFiyatlari { get; set; }

    }
}

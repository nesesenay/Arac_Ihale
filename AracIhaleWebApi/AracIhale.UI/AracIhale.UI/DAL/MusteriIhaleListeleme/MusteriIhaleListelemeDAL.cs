using AracIhale.UI.Models.VM.Arac;
using AracIhale.UI.Models.VM.AracIhaleEkle;
using AracIhale.UI.MyProvider;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL.MusteriIhaleListeleme
{
    public class MusteriIhaleListelemeDAL 
    {
        AracApiProvider _provider;
        IhaleApiProvider _ihaleProvider;
        public MusteriIhaleListelemeDAL(AracApiProvider provider, IhaleApiProvider ihaleProvider)
        {
            _provider = provider;
            _ihaleProvider = ihaleProvider;
        }

        public async Task<TumAracBilgileriDTO> IhaledekiAracBilgileriniListele(int kullaniciID)
        {
            var apidenGelenAracListesi = await _provider.AracBilgileriniListele();
            var apidenGelenAracDetayListesi = await _provider.AracDetayBilgileriniListele();
            var apidenGelenKurumsalAracDetayListesi = await _provider.KurumsalAracDetayBilgileriniListele();
            var apidenGelenAracFotolari = await _provider.AracFotolariniGetir();
            var ihaleFiyatlari = await _ihaleProvider.IhaleFiyatlariniGetir();

            

            ihaleFiyatlari.Where(a => a.KullaniciID != kullaniciID).ToList();

            List<AracDTO> kullaniciSirketineAitOlmayanIhaleler = null;

            foreach (var item in ihaleFiyatlari)
            {
                kullaniciSirketineAitOlmayanIhaleler = apidenGelenAracListesi.Where(a => a.AracID != item.AracID).ToList();
            }


            return new TumAracBilgileriDTO()
            {
                Araclar = kullaniciSirketineAitOlmayanIhaleler,
                AracDetaylari = apidenGelenAracDetayListesi,
                KurumsalAracDetaylari = apidenGelenKurumsalAracDetayListesi,
                AracFotolari = apidenGelenAracFotolari
            };
        }

        public async Task<IhaleIcerigiDTO> IhalecerigiListeleme(int aracID)
        {
            var apidenGelenAracListesi = await _provider.AracBilgileriniListele();
            var apidenGelenAracDetayListesi = await _provider.AracDetayBilgileriniListele();
            var apidenGelenKurumsalAracDetayListesi = await _provider.KurumsalAracDetayBilgileriniListele();
            var apidenGelenAracFotolari = await _provider.AracFotolariniGetir();
            var ihaleFiyatlari = await _ihaleProvider.IhaleFiyatlariniGetir();

            var gelenAracBilgisi = apidenGelenAracListesi.FirstOrDefault(a => a.AracID == aracID);
            var gelenAracDetayBilgisi = apidenGelenAracDetayListesi.FirstOrDefault(a => a.AracID == aracID);
            var gelenKurumsalAracDetayBilgisi = apidenGelenKurumsalAracDetayListesi.FirstOrDefault(a => a.AracID == aracID);
            var gelenAracFotoBilgisi = apidenGelenAracFotolari.FirstOrDefault(a => a.AracFotoID == gelenAracDetayBilgisi.AracFotoID);

            var aracIhaleListesi = await _ihaleProvider.AracIhaleleriniGetir();
            var ihaleyeEklenenAracListesi = await _ihaleProvider.IhaleyeEklenenAraclariGetir();

            var ihaleyeEklenenArac = ihaleyeEklenenAracListesi.FirstOrDefault(a => a.AracID == aracID);

            var aracIhaleBilgisi = aracIhaleListesi.FirstOrDefault(a => a.AracIhaleID == ihaleyeEklenenArac.AracIhaleID);

            return new IhaleIcerigiDTO()
            {
                AracBilgisi = gelenAracBilgisi,
                AracDetayBilgisi = gelenAracDetayBilgisi,
                AracIhaleBilgisi = aracIhaleBilgisi,
                KurumsalAracDetayBilgisi = gelenKurumsalAracDetayBilgisi,
                AracFoto = gelenAracFotoBilgisi
            };
        }

    }
}

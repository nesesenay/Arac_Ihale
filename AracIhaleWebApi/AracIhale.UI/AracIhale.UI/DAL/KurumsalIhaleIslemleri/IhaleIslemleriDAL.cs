using AracIhale.UI.Models.VM.Arac;
using AracIhale.UI.Models.VM.AracIhaleEkle;
using AracIhale.UI.MyProvider;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL.KurumsalIhaleIslemleri
{
    public class IhaleIslemleriDAL
    {
        AracApiProvider _provider;
        IhaleApiProvider _ihaleProvider;
        KullaniciApiProvider _kullaniciProvider;
        public IhaleIslemleriDAL(AracApiProvider provider, IhaleApiProvider ihaleProvider, KullaniciApiProvider kullaniciProvider)
        {
            _provider = provider;
            _ihaleProvider = ihaleProvider;
            _kullaniciProvider = kullaniciProvider;
        }


        public async void IhaleEkle(int kullaniciID, DBAracIhaleDTO dto)
        {
            var aracIhale = new AracIhaleDTO()
            {
                KullaniciID = kullaniciID,
                IhaleAdi = dto.IhaleAdi,
                IhaleBaslangicSaati = dto.IhaleBaslangicSaati.ToString(),
                IhaleBaslangicTarihi = dto.IhaleBaslangicTarihi,
                IhaleBitisSaati = dto.IhaleBitisSaati.ToString(),
                IhaleBitisTarihi = dto.IhaleBitisTarihi,
                IhaleStatuID = dto.IhaleStatuID,
                RolID = dto.RolID,
                SirketID = dto.SirketID
            };

            var eklenenAracIhale = await _ihaleProvider.AracIhaleEkleAsync(aracIhale);
        }

        public async void IhaleyeAracEkle(DBIhaleFiyatBelirlemeDTO dto, int eklenenAracIhaleID)
        {
            var fiyatBelirlemeDTO = new IhaleFiyatBelirlemeDTO()
            {
                AracID = dto.AracID,
                IhaleBaslangicFiyati = dto.IhaleBaslangicFiyati,
                MinimumAlimFiyati = dto.MinimumAlimFiyati,
            };

            await _ihaleProvider.IhaleFiyatBelirleAsync(fiyatBelirlemeDTO);



            var aracEklemeDTO = new IhaleyeAracEklemeDTO()
            {
                AracIhaleID = eklenenAracIhaleID,
                AracID = dto.AracID
            };

            await _ihaleProvider.IhaleyeAracEKleAsync(aracEklemeDTO);
        }

        public async Task<IhaleDetayDTO> IhaleDetayiniListele(int aracIhaleID)
        {

            var ihaleyeEklenenAracListesi = await _ihaleProvider.AracIhaleleriniListele();

            var ihaleyeEklenenAraclar = ihaleyeEklenenAracListesi.Where(a => a.AracIhaleID == aracIhaleID).ToList();

            if (ihaleyeEklenenAraclar.Count == 0)
            {
                ihaleyeEklenenAraclar = new List<AracIhaleListeleDTO>();
            }

            var ihaleListesi = await _ihaleProvider.EklenenIhaleListesiniGetir();

            var secilenIhale = ihaleListesi.FirstOrDefault(a => a.AracIhaleID == aracIhaleID);

            return new IhaleDetayDTO()
            {
                AracIhaleListesi = ihaleyeEklenenAraclar,
                IhaleBilgisi = secilenIhale
            };
        }

        public async Task<OnaylanacakIhaleFiyatDTO> OnaylanacakIhaleBilgileriniLİstele(int aracID)
        {

            var aracIhaleleri = await _ihaleProvider.AracIhaleleriniGetir();
            var ihaleFiyatlari = await _ihaleProvider.IhaleFiyatlariniGetir();
            var ihaleyeEklenenAraclar = await _ihaleProvider.IhaleyeEklenenAraclariGetir();
            var kullanicilar = await _kullaniciProvider.KullanicilariListele();


            var secilenIhaleFiyatlari = ihaleFiyatlari.Where(a => a.AracID == aracID).ToList();

            var ihaleyeEklenenArac = ihaleyeEklenenAraclar.FirstOrDefault(a => a.AracID == aracID);

            var aracIhale = aracIhaleleri.FirstOrDefault(a => a.AracIhaleID == ihaleyeEklenenArac.AracIhaleID);

            return new OnaylanacakIhaleFiyatDTO()
            {
                AracIhale = aracIhale,
                IhaleFiyatlari = secilenIhaleFiyatlari,
                Kullanici = kullanicilar
            };

        }

        public async Task<OnaylananIhaleBilgiDTO> OnaylananIhaleBilgisiniGetir(IhaleFiyatDTO onaylananIhale)
        {
            

            var kullanicilar = await _kullaniciProvider.KullanicilariListele();

            var onaylananKullanici = kullanicilar.FirstOrDefault(a => a.KullaniciID == onaylananIhale.KullaniciID);

            return new OnaylananIhaleBilgiDTO()
            {
                AracID = onaylananIhale.AracID,
                Fiyat = onaylananIhale.Fiyat,
                Kullanici = onaylananKullanici.Ad + " " + onaylananKullanici.Soyad
            };


        }

        public async Task<List<AracDTO>> IhaleyeEklenecekAracBilgieriniGetir(int aracIhaleID)
        {

            var ihaleListesi = await _ihaleProvider.AracIhaleleriniGetir();

            var gelenAracIhale = ihaleListesi.FirstOrDefault(a => a.AracIhaleID == aracIhaleID);


            var apidenGelenAracListesi = await _provider.IhaledeOlmayanAracBilgileriniListele();
            var aracIhaleleri = await _ihaleProvider.AracIhaleleriniGetir();
            var apidenGelenKurumsalAracDetayListesi = await _provider.IhaledeOlmayanKurumsalAracBilgileriniListele();


            var kurumsalAracBilgileri = apidenGelenKurumsalAracDetayListesi.Where(a => a.SirketID == gelenAracIhale.SirketID).ToList();


            List<AracDTO> araclar = null;

            foreach (var detay in kurumsalAracBilgileri)
            {
                araclar = apidenGelenAracListesi.Where(a => a.AracID == detay.AracID).ToList();
            }

            return araclar;
        }
    }
}

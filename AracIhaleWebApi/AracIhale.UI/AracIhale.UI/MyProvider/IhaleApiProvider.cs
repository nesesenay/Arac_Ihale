using AracIhale.UI.Models.VM.Arac;
using AracIhale.UI.Models.VM.AracIhaleEkle;
using AracIhale.UI.Models.VM.IhaleDetay;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AracIhale.UI.MyProvider
{
    public class IhaleApiProvider
    {
        HttpClient _client;
        public IhaleApiProvider(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<SirketDTO>> SirketleriListele()
        {
            List<SirketDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("ihaleislemleri/sirket");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<SirketDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

        public async Task<List<RolDTO>> RolleriListele()
        {
            List<RolDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("ihaleislemleri/rol");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<RolDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

        public async Task<List<IhaleStatuDTO>> AracIhaleStatuleriniListele()
        {
            List<IhaleStatuDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("ihaleislemleri/statu");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<IhaleStatuDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

        public async Task<List<AracIhaleListeleDTO>> AracIhaleleriniListele()
        {
            List<AracIhaleListeleDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("ihaleislemleri/ihalelistesi");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<AracIhaleListeleDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

        public async Task<AracIhaleDTO> AracIhaleEkleAsync(AracIhaleDTO dto)
        {
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("ihaleislemleri/ihaleekle", content);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<AracIhaleDTO>(responseJson);
            }

            return null;
        }

        public async Task<StatusCodeResult> IhaleyeKatilAsync(IhaleFiyatDTO dto)
        {
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("ihaleislemleri/ihaleyekatil", content);

            if (response.IsSuccessStatusCode)
            {
                return new StatusCodeResult(201);
            }

            return new StatusCodeResult(500);
        }

        public async Task<StatusCodeResult> IhaleyeAracEkleAsync(IhaleFiyatBelirlemeDTO dto)
        {
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("ihaleislemleri/ihaleyefiyatekle", content);

            if (response.IsSuccessStatusCode)
            {
                return new StatusCodeResult(201);
            }

            return new StatusCodeResult(500);
        }

        public async Task<StatusCodeResult> IhaleFiyatBelirleAsync(IhaleFiyatBelirlemeDTO dto)
        {
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("ihaleislemleri/ihaleyefiyatekle", content);

            if (response.IsSuccessStatusCode)
            {
                return new StatusCodeResult(201);
            }

            return new StatusCodeResult(500);
        }

        public async Task<StatusCodeResult> IhaleyeAracEKleAsync(IhaleyeAracEklemeDTO dto)
        {
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("ihaleislemleri/ihaleyearacekle", content);

            if (response.IsSuccessStatusCode)
            {
                return new StatusCodeResult(201);
            }

            return new StatusCodeResult(500);
        }

        public async Task<List<AracIhaleDTO>> AracIhaleleriniGetir()
        {
            List<AracIhaleDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("ihaleislemleri/ihalelerigetir");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<AracIhaleDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

        public async Task<List<IhaleFiyatDTO>> IhaleFiyatlariniGetir()
        {
            List<IhaleFiyatDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("ihaleislemleri/ihalefiyatlarinigetir");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<IhaleFiyatDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

        public async Task<List<IhaleyeAracEklemeDTO>> IhaleyeEklenenAraclariGetir()
        {
            List<IhaleyeAracEklemeDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("ihaleislemleri/ihaleyeeklenenaraclar");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<IhaleyeAracEklemeDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

        public async Task<List<IhaleListeleDTO>> EklenenIhaleListesiniGetir()
        {
            List<IhaleListeleDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("ihaleislemleri/eklenenihalelistesi");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<IhaleListeleDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

        //todo api kısmında güncelleme actionını oluştur.İhaleye ait onaylanan kişi bilgisi mevcut ise onaylı kişinin gösterildiği bir sayfa oluştur ve oraya yönlendir. Mevcut değil ise ihale onaylama sayfasına yönlendir. Vaktin kalırsa ihaleye katılma ekranında araç detay bilgilerini göster ve tasarımları gözden geçir.

        public async Task<StatusCodeResult> IhaleyeOnayBilgisiniGuncelle(IhaleFiyatDTO dto)
        {
            _client.Timeout = Timeout.InfiniteTimeSpan;
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("ihaleislemleri/onaybilgisi", content);

            if (response.IsSuccessStatusCode)
            {
                return new StatusCodeResult(201);
            }

            return new StatusCodeResult(500);
        }
    }
}

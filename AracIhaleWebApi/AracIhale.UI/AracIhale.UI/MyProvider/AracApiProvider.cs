using AracIhale.UI.Models.VM;
using AracIhale.UI.Models.VM.Arac;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AracIhale.UI.MyProvider
{
    public class AracApiProvider
    {
        HttpClient _client;
        public AracApiProvider(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<AracDTO>> AracBilgileriniListele()
        {
            List<AracDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("aracislemleri");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<AracDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

        public async Task<List<AracDetayDTO>> AracDetayBilgileriniListele()
        {
            List<AracDetayDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("aracislemleri/aracdetay");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<AracDetayDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

        public async Task<List<KurumsalAracDetayDTO>> KurumsalAracDetayBilgileriniListele()
        {
            List<KurumsalAracDetayDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("aracislemleri/kurumsalaracdetay");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<KurumsalAracDetayDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

        public async Task<List<KurumsalAracDetayDTO>> IhaledeOlmayanKurumsalAracBilgileriniListele()
        {
            List<KurumsalAracDetayDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("aracislemleri/ihaledeolmayankurumsalaraclar");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<KurumsalAracDetayDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

        public async Task<List<AracDTO>> IhaledeOlmayanAracBilgileriniListele()
        {
            List<AracDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("aracislemleri/ihaledeolmayanaraclar");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<AracDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

        public async Task<List<AracFotoDTO>> AracFotolariniGetir()
        {
            List<AracFotoDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("aracislemleri/aracfoto");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<AracFotoDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }

    }
}

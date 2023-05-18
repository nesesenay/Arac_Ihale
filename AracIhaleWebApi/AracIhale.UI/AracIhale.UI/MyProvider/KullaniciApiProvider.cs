using AracIhale.UI.Models.VM.Kullanici;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AracIhale.UI.MyProvider
{
    public class KullaniciApiProvider
    {
        HttpClient _client;
        public KullaniciApiProvider(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<KullaniciDTO>> KullanicilariListele()
        {
            List<KullaniciDTO> listem = null;
            var donenApiDegeri = await _client.GetAsync("kullaniciislemleri");
            if (donenApiDegeri.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<KullaniciDTO>>(await donenApiDegeri.Content.ReadAsStringAsync());

            }
            return listem;
        }




    }
}

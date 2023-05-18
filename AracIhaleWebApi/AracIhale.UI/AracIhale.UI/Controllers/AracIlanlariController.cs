using AracIhale.UI.Models.VM.Arac;
using AracIhale.UI.Models.VM.AracIhaleEkle;
using AracIhale.UI.MyProvider;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using AracIhale.UI.DAL.MusteriIhaleListeleme;
using AracIhale.UI.DAL.KurumsalIhaleIslemleri;

namespace AracIhale.UI.Controllers
{

    [Authorize]
    public class AracIlanlariController : Controller
    {

        AracApiProvider _provider;
        IhaleApiProvider _ihaleProvider;
        KullaniciApiProvider _kullaniciProvider;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AracIlanlariController(AracApiProvider provider, IhaleApiProvider ihaleProvider, KullaniciApiProvider  kullaniciApiProvider,IHttpContextAccessor httpContextAccessor)
        {
            _provider = provider;
            _ihaleProvider = ihaleProvider;
            _httpContextAccessor = httpContextAccessor;
            _kullaniciProvider = kullaniciApiProvider;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {

            int kullaniciID = HttpContext.Session.GetInt32("KullaniciID") ?? 0;

            MusteriIhaleListelemeDAL dal = new MusteriIhaleListelemeDAL(_provider, _ihaleProvider);
           

            var tumAracBilgileri = await dal.IhaledekiAracBilgileriniListele(kullaniciID);

            return View(tumAracBilgileri);
        }

        [HttpGet]
        public async Task<IActionResult> IhaleIcerigi(int aracID)
        {
            MusteriIhaleListelemeDAL dal = new MusteriIhaleListelemeDAL(_provider, _ihaleProvider);

            var ihaleIcerigi = await dal.IhalecerigiListeleme(aracID);

            return View(ihaleIcerigi);
        }

        [HttpGet]
        public async Task<IActionResult> IhaleyeKatil(int aracID)
        {

            TempData["aracID"] = aracID;

            int eklenenAracIhaleID = HttpContext.Session.GetInt32("EklenenAracIhaleID") ?? 0;

            var aracIhaleleri = await _ihaleProvider.AracIhaleleriniListele();


            var ihaleFiyat = aracIhaleleri.FirstOrDefault(a => a.AracID == aracID).Fiyat;

            ViewData["Fiyat"] = ihaleFiyat;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IhaleyeKatil(IhaleFiyatDTO dto)
        {
            var session = _httpContextAccessor.HttpContext.Session;
            int kullaniciID = HttpContext.Session.GetInt32("KullaniciID") ?? 0;
            var aracID = (int)TempData["aracID"];

            
            dto.AracID = aracID;
            dto.KullaniciID = kullaniciID;

            if (kullaniciID != 0)
            {
                await _ihaleProvider.IhaleyeKatilAsync(dto);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> IhaleListele()
        {
            var ihaleListesi = await _ihaleProvider.EklenenIhaleListesiniGetir();

            return View(ihaleListesi);
        }

        [HttpGet]
        public async Task<IActionResult> IhaleEkle()
        {
            var sirketler = await _ihaleProvider.SirketleriListele();
            var roller = await _ihaleProvider.RolleriListele();
            var ihaleStatuleri = await _ihaleProvider.AracIhaleStatuleriniListele();


            var aracIhale = new DBAracIhaleDTO()
            {
                Sirketler = sirketler.Select(a => new SelectListItem()
                {
                    Text = a.SirketAdi,
                    Value = a.SirketID.ToString()
                }).ToList(),
                Roller = roller.Select(a => new SelectListItem()
                {
                    Text = a.KullaniciRol,
                    Value = a.RolID.ToString()
                }).ToList(),
                IhaleStatuleri = ihaleStatuleri.Select(a => new SelectListItem()
                {
                    Text = a.IhaleninSatusu,
                    Value = a.IhaleStatuID.ToString()
                }).ToList()
            };

            return View(aracIhale);
        }

        [HttpPost]
        public async Task<IActionResult> IhaleEkle(DBAracIhaleDTO dto)
        {
            int kullaniciID = HttpContext.Session.GetInt32("KullaniciID") ?? 0;


            if (!ModelState.IsValid)
            {
                return RedirectToAction("IhaleEkle");
            }


            IhaleIslemleriDAL dal = new IhaleIslemleriDAL(_provider, _ihaleProvider, _kullaniciProvider);

            dal.IhaleEkle(kullaniciID, dto);


            return RedirectToAction("IhaleListele");
        }


        [HttpGet]
        public async Task<IActionResult> IhaleDetay(int aracIhaleID)
        {
            int eklenenAracIhaleID = HttpContext.Session.GetInt32("EklenenAracIhaleID") ?? 0;
            if (aracIhaleID != 0)
            {
                ISession session = _httpContextAccessor.HttpContext.Session;
                session.SetInt32("ihaleID", aracIhaleID);
            }
           
            int ihaleID = HttpContext.Session.GetInt32("ihaleID") ?? 0;

            if (aracIhaleID == 0)
            {
                aracIhaleID = eklenenAracIhaleID;
            }
            
            if(eklenenAracIhaleID == 0)
            {
                aracIhaleID = ihaleID;
            }

            IhaleIslemleriDAL dal = new IhaleIslemleriDAL(_provider, _ihaleProvider, _kullaniciProvider);

            var ihaleDetayi = await dal.IhaleDetayiniListele(aracIhaleID);


            var message = (string)TempData["Message"];

            ViewBag.Message = message;

            return View(ihaleDetayi);
        }


        [HttpGet]
        public async Task<IActionResult> AracEkle(int aracIhaleID)
        {
            ISession session = _httpContextAccessor.HttpContext.Session;
            session.SetInt32("EklenenAracIhaleID", aracIhaleID);

            IhaleIslemleriDAL dal = new IhaleIslemleriDAL(_provider, _ihaleProvider, _kullaniciProvider);

            var araclar = await dal.IhaleyeEklenecekAracBilgieriniGetir(aracIhaleID);

            if (araclar == null)
            {
                TempData["Message"] = "İhaleyi açan şirkete ait araç bulunmamaktadır.";
                return RedirectToAction("IhaleDetay");
            }

            var belirlenenIhaleFiyati = new DBIhaleFiyatBelirlemeDTO()
            {
                Araclar = araclar.Select(a => new SelectListItem()
                {
                    Value = a.AracID.ToString(),
                    Text = a.AracID.ToString()
                }).ToList()
            };

            return View(belirlenenIhaleFiyati);
        }

        [HttpPost]
        public async Task<IActionResult> AracEkle(DBIhaleFiyatBelirlemeDTO dto)
        {

            int eklenenAracIhaleID = HttpContext.Session.GetInt32("EklenenAracIhaleID") ?? 0;

            if (eklenenAracIhaleID != 0)
            {

                IhaleIslemleriDAL dal = new IhaleIslemleriDAL(_provider, _ihaleProvider, _kullaniciProvider);
                dal.IhaleyeAracEkle(dto, eklenenAracIhaleID);

            }

            return RedirectToAction("IhaleDetay");
        }

        [HttpGet]
        public async Task<IActionResult> IhaleBilgisi(int aracID)
        {
            var ihaleFiyatlari = await _ihaleProvider.IhaleFiyatlariniGetir();
            IhaleIslemleriDAL dal = new IhaleIslemleriDAL(_provider, _ihaleProvider, _kullaniciProvider);

            var secilenIhaleFiyatlari = ihaleFiyatlari.Where(a => a.AracID == aracID).ToList();

            var onaylanacakIhaleFiyat = await dal.OnaylanacakIhaleBilgileriniLİstele(aracID);


            IhaleFiyatDTO onaylananIhale = secilenIhaleFiyatlari.FirstOrDefault(a => a.OnaylandiMi == true);

            if (onaylananIhale != null)
            {
                var serializedIhale = JsonSerializer.Serialize(onaylananIhale);

                HttpContext.Session.SetString("onaylananIhale", serializedIhale);

                return RedirectToAction("OnaylananIhale");
            }

            return View(onaylanacakIhaleFiyat);
        }

        [HttpPost]
        public async Task<IActionResult> IhaleBilgisi([Bind("IhaleFiyatlari")] OnaylanacakIhaleFiyatDTO dto)
        {

            foreach (var item in dto.IhaleFiyatlari)
            {
                if (item.OnaylandiMi == true)
                {
                    await _ihaleProvider.IhaleyeOnayBilgisiniGuncelle(item);
                }
            }

            return RedirectToAction("IhaleEkle");
        }

        [HttpGet]
        public async Task<IActionResult> OnaylananIhale()
        {

            var serializedIhale = HttpContext.Session.GetString("onaylananIhale");

            var onaylananIhale = JsonSerializer.Deserialize<IhaleFiyatDTO>(serializedIhale);

            IhaleIslemleriDAL dal = new IhaleIslemleriDAL(_provider, _ihaleProvider, _kullaniciProvider);

            var onaylananIhaleBilgisi = await dal.OnaylananIhaleBilgisiniGetir(onaylananIhale);


            return View(onaylananIhaleBilgisi);
        }
    }
}

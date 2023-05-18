using AracIhale.UI.Models.VM;
using AracIhale.UI.Models.VM.Kullanici;
using AracIhale.UI.MyProvider;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AracIhale.UI.Controllers
{
    [AllowAnonymous]
    public class KullaniciController : Controller
    {
        KullaniciApiProvider _provider;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public KullaniciController(KullaniciApiProvider provider, IHttpContextAccessor httpContextAccessor)
        {
            _provider = provider;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        
        {
            var apidenGelenSonuc = await _provider.KullanicilariListele();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(KullaniciDTO dto)
        {
            var apidenGelenSonuc = await _provider.KullanicilariListele();


            var kullanici = apidenGelenSonuc.FirstOrDefault(a => a.Email == dto.Email && a.Sifre == dto.Sifre);
            if (kullanici != null)
            {
                int rolID = kullanici.RolID;

              

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, kullanici.Ad),
                    new Claim(ClaimTypes.Role, kullanici.RolID.ToString()),
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    ExpiresUtc = DateTime.Now.AddMinutes(10),
                };
                await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

                ISession session = _httpContextAccessor.HttpContext.Session;
                session.SetInt32("KullaniciID", kullanici.KullaniciID);


                if (rolID == 3)
                {
                    return RedirectToAction("IhaleListele", "AracIlanlari");
                }
                else if (rolID == 1 || rolID == 2)
                {
                    return RedirectToAction("Index", "AracIlanlari");
                }
            }

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(); // kimlik doğrulama oturumu sonlandırılır

            return RedirectToAction("Index");
        }



    }
}

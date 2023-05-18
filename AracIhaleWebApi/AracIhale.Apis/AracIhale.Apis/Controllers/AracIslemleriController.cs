using AracIhale.Apis.Models;
using AracIhale.Apis.Models.DAL.Interfaces;
using AracIhale.Apis.Models.DTO.Arac;
using AracIhale.Apis.Models.DTO.Kurumsal;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace AracIhale.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class AracIslemleriController : ControllerBase
    {
        private readonly IAracDAL _dal;
        public AracIslemleriController(IAracDAL dal)
        {
            _dal = dal;
        }

        [HttpGet("")]
        public async Task<IActionResult> AraclariGetir()
        
        {
            try
            {
                var aracBilgileri = await _dal.GetAracDTOListAsync();
                return Ok(aracBilgileri);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
            
        }

        [HttpGet("AracDetay")]
        public async Task<IActionResult> AraclarDetaylariGetir()
        {
            try
            {
                var aracDetayBilgileri = await _dal.GetAracDetayDTOListAsync();
                return Ok(aracDetayBilgileri);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("KurumsalAracDetay")]
        public async Task<IActionResult> KurumsalAracDetaylariGetir()
        {
            try
            {
                var kurumsalAracDetayBilgileri = await _dal.GetKurumsalAracDetayDTOListAsync();
                return Ok(kurumsalAracDetayBilgileri);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("aracfoto")]
        public async Task<IActionResult> AracFotolariniGetir()
        
        {
            try
            {
                var aracFotolari = await _dal.GetAracFotoListAsync();
                return Ok(aracFotolari);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("IhaledeOlmayanKurumsalAraclar")]
        public async Task<IActionResult> IhaledeOlmayanKurumsalAracBilgileri()

        {
            try
            {
                var kurumsalAracDetaylari = await _dal.GetIhaledeOlmayanKurumsalAracListAsync();
                return Ok(kurumsalAracDetaylari);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("IhaledeOlmayanAraclar")]
        public async Task<IActionResult> IhaledeOlmayanAracBilgileri()

        {
            try
            {
                var kurumsalAracDetaylari = await _dal.GetIhaledeOlmayanAracDTOListAsync();
                return Ok(kurumsalAracDetaylari);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }


    }
}

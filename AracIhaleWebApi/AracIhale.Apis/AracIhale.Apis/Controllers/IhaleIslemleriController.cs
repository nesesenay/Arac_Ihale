using AracIhale.Apis.Models;
using AracIhale.Apis.Models.DAL.Interfaces;
using AracIhale.Apis.Models.DTO.Arac;
using AracIhale.Apis.Models.DTO.Ihale;
using AracIhale.Apis.Models.DTO.Kurumsal;
using AracIhale.Apis.Models.DTO.RolBilgisi;
using AracIhale.Apis.Models.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AracIhale.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IhaleIslemleriController : ControllerBase
    {

        private readonly ISirketDAL _dal;
        private readonly IRolDAL _rolDal;
        private readonly IIhaleStatuDAL _statuDal;
        private readonly IIhaleDAL _ihaleDal;
        private readonly IAracIhaleDAL _aracIhaleDal;
        private readonly IIhaleFiyatBelirlemeDAL _ihaleFiyatBelirlemeDAL;
        private readonly IIhaleyeAracEkleDAL _ihaleyeAracEkleDAL;
        private readonly IIhaleFiyatDAL _ihaleFiyatDAL;
        private readonly IMapper _mapper;
        public IhaleIslemleriController(ISirketDAL dal, IMapper mapper, IRolDAL rolDal, IIhaleStatuDAL statuDal, IIhaleDAL ihaleDAL, IAracIhaleDAL aracIhaleDal, IIhaleFiyatBelirlemeDAL ihaleFiyatBelirlemeDAL, IIhaleyeAracEkleDAL ihaleyeAracEkleDAL, IIhaleFiyatDAL ihaleFiyatDAL)
        {
            _dal = dal;
            _mapper = mapper;
            _rolDal = rolDal;
            _statuDal = statuDal;
            _ihaleDal = ihaleDAL;
            _aracIhaleDal = aracIhaleDal;
            _ihaleFiyatBelirlemeDAL = ihaleFiyatBelirlemeDAL;
            _ihaleyeAracEkleDAL = ihaleyeAracEkleDAL;
            _ihaleFiyatDAL = ihaleFiyatDAL;
        }

        //todo bu verileri ui da çek ve oradaki dtolara dönüştür. Arac ihalenin select itemlarına ekle. 

        [HttpGet("sirket")]
        public async Task<IActionResult> GetAllAsync()
        {
            var deger = await _dal.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<SirketDTO>>(deger));
        }

        [HttpGet("rol")]
        public async Task<IActionResult> GetAllAsync01()
        {
            var deger = await _rolDal.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<RolDTO>>(deger));
        }

        [HttpGet("statu")]
        public async Task<IActionResult> GetAllAsync02()
        {
            var deger = await _statuDal.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<IhaleStatuDTO>>(deger));
        }

        [HttpGet("ihalelistesi")]
        public async Task<IActionResult> IhaleListesiniGetir()
        {
            try
            {
                var aracIhaleListesi = await _ihaleDal.GetAracIhaleListesiDTOListAsync();
                return Ok(aracIhaleListesi);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Bir hata oluştu");
            }
        }


        [HttpGet("eklenenihalelistesi")]
        public async Task<IActionResult> EklenenIhaleleriGetir()
        {
            try
            {
                var ihaleListesi = await _ihaleDal.GetIhaleListesiDTOListAsync();
                return Ok(ihaleListesi);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Bir hata oluştu");
            }
        }

        [HttpPost("ihaleekle")]
        public IActionResult AracIhaleEkle([FromBody] AracIhaleDTO eklenecekIhaleBilgisi)
        {
            try
            {
                _aracIhaleDal.Add(_mapper.Map<AracIhale.Apis.Models.Entities.AracIhale>(eklenecekIhaleBilgisi));

                var enSonEklenenIhale = _aracIhaleDal.GetAll().OrderByDescending(a => a.AracIhaleID).FirstOrDefault();


                var eklenenAracIhaleDTO = _mapper.Map<AracIhaleDTO>(enSonEklenenIhale);


                return Created("", eklenenAracIhaleDTO);
            }
            catch (Exception ex)
            {
              
                return StatusCode(500, "Bir hata oluştu."); 
            }
        }

        [HttpPost("ihaleyefiyatekle")]
        public IActionResult IhaleyeFiyatEkle([FromBody] IhaleFiyatBelirlemeDTO eklenecekIhaleFiyat)
        {
            try
            {
                _ihaleFiyatBelirlemeDAL.Add(_mapper.Map<IhaleFiyatBelirleme>(eklenecekIhaleFiyat));



                return StatusCode(201, "ekleme işlemi başarılı");
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Bir hata oluştu.");
            }
        }

        [HttpPost("ihaleyekatil")]
        public IActionResult IhaleyeKatil([FromBody] IhaleFiyatDTO ihaleyeKatilmaBilgisi)
        {
            try
            {
                _ihaleFiyatDAL.Add(_mapper.Map<IhaleFiyat>(ihaleyeKatilmaBilgisi));



                return StatusCode(201, "ekleme işlemi başarılı");
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Bir hata oluştu.");
            }
        }

        [HttpPost("ihaleyearacekle")]
        public IActionResult IhaleyeAracEkle([FromBody] IhaleyeAracEklemeDTO ihaleyeEklenecekArac)
        {
            try
            {
                _ihaleyeAracEkleDAL.Add(_mapper.Map<IhaleyeAracEkleme>(ihaleyeEklenecekArac));

                return StatusCode(201, "ekleme işlemi başarılı");
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Bir hata oluştu.");
            }
        }

        [HttpGet("ihalelerigetir")]
        public async Task<IActionResult> AracIhaleleriniGetir()
        {
            try
            {
                var aracIhaleleri = await _aracIhaleDal.GetAllAsync();
                return Ok(aracIhaleleri);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Bir hata oluştu");
            }
        }

        [HttpGet("ihalefiyatlarinigetir")]
        public async Task<IActionResult> IhaleFiyatlariniGetir()
        {
            try
            {
                var ihaleFiyatlari = await _ihaleFiyatDAL.GetAllAsync();
                return Ok(ihaleFiyatlari);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Bir hata oluştu");
            }
        }

        [HttpGet("ihaleyeeklenenaraclar")]
        public async Task<IActionResult> IhaleyeEklenenAraclariGetir()
        {
            try
            {
                var ihaleyeEklenneAraclar = await _ihaleyeAracEkleDAL.GetAllAsync();
                return Ok(ihaleyeEklenneAraclar);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Bir hata oluştu");
            }
        }

        [HttpPost("onaybilgisi")]
        public IActionResult IhaleOnayBilgisiniGuncelle([FromBody] IhaleFiyatDTO guncellenecekOnayBilgisi)
        {
            try
            {
                _ihaleFiyatDAL.Update(_mapper.Map<IhaleFiyat>(guncellenecekOnayBilgisi));

                return StatusCode(201, "güncelleme işlemi başarılı");
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Bir hata oluştu.");
            }
        }

    }
}

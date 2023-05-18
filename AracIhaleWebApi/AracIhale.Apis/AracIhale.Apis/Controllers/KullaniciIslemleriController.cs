using AracIhale.Apis.Models;
using AracIhale.Apis.Models.DAL.Interfaces;
using AracIhale.Apis.Models.DTO.Kullanici;
using AracIhale.Apis.Models.DTO.Kurumsal;
using AracIhale.Apis.Models.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AracIhale.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciIslemleriController : ControllerBase
    {
        private readonly IKullaniciDAL _dal;
        private readonly IMapper _mapper;

        public KullaniciIslemleriController(IKullaniciDAL dal, IMapper mapper, MyContext db)
        {
            _dal = dal;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var deger = await _dal.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<KullaniciDTO>>(deger));
        }

       

    }
}

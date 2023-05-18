using AracIhale.Apis.Models.DTO.Ihale;
using AracIhale.Apis.Models.DTO.Kullanici;
using AracIhale.Apis.Models.DTO.Kurumsal;
using AracIhale.Apis.Models.DTO.RolBilgisi;
using AracIhale.Apis.Models.Entities;
using AutoMapper;

namespace AracIhale.Apis.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Kullanici, KullaniciDTO>();
            CreateMap<KullaniciDTO, Kullanici>();

            CreateMap<Sirket, SirketDTO>();
            CreateMap<SirketDTO, Sirket>();

            CreateMap<Rol, RolDTO>();
            CreateMap<RolDTO, Rol>();

            CreateMap<IhaleStatu, IhaleStatuDTO>();
            CreateMap<IhaleStatuDTO, IhaleStatu>();

            CreateMap<IhaleFiyatBelirleme, IhaleFiyatBelirlemeDTO>();
            CreateMap<IhaleFiyatBelirlemeDTO, IhaleFiyatBelirleme>();

            CreateMap<IhaleyeAracEkleme, IhaleyeAracEklemeDTO>();
            CreateMap<IhaleyeAracEklemeDTO, IhaleyeAracEkleme>();

            CreateMap<IhaleFiyat, IhaleFiyatDTO>();
            CreateMap<IhaleFiyatDTO, IhaleFiyat>();

            CreateMap<AracIhale.Apis.Models.Entities.AracIhale, AracIhaleDTO>();
            CreateMap<AracIhaleDTO, AracIhale.Apis.Models.Entities.AracIhale>();
        }
    }
}

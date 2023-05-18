using AracIhale.Apis.Models.DAL.Interfaces;
using AracIhale.Apis.Models.DTO.Ihale;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AracIhale.Apis.Models.DTO.Arac;

namespace AracIhale.Apis.Models.DAL.Concrete
{
    public class EfIhaleRepoBaseDAL : IIhaleDAL
    {
        public async Task<IEnumerable<AracIhaleListeleDTO>> GetAracIhaleListesiDTOListAsync()
        {
            
                using (var context = new MyContext())
                {
                    var ihaleListesi = await (from a in context.Aracs
                                               join mo in context.Models on a.ModelID equals mo.ModelID
                                               join ma in context.Markas on mo.MarkaID equals ma.MarkaID
                                               join k in context.Kullanicis on a.KullaniciID equals k.KullaniciID
                                               join i in context.IhaleyeAracEklemes on a.AracID equals i.AracID
                                               join f in context.IhaleFiyatBelirlemes on i.AracID equals f.AracID
                                               join ai in context.AracIhales on i.AracIhaleID equals ai.AracIhaleID
                                               join r in context.Rols on ai.RolID equals r.RolID
                                               join kad in context.KurumsalKullaniciAracDetays on a.AracID equals kad.AracID
                                               where i.AracID == a.AracID 
                                               select new AracIhaleListeleDTO()
                                               {
                                                   AracIhaleID = ai.AracIhaleID,
                                                   AracID = a.AracID,
                                                   Model = mo.ModelAdi,
                                                   Marka = ma.MarkaAdi,
                                                   KaydedenKul = k.Ad + " " + k.Soyad,
                                                   Fiyat = f.IhaleBaslangicFiyati,
                                                   KaydedilenZaman = ai.KaydetmeTarihi,
                                                   Rol = r.KullaniciRol,
                                                   Statu = "Satışta"
                                               }).ToListAsync();


                    return ihaleListesi;

                }
  
        }

        public async Task<IEnumerable<IhaleListeleDTO>> GetIhaleListesiDTOListAsync()
        {

            using (var context = new MyContext())
            {
                var ihaleListesi = await (from a in context.AracIhales
                                          join k in context.Kullanicis on a.KullaniciID equals k.KullaniciID
                                          join r in context.Rols on a.RolID equals r.RolID
                                          join s in context.IhaleStatus on a.IhaleStatuID equals s.IhaleStatuID
                                          join si in context.Sirkets on a.SirketID equals si.SirketID
                                          select new IhaleListeleDTO()
                                          {
                                              AracIhaleID = a.AracIhaleID,
                                              Kullanici = k.Ad + " " + k.Soyad,
                                              Rol = r.KullaniciRol,
                                              IhaleStatu = s.IhaleninSatusu,
                                              IhaleAdi = a.IhaleAdi,
                                              IhaleBaslangicSaati = a.IhaleBaslangicSaati,
                                              IhaleBaslangicTarihi = a.IhaleBaslangicTarihi,
                                              IhaleBitisSaati = a.IhaleBaslangicSaati,
                                              IhaleBitisTarihi = a.IhaleBitisTarihi,
                                              KaydetmeTarihi = a.KaydetmeTarihi,
                                              Sirket = si.SirketAdi

                                          }).ToListAsync();


                return ihaleListesi;

            }

        }
    }
}

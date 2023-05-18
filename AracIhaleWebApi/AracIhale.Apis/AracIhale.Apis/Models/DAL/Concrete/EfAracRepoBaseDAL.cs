using AracIhale.Apis.Models.DAL.Interfaces;
using AracIhale.Apis.Models.DTO;
using AracIhale.Apis.Models.DTO.Arac;
using AracIhale.Apis.Models.DTO.Kurumsal;
using AracIhale.Apis.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhale.Apis.Models.DAL.Concrete
{
    public class EfAracRepoBaseDAL : IAracDAL
    {
        public async Task<IEnumerable<AracDetayDTO>> GetAracDetayDTOListAsync()
        {
            using (var context = new MyContext())
            {
                var aracDetayBilgileri = await (from a in context.AracDetays
                                          join r in context.Renks on a.RenkID equals r.RenkID
                                          join g in context.GovdeTips on a.GovdeTipID equals g.GovdeTipID
                                          join y in context.YakitTips on a.YakitTipID equals y.YakitTipID
                                          join o in context.OpsiyonelDonanims on a.OpsiyonelDonanimID equals o.OpsiyonelDonanimID
                                          join v in context.Versiyons on a.VersiyonID equals v.VersiyonID
                                          join vt in context.VitesTips on a.VitesTipID equals vt.VitesTipID
                                          join i in context.IhaleyeAracEklemes on a.AracID equals i.AracID
                                          where i.AracID == a.AracID
                                          select new AracDetayDTO()
                                          {
                                              AracID = a.AracID,
                                              Aciklama = a.Aciklama,
                                              KmBilgisi = a.KmBilgisi,
                                              MotorGucu = a.MotorGucu,
                                              MotorHacmi = a.MotorHacmi,
                                              Yıl = a.Yıl,
                                              Renk = r.AracRenk,
                                              GovdeTip = g.AracGovdeTipi,
                                              YakitTip = y.AracYakitTipi,
                                              OpsiyonelDonanim = o.AracOpsiyonelDonanim,
                                              Versiyon = v.AracVersiyon,
                                              VitesTip =  vt.AracVitesTipi,
                                              AracFotoID = a.AracFotoID
                                          }).ToListAsync();


                return aracDetayBilgileri;
            }
        }

        public async Task<IEnumerable<AracDTO>> GetAracDTOListAsync()
        {
            using (var context = new MyContext())
            {
                var aracBilgileri = await (from a in context.Aracs
                                        join mo in context.Models on a.ModelID equals mo.ModelID
                                        join ma in context.Markas on mo.MarkaID equals ma.MarkaID
                                        join p in context.Plakas on a.PlakaID equals p.PlakaID
                                        join ad in context.Kullanicis on a.KullaniciID equals ad.KullaniciID
                                        join i in context.IhaleyeAracEklemes on a.AracID equals i.AracID
                                        where i.AracID == a.AracID
                                           select new AracDTO()
                                        {
                                            AracID = a.AracID,
                                            AracNo = a.AracNo,
                                            GarantiliMi = a.GarantiliMi,
                                            KaydedilenTarih = a.KaydedilenTarih,
                                            Model = mo.ModelAdi,
                                            Marka = ma.MarkaAdi,
                                            Plaka = p.AracPlaka,
                                            Admin = ad.Ad + " " + ad.Soyad
                                        }).ToListAsync();


                return aracBilgileri;

            }

        }

        public async Task<IEnumerable<AracDTO>> GetIhaledeOlmayanAracDTOListAsync()
        {
            using (var context = new MyContext())
            {
                var aracBilgileri = await (from a in context.Aracs
                                           join mo in context.Models on a.ModelID equals mo.ModelID
                                           join ma in context.Markas on mo.MarkaID equals ma.MarkaID
                                           join p in context.Plakas on a.PlakaID equals p.PlakaID
                                           join ad in context.Kullanicis on a.KullaniciID equals ad.KullaniciID
                                           where !(from iae in context.IhaleyeAracEklemes
                                                   select iae.AracID).Contains(a.AracID)
                                           select new AracDTO()
                                           {
                                               AracID = a.AracID,
                                               AracNo = a.AracNo,
                                               GarantiliMi = a.GarantiliMi,
                                               KaydedilenTarih = a.KaydedilenTarih,
                                               Model = mo.ModelAdi,
                                               Marka = ma.MarkaAdi,
                                               Plaka = p.AracPlaka,
                                               Admin = ad.Ad + " " + ad.Soyad
                                           }).ToListAsync();


                return aracBilgileri;

            }

        }

        public async Task<IEnumerable<AracFotoDTO>> GetAracFotoListAsync()
        {
            using (var context = new MyContext())
            {
                var aracFotolari = await (from a in context.AracFotoes
                                          join ad in context.AracDetays on a.AracFotoID equals ad.AracFotoID
                                          join i in context.IhaleyeAracEklemes on ad.AracID equals i.AracID
                                          where i.AracID == ad.AracID && a.AracFotoID == ad.AracFotoID
                                          select new AracFotoDTO()
                                          {
                                              AracFotoID = a.AracFotoID,
                                              AracFoto1 = a.AracFoto1,
                                              AracFoto2 = a.AracFoto2,
                                              AracFoto3 = a.AracFoto3,
                                              AracFoto4 = a.AracFoto4
                                            }).ToListAsync();


                return aracFotolari;
            }
        }

        public async Task<IEnumerable<KurumsalAracDetayDTO>> GetIhaledeOlmayanKurumsalAracListAsync()
        {
            using (var context = new MyContext())
            {
                

                var kurumsalAracDetayBilgileri = await (from a in context.KurumsalKullaniciAracDetays
                                                        join p in context.ParaBirims on a.ParaBirimID equals p.ParaBirimID
                                                        join s in context.Sirkets on a.SirketID equals s.SirketID
                                                        where !(from iae in context.IhaleyeAracEklemes
                                                                select iae.AracID).Contains(a.AracID)
                                                        select new KurumsalAracDetayDTO()
                                                        {
                                                            AracID = a.AracID,
                                                            Fiyat = a.Fiyat,
                                                            ParaBirim = p.ParaninBirimi,
                                                            Sirket = s.SirketAdi,
                                                            AracStatu = "Satışta",
                                                            SirketID = s.SirketID
                                                        }).ToListAsync();


                return kurumsalAracDetayBilgileri;
            }
        }

        public async Task<IEnumerable<KurumsalAracDetayDTO>> GetKurumsalAracDetayDTOListAsync()
        {
            using (var context = new MyContext())
            {
                var kurumsalAracDetayBilgileri = await (from a in context.KurumsalKullaniciAracDetays
                                                        join p in context.ParaBirims on a.ParaBirimID equals p.ParaBirimID
                                                        join s in context.Sirkets on a.SirketID equals s.SirketID
                                                        join i in context.IhaleyeAracEklemes on a.AracID equals i.AracID
                                                        where i.AracID == a.AracID
                                                        select new KurumsalAracDetayDTO()
                                                        {
                                                            AracID = a.AracID,
                                                            Fiyat = a.Fiyat,
                                                            ParaBirim = p.ParaninBirimi,
                                                            Sirket = s.SirketAdi,
                                                            AracStatu = "Satışta",
                                                            SirketID = s.SirketID
                                                        }).ToListAsync();


                return kurumsalAracDetayBilgileri;

            }
        }

      
    }
}



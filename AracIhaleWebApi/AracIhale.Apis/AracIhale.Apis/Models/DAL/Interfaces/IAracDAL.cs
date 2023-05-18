using AracIhale.Apis.Models.DTO;
using AracIhale.Apis.Models.DTO.Arac;
using AracIhale.Apis.Models.DTO.Kurumsal;
using AracIhale.Apis.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AracIhale.Apis.Models.DAL.Interfaces
{
    public interface IAracDAL 
    {
        Task<IEnumerable<AracDTO>> GetAracDTOListAsync();
        Task<IEnumerable<AracDetayDTO>> GetAracDetayDTOListAsync();
        Task<IEnumerable<KurumsalAracDetayDTO>> GetKurumsalAracDetayDTOListAsync();
        Task<IEnumerable<KurumsalAracDetayDTO>> GetIhaledeOlmayanKurumsalAracListAsync();

        Task<IEnumerable<AracDTO>> GetIhaledeOlmayanAracDTOListAsync();
        Task<IEnumerable<AracFotoDTO>> GetAracFotoListAsync();
    }
}

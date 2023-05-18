using AracIhale.Apis.Models.DTO.Arac;
using AracIhale.Apis.Models.DTO.Ihale;
using AracIhale.Apis.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AracIhale.Apis.Models.DAL.Interfaces
{
    public interface IIhaleDAL
    {
        Task<IEnumerable<AracIhaleListeleDTO>> GetAracIhaleListesiDTOListAsync();
        Task<IEnumerable<IhaleListeleDTO>> GetIhaleListesiDTOListAsync();
    }
}

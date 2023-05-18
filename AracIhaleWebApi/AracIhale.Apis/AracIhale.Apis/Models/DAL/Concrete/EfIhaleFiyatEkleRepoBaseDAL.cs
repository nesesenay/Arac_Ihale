using AracIhale.Apis.Models.DAL.Interfaces;
using AracIhale.Apis.Models.Entities;

namespace AracIhale.Apis.Models.DAL.Concrete
{
    public class EfIhaleFiyatEkleRepoBaseDAL : EfRepoBase<IhaleFiyat, MyContext>, IIhaleFiyatDAL
    {
    
    }
}

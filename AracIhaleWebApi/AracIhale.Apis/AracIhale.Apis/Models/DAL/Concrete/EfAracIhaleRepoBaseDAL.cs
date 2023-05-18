using AracIhale.Apis.Models.DAL.Interfaces;
using AracIhale.Apis.Models.Entities;

namespace AracIhale.Apis.Models.DAL.Concrete
{
    public class EfAracIhaleRepoBaseDAL : EfRepoBase<AracIhale.Apis.Models.Entities.AracIhale, MyContext>, IAracIhaleDAL
    {
    }
}

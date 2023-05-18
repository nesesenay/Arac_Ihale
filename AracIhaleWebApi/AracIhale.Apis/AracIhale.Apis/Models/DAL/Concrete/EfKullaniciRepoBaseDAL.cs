using AracIhale.Apis.Models.Entities;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using AracIhale.Apis.Models.DAL.Interfaces;

namespace AracIhale.Apis.Models.DAL.Concrete
{
    public class EfKullaniciRepoBaseDAL :EfRepoBase<Kullanici, MyContext>, IKullaniciDAL
    {
       
    }
}

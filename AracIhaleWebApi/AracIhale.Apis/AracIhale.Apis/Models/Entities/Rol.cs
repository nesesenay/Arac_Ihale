using System.Collections.Generic;

namespace AracIhale.Apis.Models.Entities
{
    public class Rol : IEntity
    {
        public int RolID { get; set; }
        public string KullaniciRol { get; set; }


        public List<Kullanici> Kullanicilar { get; set; }
        public List<AracIhale> AracIhaleleri { get; set; }
    }
}

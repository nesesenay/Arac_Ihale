namespace AracIhale.Apis.Models.Entities
{
    public class AracIhaleSahip
    {
        public int AracIhaleID { get; set; }
        public AracIhale AracIhale { get; set; }
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}

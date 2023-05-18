namespace AracIhale.UI.Models.VM.Kullanici
{
    public class KurumsalKullaniciDTO
    {
        public int KurumsalKullaniciID { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public int RolID { get; set; } = 2;
    }
}

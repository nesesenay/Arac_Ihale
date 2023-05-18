namespace AracIhale.UI.Models.VM.Kullanici
{
    public class AdminKullaniciDTO
    {
        public int AdminKullaniciID { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public int RolID { get; set; } = 3;
    }
}

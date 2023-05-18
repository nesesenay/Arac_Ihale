namespace AracIhale.Apis.Models.DTO.Ihale
{
    public class IhaleFiyatBelirlemeDTO
    {
        public int AracID { get; set; }
        public decimal IhaleBaslangicFiyati { get; set; }
        public decimal MinimumAlimFiyati { get; set; }
        public int ParaBirimID { get; set; }
    }
}

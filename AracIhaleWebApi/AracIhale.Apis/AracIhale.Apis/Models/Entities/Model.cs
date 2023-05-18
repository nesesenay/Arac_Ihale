namespace AracIhale.Apis.Models.Entities
{
    public class Model : IEntity
    {
        public int ModelID { get; set; }
        public string ModelAdi { get; set; }
        public int MarkaID { get; set; }
    }
}

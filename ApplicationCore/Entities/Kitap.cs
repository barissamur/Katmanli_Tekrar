namespace ApplicationCore.Entities
{
    public class Kitap : BaseEntity
    {
        public string Ad { get; set; } = null!;

        public Yazar Yazar { get; set; } = null!;
        public int YazarId { get; set; }
    }
}

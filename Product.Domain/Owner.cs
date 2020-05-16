using Domain.Enum;

namespace Domain
{
    public class Owner
    {
        public string Name { get; set; }
        public Ownership Type { get; set; }
        public int Id { get; set; }
        public LegalForm Subject { get; set; }
        public string Nationality { get; set; }
    }
}

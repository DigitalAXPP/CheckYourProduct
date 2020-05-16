using System.Collections.Generic;

namespace Domain
{
    public class Producer
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Revenue { get; set; }
        public List<Owner> Owner { get; set; }
        public string Headquarter { get; set; }
    }
}

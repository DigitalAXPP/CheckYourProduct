namespace Product.Domain
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Producer Producer { get; set; }
        public string Logo { get; set; }
    }
}

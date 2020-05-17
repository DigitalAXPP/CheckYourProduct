using Domain;
using Domain.Enum;
using System.Collections.Generic;

namespace CheckYourProduct.UI.ViewModel
{
    public class ProductViewModel
    {
        public static List<Owner> owner = new List<Owner>() 
        {
            new Owner() { 
                Name = "Mr. Smith",
                Nationality = "DER"
            }
        };

        public static Producer producer = new Producer()
        {
            Name = "Coca Cola",
            Headquarter = "New York",
            Owner = owner
        };
        private Product _item;

        public Product Item
        {
            get { return _item; }
            set { _item = value; }
        }

        private Product _testItem;

        public Product TestItem
        {
            get { return _testItem; }
            set { _testItem = value; }
        }


        public ProductViewModel()
        {
            Item = new Product()
            {
                Id = 1,
                Name = "Fanta",
                Category = Category.Food,
                Producer = producer
            };
        }

    }
}

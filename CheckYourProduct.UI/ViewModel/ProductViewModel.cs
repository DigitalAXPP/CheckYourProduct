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

        public ProductViewModel()
        {
            Item = new Product()
            {
                Name = "Fanta",
                Category = Category.Food,
                Producer = producer
            };
        }

    }
}

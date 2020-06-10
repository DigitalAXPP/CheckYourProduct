using CheckYourProduct.UI.Commands;
using CheckYourProduct.UI.Views;
using Domain;
using Domain.Enum;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;

namespace CheckYourProduct.UI.ViewModel
{
    public class ProductViewModel : ProductViewModelBase
    {
        public string ProductIndex { get; set; } = "Enter index";
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
            set 
            { 
                _testItem = value;
                OnPropertyChanged("TestItem");
            }
        }

        private SearchKeyword searchKeyword;
        private int result;

        public ProductViewModel()
        {
            searchKeyword = new SearchKeyword(this);
            TestItem = new Product()
            {
                Name = "TestSearch1",
                Category = Category.Fashion
            };
            Item = new Product()
            {
                Id = 1,
                Name = "Fanta",
                Category = Category.Food,
                Producer = producer
            };
        }

        public void Search()
        {
            List<Product> list = new List<Product>()
            {
                new Product()
                {
                    Name = "TestSearch1",
                    Category = Category.Fashion
                },
                new Product()
                {
                    Name = "TestSearch2",
                    Category = Category.Food
                },
                new Product()
                {
                    Name = "TestSearch3",
                    Category = Category.IT
                }
            };
            if (int.TryParse(ProductIndex, out result))
            {
                TestItem = list[result];
                
            }
        }

        public ICommand SearchCommand
        {
            get
            {
                return searchKeyword;
            }
        }
    }
}

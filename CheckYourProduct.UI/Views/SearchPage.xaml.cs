using CheckYourProduct.UI.ViewModel;
using Domain;
using Domain.Enum;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace CheckYourProduct.UI.Views
{
    /// <summary>
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : UserControl
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private void SearchButton(object sender, RoutedEventArgs e)
        {
            string number = TextBox_Search.Text;
            this.TestListView.DataContext = GetItem(number);
            TextBox_Search.Text = "Searched successfully!";
        }

        private Product GetItem(string Enumerator)
        {
            List<Product> list = new List<Product>()
            {
                new Product()
                {
                    Name = "TestItem1",
                    Category = Category.Fashion
                },
                new Product()
                {
                    Name = "TestItem2",
                    Category = Category.Food
                },
                new Product()
                {
                    Name = "TestItem3",
                    Category = Category.IT
                }
            };
            int i = int.Parse(Enumerator);
            return list[i];
        }
    }
}

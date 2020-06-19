using Domain;
using Domain.Enum;
using System.Collections.Generic;
using System.IO;

namespace Data
{
    public class CSVReader
    {
        public string[] csvArray { get; set; }
        public List<Product> products { get; set; }
        public List<Product> Read()
        {
            using (var reader = new StreamReader(@"C:\Users\DigitalAXPP\source\repos\CheckYourProduct\Product.Data\Files\TestData.csv"))
            {
                products = new List<Product>();
                var headerline = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    csvArray = line.Split(',');
                    products.Add(new Product
                    {
                        Name = csvArray[0],
                        Category = Category.Food,
                        Producer = new Producer
                        {
                            Name = csvArray[1],
                            Headquarter = csvArray[6]
                        }
                    });
                }
                return products;
            }
        }
    }
}

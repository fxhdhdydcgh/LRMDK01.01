using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product product = new Product();
            product.SetName("продукт");
            product.SetSaled(0);
            product.SetPrice(0);
            Bread bread = new Bread();
            bread.SetName("хлеб1");
            bread.SetSaled(1);
            bread.SetPrice(30);

            Bread bread1 = new Bread();
            bread1.SetName("хлеб2");
            bread1.SetSaled(170);
            bread1.SetPrice(10);

            Bread bread2 = new Bread();
            bread2.SetName("хлеб3");
            bread2.SetSaled(400);
            bread2.SetPrice(10);

            Milk milk = new Milk();
            milk.SetName("молоко");
            milk.SetSaled(5);
            milk.SetPrice(20);

            Milk milk1 = new Milk();
            milk1.SetName("молоко1");
            milk1.SetSaled(20);
            milk1.SetPrice(20);

            products.Add(product);
            products.Add(bread);
            products.Add(bread1);
            products.Add(bread2);
            products.Add(milk);
            products.Add(milk1);
            foreach (Product item in products)
            {
                Console.WriteLine(item.GetName() + "\tпродано: " + item.GetSaled() + "\tцена за штуку: " + item.GetPrice() + "\tскидка:" + item.GetDiscount() + "%\t цена со скидкой: " + item.GetPriceWithDiscount() + "\n");
            }
        }
    }
}

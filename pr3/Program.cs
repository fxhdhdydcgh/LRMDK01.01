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
            Bread bread = new Bread();
            bread.SetName("хлеб1");
            bread.SetSaled(1);
            bread.SetPrice(30);

            Bread bread1 = new Bread();
            bread1.SetName("хлеб2");
            bread1.SetSaled(170);
            bread1.SetPrice(10);

            Bread bread2 = new Bread();
            bread.SetName("хлеб3");
            bread.SetSaled(400);
            bread.SetPrice(10);

            Milk milk = new Milk();
            bread.SetName("молоко");
            bread.SetSaled(5);
            bread.SetPrice(20);

            Milk milk1 = new Milk();
            bread.SetName("молоко1");
            bread.SetSaled(20);
            bread.SetPrice(20);

            products.Add(product);
            products.Add(bread);
            products.Add(bread1);
            products.Add(bread2);
            products.Add(milk);
            products.Add(milk1);
        }
    }
}

using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();

            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır karpuzu";

            Product[] products = new Product[] {product1, product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.Price);
            }
            Console.WriteLine("----Metodlar----");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add2(product1.Name, product1.Description, product1.Price);
        }
    }
}

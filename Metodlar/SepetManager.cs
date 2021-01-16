using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler "+ product.Name + " Sepete Eklendi!");
        }
        public void Add2(string name, string description, double price)
        {
            Console.WriteLine("Tebrikler "+ name + " Sepete Eklendi add2!");
        }
    }
}

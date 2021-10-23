using System;
using System.IO;

namespace HW8_1
{

    class Utilita
    {



        private readonly string path = @"C:\Users\admin\source\repos\HW8_1\HW8_1\Products.txt";
        Product[] products;
        private int size = 0;
        public int Size => size;
        public Utilita()
        {
            string[] readText = File.ReadAllLines(path);
            products = new Product[readText.Length];
            string[] sub;
            for (int i = 0; i < 10; i++)
            {
                sub = readText[i].Split(' ');
                products[i] = new Product(sub[0], Convert.ToDouble(sub[1]));
            }
            size = this.products.Length;
        }

        public Product[] BackToMain(Product[] product)
        {
            for (int i = 0; i < this.products.Length; i++)
            {
                product[i] = new Product(products[i]);
            }
            return product;
        }


        public string Write(Product[] product)
        {
            string res = null;
            for (int i = 0; i < product.Length; i++)
            {
                res += product[i].ToString() + "\n";
            }
            return res;
        }

    }
}

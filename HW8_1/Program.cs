using System;

namespace HW8_1
{
    class Program
    {
        public delegate int Comparison(Product a, Product b);
Цей розв'язок не відповідає умові задачі
        static void Main(string[] args)
        {
            Utilita utilita = new Utilita();
            Product[] product=new Product[utilita.Size];
            utilita.BackToMain(product);
            BubleSort buble = new BubleSort();
            Console.WriteLine("Compared by name\n");
            Comparison n = CompareN;
            buble.Sort(product, n);
            Console.WriteLine("Compared by price\n");
            n = CompareP;
            buble.Sort(product, n);
        }


        public static int CompareP(Product a, Product b)
        {
            if (a.Price < b.Price)
            {
                return 1;
            }
            else return 0;
        }


        public static int CompareN(Product a, Product b)
        {
            return string.Compare(a.Name, b.Name);
        }
    }
}

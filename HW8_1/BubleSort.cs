using System;

namespace HW8_1
{

    class BubleSort
    {
        Utilita utilita = new Utilita();
        public void Sort(Product[] product, Program.Comparison comparison)
        {

            for (int write = 0; write < product.Length; write++)
            {
                for (int sort = 0; sort < product.Length - 1; sort++)
                {
                    if (comparison(product[sort], product[sort + 1]) == 1)
                    {
                        Swap(sort, product);
                    }
                }
           }
            string result = utilita.Write(product);
            Console.WriteLine(result);
        }



        public void Swap(int sort, Product[] product)
        {
            Product temp = product[sort + 1];
            product[sort + 1] = product[sort];
            product[sort] = temp;
        }



    }
}

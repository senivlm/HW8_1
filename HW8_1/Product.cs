namespace HW8_1
{
    class Product
    {
        private readonly string name = null;
        private readonly double price = 0;
        public string Name => name;
        public double Price => price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public Product(Product product)
        {
            this.name = product.name;
            this.price = product.price;
        }


        public override string ToString()
        {
            return "Name\t" + name + "\tPrice\t" + price;
        }


    }
}

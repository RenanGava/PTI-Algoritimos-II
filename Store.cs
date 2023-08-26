using System.Globalization;

namespace Mercado
{


    class Store
    {

        public List<Product> ProductsInStock = new List<Product>();
        private Product Product;

        public void AddProductStock(string name, double price, string code, int stock)
        {
            if (name != "")
            {
                this.Product.Name = name;
                this.Product.Price = price;
                this.Product.Code = code;
                this.Product.Stock = stock;


                this.ProductsInStock.Add(this.Product);
            }
            else
            {
                Console.WriteLine("Faltam parametros a serem preenchidos");
            }
        }


        public void RemoveProductStock(string code)
        {
            if (code != "")
            {

                for (int i = 0; i < this.ProductsInStock.Count; i++)
                {
                    if(this.ProductsInStock[i].Code == code){
                        this.ProductsInStock.RemoveAt(i);
                    }
                }
            }
        }
        public void PrintStockStore()
        {

            CultureInfo formated = CultureInfo.InvariantCulture;

            Console.WriteLine("" + new String('_', 50) + "_");
            foreach (var product in this.ProductsInStock)
            {
                var priceProductString = "" + product.Price;
                var stockProductString = "" + product.Stock;
                // Code Product
                Console.WriteLine("" + Spacing('_', 50) + "_");
                Console.WriteLine("¦ Code    ¦ " + product.Code + Spacing(' ', 39, product.Code.Length) + "¦");
                Console.WriteLine("¦" + Spacing('_', 50) + "¦");
                
                // Product Datails
                Console.WriteLine("¦ Produto ¦ " + product.Name + Spacing(' ', 39, product.Name.Length) + "¦");
                Console.WriteLine("¦ Preço   ¦ " + product.Price.ToString("F2", formated) + Spacing(' ', 39, priceProductString.Length) + "¦");
                Console.WriteLine("¦ Stock   ¦ " + product.Stock + Spacing(' ', 39, stockProductString.Length) + "¦");
                Console.WriteLine("¦" + Spacing('_', 50) + "¦");

            }
        }







        private string Spacing(char character, int numberSpaces, int lengthString)
        {

            return new String(character, numberSpaces - lengthString);
        }

        private string Spacing(char character, int numberSpaces)
        {

            return new String(character, numberSpaces);
        }

    }
}
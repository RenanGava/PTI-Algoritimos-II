using System.Globalization;

namespace Mercado
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Store store = new Store();
            Display display = new Display();

            bool loop = true;

            while (loop)
            {
                display.DisplayOptions();
                ConsoleKeyInfo option = Console.ReadKey();
                Console.Clear();
                
                // Novo Produto
                if (ConsoleKey.D1 == option.Key)
                {
                    Product product = display.InputLabels();

                    store.NewProductStock(
                        product.Name,
                        product.Price,
                        product.Code,
                        product.Stock
                    );
                }
                // Listar Produtos
                else if (ConsoleKey.D2 == option.Key)
                {
                    store.PrintStockStore();
                }
                // Remover Produto
                else if (ConsoleKey.D3 == option.Key)
                {
                    store.PrintStockStore();
                    string code = Console.ReadLine();

                    store.RemoveProductStock(code);
                    
                }
                else if (ConsoleKey.D4 == option.Key)
                {
                    Product product = display.InputLabels();

                    store.NewProductStock(
                        product.Name,
                        product.Price,
                        product.Code,
                        product.Stock
                    );
                    Console.Clear();
                }
                else if (ConsoleKey.D5 == option.Key)
                {
                    Product product = display.InputLabels();

                    store.NewProductStock(
                        product.Name,
                        product.Price,
                        product.Code,
                        product.Stock
                    );
                    Console.Clear();
                }
                else if (ConsoleKey.D0 == option.Key)
                {
                    Product product = display.InputLabels();

                    store.NewProductStock(
                        product.Name,
                        product.Price,
                        product.Code,
                        product.Stock
                    );
                    Console.Clear();
                }
            }
        }
    }

}
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

            while (true)
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
                    Console.Clear();
                    store.PrintStockStore();
                    Console.WriteLine("Digite o Código do Produto: ");
                    string code = Console.ReadLine();

                    store.RemoveProductStock(code);
                    Console.Clear();
                    
                }
                // Add quantidade no estoque
                else if (ConsoleKey.D4 == option.Key)
                {
                    Console.Clear();
                    store.PrintStockStore();
                    Console.WriteLine("Digite o Código do Produto: ");
                    string code = Console.ReadLine();
                    Console.WriteLine("Digite a Quantidade a ser add no Estoque: ");
                    int amount = int.Parse(Console.ReadLine());

                    store.AddProductStock(code, amount);
                    Console.Clear();

                }
                //  Remove quantidade do estoque
                else if (ConsoleKey.D5 == option.Key)
                {
                    Console.Clear();
                    store.PrintStockStore();
                    Console.WriteLine("Digite o Código do Produto: ");
                    string code = Console.ReadLine();
                    Console.WriteLine("Digite a Quantidade a ser Removida no Estoque: ");
                    int amount = int.Parse(Console.ReadLine());

                    store.RemoveAmountStock(code, amount);
                    Console.Clear();
                }
                // sair do programa
                else if (ConsoleKey.D0 == option.Key || ConsoleKey.Escape == option.Key)
                {
                    break;
                }
            }
        }
    }

}
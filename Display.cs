using System.Globalization;

namespace Mercado
{


    class Display
    {
        public Product InputLabels()
        {

            CultureInfo formated = CultureInfo.InvariantCulture;
            Product Product = new Product();
            Console.Write("Digite o Nome do Produto: ");
            Product.Name = Console.ReadLine();
            Console.Write("Digite o Preço do Produto: ");
            Product.Price = double.Parse(Console.ReadLine(), formated);
            Console.Write("Digite o Código do Produto: ");
            Product.Code = Console.ReadLine();
            Console.Write("Digite a Quantidade em Estoque do Produto");
            Product.Stock = int.Parse(Console.ReadLine());

            return Product;
        }

        public void DisplayOptions()
        {
            Console.WriteLine(
                "¦------------------------¦\n" +
                "¦ [1] Novo Produto       ¦\n" +
                "¦ [2] Listar Produtos    ¦\n" +
                "¦ [3] Remover Produtos   ¦\n" +
                "¦ [4] Entrada de Estoque ¦\n" +
                "¦ [5] Saída de Estoque   ¦\n" +
                "¦ [0 | Esc] Sair         ¦\n" +
                "¦------------------------¦"
            );
        }
    }
}
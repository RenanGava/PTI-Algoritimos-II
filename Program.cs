namespace Mercado{

    class Program{

        static void Main(string[] args){
            Store store = new Store();

           bool loop = true; 

            while(loop){

            }

            

            store.AddProductStock("teste1", 10.12, "123451", 10);
            store.AddProductStock("TESTE2000", 20.11, "54321", 20);
            // store.RemoveProductStock("54321");
            store.PrintStockStore();
        }


        private void InputLabels(){

            Product Product = new Product();
            Console.Write("Digite o Nome do Produto");
            Product.Name = Console.ReadLine();
            Console.Write("Digite o Preço do Produto");
            Product.Price = double.Parse(Console.ReadLine());
            Console.Write("Digite o Nome do Produto");
            Product.Name = Console.ReadLine();
            Console.Write("Digite o Nome do Produto");
            Product.Name = Console.ReadLine();
        }
    }

}
using System;

class Program
{
    static void Main(string[] args)
    {
        StockManagementSystem stockSystem = new StockManagementSystem();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar Produto");
            Console.WriteLine("2 - Atualizar Produto");
            Console.WriteLine("3 - Remover Produto");
            Console.WriteLine("4 - Pesquisar Produto");
            Console.WriteLine("5 - Calcular Valor do Estoque");
            Console.WriteLine("6 - Gerar Relatório de Produtos Prestes a Vencer");
            Console.WriteLine("0 - Sair");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    stockSystem.AddProduct();
                    break;
                case 2:
                    stockSystem.UpdateProduct();
                    break;
                case 3:
                    stockSystem.RemoveProduct();
                    break;
                case 4:
                    stockSystem.SearchProduct();
                    break;
                case 5:
                    stockSystem.CalculateStockValue();
                    break;
                case 6:
                    stockSystem.GenerateExpiryReport();
                    break;
                case 0:
                    Console.WriteLine("Saindo do sistema.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}

namespace PTI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque(); 
            int opcao;

            do
            {
                Console.WriteLine("=== Gestão de estoque da Concessionária TupiCars ===");
                Console.WriteLine("[1] NOVO");
                Console.WriteLine("[2] LISTAR VEÍCULOS");
                Console.WriteLine("[3] REMOVER VEÍCULOS");
                Console.WriteLine("[4] ENTRADA DE VEÍCULOS");
                Console.WriteLine("[5] SAÍDA DE VEÍCULOS");
                Console.WriteLine("[0] SAIR");
                Console.Write("Escolha uma das opções: ");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        estoque.AdicionarCarro();
                        break;
                    case 2:
                        estoque.ListarCarros();
                        break;
                    case 3:
                        estoque.RemoverCarro();
                        break;
                    case 4:
                        estoque.EntradaEstoque();
                        break;
                    case 5:
                        estoque.SaidaEstoque();
                        break;
                    case 0:
                        Console.WriteLine("Fim do Programa...");
                        break;
                    default:
                        Console.WriteLine("ERRO: ESCOLHA UMA OPÇÃO VÁLIDA");
                        break;
                }
            }
            while (opcao != 0);
        }
    }
}



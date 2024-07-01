namespace Desafio_Estacionamento_academiaGIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento();
            int opcao = 0;

            while (opcao != 3)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Entrada de veículo");
                Console.WriteLine("2. Saída de veículo");
                Console.WriteLine("3. Encerrar o programa");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        estacionamento.Entrada();
                        break;
                    case 2:
                        estacionamento.Saida();
                        break;
                    case 3:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Estacionamento_academiaGIS
{
    class Estacionamento
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        private const double precoHora = 5.0;

        public void Entrada()
        {
            Console.Write("Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            Console.Write("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite a marca do veículo: ");
            string marca = Console.ReadLine();

            Veiculo veiculo = new Veiculo(placa, modelo, marca);
            veiculos.Add(veiculo);

            Console.WriteLine("Veículo estacionado!");
        }

        public void Saida()
        {
            Console.Write("Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            Console.Write("Digite a quantidade de horas estacionado: ");
            int horas = int.Parse(Console.ReadLine());

            Veiculo veiculo = veiculos.Find(v => v.Placa == placa);
            if (veiculo != null)
            {
                veiculos.Remove(veiculo);
                double valorTotal = horas * precoHora;
                Console.WriteLine($"O valor total cobrado pelo tempo de estacionamento é: R${valorTotal}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }
    }
}

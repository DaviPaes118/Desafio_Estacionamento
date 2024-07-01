using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Estacionamento_academiaGIS
{
    class Veiculo
    {
        public string Placa { get; private set; }
        public string Modelo { get; private set; }
        public string Marca { get; private set; }

        public Veiculo(string placa, string modelo, string marca)
        {
            Placa = placa;
            Modelo = modelo;
            Marca = marca;
        }
    }
}

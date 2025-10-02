using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospedex.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        public string TipoSuite;
        public int Capacidade;
        public decimal ValorDiaria;
    }
}
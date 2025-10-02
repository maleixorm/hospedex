using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospedex.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados;

        public Reserva() {}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count() <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A suíte não comporta a quantidade de pessoas indicada!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count();
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal desconto = 0;
            if (DiasReservados >= 10)
            {
                desconto = DiasReservados * Suite.ValorDiaria * 0.10M;
            }
            decimal valorTotal = DiasReservados * Suite.ValorDiaria - desconto;
            return valorTotal;
        }
    }
}
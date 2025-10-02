using System.Text;
using hospedex.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Marcos", sobrenome: "Marques");
Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Standard", capacidade: 2, valorDiaria: 120);

Reserva reserva = new Reserva(diasReservados: 7);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da estadia: {reserva.CalcularValorDiaria().ToString("C")}");
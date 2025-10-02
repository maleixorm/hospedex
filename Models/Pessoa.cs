using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospedex.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public string Nome;
        public string Sobrenome;
    }
}
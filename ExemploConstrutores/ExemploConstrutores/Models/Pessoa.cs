using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    internal class Pessoa
    {

        private readonly string nome = "Rafael";
        private readonly string sobrenome;

        //public Pessoa()
        //{
        //    nome = string.Empty;
        //    sobrenome = string.Empty;
        //}

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor da classe pessoa.");
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é: {nome} {sobrenome}");
        }
    }
}

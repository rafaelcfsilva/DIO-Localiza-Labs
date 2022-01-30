using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    internal class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} e recebo {Salario}.");
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    internal class Pessoa
    {

        public string Nome { get; set; }

        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos de idade.");
        }

    }
}

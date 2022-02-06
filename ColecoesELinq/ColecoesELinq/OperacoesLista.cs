using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColecoesELinq
{
    internal class OperacoesLista
    {

        public void imprimirLista(List<string> lista)
        {

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Índice: {i}, estado: {lista[i]}");
            }

        }
    }
}

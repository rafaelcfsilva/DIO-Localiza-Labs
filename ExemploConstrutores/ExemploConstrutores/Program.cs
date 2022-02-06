// See https://aka.ms/new-console-template for more information


using ExemploConstrutores.Models;

namespace ExemploConstrutores
{

    class Program
    {

        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {


            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair;
            op.Invoke(10, 10);



            //Data data = new Data();

            //data.SetMes(20);
            //data.SetMes(3);
            //data.ApresentarMes();

            //Pessoa p1 = new Pessoa("Rafael", "Fonseca");
            //p1.Apresentar();

            //Log log = Log.GetInstance();

            //log.PropriedadeLog = "Teste Instancia";

            //Log log2 = Log.GetInstance();
            //Console.WriteLine(log2.PropriedadeLog);

        } 

    }
}
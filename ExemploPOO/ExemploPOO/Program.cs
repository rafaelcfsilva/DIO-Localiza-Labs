// See https://aka.ms/new-console-template for more information
using ExemploPOO.Helper;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste.txt");



            FileHelper helper = new FileHelper();

            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);

            //helper.MoverArquivo(caminho, novoCaminhoArquivo);

            //helper.CriarArquivoTextoStream(caminho, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);


            //helper.CriarArquivoTexto(caminhoArquivo, "Olá!! Teste de escrita no arquivo.");


            //helper.ApagarDiretorio(caminhoPathCombine, true);

            //helper.CriarDiretorio(Path.Combine(caminho,"Pasta Teste 3", "Subpasta Teste 3"));

            //helper.ListarArquivosDiretorios(caminho);i

            //helper.ListarDiretorios(caminho);


            //ICalculadora calc = new Calculadora();

            //Console.WriteLine(calc.Multiplicar(10,5));


            //Corrente conta = new Corrente();
            //conta.Creditar(100);

            //conta.ExibirSaldo();


            //Calculadora calc = new Calculadora();

            //Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));
            //Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));

            //Pessoa p1 = new Pessoa();

            //p1.Nome = "Rafael";
            //p1.Idade = 27;

            //p1.Apresentar();

            //Retangulo r = new Retangulo();

            //Console.WriteLine("Insira o comprimento e a largura:");
            //r.definirMedidas(30, 20);




        }
    }
}


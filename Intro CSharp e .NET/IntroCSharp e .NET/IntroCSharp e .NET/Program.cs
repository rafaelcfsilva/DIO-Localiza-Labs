// See https://aka.ms/new-console-template for more information

using IntroCSharp_e_.NET;

namespace IntroCSharp;

class Program {


    static void Main(string[] args)
    {

        Aluno[] alunos = new Aluno[5];
        var indiceAluno = 0;

        static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Insira a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno.");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular media geral");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;

        }

        string opcaoUsuario = ObterOpcaoUsuario();


        while(opcaoUsuario.ToUpper() != "X")
        {
            switch (opcaoUsuario)
            {
                //TODO Inserir novo aluno
                case "1":
                    
                    Console.WriteLine("Informe o nome do aluno");
                    Aluno aluno = new Aluno();
                    aluno.Nome = Console.ReadLine();

                    Console.WriteLine("Informe a nota do aluno:");

                    if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                    {
                        aluno.Nota = nota;
                    }
                    else
                    { 
                        throw new ArgumentException("Valor deve ser decimal.");
                    }

                    alunos[indiceAluno] = aluno;
                    indiceAluno++;

                    break;
                case "2":
                    foreach (var a in alunos)
                    {
                        if (!string.IsNullOrEmpty(a.Nome))
                        {
                        Console.WriteLine($"Aluno: {a.Nome} Nota: {a.Nota}");
                        }
                    }
                    break;
                case "3":
                    decimal notaTotal = 0;
                    var nrAlunos = 0;

                    for (int i = 0; i < alunos.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(alunos[i].Nome))
                        {
                            notaTotal = notaTotal + alunos[i].Nota;
                            nrAlunos++;
                        }
                    }

                    var mediaGeral = notaTotal / nrAlunos;
                    Console.WriteLine($"Media Geral da Classe: {mediaGeral}");
                    
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            opcaoUsuario = ObterOpcaoUsuario();
        }
        
    }
}







// See https://aka.ms/new-console-template for more information

namespace ColecoesELinq
{

    class Program
    {

        static void Main(string[] args)
        {


            int[] arrayNumeros = new int[] { 1, 2, 3, 76, 345, 3452, 76, 345 };

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            Console.WriteLine($"Minimo: {minimo}");
            Console.WriteLine($"Maximo: {maximo}");
            Console.WriteLine($"Medio: {medio}");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine("Array Original: " + String.Join(",", arrayNumeros));
            Console.WriteLine("Array Distinto: " + String.Join(",", arrayUnico));

            //var numerosParesQuery =
            //    from num in arrayNumeros
            //    where num % 2 == 0
            //    orderby num
            //    select num;

            //var numerosParesMetodo = arrayNumeros.Where(num => num % 2 == 0).OrderBy(num => num).ToList();

            //Console.WriteLine("Numeros pares query: " + String.Join(", ", numerosParesQuery));
            //Console.WriteLine("Numeros pares metodo: " + String.Join(", ", numerosParesMetodo));



            //Dictionary<string, string> estados = new Dictionary<string, string>();

            //estados.Add("GO", "Goiás");
            //estados.Add("SP", "São Paulo");
            //estados.Add("RJ", "Rio de Janeiro");


            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    //Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            //}

            //string valorProcurado = "BA";

            //if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            //{
            //    Console.WriteLine(estadoEncontrado);
            //}
            //else
            //{
            //    Console.WriteLine($"Chave: {valorProcurado} não encontrado.");
            //}


            //OperacoesLista opLista = new OperacoesLista();


            //Stack<string> pilhaLivros = new Stack<string>();

            //pilhaLivros.Push(".NET");
            //pilhaLivros.Push("DDD");
            //pilhaLivros.Push("Codigo Limpo");

            //Console.WriteLine($"Livros para Leitura: {pilhaLivros.Count}");

            //while (pilhaLivros.Count > 0)
            //{
            //    Console.WriteLine($"Próximo livro para leitura: {pilhaLivros.Peek()}");
            //    Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso.");
            //}

            //Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");

            //Queue<string> fila = new Queue<string>();

            //fila.Enqueue("Rafael");
            //fila.Enqueue("João");
            //fila.Enqueue("Amanda");
            //fila.Enqueue("Roberto");

            //while(fila.Count > 0)
            //{
            //    Console.WriteLine($"Vez de: {fila.Peek()}");
            //    Console.WriteLine(($"{fila.Dequeue()} atendido."));
            //}

            //Console.WriteLine($"Pessoas na fila: {fila.Count}");



            //List<string> estados = new List<string>() { "MT", "BA", "SC"};
            //string[] estadosArray = new string[2] {"GO", "SP"};


            //opLista.imprimirLista(estados);

            ////Console.WriteLine("Removendo o elemento");
            ////estados.Remove("MG");

            ////estados.AddRange(estadosArray);
            //estados.Insert(0, "RJ");

            //opLista.imprimirLista(estados);

            //OperacoesArray op = new OperacoesArray();

            //int[] array = new int[5] { 5, 234, 34, 1, 3245 };
            //int[] arrayCopia = new int[10];


            //string[] arrayString = op.converterParaArrayString(array);


            //Console.WriteLine($"Capacidade atual do array: {array.Length}");
            //op.RedimensionarArray(ref array, array.Length * 2);
            //Console.WriteLine($"Capacidade do array após redimensionamento:{array.Length}");

            //int valorProcurado = 5;

            //int indiceObtido = op.obterIndice(array, valorProcurado);

            //if (indiceObtido > -1)
            //{
            //    Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indiceObtido);
            //}
            //else
            //{
            //    Console.WriteLine("Valor não existente no array.");
            //}

            //int valorAchado = op.obterValor(array, valorProcurado);

            //if(valorAchado > 0)
            //{
            //    Console.WriteLine("Encontrei o valor.");
            //}
            //else
            //{
            //    Console.WriteLine("Não encontrei o valor.");
            //}



            //bool maiorQue = op.todosMaiorQue(array, valorProcurado);

            //if (maiorQue)
            //{
            //    Console.WriteLine("Todos os valores são maiores que: {0}", valorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Existem valores menores que {0}", valorProcurado);
            //}

            //bool existe = op.Existe(array, valorProcurado);

            //if (existe)
            //{
            //    Console.WriteLine("Valor encontrado: {0}", valorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Valor não encontrado: {0}", valorProcurado);
            //}



            //Console.WriteLine("Array inicial:");
            ////op.ImprimirArray(array);

            //Console.WriteLine("Array ordenado:");
            ////op.OrdenarBubbleSort(ref array);
            ////op.ImprimirArray(array);


            //Console.WriteLine($"Array antes da copia");
            //op.ImprimirArray(arrayCopia);

            //op.Copiar(ref array, ref arrayCopia);
            //Console.WriteLine($"Array depois da copia");
            //op.ImprimirArray(arrayCopia);


            //int[,] matriz = new int[4, 2]
            //{
            //    { 10, 20},
            //    { 30, 40},
            //    { 50, 60},
            //    { 70, 80},
            //};

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine(matriz[i, j]);
            //    }

            //}

            //int[] arrayInteiros = new int[3];

            //arrayInteiros[0] = 10;
            //arrayInteiros[1] = 20;
            //arrayInteiros[2] = 30;

            //Console.WriteLine("Percorrendo o Array pelo FOR");
            //for (int i = 0; i < arrayInteiros.Length; i++)
            //{
            //    Console.WriteLine(arrayInteiros[i]);
            //}


            //Console.WriteLine("Percorrendo o Array pelo FOREACH");
            //foreach (int item in arrayInteiros)
            //{
            //    Console.WriteLine(item);
            //}

        }

    }
}
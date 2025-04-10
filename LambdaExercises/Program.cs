using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op = "0";
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("Selecione uma das opções a seguir:");
                Console.WriteLine("1 - Dobrar os Números\n2 - Filtrar Números Pares\n3 - Converter Lista de Strings para Maiúsculas\n4 - Somar Valores da Lista\n5 - Buscar Palavras Específicas\n6 - Multiplicar Todos os Elementos por um Número\n\n0 - SAIR");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        List<int> listaCase1 = new List<int> { 15, 7, 30, 14 };
                        var dobro = listaCase1.Select(x => x * 2).ToList();
                        Console.WriteLine(String.Join(", ", dobro));
                        Console.ReadKey();
                        break;
                    case "2":
                        List<int> listaCase2 = new List<int> { 2, 5, 6, 7, 11, 12, 22, 43, 52 };
                        var pares = listaCase2.Where(x => x % 2 == 0).ToList();

                        Console.WriteLine(String.Join(", ", pares));
                        Console.ReadKey();
                        break;
                    case "3":
                        List<string> listaCase3 = new List<string> { "tudominus", "PrimeirasMaius", "SOUMAMInUS", "Primeiramaius" };
                        var maius = listaCase3.ConvertAll(x => x.ToUpper()).ToList();

                        Console.WriteLine(String.Join(", ", maius));
                        Console.ReadKey();
                        break;
                    case "4":
                        List<int> listaCase4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                        var soma = listaCase4.Sum(x => x);

                        Console.WriteLine(String.Join(", ", soma));
                        Console.ReadKey();
                        break;
                    case "5":
                        List<string> listaCase5 = new List<string> { "Maçã", "Banana", "Apple", "Abacate", "Limão", "Laranja", "Abacaxi" };
                        var startsWithA = listaCase5.Where(x => x.StartsWith("A")).ToList();

                        Console.WriteLine(String.Join(", ", startsWithA));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Write("Escolha o número: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        List<int> listaCase6 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                        var multiNum = listaCase6.Select(x => x * numero).ToList();

                        Console.WriteLine(String.Join(", ", multiNum));
                        Console.ReadKey();
                        break;

                }
            } while (op != "0");
        }
    }
}

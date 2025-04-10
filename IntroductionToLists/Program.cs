using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introdução_a_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            int op = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("MENU");

                Console.WriteLine("1 - Inserir nomes na Lista");
                Console.WriteLine("2 - Listar nomes na Lista");
                Console.WriteLine("3 - Remover nomes da Lista");
                Console.WriteLine("4 - Ordenar Lista");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha uma opção: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Muito Obrigado!");
                        break;
                    case 1:
                        InserirNomes(nomes);
                        break;
                    case 2:
                        ListarNomes(nomes);
                        break;
                    case 3:
                        RemoverNomes(nomes);
                        break;
                    case 4:
                        OrdenarNomes(nomes);
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida");
                        break;
                }
            } while (op != 0);
        }

        static void InserirNomes(List<string> nomes)
        {
            Console.WriteLine("Insira o nome na lista: ");
            string nome = Console.ReadLine();
            nomes.Add(nome);
            Console.WriteLine("NOME INSERIDO COM SUCESSO");
            Console.ReadKey();
        }
        static void ListarNomes(List<string> nomes)
        {
            if (nomes.Count == 0)
            {
                Console.WriteLine("Lista Vazia. Pressione qualquer tecla para continuar.");
            }
            else
            {
                for (int i = 0; i < nomes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {nomes[i]}");
                }

            }
            Console.ReadKey();
        }
        static void RemoverNomes(List<string> nomes)
        {
            if (nomes.Count == 0)
            {
                Console.WriteLine("Lista Vazia. Pressione qualquer tecla para continuar.");
            }
            else
            {
                ListarNomes(nomes);
                Console.WriteLine($"Escolha um nome para remover");
                string remover = Console.ReadLine();

                if (nomes.Contains(remover))
                {
                    nomes.Remove(remover);
                    Console.WriteLine("NOME REMOVIDO COM SUCESSO!");
                }
                else
                {
                    Console.WriteLine("O nome não está na lista");
                }

            }
            Console.ReadKey();
        }
        static void OrdenarNomes(List<string> nomes)
        {
            if (nomes.Count == 0)
            {
                Console.WriteLine("Lista Vazia. Pressione qualquer tecla para continuar.");
            }
            else
            {
                nomes.Sort();
                Console.WriteLine("Lista Ordenada!");
                ListarNomes(nomes);
            }
            Console.ReadKey();
        }
    }
}

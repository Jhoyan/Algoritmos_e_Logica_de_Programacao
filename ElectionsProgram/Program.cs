using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections_Program
{
    internal class Program
    {
        public static class Globals
        {
            public static (string, string, int, string, int) candidato = (Nome: "", Apelido: "", Numero: -1, Partido: "", Votos: 0); // eu escolhi atrelar os votos aos candidatos dentro das tuplas
        }

        static void Main(string[] args)
        {
            List<(string Nome, string Apelido, int Numero, string Partido, int Votos)> candidatos = new List<(string, string, int, string, int)>();
            List<int> votos = new List<int>();
            string op = ""; // usei string pra não ter que fazer verificação se o usuário realmente inseriu um número ou se ele inseriu qualquer outra porcaria


            do
            {
                Console.Clear();
                Console.WriteLine("MENU");

                Console.WriteLine("1 - Cadastrar Candidato");
                Console.WriteLine("2 - Listar Candidatos");
                Console.WriteLine("3 - Votar");
                Console.WriteLine("4 - Apurar resultados");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha uma opção: ");
                op = Console.ReadLine();
                switch (op)
                {
                    case "0":
                        Console.WriteLine("Muito Obrigado!");
                        break;
                    case "1":
                        candidatos.Add(InserirCandidatos(candidatos));
                        break;
                    case "2":
                        ListarCandidatos(candidatos);
                        break;
                    case "3":
                        ListarCandidatos(candidatos);
                        Votar(candidatos, votos);
                        break;
                    case "4":
                        ApurarVotos(candidatos, votos);
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida");
                        break;
                }
                Console.ReadKey();
            } while (op != "0");
        }
        static (string, string, int, string, int) InserirCandidatos(List<(string Nome, string Apelido, int Numero, string Partido, int Votos)> candidatos)
        {
            bool existe = false;
            int votos = 0;
            int numero = 0;

            Console.Write("Nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Apelido: ");
            string apelido = Console.ReadLine();

            do
            {
                Console.Write("Numero: ");
                if(int.TryParse(Console.ReadLine(), out numero)) // verifica se o número atribuído ao candidato é realmente um número
                {
                    foreach (var entrada in candidatos)
                    {
                        if (entrada.Numero == numero)
                        {
                            existe = true;
                        }
                        else
                        {
                            existe = false;
                        }

                    }

                    if (numero == 0) //bloqueia a entrada de zeros (pois no meu código são usados para votos em branco)
                    {
                        Console.WriteLine("O número do candidato não pode ser zero"); 
                        existe = true;
                    }
                    else if (numero < 0) //bloqueia a entrada de números negativos (pq acho que faz sentido)
                    {
                        Console.WriteLine("O número do candidato não pode ser negativo");
                        existe = true;
                    }
                    else if (existe) //verifica se o número inserido já está relacionado a outro candidato
                    {
                        Console.WriteLine("O número já está relacionado a outro candidato");
                        existe = true;
                    }
                    else
                    {
                        existe = false; // se tudo tiver dado certo, muda a variavel de verificação de existência pra falso e segue o código
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Digite apenas números.\n");
                    existe = true;
                }                
            } while (existe == true);

            Console.Write("Partido: ");
            string partido = Console.ReadLine();


            return (nome, apelido, numero, partido, votos);
        }
        static bool SemCandidatos(List<(string Nome, string Apelido, int Numero, string Partido, int Votos)> candidatos)
        {
            if (candidatos.Count == 0) // verifica se algum candidato foi cadastrado fazendo a verificação de contagem da lista e retorna um valor booleano
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void ListarCandidatos(List<(string Nome, string Apelido, int Numero, string Partido, int Votos)> candidatos)
        {
            if(SemCandidatos(candidatos)) 
            {
                Console.WriteLine("Não há candidatos cadastrados. Pressione qualquer tecla para continuar.");
            }
            else
            {
                foreach (var candidato in candidatos) 
                {
                    Console.WriteLine($"\nNome: {candidato.Nome}\nApelido: {candidato.Apelido}\nNumero: {candidato.Numero}\nPartido: {candidato.Partido}\n");
                }

            }
            Console.ReadKey();
        }
        static void Votar(List<(string Nome, string Apelido, int Numero, string Partido, int Votos)> candidatos, List<int> Votos)
        {
            string voto = "";
            Console.WriteLine("VOTAÇÃO\n");

            Console.WriteLine("Digite o número do candidato para votar nele.");
            Console.WriteLine("Digite 0 para votar em branco.");
            Console.WriteLine("Digite o número de nenhum candidato para votar nulo.");
            Console.WriteLine("Digite SAIR para voltar ao menu principal.");

            do
            {
                Console.Write("\nEscolha uma opção: ");
                voto = Console.ReadLine();
                if (int.TryParse(voto, out int votoint)) // verificação se é um número ou não
                {
                    Votos.Add(votoint);
                    Console.WriteLine("Voto computado com sucesso!");
                }
                else
                {
                    if (voto.ToUpper() != "SAIR") //toUpper pra não ter diferença do que o usuário escrever
                    {
                        Console.WriteLine("Entrada inválida");
                    }
                    else
                    {
                        Console.WriteLine("\nPressione qualquer tecla.");
                    }
                }
            } while (voto.ToUpper() != "SAIR"); //toUpper pra não ter diferença do que o usuário escrever

        }
        static void ApurarVotos(List<(string Nome, string Apelido, int Numero, string Partido, int Votos)> candidatos, List<int> Votos)
        {
            int emBranco = 0;
            int nulos = 0;
            
            if (SemCandidatos(candidatos))
            {
                Console.WriteLine("Não há candidatos cadastrados. Pressione qualquer tecla para continuar.");
            }
            else
            {
                for (int i = 0; i < Votos.Count; i++)
                {
                    if (Votos[i] == 0)
                    {
                        emBranco++;
                        continue; // usei pra reiniciar o loop logo e não atrapalhar a contagem de nulos
                    }
                    bool nulo = true;
                    for (int j = 0; j < candidatos.Count; j++)
                    {
                        
                        if (Votos[i] == candidatos[j].Numero)
                        {
                            var candidato = candidatos[j];
                            candidatos[j] = (candidato.Nome, candidato.Apelido, candidato.Numero, candidato.Partido, candidato.Votos + 1); //como as tuplas são imutáveis, a solução que eu consegui pra manter a utilização das tuplas e manter os votos atrelados ao cadastro dos candidatos foi recriar as tuplas toda vez que um voto for associado ao candidato
                            nulo = false;

                        }
                    }
                    if (nulo)
                    {
                        nulos++;
                    }
                }
                foreach (var candidato in candidatos)
                {
                    Console.WriteLine($"\nApelido: {candidato.Apelido}\nVotos: {candidato.Votos}\n");
                }
                Console.WriteLine($"\nNulos: {nulos}\nEm Branco: {emBranco}");

                for (int i = 0; i < candidatos.Count; i++) // usei esse For pra resetar a quantidade de votos de cada candidato pra não bugar quando executar o switch 4 duas vezes seguidas
                {
                    var candidato = candidatos[i];
                    candidatos[i] = (candidato.Nome, candidato.Apelido, candidato.Numero, candidato.Partido, 0); //fiz da mesma forma, recriando as tuplas só que atrelando 0 à quantidade de votos do candidato
                }
            }
            Console.ReadKey();
        }
    }
}

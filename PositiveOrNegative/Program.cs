using System.ComponentModel.Design;

while (true)
{
    string input;
    int numero;
    string condicao;
    Console.WriteLine("Digite um número inteiro");
    input = Console.ReadLine();
    if (int.TryParse(input, out numero))
    {
        if (numero > 0)
        {
            Console.WriteLine("O NÚMERO É POSITIVO!!!");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O NÚMERO É NEGATIVO!!!");
        }
        else
        {
            Console.WriteLine("ZERO É NULO");
        }
    }
    else
    { while (true)
        {
            Console.WriteLine("Entrada inválida.");
            Console.WriteLine("Quer digitar outro número? ('Sim' ou 'Não')");
            condicao = Console.ReadLine();
            if (condicao == "Sim" || condicao == "sim")
            { break; }
            else if (condicao == "Não" || condicao == "nao" || condicao == "Nao" || condicao == "não")
            { return; }
            else { Console.WriteLine("Por favor, digite apenas 'Sim' ou 'Não'."); }
        }
    }
}

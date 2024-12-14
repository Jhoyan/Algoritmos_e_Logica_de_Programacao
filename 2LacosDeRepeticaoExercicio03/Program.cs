using static System.Console;
using static System.Convert;

int n = 0;
double soma = 0;
double qtd = 0;
double media = 0;

do
{
    WriteLine("Digite um número: ");
    n = ToInt32(ReadLine());
    soma += n;
    qtd++;
} while (n != 0);

media = soma / (qtd-1);
WriteLine($"A média dos {qtd-1} valores lidos é de {media}");
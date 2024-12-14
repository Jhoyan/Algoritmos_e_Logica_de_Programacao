using static System.Console;
using static System.Convert;

int n = 0;
int qtd = 0;

for (int i = 0; i < 30; i++)
{
    WriteLine("Digite um número: ");
    n = ToInt32(ReadLine());
    if (n > 100)
    {
        qtd++;
    }
}

WriteLine($"A quantidade de números digitados maiores que 100 é de: {qtd}");
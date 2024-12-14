using static System.Console;
using static System.Convert;

int qtd = 0;
int positivos = 0;
int negativos = 0;
double soma = 0;
double media = 0;
double numero = 0;

do
{
    Write("Digite um número (0 para finalizar): ");
    numero = ToDouble(ReadLine());

    soma += numero;
    qtd++;

    if (numero > 0)
    {
        positivos++;
    }
    else if (numero < 0)
    {
        negativos++;
    }
} while (numero != 0);

media = soma / (qtd-1);
WriteLine($"Média aritmética: {media}");
WriteLine($"Quantidade de valores positivos: {positivos}");
WriteLine($"Quantidade de valores negativos: {negativos}");
using static System.Console;
using static System.Convert;

int negativos = 0;
int numero;

do
{
    Write("Digite um número inteiro (Digite 0 para finalizra): ");
    numero = ToInt32(ReadLine());

    if (numero < 0)
    {
        negativos += numero;
    }

} while (numero != 0);

WriteLine($"A soma dos números negativos é {negativos}");

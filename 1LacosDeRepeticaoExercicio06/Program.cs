using static System.Console;
using static System.Convert;

int n = 0;
WriteLine("Digite um número: ");
n = ToInt32(ReadLine());

while (n != 1)
{
    if (n % 2 == 0)
    {
        n = n / 2;
        WriteLine(n);
    } else
    {
        n = n * 3 + 1;
        WriteLine(n);
    }
}
WriteLine("Quando você executa o programa, ele solicita que o usuário insira um número inteiro n. O programa então aplica repetidamente as regras até que n seja igual a 1");
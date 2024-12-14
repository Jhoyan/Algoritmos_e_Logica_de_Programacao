using static System.Console;
using static System.Convert;

int n = 0;

for(int i = 0; i < 10; i++)
{
    WriteLine("Digite um número: ");
    n = ToInt32(ReadLine());
    if(n % 3 == 0)
    {
        WriteLine($"O número {n} é divisível por 3");
    }
}
using static System.Console;
using static System.Convert;

int n  = 0;
int m = 1;

WriteLine("Digite o número da tabuada: ");
n = ToInt32(ReadLine());

for (int j = 0; j < n; j++)
{
    for (int i = 1; i <= 10; i++)
    {
        WriteLine($"{m} X {i} = {m * i}");
    }
    m++;
}
using static System.Console;
using static System.Convert;

int i  = 0;
int j = 0;
double mediana = 0;
double num1 = 0;
double num2 = 0;
int qntd = 0;
int qntd2 = 0;


WriteLine("Digite o número inicial: ");
i = ToInt32(ReadLine());

WriteLine("Digite o número final: ");
j = ToInt32(ReadLine());

for (int i2 = i; i2 <= j; i2++)
{
    qntd++;
}

for (int i3 = i; i3 <= j; i3++)
{
    qntd2++;
    if (qntd % 2 == 1)
    {
        if (qntd2 == ((qntd + 1) / 2))
        {
            mediana = i3;
        }
    } else
    {
        if (qntd2 == (qntd / 2))
        {
            num1 = i3;
            num2 = i3 + 1;
            mediana = (num1 + num2) / 2;
        }
    }
}
WriteLine($"A mediana da sequência indicada é {mediana}");
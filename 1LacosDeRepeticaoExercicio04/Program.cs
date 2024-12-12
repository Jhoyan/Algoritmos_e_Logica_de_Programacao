using static System.Console;
using static System.Convert;

double positivos = 0;
double pares = 0;
double impares = 0;
double divisiveis = 0;
double inicial = 0;

double totalPositivos = 0;
double totalPares = 0;
double totalImpares = 0;
double totalDivisiveis = 0;

double mediaInteiros = 0;
double mediaPares = 0;
double mediaImpares = 0;
double mediaDivisiveis = 0;

double n = 0;
WriteLine("Digite o número inicial: ");
n = ToDouble(ReadLine());

double m = 0;
WriteLine("Digite o número final: ");
m = ToDouble(ReadLine());

inicial = n;
for (double i = n; i <= m; i++)
{
    if (i <= m)
    {
        totalPositivos += i;
        positivos++;
        if (i % 2 == 0)
        {
            totalPares += i;
            pares++;
        } else
        {
            totalImpares += i;
            impares++;
        }
        if (i % 3 == 0 || i % 7 == 0)
        {
            totalDivisiveis += i;
            divisiveis++;
        }
    }
}
mediaInteiros = totalPositivos / positivos;
mediaPares = totalPares / pares;
mediaImpares = totalImpares / impares;
mediaDivisiveis = totalDivisiveis / divisiveis;

WriteLine($"\nNo intervalo entre {inicial} e {m} podem ser encontrados: \n{positivos} números positivos inteiros. \n{pares} números pares. \n{impares} números ímpares. \n{divisiveis} números divisíveis por 3 ou por 7. \n\nSendo as médias entre cada grupo: \n{mediaInteiros} a média dos positivos inteiros; \n{mediaPares} a média dos números pares; \n{mediaImpares} a média dos números ímpares; \n{mediaDivisiveis} a média dos números divisíveis por 3 ou por 7.");

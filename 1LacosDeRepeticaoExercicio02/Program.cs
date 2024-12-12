using System.IO.Pipes;
using static System.Console;
using static System.Convert;

double altPedro = 1.5;
double taxaCresPedro = 0.02;
double altLucas = 1.1;
double taxaCresLucas = 0.03;
int anos = 0;
int anosIgual = 0;

while (altLucas <= altPedro)
{
    altLucas += taxaCresLucas;
    altPedro += taxaCresPedro;
    if (anosIgual == 0 && altLucas >= altPedro)
    {
        anosIgual = anos;
        anos++;
    } else { anos++; }
}
WriteLine($"Levará {anosIgual} anos até que Lucas e Pedro tenham a mesma altura e {anos} anos até que Lucas ultrapasse a altura de Pedro.");
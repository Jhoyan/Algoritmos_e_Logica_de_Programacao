using static System.Console;
using static System.Convert;

int fibo = 0;
int atual = 1;
int anterior = 0;
int n  = 0;

WriteLine("Escreva quantos números da sequência de Fibonacci deseja saber: ");
n = ToInt32(ReadLine());

for (int i = 1; i <= n; i++)
{
    fibo = anterior + atual;
    WriteLine(fibo);
    anterior = atual;
    atual = fibo;
}
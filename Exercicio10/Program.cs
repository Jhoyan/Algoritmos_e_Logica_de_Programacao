using static System.Console;
using static System.Convert;

double valorCompra, valorPago, valorTroco = 0, valorTrocoDeduzir;
int notas100 = 0, notas10 = 0, notas1 = 0;

WriteLine("Qual o valor da compra feita? ");
valorCompra = ToDouble(ReadLine());
WriteLine("Qual o valor pago? ");
valorPago = ToDouble(ReadLine());
valorTroco = valorPago - valorCompra;
valorTrocoDeduzir = valorTroco;

while(true)
    if (valorTrocoDeduzir - 100 >= 0)
    {
        valorTrocoDeduzir -= 100;
        notas100++;
    }
    else if (valorTrocoDeduzir - 10 >= 0)
    {
        valorTrocoDeduzir -= 10;
        notas10++;
    }
    else if (valorTrocoDeduzir - 1 >= 0)
    {
        valorTrocoDeduzir -= 1;
        notas1++;
    }
    else
    {
        WriteLine($"O valor do troco será de {valorTroco}, dividido entre {notas100} notas de R$100, {notas10} notas de R$10 e {notas1} notas de R$1.");
        break;
    }
using static System.Console;
using static System.Convert;

double precoPorcas = 1, precoParafusos = 2, PrecoArruelas = 0.5;
int qntdPorcas, qntdParafusos, qntdArruelas;
double precoTotalPorcas, precoTotalParafusos, precoTotalArruelas;
double valorTotal, valorTotalAjustado, desconto;

WriteLine("Quantas porcas deseja comprar? ");
qntdPorcas = ToInt32(ReadLine());
WriteLine("Quantos parafusos deseja comprar? ");
qntdParafusos = ToInt32(ReadLine());
WriteLine("Quantas arreulas deseja comprar? ");
qntdArruelas = ToInt32(ReadLine());


precoTotalPorcas = (precoPorcas * qntdPorcas) * 0.90;
precoTotalParafusos = (precoParafusos * qntdParafusos) * 0.80;
precoTotalArruelas = (PrecoArruelas * qntdArruelas) * 0.70;

valorTotal = (precoPorcas * qntdPorcas) + (precoParafusos * qntdParafusos) + (PrecoArruelas * qntdArruelas);
valorTotalAjustado = precoTotalPorcas + precoTotalParafusos + precoTotalArruelas;
desconto = valorTotal - valorTotalAjustado;

WriteLine($"\nComprando {qntdPorcas} porcas, {qntdParafusos} parafusos e {qntdArruelas} arruelas, o preço total da compra ficaria de R${valorTotal}. Mas há um desconto de 10% no valor das porcas, 20% no valor dos parafusos e 30% no valor das arruelas. Por isso, o preço ajustado é de R${valorTotalAjustado} com um desconto total de R${desconto}.");
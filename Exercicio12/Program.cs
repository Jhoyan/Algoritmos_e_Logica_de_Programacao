using static System.Console; using static System.Convert;

double salariominimo = 1400;
int carrosvendidos = 0;
double valordasvendas = 0;
double comissaofixa = 0;
double comissaoporcentagem = 0;
double salariofinal = 0;

WriteLine("Quantos carros o vendedor conseguiu vender no mês? ");
carrosvendidos = ToInt32(ReadLine());
WriteLine("Qual o valor total em vendas que o vendedor realizou? ");
valordasvendas = ToDouble(ReadLine());

comissaofixa = carrosvendidos * 50;
comissaoporcentagem = valordasvendas * 0.05;

salariofinal = (salariominimo * 2) + comissaofixa + comissaoporcentagem;
WriteLine($"O vendedor receberá, nesse mês, um salário de R${salariofinal}. Sendo R${salariominimo * 2} o valor do salário fixo, R${comissaofixa} o valor das comissões por carro vendido e R${comissaoporcentagem} o valor das comissões por valor de vendas no total.");
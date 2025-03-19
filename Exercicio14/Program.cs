using static System.Console; using static System.Convert;

int anos = 0;
double diasVividos = 0.0;

WriteLine("Qual sua idade? ");
anos = ToInt32(ReadLine());

diasVividos = (anos * 12) * 30;
WriteLine($"Você tinha vivido um total de {diasVividos} dias quando completou {anos} anos.");
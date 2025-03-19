using static System.Convert; using static System.Console;

string nome1, nome2, nome3, nome4;
double preco1, preco2, preco3, preco4;
double totalDeDesconto1, totalDeDesconto2, totalDeDesconto3, totalDeDesconto4;
double precoComDesconto1, precoComDesconto2, precoComDesconto3, precoComDesconto4;

nome1 = "Futebol, o maior esporte do mundo!";
preco1 = 60;
totalDeDesconto1 = 0.1;
precoComDesconto1 = preco1 - (preco1 * totalDeDesconto1);


nome2 = "Como a LGPD pode te ajudar em situações desconfortáveis.";
preco2 = 30;
totalDeDesconto2 = 0.2;
precoComDesconto2 = preco2 - (preco2 * totalDeDesconto2);

nome3 = "Colossus: o computador que venceu a guerra!";
preco3 = 80;
totalDeDesconto3 = 0.15;
precoComDesconto3 = preco3 - (preco3 * totalDeDesconto3);

nome4 = "Ensimentos passados em filmes infantis que valem para vida toda.";
preco4 = 20;
totalDeDesconto4 = 0.5;
precoComDesconto4 = preco4 - (preco4 * totalDeDesconto4);

WriteLine($"O primeiro artigo: {nome1}, sai do preço de R${preco1} para R${precoComDesconto1}(10% de desconto).");
WriteLine($"O segundo artigo: {nome2}, sai do preço de R${preco2} para R${precoComDesconto2}(20% de desconto).");
WriteLine($"O terceiro artigo: {nome3}, sai do preço de R${preco3} para R${precoComDesconto3}(15% de desconto).");
WriteLine($"O quarto artigo: {nome4}, sai do preço de R${preco4} para R${precoComDesconto4}(50% de desconto).");
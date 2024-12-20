int valor1;
int valor2;
int quocienteInteiro;
int resto;

Console.WriteLine("Qual o numerador?");
valor1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Qual o denominador?");
valor2 = Convert.ToInt32(Console.ReadLine());

quocienteInteiro = valor1 / valor2;
Console.WriteLine($"O valor do quociente inteiro é de {quocienteInteiro}");
resto = valor1 % valor2;
Console.WriteLine($"O valor do resto é de {resto}");
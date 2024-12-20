int valor1;
int valor2;
int resultado;

Console.WriteLine("Qual o primeiro valor? ");
valor1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Qual o segundo valor? ");
valor2 = Convert.ToInt32(Console.ReadLine());

resultado = (valor1*valor1) + (valor2*valor2);
Console.WriteLine($"O resultado da soma dos quadrados é de {resultado}");
using System.Security.AccessControl;

double altura, comprimento, largura, volume;

Console.WriteLine("Qual a altura do retângulo em cm? ");
altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Qual o comprimento do retângulo em cm? ");
comprimento = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Qual a largura do retângulo em cm? ");
largura = Convert.ToDouble(Console.ReadLine());

volume = altura * comprimento * largura;
Console.WriteLine($"O volume do retângulo é de {volume}cm cúbicos");
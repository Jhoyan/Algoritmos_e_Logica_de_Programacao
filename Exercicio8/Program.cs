double velocidadekmh;
double velocidadems;

Console.WriteLine("Qual a velocidade em KM/H? ");
velocidadekmh = Convert.ToDouble(Console.ReadLine());

velocidadems = velocidadekmh / 3.6;
Console.WriteLine($"A velocidade em m/s é de {velocidadems}.");
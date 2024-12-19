double tempCelcius, tempFahren;

Console.WriteLine("Qual a temperatura em graus Celcius? ");
tempCelcius = Convert.ToDouble(Console.ReadLine());

tempFahren = (9 * tempCelcius + 160) / 5;
Console.WriteLine($"A temperatura em Fahrenheit é de {tempFahren}");
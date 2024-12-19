double valor, quadrado, cubo;

Console.WriteLine("Digite um valor: ");
valor = Convert.ToDouble(Console.ReadLine());

quadrado = valor * valor;
cubo = valor * valor * valor;

Console.WriteLine($"O quadrado de {valor} é igual a {quadrado}, enquanto o cubo de {valor} é igual a {cubo}.");
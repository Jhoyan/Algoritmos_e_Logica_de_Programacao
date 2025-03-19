using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using static System.Console;
using static System.Convert;

int numero = 0;

WriteLine("Qual questão deseja resolver? ");
numero = ToInt32(ReadLine());

switch (numero)
{
    case 1:
        // Faça um algoritmo que leia uma temperatura em graus Celsius e apresente-a convertida em graus Fahrenheit. A fórmula de conversão é: F = (9 * C + 160) / 5, na qual F é a temperatura em Fahrenheit e C é a temperatura em Celsius; (5 pontos)
        double f = 0;
        double c = 0;

        WriteLine("Digite a temperatura em graus Celcius: ");
        c = ToDouble(ReadLine());

        f = (9 * c + 160) / 5;
        WriteLine($"A temperatura em Fahrenheit será de {f}");
        break;
    case 2:
        // Questão 02 - Faça um algoritmo que leia dois valores inteiros e apresente o resultado da soma do quadrado e do cubo de cada valor lido. (5 pontos)
        int num1 = 0, num2 = 0;
        int quadrado1 = 0, quadrado2 = 0;
        int cubo1 = 0, cubo2 = 0;
        int resultQuadrado = 0, resultCubo = 0;

        WriteLine("Digite o primeiro valor: ");
        num1 = ToInt32(ReadLine());

        WriteLine("Digite o segundo valor: ");
        num2 = ToInt32(ReadLine());

        quadrado1 = num1 * num1;
        quadrado2 = num2 * num2;

        cubo1 = num1 * quadrado1;
        cubo2 = num2 * quadrado2;

        resultQuadrado = quadrado1 + quadrado2;
        resultCubo = cubo1 + cubo2;
        WriteLine($"A soma do quadrado de cada valor lido é de {resultQuadrado}");
        WriteLine($"A soma do cubo de cada valor lido é de {resultCubo}");
        break;
    case 3:
        // Questão 03 - Suponha que um caixa disponha apenas de notas de 1, 10 e 100 reais. Considerando que alguém está pagando uma compra, escreva um algoritmo que mostre o número mínimo de notas que o caixa deve fornecer como troco. Mostre também: o valor da compra, o valor do troco e a quantidade de cada tipo de nota do troco. Suponha que o sistema monetário não utilize moedas. ( 5 pontos)
        double valorCompra, valorPago, valorTroco = 0, valorTrocoDeduzir;
        int notas100 = 0, notas10 = 0, notas1 = 0;

        WriteLine("Qual o valor da compra feita? ");
        valorCompra = ToDouble(ReadLine());
        WriteLine("Qual o valor pago? ");
        valorPago = ToDouble(ReadLine());
        valorTroco = valorPago - valorCompra;
        valorTrocoDeduzir = valorTroco;

        while (true)
            if (valorTrocoDeduzir - 100 >= 0)
            {
                valorTrocoDeduzir -= 100;
                notas100++;
            }
            else if (valorTrocoDeduzir - 10 >= 0)
            {
                valorTrocoDeduzir -= 10;
                notas10++;
            }
            else if (valorTrocoDeduzir - 1 >= 0)
            {
                valorTrocoDeduzir -= 1;
                notas1++;
            }
            else
            {
                WriteLine($"O valor do troco será de {valorTroco}, dividido entre {notas100} notas de R$100, {notas10} notas de R$10 e {notas1} notas de R$1.");
                break;
            }
        break;
    case 4:
        //Uma rainha requisitou os serviços de um monge e disse-lhe que pagaria qualquer preço. O monge, necessitando de alimentos, indagou à rainha sobre o pagamento, se poderia ser feito com grãos de trigo dispostos em um tabuleiro de xadrez(que possui 64 casas), de tal forma que o primeiro quadro deveria conter apenas um grão e os quadros subsequentes, o dobro do quadro anterior. Crie um algoritmo para calcular o total de grãos que o monge recebeu. (4 pontos).
        ulong result = 0;
        ulong multiplicacao = 1;

        for (int i = 1; i <= 64; i++)
        {
            result = result + multiplicacao;
            multiplicacao = multiplicacao * 2;
        }
        WriteLine($"O total de grãos que o monge recebeu foi de: {result}");
        break;
    case 5:
        // Dado o conjunto de instruções a seguir, faça um algoritmo com quatro variações, colocando o comando de repetição adequadamente, de forma a: (8 pontos)
        // a) Executar o conjunto 10 vezes;
        WriteLine("A)");
        for (int i = 1; i <= 10; i++)
        {
            WriteLine(i);
        }

        // b) Não executar nenhuma vez;
        WriteLine("B)");
        while ("vaquinha laranja" == "vaquinha amarela")
        {
            WriteLine("vaquinha vermelha");
        }

        // c) Executar o conjunto 100 vezes utilizando duas estruturas de repetição;
        WriteLine("C)");
        for (int i = 1; i <= 100; i++)
        {  WriteLine(i); }
        
        int jota = 1;
        while (jota < 100)
        { WriteLine(jota); }

        // d) Executar N vezes, onde N é uma variável informada pelo usuário.
        WriteLine("D)");
        int numeroRepeticao;

        WriteLine("Digite até quantos deseja contar: ");
        numeroRepeticao = ToInt32(ReadLine());

        for (int i = 1; i <= numeroRepeticao; i++)
        { WriteLine(i); }

        break;
    case 6:
        //Faça um algoritmo que calcule e imprime a soma dos inteiros de 1 a 10. Utilize as estruturas ENQUANTO-FACA / REPITA - FACA para fazer um laço com as instruções de cálculo e incremento. O laço deve terminar quando o valor de x se tornar 11. (8 pontos).
        int somacase6while = 0;
        int somacase6dowhile = 0;
        int xwhile = 1;
        int xdowhile = 1;

        while (somacase6while < 11)
        {
            WriteLine(somacase6while);
            somacase6while = somacase6while + xwhile;
            xwhile++;
        }

        do
        {
            WriteLine(somacase6dowhile);
            somacase6dowhile = somacase6dowhile + xdowhile;
            xdowhile++;
        } while (somacase6dowhile < 11);
        break;
    case 7:
        // Resolva um exercício da prova anterior a sua escolha. ( 10 pontos)
        // Exercício escolhido: Crie um programa que solicite 40 números e apresente: a média, a soma e o maior.
        int somacase7 = 0;
        int maiorcase7 = int.MinValue;
        int numerocase7;

        for (int i = 0; i < 40; i++)
        {
            WriteLine($"Digite o número {(i + 1)}:");
            numerocase7 = ToInt32(ReadLine());

            somacase7 += numerocase7;

            if (numerocase7 > maiorcase7)
            {
                maiorcase7 = numerocase7;
            }
        }

        double media = somacase7 / 40.0;

        WriteLine($"Soma: {somacase7}");
        WriteLine($"Média: {media}");
        WriteLine($"Maior: {maiorcase7}");
        break;
}
using static System.Console;
using static System.Convert;

/*int[] teste = new int[8];
int[] teste2 = new int[8];
int[] teste3 = new int[8];

for (int i = 0; i < 8; i++)
{
    Console.Write($"Escreva o {i+1}º valor: ");
    teste[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0;i < 8; i++)
{
    teste2[i] = teste[i]*2;
}
for (int i = 0; i<8;i++)
{
    teste3[i] = teste[i] + teste2[i];
}
for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"A soma dos vetores {teste[i]} + {teste2[i]} é de: {teste3[i]}");
}*/

int atividade = 0;

WriteLine($"Digite qual atividade deseja resolver: ");
atividade = ToInt32(ReadLine());

switch (atividade)
{
    case 1:
        int[] vetorCase1 = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Write($"Escreva o {i + 1}º valor: ");
            vetorCase1[i] = ToInt32(ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            WriteLine($"O {i + 1}º valor é {vetorCase1[i]}");
        }
        break;
    case 2:
        int[] vetorCase2 = new int[10];
        int somaCase2 = 0;

        for (int i = 0; i < 10; i++)
        {
            Write($"Escreva o {i + 1}º valor: ");
            vetorCase2[i] = ToInt32(ReadLine());
            somaCase2 += vetorCase2[i];
        }
        WriteLine($"A soma dos valores do vetor é de: {somaCase2}");
        break;
    case 3:
        int[] vetorCase3 = new int[5];
        int maiorCase3 = 0;
        int menorCase3 = 0;

        for (int i = 0; i < 5; i++)
        {
            Write($"Por favor, digite o {i + 1}º valor: ");
            vetorCase3[i] = ToInt32(ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            if (i == 0)
            {
                maiorCase3 = vetorCase3[i];
                menorCase3 = vetorCase3[i];
            }
            else if (vetorCase3[i] < menorCase3)
            {
                menorCase3 = vetorCase3[i];
            }
            else if (vetorCase3[i] > maiorCase3)
            {
                maiorCase3 = vetorCase3[i];
            }
        }
        WriteLine($"O menor valor digitado é {menorCase3}, enquanto o maior valor digitado é {maiorCase3}");
        break;
    case 4:
        int[] vetorCase4 = new int[8];
        int somaCase4 = 0;
        int mediaCase4 = 0;
        int divisorCase4 = 0;

        for (int i = 0; i < 8; i++)
        {
            Write($"Digite o {i}º valor: ");
            vetorCase4[i] = ToInt32(ReadLine());
            somaCase4 += vetorCase4[i];
            divisorCase4 = i;
        }
        mediaCase4 = somaCase4 / divisorCase4;
        WriteLine($"A média dos valores é de: {mediaCase4}");
        break;
    default:
        WriteLine("Digite um valor válido");
        break;
}
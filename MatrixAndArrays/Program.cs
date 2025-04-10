using System.Security.Cryptography;
using static System.Console;
using static System.Convert;

Write("Escolha uma atividade para resolver: ");
int atividade = ToInt32(ReadLine());

switch (atividade)
{
    case 1:
        int tamanho = 20;
        int[,] matrizCase1 = new int[tamanho, tamanho];
        int[] existentes = new int[tamanho * tamanho];
        int numero = 0;
        int contadorExistentes = 0;
        bool existe = false;

        Random random = new Random();

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                numero = random.Next(1, 500);
                for (int k = 0; k < tamanho * tamanho; k++)
                {
                    if (existentes[k] == numero)
                    {
                        existe = true;
                    }
                }
                if (existe == false)
                {
                    existentes[contadorExistentes] = numero;
                    contadorExistentes++;
                    matrizCase1[i, j] = numero;
                }
                else
                {
                    j--;
                    existe = false;
                }
            }
        }

        int linha = 0;
        int coluna = 0;
        existe = false;
        WriteLine("Por favor, escolha um número para descobrir sua posição na matriz.");
        double numeroUsuario = ToInt32(ReadLine());

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (numeroUsuario == matrizCase1[i, j] && existe == false)
                {
                    existe = true;
                    linha = i;
                    coluna = j;
                }
            }

        }
        if (existe)
        {
            WriteLine($"O número escolhido está na linha {linha + 1} e na coluna {coluna + 1}");
        }
        else
        {
            WriteLine("O número escolhido não foi encontrado");
        }
        break;
    case 2:
        double somaProva = 0;
        double[] mediaProva = new double[4];
        double somaAluno = 0;
        double[] mediaAluno = new double[5];
        double[,] matrizCase2 = new double[5, 4];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Write($"Digite a {j + 1}ª nota do {i + 1}º aluno: ");
                matrizCase2[i, j] = ToDouble(ReadLine());
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                somaProva += matrizCase2[j, i];
            }
            mediaProva[i] = somaProva / 5;
            somaProva = 0;
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                somaAluno += matrizCase2[i, j];
            }
            mediaAluno[i] = somaAluno / 4;
            somaAluno = 0;
        }

        WriteLine("\nMatriz de notas por prova e por aluno: ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Write(matrizCase2[i, j] + "\t");
            }
            WriteLine();
        }

        WriteLine("\nMédias de notas obtidas por prova: ");
        for (int i = 0; i < 4; i++)
        {
            WriteLine($"Média da {i+1}º prova: {mediaProva[i]}");
        }

        WriteLine("\nMédias de notas obtidas por aluno: ");
        for (int i = 0; i < 5; i++)
        {
            WriteLine($"Média do {i + 1}º aluno: {mediaAluno[i]}");
        }

        
        break;
    default:
        WriteLine("Só tem a atividade 1 e 2.");
        break;
}
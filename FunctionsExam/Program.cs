
bool finalizar = true;
int atividade = -1;

do
{
    try
    {
        Console.WriteLine("\nMENU DE ATIVIDADES");
        Console.WriteLine("\n1-Inverter um vetor \n2-Média dos números pares em um vetor \n3-Soma das diagonais de uma matriz 3x3 \n4-Soma dos elementos de cada linha de uma matriz 4x4 \n5-Frequência de um número em um vetor \n6-Transposição de uma matriz 3x3 \n\n7-SAIR");
        Console.WriteLine("\nALUNOS: \nDiogo Amaral Negrisoli Pereira - Matrícula n° 2024102060018 \nJhoyan Wellek Macedo Padovan - Matrícula n° 2024102060010");
        atividade = Convert.ToInt32(Console.ReadLine());

        switch (atividade - 1)
        {
            case 0:
                Console.WriteLine("\nINVERTER UM VETOR");
                Console.WriteLine("");
                double[] vetorCase0 = new double[10];

                Console.WriteLine("Informe dez números");
                Console.WriteLine("");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Insira o {i + 1}° número:");
                    vetorCase0[i] = Convert.ToDouble(Console.ReadLine());
                }

                static void InverteVetor(double[] vetorFuncao)
                {
                    int finalCase0 = 9;
                    double[] vetorInvertido = new double[10];
                    for (int i = 0; i < 10; i++)
                    {
                        vetorInvertido[i] = vetorFuncao[finalCase0];
                        finalCase0--;
                    }

                    foreach (double num in vetorInvertido)
                    {
                        Console.Write($"{num} ");
                    }
                }

                Console.WriteLine("Vetor normal: ");
                foreach (double normal in vetorCase0)
                {
                    Console.Write($"{normal} ");
                }

                Console.WriteLine("\n\nVetor invertido: ");
                InverteVetor(vetorCase0);

                Console.WriteLine(" ");
                Console.ReadKey();
                break;

            case 1:
                Console.WriteLine("\nMÉDIA DOS NÚMEROS PARES EM UM VETOR");
                Console.WriteLine(" ");

                double[] vetorCase1 = new double[10];
                Console.WriteLine("Informe dez números");
                Console.WriteLine("");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Insira o {i + 1}° número:");
                    vetorCase1[i] = Convert.ToDouble(Console.ReadLine());
                }

                static void MediaPares(double[] vetorCompleto)
                {
                    int contadorPares = 0;
                    double[] vetorPares = new double[10];
                    double soma = 0;
                    double media = 0;

                    for (int i = 0; i < 10; i++)
                    {
                        if (vetorCompleto[i] % 2 == 0 && vetorCompleto[i] != 0)
                        {
                            vetorPares[i] = vetorCompleto[i];
                            contadorPares++;
                        }
                    }

                    if (contadorPares == 0)
                    {
                        Console.WriteLine("\nNão há nenhum número par no vetor.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            soma += vetorPares[i];
                        }
                        media = soma / contadorPares;

                        Console.WriteLine($"\nA média da soma dos números pares do vetor será: {media}");
                        Console.WriteLine("");
                    }
                }

                MediaPares(vetorCase1);
                Console.ReadKey();
                break;

            case 2:
                Console.WriteLine("\nSOMA DAS DIAGONAIS DE UMA MATRIZ 3X3");
                Console.WriteLine("");

                double[,] numMatriz = new double[3, 3];

                static void Somamatriz(double[,] vetorMatriz)
                {
                    double somaDiagonalSecundaria = 0;
                    double somaDiagonalPrincipal = 0;
                    int j = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        int contador = 0;

                        while (contador < 1)
                        {
                            somaDiagonalPrincipal += vetorMatriz[i, j];
                            contador++;
                        }
                        j++;
                    }

                    j = 0;

                    for (int i = 2; i != -1; i--)
                    {
                        int contador = 0;

                        while (contador < 1)
                        {
                            somaDiagonalSecundaria += vetorMatriz[i, j];
                            contador++;
                        }
                        j++;
                    }

                    if (somaDiagonalPrincipal > somaDiagonalSecundaria)
                    {
                        Console.WriteLine($"\nA soma da diagonal principal é maior que a diagonal secundária!");
                        Console.WriteLine($"\nDiagonal principal: {somaDiagonalPrincipal}");
                        Console.WriteLine($"\nDiagonal secundaria: {somaDiagonalSecundaria}");
                        Console.WriteLine("");
                    }
                    else if (somaDiagonalSecundaria > somaDiagonalPrincipal)
                    {
                        Console.WriteLine($"\nA soma da diagonal secundária é maior que a diagonal principal!");
                        Console.WriteLine($"\nDiagonal principal: {somaDiagonalPrincipal}");
                        Console.WriteLine($"\nDiagonal secundaria: {somaDiagonalSecundaria}");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine($"\nA soma das diagonais são iguais!");
                        Console.WriteLine($"\nDiagonal principal: {somaDiagonalPrincipal}");
                        Console.WriteLine($"\nDiagonal secundaria: {somaDiagonalSecundaria}");
                        Console.WriteLine("");
                    }

                }

                Console.WriteLine("Insira os números de uma matriz 3x3");
                Console.WriteLine("");

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Insira o número da {i + 1}° linha, coluna {j + 1}:");
                        numMatriz[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }

                Somamatriz(numMatriz);
                Console.ReadKey();
                break;

            case 3:
                Console.WriteLine("\nSOMA DOS ELEMENTOS DE CADA LINHA DE UMA MATRIZ 4X4");
                Console.WriteLine("");

                Console.WriteLine("Informe os números para compor a matriz");
                double[,] matrizNum = new double[4, 4];

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"Informe o número da {i + 1}° linha, {j + 1}° coluna: ");
                        matrizNum[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }

                static void SomaLinhas(double[,] vetor)
                {
                    double[] vetorSoma = new double[4];

                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            vetorSoma[i] += vetor[i, j];
                        }
                    }

                    Console.WriteLine("\nA soma dos elementos de cada linha da matriz será: ");

                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"{i + 1}° linha: {vetorSoma[i]}");
                    }
                    Console.WriteLine(" ");
                }

                SomaLinhas(matrizNum);
                Console.ReadKey();
                break;

            case 4:
                Console.WriteLine("\nFREQUÊNCIA DE UM NÚMERO EM UM VETOR");
                Console.WriteLine(" ");

                double[] vetorUsuario = new double[10];
                double numUsuario = 0;

                Console.WriteLine("Informe 10 números para preencher o vetor");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"\nDigite o {i + 1}° número: ");
                    vetorUsuario[i] = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("\nDigite um número para ver a frequência que ele aparece no vetor");
                numUsuario = Convert.ToDouble(Console.ReadLine());

                static void FrequenciaElementos(double[] vetor, double num)
                {
                    int contador = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        if (num == vetor[i])
                        {
                            contador++;
                        }
                    }

                    Console.WriteLine($"O número {num} aparece {contador} vezes no vetor.");
                    Console.WriteLine(" ");
                }

                FrequenciaElementos(vetorUsuario, numUsuario);

                Console.ReadKey();
                break;

            case 5:
                Console.WriteLine("\nTRANSPOSIÇÃO DE UMA MATRIZ 3X3");
                Console.WriteLine("");

                double [,] num = new double[3,3];

                Console.WriteLine("Informe os números para preencher uma matriz 3x3");
                for(int i = 0;i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        Console.Write($"\nInforme o número da {i + 1}° linha, {j + 1}° coluna: ");
                        num[i,j] = Convert.ToDouble(Console.ReadLine());
                    }
                }

                static void TransporMatriz(double[,] matriz)
                {
                    double[,] matrizTransposta = new double[3, 3];

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            matrizTransposta[j, i] = matriz[i, j];
                        }
                    }

                    Console.WriteLine("Transposta:");
                    for (int i = 0;i < 3; i++)
                    {
                        for(int j = 0;j < 3; j++)
                        {
                            Console.Write($"{matrizTransposta[i,j]} "); 
                        }
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(" ");
                }

                Console.WriteLine($"\nOriginal: ");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"{num[i,j]} ");
                    }
                    Console.WriteLine("");
                }
                TransporMatriz(num);

                Console.ReadKey();
                break;

            case 6:
                finalizar = false;
                break;

            default:
                Console.WriteLine("\nDigite apenas o número das atividades aparentes.");
                Console.WriteLine("");
                break;
        }
    }
    catch (System.FormatException)
    {
        Console.WriteLine("\nDigite apenas números.");
        Console.WriteLine("");
    }
} while (finalizar);
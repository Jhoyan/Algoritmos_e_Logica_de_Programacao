using static System.Convert;
using static System.Console;

string atividade;
Write("Digite a atividade que deseja resolver: ");
atividade = ReadLine();

switch (atividade)
{
    case "1":


        int linhasCaseUm = 4;
        int colunasCaseUm = 4;
        int maiorCaseUm = 0;
        int menorCaseUm = 0;
        int somaCaseUm = 0;

        int[,] matrizCaseUm = new int[4, 4];


        for (int i = 0; i < linhasCaseUm; i++)
        {
            for (int j = 0; j < colunasCaseUm; j++)
            {
                Write($"Digite o valor da linha {i} e coluna {j}: ");
                matrizCaseUm[i, j] = ToInt32(ReadLine());
            }
        }

        for (int i = 0; i < linhasCaseUm; i++)
        {
            for (int j = 0; j < colunasCaseUm; j++)
            {
                if (matrizCaseUm[i, j] > maiorCaseUm)
                {
                    maiorCaseUm = matrizCaseUm[i, j];
                }
                else if (matrizCaseUm[i, j] < menorCaseUm)
                {
                    menorCaseUm = matrizCaseUm[i, j];
                }
            }
        }
        somaCaseUm = maiorCaseUm + menorCaseUm;
        WriteLine($"O maior valor da matriz é {maiorCaseUm} e o menor valor é {menorCaseUm} e a soma entre eles é: {somaCaseUm}");
        break;
    case "2":
        int linhasMatrizUmCaseDois = 4;
        int linhasMatrizDoisCaseDois = 4;
        int colunasMatrizUmCaseDois = 4;
        int colunasMatrizDoisCaseDois = 4;
        int somaCaseDois = 0;

        int[,] matrizUmCaseDois = new int[linhasMatrizUmCaseDois, colunasMatrizUmCaseDois];
        int[,] matrizDoisCaseDois = new int[linhasMatrizDoisCaseDois, colunasMatrizDoisCaseDois];

        for (int i = 0; i < linhasMatrizUmCaseDois; i++)
        {
            for (int j = 0; j < colunasMatrizUmCaseDois; j++)
            {
                Write($"Digite o valor da linha {i + 1}, coluna {j + 1} da primeira matriz: ");
                matrizUmCaseDois[i, j] = ToInt32(ReadLine());
                somaCaseDois += matrizUmCaseDois[i, j];
            }
        }

        for (int i = 0; i < linhasMatrizDoisCaseDois; i++)
        {
            for (int j = 0; j < colunasMatrizDoisCaseDois; j++)
            {
                Write($"Digite o valor da linha {i + 1}, coluna {j + 1} da segunda matriz: ");
                matrizDoisCaseDois[i, j] = ToInt32(ReadLine());
                somaCaseDois += matrizDoisCaseDois[i, j];
            }
        }
        WriteLine($"A soma dos valores das matrizes é de: {somaCaseDois}");
        break;
    case "3":
        int linhasMatrizACaseTres = 2;
        int linhasMatrizBCaseTres = 2;
        int colunasMatrizACaseTres = 2;
        int colunasMatrizBCaseTres = 2;
        int indiceInterseccao = 0;

        int[] interseccao = new int[linhasMatrizACaseTres * colunasMatrizACaseTres];
        int[,] matrizACaseTres = new int[linhasMatrizACaseTres, colunasMatrizACaseTres];
        int[,] matrizBCaseTres = new int[linhasMatrizBCaseTres, colunasMatrizBCaseTres];

        for (int i = 0; i < linhasMatrizACaseTres; i++)
        {
            for (int j = 0; j < colunasMatrizACaseTres; j++)
            {
                Write($"Digite o valor da linha {i + 1}, coluna {j + 1} da primeira matriz: ");
                matrizACaseTres[i, j] = ToInt32(ReadLine());
            }
        }

        for (int i = 0; i < linhasMatrizBCaseTres; i++)
        {
            for (int j = 0; j < colunasMatrizBCaseTres; j++)
            {
                Write($"Digite o valor da linha {i + 1}, coluna {j + 1} da segunda matriz: ");
                matrizBCaseTres[i, j] = ToInt32(ReadLine());
            }
        }
        for (int i = 0; i < linhasMatrizACaseTres; i++)
        {
            for (int j = 0; j < colunasMatrizACaseTres; j++)
            {
                for (int k = 0; k < linhasMatrizBCaseTres; k++)
                {
                    for (int l = 0; l < colunasMatrizBCaseTres; l++)
                    {

                        if (matrizACaseTres[i, j] == matrizBCaseTres[k, l])
                        {
                            bool existe = false;

                            for (int m = 0; m < indiceInterseccao; m++)
                            {
                                if (interseccao[m] == matrizBCaseTres[k, l] && existe == false)
                                    existe = true;
                            }
                            if (!existe)
                            {
                                interseccao[indiceInterseccao] = matrizBCaseTres[k, l];
                                indiceInterseccao++;
                            }
                        }
                    }
                }
            }
        }
        for (int i = 0; i < indiceInterseccao; i++)
        {
            WriteLine(interseccao[i]);
        }
        break;
}
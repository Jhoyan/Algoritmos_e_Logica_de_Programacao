using static System.Console;
using static System.Convert;

string atividade;

Write("Seja bem-vindo.\nDigite a atividade que deseja resolver: ");
atividade = ReadLine();

switch (atividade)
{
    case "1":
        int numeroCase1 = 0;
        int[] vetorCase1 = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Write($"Digite o {i + 1}º valor: ");
            numeroCase1 = ToInt32(ReadLine());
            vetorCase1[i] = numeroCase1;
        }
        for (int i = vetorCase1.Length - 1; i >= 0; i--)
        {
            WriteLine(vetorCase1[i]);
        }
        break;
    case "2":
        int[] vetor1Case2 = new int[20];
        int[] vetor2Case2 = new int[20];
        int[] vetorSubCase2 = new int[20];
        int[] vetorAdiCase2 = new int[20];
        int[] vetorMultiCase2 = new int[20];
        int numeroRandomCase2 = 0;
        Random rand = new Random();

        for (int i = 0; i < 20; i++)
        {
            numeroRandomCase2 = rand.Next(0, 50);
            Write($"O [i]º valor gerado foi: {numeroRandomCase2}");
            vetor1Case2[i] = numeroRandomCase2;
        }
        for (int i = 0; i < 20; i++)
        {
            numeroRandomCase2 = rand.Next(0, 50);
            Write($"O [i]º valor gerado foi: {numeroRandomCase2}");
            vetor2Case2[i] = numeroRandomCase2;
        }
        for (int i = 0; i < 20; i++)
        {
            vetorSubCase2[i] = vetor1Case2[i] - vetor2Case2[i];

            vetorAdiCase2[i] = vetor1Case2[i] + vetor2Case2[i];

            vetorMultiCase2[i] = vetor1Case2[i] * vetor2Case2[i];

        }
        WriteLine("\n\nSUBTRAÇÃO: ");
        for (int i = 0; i < 20; i++)
        {
            WriteLine($"{vetor1Case2[i]} - {vetor2Case2[i]} = {vetorSubCase2[i]}");
        }
        WriteLine("\n\nADIÇÃO: ");
        for (int i = 0; i < 20; i++)
        {
            WriteLine($"{vetor1Case2[i]} + {vetor2Case2[i]} = {vetorAdiCase2[i]}");
        }
        WriteLine("\n\nMULTIPLICAÇÃO: ");
        for (int i = 0; i < 20; i++)
        {
            WriteLine($"{vetor1Case2[i]} * {vetor2Case2[i]} = {vetorMultiCase2[i]}");
        }
        break;
    case "3":
        int tamanhoVetoresCase4 = 5;
        int[] vetor1Case4 = new int[tamanhoVetoresCase4];
        int[] vetor2Case4 = new int[tamanhoVetoresCase4];
        int[] vetor3Case4 = new int[tamanhoVetoresCase4 * 2];
        int qtd1Case4 = 0;
        int qtd2Case4 = 0;
        Random randomCase4 = new Random();


        for (int i = 0; i < tamanhoVetoresCase4; i++)
        {
            vetor1Case4[i] = randomCase4.Next(1, 5);
            vetor2Case4[i] = randomCase4.Next(1, 5);
        }        

        Write("Os números do primeiro vetor são: ");
        for (int i = 0; i < tamanhoVetoresCase4; i++)
        {
            Write($"{vetor1Case4[i]} -");
        }

        Write("Os números do segundo vetor são: ");
        for (int i = 0; i < tamanhoVetoresCase4; i++)
        {
            Write($"{vetor2Case4[i]} -");
        }

        for (int i = 0; i < tamanhoVetoresCase4 * 2; i++)
        {
            if (i == 0 || i % 2 == 0)
            {
                vetor3Case4[i] = vetor1Case4[qtd1Case4];
                qtd1Case4++;
            }
            else
            {
                vetor3Case4[i] = vetor2Case4[qtd2Case4];
                qtd2Case4++;
            }
            WriteLine($"\n{vetor3Case4[i]}");
        }
        


        /*
        for (int i = 0; i < 10; i++)
        {           
            vetor3Case4[i*2] = vetor1Case4[qtd1Case4];
            qtd1Case4++;
            vetor3Case4[i*2 + 1] = vetor2Case4[qtd2Case4];
            qtd2Case4++;
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(vetor3Case4[i]);
        } */
        break;

}
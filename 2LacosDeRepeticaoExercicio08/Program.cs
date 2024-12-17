using static System.Console;
using static System.Convert;

double nota1 = 0.0, nota2 = 0.0, media = 0.0;
string mensagem;
int continuar;

do
{
    WriteLine("Digite a nota 1: ");
    nota1 = ToDouble(ReadLine());

    WriteLine("Digite a nota 2: ");
    nota2 = ToDouble(ReadLine());

    media = (nota1 + nota2) / 2.0;

    if (media >= 0.0 && media < 5.0)
    {
        mensagem = "Reprovado";
    }
    else if (media >= 5.0 && media < 7.0)
    {
        mensagem = "Exame";
    }
    else if (media >= 7.0 && media <= 10.0)
    {
        mensagem = "Aprovado";
    }
    else
    {
        mensagem = "Tem alguma coisa errada nessa nota aí";
    }

    WriteLine($"Média: {media:F2} - {mensagem}");

    WriteLine("Digite 0 para sair ou outro número para continuar: ");
    continuar = ToInt32(ReadLine());
}
while (continuar != 0);

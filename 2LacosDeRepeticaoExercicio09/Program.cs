using static System.Console;
using static System.Convert;

string nomeProduto;
double precoCusto, novoPreco;
int continuar;

do
{
    WriteLine("Digite o nome do produto: ");
    nomeProduto = ReadLine();

    WriteLine("Digite o preço de custo do produto: ");
    precoCusto = ToDouble(ReadLine());

    novoPreco = precoCusto * 1.15;

    WriteLine($"O produto {nomeProduto} terá um preço novo de {novoPreco:F2}\nDigite 0 para sair ou outro número para continuar: ");
    continuar = ToInt32(ReadLine());
}
while (continuar != 0);

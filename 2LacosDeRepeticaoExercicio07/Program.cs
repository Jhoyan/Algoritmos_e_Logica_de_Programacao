using static System.Console;
using static System.Convert;

string nome;
int salario;
int continuar = 0;

do
{
    WriteLine("Digite o nome do funcionário: ");
    nome = ReadLine();

    WriteLine("Digite o salário do funcionário: ");
    salario = ToInt32(ReadLine());

    if (salario >= 1000)
    {
        WriteLine($"Funcionário: {nome}, Salário: R$ {salario}");
    }

    WriteLine("Deseja digitar outro funcionário? (Digite 0 para encerrar): ");
    continuar = ToInt32(ReadLine());

} while (continuar != 0);

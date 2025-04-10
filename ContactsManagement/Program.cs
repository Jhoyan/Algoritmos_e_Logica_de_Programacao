// Diogo Amaral Negrisoli Pereira - 2024102060018
// Jhoyan Wellek Macedo Padovan - 2024102060010

bool encerramento = true;
List<(string nome, string numero)> listaContatos = new List<(string nome, string numero)>();

while (encerramento)
{
    int atividade = 0;

    Console.WriteLine("MENU INICIAL\n");
    Console.WriteLine("1 - Adicionar Contato\n2 - Buscar Contato\n3 - Listar Contatos\n4 - Remover Contatos\n5 - Sair do Programa");

    atividade = Convert.ToInt32(Console.ReadLine());

    switch (atividade)
    {
        case 1:
            AdicionarContato();
            break;

        case 2:
            BuscarContato();
            break;

        case 3:
            ListarContatos();
            break;

        case 4:
            RemoverContatos();
            break;

        case 5:
            encerramento = false;
            break;

        default:
            Console.WriteLine("Digite apenas os números presentes.");
            break;
    }
}

void AdicionarContato()
{
    Console.WriteLine("\nADICIONAR CONTATO\n");
    Console.WriteLine("Nome: ");
    string nomeAdd = Console.ReadLine();
    Console.WriteLine("Número: ");
    string numeroAdd = Console.ReadLine();

    (string nome, string numero) tuplaContato = (nomeAdd, numeroAdd);

    listaContatos.Add(tuplaContato);
    Console.WriteLine("");
}

void BuscarContato()
{
    Console.WriteLine("\nBUSCAR CONTATO\n");
    Console.WriteLine("Nome: ");
    string nome = Console.ReadLine();

    (string, string) contato = listaContatos.Find(x => x.nome == nome);

    if (nome == contato.Item1)
    {
        Console.WriteLine("Contato Localizado:\n");
        Console.WriteLine($"Nome: {contato.Item1} | Número: {contato.Item2}");
    }
    else
    {
        Console.WriteLine("Contato NÃO Localizado.");
    }
    Console.WriteLine("");
}

void ListarContatos()
{
    Console.WriteLine("\nLISTAR CONTATOS\n");

    Console.WriteLine("Contatos salvos:");

    List<string> exibirContatos = listaContatos.Select(x => $"{x.nome} | {x.numero}").ToList();

    foreach (string exibir in exibirContatos)
    {
        Console.WriteLine(exibir);
    }
    Console.WriteLine("");
}

void RemoverContatos()
{
    Console.WriteLine("\nREMOVER CONTATO\n");
    Console.WriteLine("Nome: ");
    string nomeRemove = Console.ReadLine();

    (string, string) contato = listaContatos.Find(x => x.nome == nomeRemove);

    if (nomeRemove == contato.Item1)
    {
        listaContatos.Remove((contato.Item1, contato.Item2));
        Console.WriteLine("Contato Removido!\n");
    }
    else
    {
        Console.WriteLine("Contato NÃO Localizado.");
    }
    Console.WriteLine("");
}
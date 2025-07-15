int opcao;

    do
        {
            ExibirMenu();

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1: CadItem("frutas.csv"); break;
                    case 2: CadItem("legumes.csv"); break;
                    case 3: CadItem("verduras.csv"); break;
                    case 4: ExibirItens("frutas.csv"); break;
                    case 5: BuscarItem("frutas.csv"); break;
                    case 6: ModificarQuantidade("frutas.csv"); break;
                    case 7: LimparArquivo("frutas.csv"); break;
                    case 8: Console.WriteLine("Saindo..."); break;
                    default: Console.WriteLine("Opção inválida."); break;
                }
            }
            else
            {
                Console.WriteLine("Entrada não reconhecida.");
            }

            Console.ReadKey();
            Console.Clear();

        } while (opcao != 8);

    void ExibirMenu()
    {
        Console.WriteLine("Menu de Colheita:");
        Console.WriteLine("1 - Cadastrar Fruta");
        Console.WriteLine("2 - Cadastrar Legume");
        Console.WriteLine("3 - Cadastrar Verdura");
        Console.WriteLine("4 - Exibir Frutas");
        Console.WriteLine("5 - Buscar Fruta");
        Console.WriteLine("6 - Modificar Quantidade de Fruta");
        Console.WriteLine("7 - Limpar Arquivo de Frutas");
        Console.WriteLine("8 - Sair");
        Console.Write("Escolha uma opção: ");
    }

    void CadItem(string caminho)
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine()?.ToLower();
        Console.Write("Digite a quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        string conteudo = File.Exists(caminho) ? File.ReadAllText(caminho) : "";

        if (conteudo.Contains($"{nome}|"))
        {
            Console.WriteLine("Item já cadastrado.");
        }
        else
        {
            File.AppendAllText(caminho, $"{nome}|{quantidade},");
            Console.WriteLine("Item cadastrado com sucesso!");
        }
    }

    void ExibirItens(string caminho)
{
    if (File.Exists(caminho))
    {
        string[] itens = File.ReadAllText(caminho).Split(',');

        for (int i = 0; i < itens.Length; i++)
        {
            if (!string.IsNullOrWhiteSpace(itens[i]))
            {
                var partes = itens[i].Split('|');
                Console.WriteLine($"Item: {partes[0]} - Quantidade: {partes[1]}");
            }
        }
    }
    else
    {
        Console.WriteLine("Arquivo não encontrado.");
    }
}


    void BuscarItem(string caminho)
{
    Console.Write("Digite o nome do item para buscar: ");
    string nomeBuscado = Console.ReadLine()?.ToLower();

    if (!File.Exists(caminho)) return;

    string[] itens = File.ReadAllText(caminho).Split(',');

    var encontrado = itens.FirstOrDefault(item =>
        !string.IsNullOrWhiteSpace(item) &&
        item.StartsWith($"{nomeBuscado}|"));

    Console.WriteLine(encontrado != null ? $"Encontrado: {encontrado}" : "Item não encontrado.");
}


    void ModificarQuantidade(string caminho)
    {
        Console.Write("Digite o nome do item a modificar: ");
        string nome = Console.ReadLine()?.ToLower();
        Console.Write("Nova quantidade: ");
        int novaQtd = int.Parse(Console.ReadLine());

        if (!File.Exists(caminho)) return;

        var itens = File.ReadAllText(caminho).Split(',').ToList();
        bool alterado = false;

        for (int i = 0; i < itens.Count; i++)
        {
            if (!string.IsNullOrWhiteSpace(itens[i]) && itens[i].StartsWith($"{nome}|"))
            {
                itens[i] = $"{nome}|{novaQtd}";
                alterado = true;
                break;
            }
        }

        if (alterado)
        {
            File.WriteAllText(caminho, string.Join(",", itens.Where(i => !string.IsNullOrWhiteSpace(i))) + ",");
            Console.WriteLine("Quantidade atualizada com sucesso.");
        }
        else
        {
            Console.WriteLine("Item não encontrado!");
        }
    }

    void LimparArquivo(string caminho)
    {
        if (File.Exists(caminho))
        {
            File.WriteAllText(caminho, "");
            Console.WriteLine("Arquivo limpo.");
        }
        else
        {
            Console.WriteLine("Arquivo inexistente.");
        }
    }

int opcao = 0;

do
{
    ExibirMenu();

    if (int.TryParse(Console.ReadLine(), out opcao))
    {
        switch (opcao)
        {
            case 1:
                CadFruta();
                Console.ReadKey();
                break;
            case 2:
                CadLegume();
                Console.ReadKey();
                break;
            case 3:
                CadVerdura();
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Escolha uma opção válida");
                Console.ReadKey();
                break;
        }
    }
    else
    {
        Console.WriteLine("Não é uma opção válida, tente novamente");
        Console.ReadKey();
    }

} while (opcao != 3);

void ExibirMenu()
{
    Console.Clear();
    Console.WriteLine("Escolha qual produto gostaria de cadastrar");
    Console.WriteLine("1 - Frutas");
    Console.WriteLine("2 - Legumes");
    Console.WriteLine("3 - Verduras");
    Console.Write("Escolha uma opção: ");
}

void CadFruta()
{
    Console.WriteLine("Digite a fruta desejada: ");
    string frutas = Console.ReadLine();

    if (frutas != "")
    {
    }
    else
    {
        Console.WriteLine("Fruta inválida");
    }

    SalvarFrutas(frutas);
}

void CadLegume()
{
    Console.WriteLine("Digite o Legume desejado: ");
    string legumes = Console.ReadLine();

    if (legumes != "")
    {
    }
    else
    {
        Console.WriteLine("Legume inválido");
    }

    SalvarLegumes(legumes);
}

void CadVerdura()
{
    Console.WriteLine("Digite a Verdura desejada: ");
    string verduras = Console.ReadLine();

    if (verduras != "")
    {
        
    }
    else
    {
        Console.WriteLine("Verdura inválida");
    }

    SalvarVerduras(verduras);
}

void SalvarFrutas(string paramFrutas)
{
    string caminho = "frutas.csv";

    if (File.Exists(caminho))
    {
        string conteudo = File.ReadAllText(caminho);

        ContemFruta(paramFrutas, conteudo, caminho);
    }
}

void ContemFruta(string paramFrutas1, string paramConteudo, string paramCaminho)
{
    if(paramConteudo.Contains(paramFrutas1))
    {
        Console.WriteLine("Digite outra fruta, fruta já cadastrada!");
    }
    else
    {
        Console.WriteLine($"{paramFrutas1} cadastrada com sucesso!");
        File.WriteAllText(paramCaminho, paramConteudo + $"{paramFrutas1}, ");
    }
}

void SalvarLegumes(string paramLegumes)
{
    string caminho = "legumes.csv";

    if (File.Exists(caminho))
    {
        string conteudo = File.ReadAllText(caminho);

        ContemLegume(paramLegumes, conteudo, caminho);
    }
}

void ContemLegume(string paramLegumes1, string paramConteudo, string paramCaminho)
{
    if(paramConteudo.Contains(paramLegumes1))
    {
        Console.WriteLine("Digite outro legume, legume já cadastrada!");
    }
    else
    {
        Console.WriteLine($"{paramLegumes1} cadastrado com sucesso!");
        File.WriteAllText(paramCaminho, paramConteudo + $"{paramLegumes1}, ");
    }
}

void SalvarVerduras(string paramVerduras)
{
    string caminho = "verduras.csv";

    if (File.Exists(caminho))
    {
        string conteudo = File.ReadAllText(caminho);

        ContemVerdura(paramVerduras, conteudo, caminho);
    }
}

void ContemVerdura(string paramVerduras1, string paramConteudo, string paramCaminho)
{
    if(paramConteudo.Contains(paramVerduras1))
    {
        Console.WriteLine("Digite outra verdura, verdura já cadastrada!");
    }
    else
    {
        Console.WriteLine($"{paramVerduras1} cadastrada com sucesso!");
        File.WriteAllText(paramCaminho, paramConteudo + $"{paramVerduras1}, ");
    }
}
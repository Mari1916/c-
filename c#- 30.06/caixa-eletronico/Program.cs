using System.ComponentModel.DataAnnotations;

double saldo = 0;
int opcao = 0;

do
{
    ExibirMenu();

    if (int.TryParse(Console.ReadLine(), out opcao))
    {
        switch (opcao)
        {
            case 1:
                ExibirSaldo();
                Console.ReadKey();
                break;
            case 2:
                Depositar();
                Console.ReadKey();
                break;
            case 3:
                Sacar();
                Console.ReadKey();
                break;
            case 4:
                Extrato();
                Console.ReadKey();
                break;
            case 5:
                Console.WriteLine("Sair");
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

} while (opcao != 5);

void ExibirMenu()
{
    Console.Clear();
    Console.WriteLine("Selicione uma das opções a baixo:");
    Console.WriteLine("1 - Saldo");
    Console.WriteLine("2 - depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Extrato");
    Console.WriteLine("5 - Sair");
}

void ExibirSaldo()
{
    if (saldo < 0)
    {
        Console.WriteLine($"Saldo atual > R$ {saldo} 😰");
    }
    else
    {
        Console.WriteLine($"Saldo atual > R$ {saldo} 😁");
    }
}

void Depositar()
{
    double deposito;

    if (double.TryParse(Console.ReadLine(), out deposito))
    {
        saldo = saldo + deposito;
    }
    else
    {
        Console.WriteLine("Valor para depósito inválido.");
    }

    SalvarOperacao(deposito, "deposito");

}

void Sacar()
{
    double saque;

    if (double.TryParse(Console.ReadLine(), out saque))
    {
        saldo = saldo - saque;
    }
    else
    {
        Console.WriteLine("Valor para depósito inválido.");
    }

    SalvarOperacao(saque, "saque");
}

void SalvarOperacao(double paramDeposito, string operacao)
{
    string caminho = "extrato.txt";

    if (File.Exists(caminho))
    {
    string conteudo = File.ReadAllText(caminho);

    File.WriteAllText(caminho, conteudo + $"\"{operacao}: R$ {paramDeposito}\",");
    }
}

void Extrato()
{
    string caminho = "extrato.txt";

    if (File.Exists(caminho))
    {
        string conteudo = File.ReadAllText(caminho);

        string[] transacoes = conteudo.Split("\",\"");

        for (int cont = 0; cont < transacoes.Length; cont++)
        {
            Console.WriteLine(transacoes[cont]);
        }
    }
}

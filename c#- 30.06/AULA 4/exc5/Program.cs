Console.WriteLine("Digite seu nome, e-mail e telefone:");
string entrada = Console.ReadLine();

// Divide com base nas vírgulas
string[] dados = entrada.Split(',');


if (dados.Length == 3)
{
    string nome = dados[0].Trim();
    string email = dados[1].Trim();
    string telefone = dados[2].Trim();

    // Exibe os dados formatados
    Console.WriteLine("Cadastro realizado com sucesso:");
    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"E-mail: {email}");
    Console.WriteLine($"Telefone: {telefone}");
}
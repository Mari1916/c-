Console.WriteLine("Digite seu nome completo");
string nomeCompleto = Console.ReadLine();

//As requisições
int contagem = nomeCompleto.Trim().Length;
bool verificacao = nomeCompleto.Contains("Silva");
//Negocio do nome
string[] divisao = nomeCompleto.Split(' ');
string primeiroNome = divisao[0];

Console.WriteLine($"A quantidade de caracteres nesse nome é:  {contagem}");
Console.WriteLine($"Contém o sobrenome Silva no seu nome?  {verificacao}");
Console.WriteLine($"Seu primeiro nome é:  {primeiroNome}");
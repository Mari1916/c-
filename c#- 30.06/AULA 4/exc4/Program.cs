Console.WriteLine("Digite uma frase:");
string frase = Console.ReadLine();

//Veirificações
bool comeco = frase.StartsWith("Olá");
bool final = frase.EndsWith("!");
int verificacao = frase.IndexOf("C#");

Console.WriteLine($"A frase começa com 'Ola'? {comeco}" );
Console.WriteLine($"A frase termina com '!'? {final}" );
Console.WriteLine($"A frase contém a palavra 'C#'? {verificacao}" );
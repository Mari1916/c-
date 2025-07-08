Console.Write("Digite sua senha");
string senha = Console.ReadLine();

string senhaCorreta = "1234";

while (senha != senhaCorreta)
{
    Console.WriteLine("Tente Novamente ");
    Console.Write("Digite a senha: ");
    senha = Console.ReadLine();
}
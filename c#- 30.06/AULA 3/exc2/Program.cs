int n;

Console.Write("Digite um número inteiro positivo: ");
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Somente os inteiros amigão!");
}

int soma = 0;

for (int i = 1; i <= n; i++)
{
    soma += i;
}

Console.WriteLine($"A soma de todos os números de 1 até {n} é {soma}.");
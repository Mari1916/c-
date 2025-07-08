double valor;

do
{
    Console.Write("Digite um valor (ou 0 para sair): ");
    valor = Convert.ToDouble(Console.ReadLine());

    if (valor != 0)
    { 
        double resultado = valor * 0.25;
        Console.WriteLine($"25% de {valor} é {resultado}\n");
    }

} while (valor != 0);

Console.WriteLine("Programa encerrado.");
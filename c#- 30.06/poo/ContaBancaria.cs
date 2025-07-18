namespace poo;

class ContaBancaria
{
    public string numero;
    public string titular;
    public double saldo;
    



    public void Depositar(double deposito)
    {
        Console.WriteLine("O valor a ser depositado é: 100");

        if (deposito > 0)
        {
            saldo = saldo + deposito;
        }
        else
        {
            Console.WriteLine("Valor para depósito inválido.");
        }
    }

    public void Sacar(double saque)
    {
        Console.WriteLine("O valor a ser sacado é: 50");
        
        if (saque > 0)
        {
            saldo = saldo - saque;
        }
        else
        {
            Console.WriteLine("Valor para depósito inválido.");
        }

    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"O saldo é {saldo}");
    }

}
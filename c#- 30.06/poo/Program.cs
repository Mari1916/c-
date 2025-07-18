namespace poo;

class Program
{
    static void Main(string[] args)
    {
        Pessoa joao = new Pessoa(); // Criar novo obj
        Pessoa jose = new Pessoa();

        jose.nome = "José";
        jose.idade = 29;

        Console.Clear();

        joao.Falar();
        jose.Falar();

        Carro bumblebee = new Carro();
        bumblebee.marca = "Chevrolet";
        bumblebee.modelo = "Camaro";
        bumblebee.ano = 2010;
        bumblebee.Ligar();
        bumblebee.Ligar();
        bumblebee.Desligar();
        bumblebee.Desligar();
        bumblebee.Info();

        ContaBancaria josivaldo = new ContaBancaria();
        josivaldo.numero = "123456-7";
        josivaldo.titular = "Josivaldo da Silva";
        josivaldo.saldo = 100;
        josivaldo.MostrarSaldo();
        josivaldo.Depositar(100);
        josivaldo.Sacar(50);
        josivaldo.MostrarSaldo();

    }
}

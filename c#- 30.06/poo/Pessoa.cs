namespace  poo;

class Pessoa
{
    //Definindo o atributo "Nome", e atribuindo valor "joao"
    public string nome = "João";
    public int idade;
    public string email;

    public void Falar()
    {
        Console.WriteLine($"{nome} está falando!");
    }
}
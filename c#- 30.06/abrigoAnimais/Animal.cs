namespace abrigoAnimais;

class Animal
{
    public string Nome;
    public string Especie;
    public int Idade;

    public Animal(string paramNome, string paramEspecie)
    {
        Nome = paramNome;
        Especie = paramEspecie;
    }

    public void Comer()
    {
        Console.WriteLine($"{Nome} esta comendo");
    }

    public void Brincar(string brinquedo)
    {
        Console.WriteLine($"{Nome} está brincando com {brinquedo}");
    }

    public string EspecieBicho()
    {
        return "A espécie do bichinho é " + Especie;
    }
}
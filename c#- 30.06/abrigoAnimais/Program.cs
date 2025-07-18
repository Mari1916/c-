namespace abrigoAnimais;

class Program
{
    static void Main(string[] args)
    {
        Abrigo LarDosBichinhos = new Abrigo();
        LarDosBichinhos.Nome = "Lar dos Bichinhos Felizes";
        LarDosBichinhos.Capacidade = 54;
        LarDosBichinhos.Endereco = "Rua dos cães, 120";
        LarDosBichinhos.Especies[0] = "Cachorro";
        LarDosBichinhos.Especies[1] = "Gato";
        LarDosBichinhos.Especies[2] = "Papagaio";
        LarDosBichinhos.Especies[3] = "Cobra";

        Animal Pompom = new Animal("Pompom", "Cachorro");

        Pompom.Idade = 12;
        Pompom.Comer();
        Pompom.Brincar("Bola");
        string EspecieAnimal = Pompom.EspecieBicho();

        Console.WriteLine(Pompom.Nome);
        Console.WriteLine(Pompom.Especie);
    }
}

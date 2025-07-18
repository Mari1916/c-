namespace calculo_retangulo;

class Program
{
    static void Main(string[] args)
    {
        Retangulo Calculo = new Retangulo();
        Calculo.Base = 10;
        Calculo.Altura = 20;

        string Area = Calculo.CalcularArea();

        Console.WriteLine(Area);
    }
    
}

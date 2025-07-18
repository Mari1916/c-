namespace calculo_garrafa;

class Program
{
    static void Main(string[] args)
    {
        Garrafa Calculo = new Garrafa();
        Calculo.QuantidadeEmLitros = 10;
        
        string ML = Calculo.CalcularMililitros();

        Calculo.QuantidadeEmMililitros = ML;
        

        Console.WriteLine(ML);
    }
}

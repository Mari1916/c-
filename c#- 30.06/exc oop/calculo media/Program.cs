namespace calculo_media;

class Program
{
    static void Main(string[] args)
    {
        CalculoDeMedia Calculo = new CalculoDeMedia();
        Calculo.Notas[0] = 7;
        Calculo.Notas[1] = 9;

        string calc = Calculo.CalcularMedia();

        Calculo.Media = calc;

        Console.WriteLine(calc);

    }
}

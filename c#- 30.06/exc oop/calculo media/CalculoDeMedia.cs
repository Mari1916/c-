namespace calculo_media;

class CalculoDeMedia
{
    public int[] Notas = new int[2];
    public string Media;

    public string CalcularMedia()
    {
        double calculo = (Notas[0] + Notas[1]) / 2;
        return $"As médias das notas {Notas[0]} e {Notas[1]} é {calculo}";
    }
}
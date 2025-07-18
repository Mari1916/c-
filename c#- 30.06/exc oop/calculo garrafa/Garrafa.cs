namespace calculo_garrafa;

class Garrafa
{
    public int QuantidadeEmLitros;
    public string QuantidadeEmMililitros;
    public string CalcularMililitros()
    {
        double ml = QuantidadeEmLitros * 1000;
        return "Em ml é igal á: " + ml;
    }
}
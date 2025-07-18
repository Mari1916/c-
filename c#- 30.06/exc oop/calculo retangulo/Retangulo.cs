namespace calculo_retangulo;

class Retangulo
{
    public double Base;
    public double Altura;

    public string CalcularArea()
    {
        double area = Base * Altura;
        return "A área do retângulo é: " + area;
    }
}
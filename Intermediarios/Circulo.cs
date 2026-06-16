public class Circulo
{
    private double _raio;

    public double Raio
    {
        get { return _raio; }
        set { _raio = value; }
    }

    public double Diametro
    {
        get { return _raio * 2; }
    }

    public double Area
    {
        get { return 3.14 * _raio * _raio; }
    }
}
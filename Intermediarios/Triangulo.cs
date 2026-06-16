namespace dia_1506
{
    public class Triangulo
    {
        private double _ladoA;
        private double _ladoB;
        private double _ladoC;

        public double LadoA
        {
            get { return _ladoA; }
            set
            {
                if (FormarTriangulo(value, _ladoB, _ladoC))
                    _ladoA = value;
            }
        }

        public double LadoB
        {
            get { return _ladoB; }
            set
            {
                if (FormarTriangulo(_ladoA, value, _ladoC))
                    _ladoB = value;
            }
        }

        public double LadoC
        {
            get { return _ladoC; }
            set
            {
                if (FormarTriangulo(_ladoA, _ladoB, value))
                    _ladoC = value;
            }
        }

        private bool FormarTriangulo(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
namespace dia_1506
{
    public class Imovel
    {
        public string Endereco { get; set; }
        public double Valor { get; set; }

        public void AplicarDesconto(double porcentagem)
        {
            Valor = Valor - (Valor * porcentagem / 100);
        }
    }
}
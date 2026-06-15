using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dia_1506
{
    public class Produto
    {     

        private double _preco;
        private string Nome { get; set; }
        public double Preco {
            get
            {
                return _preco;
            }
            set
            {
                if (value > 0)
                {
                    _preco = value;
                }
            } }
        private int Quantidade { get; set; }
    }
}
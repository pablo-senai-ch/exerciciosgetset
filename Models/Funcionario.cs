using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dia_1506
{
    public class Funcionario
    {
        private double _reajuste;
        public string Nome { get; set; }
        public double Salario {
            get
            {
                return _reajuste;
            }
            set
            {
                if(_reajuste < 1.200)
                {
                    _reajuste = value;
                }
            } }
    }
}
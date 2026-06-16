using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dia_1506
{
    public class Data
    {
        private int _validar;
        public int Dia {
            get
            {
                return _validar;
            }
            set
            {
                if(_validar >= 1 && _validar < 31);
                _validar = value;
            } }
        public int Mes { get; set; }
        public int Ano { get; set; }
    }
}
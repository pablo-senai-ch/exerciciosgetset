using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace dia_1506
{
    public class Voo
    {
        public int NumeroVoo { get; set; }

        public string Origem { get; set; }

        private string _destino;

        public string Destino
        {
            get { return _destino; }
            set
            {
                if (value != Origem)
                    _destino = value;
            }
        }
    }
}
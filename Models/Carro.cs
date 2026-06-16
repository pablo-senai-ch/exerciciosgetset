using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dia_1506
{
    public class Carro
    {
        private int _fabricacao;
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano {
            get
            {
                return _fabricacao;
            }
            set
            {
                if(value > 1886)
                {
                    _fabricacao = value;
                }
            } }
    }
}
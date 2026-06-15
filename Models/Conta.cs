using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace dia_1506
{
    public class Conta
    {
        private double _depositar;
        private double _sacar;
        private int numeroConta { get; set; }
        public double Saldo { get; private set;}    
        

        public void Depositar(double valor)
        {
            if(valor > 0)
            {
                Saldo += valor;
            }
        }
        public bool Sacar (double valor)
        {
            if(valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
}
}
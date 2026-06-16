using System;

namespace dia_1506
{
    public class Pessoas
    {
        private int idade;

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                idade = value;
            }
        }

        public bool Maior
        {
            get
            {
                return idade >= 18;
            }
        }
    }
}
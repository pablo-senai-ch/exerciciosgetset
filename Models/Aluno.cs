using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dia_1506
{
    public class Aluno
    {
        private int _nota;
        private string? Nome { get; set; }
        private int Matricula { get; set; }
        public int Nota
        {
            get
            {
                return _nota;
            }
            set
            {
                if (value < 0 || value >= 10)
                {
                    _nota = value;
                }
            }
        }
    }
}
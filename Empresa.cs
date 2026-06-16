using System.Collections.Generic;

namespace dia_1506
{
    public class Empresa
    {
        public string Nome { get; set; }

        private List<Funcionario> funcionarios = new List<Funcionario>();

        public void AdicionarFuncionario(Funcionario f)
        {
            funcionarios.Add(f);
        }

        public double FolhaPagamento
        {
            get
            {
                double total = 0;

                foreach (var f in funcionarios)
                {
                    total += f.Salario;
                }

                return total;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Aula03Colecao.Models.Enuns;

namespace Aula03Colecao.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Cpf { get; set; } = string.Empty;
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
        public TipoFuncionarioEnum TipoFuncionario { get; set; }




        public void ReajustarSalario()
        {
            Salario = Salario + (Salario * 10 / 100);
        }

        public string ExibirPeriodoExperiencia()
        {
            string periodoExperiencia =
                string.Format("Períodos de experiência: {0} até {1}", DataAdmissao, DataAdmissao.AddMonths(3));
            return periodoExperiencia;
        }

        public decimal CalcularDescontoVT(decimal percentual)
        {
            decimal desconto = this.Salario * percentual / 100;
            return desconto;
        }

        private int ContarCaracteres(string dado)
        {
            return dado.Length;
        }

        public bool ValidarCpf()
        {
            if (ContarCaracteres(Cpf) == 11)
                return true;

            else
                return false;
        }




    }
}

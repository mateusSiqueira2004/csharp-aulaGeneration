using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Exercicio2.Model
{
    public class Gerente : Funcionario
    {
        private decimal bonus;
        public Gerente(string nome, decimal salario, int idade, int id, string funcao, decimal bonus) : base(nome, salario, idade, id, funcao)
        {
            this.bonus = bonus;
        }
        public decimal getComissao()
        {
            return bonus;
        }
        public void setComissao(decimal bonus)
        {
            this.bonus = bonus;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.Write("Sua comissao: " + this.bonus + "\nDando um valor de: " + (this.bonus + getSalario()) +
                "\n*************************************************\n");
        }
    }
}

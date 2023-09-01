using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Exercicio2.Model
{
    public class Vendedor : Funcionario
    {   
        private decimal comissao;
        public Vendedor(string nome, decimal salario, int idade, int id, string funcao, decimal comissao) : base(nome, salario, idade, id, funcao)
        {
            this.comissao = comissao;
        }
        public decimal getComissao()
        {
            return comissao;
        }
        public void setComissao(decimal comissao) {
            this.comissao=comissao;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.Write("Sua comissao: " + this.comissao + "\nDando um valor de: "+ (this.comissao + getSalario()) +
                "\n*************************************************\n");
        }
    }
}

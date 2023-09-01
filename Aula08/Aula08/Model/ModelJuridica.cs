using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Exercicio1.Model
{
    public class ModelJuridica : Cliente
    {
        private string cnpj;
        public ModelJuridica(string nome, string email, string endereco, int id, string telefone, int tipo, string cnpj) : base(nome, email, endereco, id, telefone, tipo)
        {
            this.cnpj = cnpj;
        }
        public string getCnpj()
        {
            return cnpj;
        }
        public void setCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.Write("Seu CNPJ: " + this.cnpj + 
                "\n*************************************************\n");
        }
    }
}

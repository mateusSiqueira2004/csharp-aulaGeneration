using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Exercicio1.Model
{
    public class ModelFisica : Cliente
    {
        private string cpf;
        public ModelFisica(string nome, string email, string endereco, int id, string telefone, int tipo, string cpf) 
            : base(nome, email, endereco, id, telefone, tipo)
        {
            this.cpf = cpf;
        }
        public string getCPF()
        {
            return cpf;
        }
        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.Write("Seu CPF: " + this.cpf +
                "\n*************************************************\n");
        }
    }
}

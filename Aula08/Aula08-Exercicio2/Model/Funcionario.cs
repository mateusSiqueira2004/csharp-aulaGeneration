using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Exercicio2.Model
{
    public class Funcionario
    {
        private string nome = string.Empty, funcao = string.Empty;
        private decimal salario;
        private int idade, id;

        public Funcionario(string nome, decimal salario, int idade, int id, string funcao)
        {
            this.nome = nome;
            this.salario = salario;
            this.idade = idade;
            this.id = id;
            this.funcao = funcao;
        }
        public string getNome()
        {
            return nome;
        }
        public int getIdade()
        {
            return idade;
        }
        public int getId()
        {
            return id;
        }
        public decimal getSalario()
        {
            return salario;
        }
        public string getFuncao()
        {
            return funcao;
        }

        public void setFuncao(string funcao)
        {
            this.funcao = funcao;
        }
        public void setSalario(decimal salario)
        {
            this.salario = salario;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public virtual void Visualizar()
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                "\n*************************************************\n" +
                "\n     AQUI ESTÁ INFORMAÇÕES DA SUA CONTA\n" +
                "\n*************************************************\n" +
                $"\nSeu nome: {this.nome}" +
                $"\nSua idade: {this.idade}" +
                $"\nId de conta: {this.id}" +
                $"\nSeu salario é: {this.salario}" +
                $"\nSua função: {this.funcao}" +
                "\n*************************************************\n");
        }
    }
}

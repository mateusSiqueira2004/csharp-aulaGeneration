using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aula08_Exercicio1.Model
{
    internal class Cliente
    {
        private string nome = string.Empty, email = string.Empty, cpf = string.Empty;
        private int idade, id ;

        public Cliente(string nome, string email, int idade, int id, string cpf)
        {
            this.nome = nome;
            this.email = email;
            this.idade = idade;
            this.id = id;
            this.cpf = cpf;
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
        public string getEmail()
        {
            return email;
        }
        public string getCpf()
        {
            return cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public void setEmail(string email)
        {
            this.email = email;
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

        public void Visualizar()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                "\n*************************************************\n" +
                "\n     AQUI ESTÁ INFORMAÇÕES DA SUA CONTA\n" +
                "\n*************************************************\n" +
                $"\nSeu nome: {this.nome}" +
                $"\nSua idade: {this.idade}" +
                $"\nId de conta: {id}" +
                $"\nEmail registrado: {this.email}" +
                $"\nSeu CPF: {this.cpf}" +
                "\n*************************************************\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aula08_Exercicio1.Model
{
    public class Cliente
    {
        private string nome = string.Empty, email = string.Empty, telefone = string.Empty, endereco = string.Empty;
        private int id, tipo;

        public Cliente(string nome, string email, string endereco, int id, string telefone, int tipo)
        {
            this.nome = nome;
            this.email = email;
            this.endereco = endereco;
            this.id = id;
            this.telefone = telefone;
            this.tipo = tipo;
        }
        public string getNome()
        {
            return nome;
        }
        public string getEndereco()
        {
            return endereco;
        }
        public int getId()
        {
            return id;
        }
        public string getEmail()
        {
            return email;
        }
        public string getTelefone()
        {
            return telefone;
        }
        public int getTipo()
        {
            return tipo;
        }

        public void setTipo(int tipo)
        {
            this.tipo =tipo;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public virtual void Visualizar()
        {
            string tipo = " ";
            switch (this.tipo)
            {
                case 1:
                    tipo = "\nEssa é uma Pessoa Juridica";
                    break;
                case 2:
                    tipo = "\nEssa é uma Pessoa Fisica";
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                "\n*************************************************\n" +
                "\n     AQUI ESTÁ INFORMAÇÕES DA SUA CONTA\n" +
                "\n*************************************************\n" +
                $"\nSeu nome: {this.nome}" +
                $"\nSeu endereco: {this.endereco}" +
                $"\nId de conta: {this.id}" +
                $"\nEmail registrado: {this.email}" +
                $"\nSeu telefone: {this.telefone}" + tipo);
        }
    }
}

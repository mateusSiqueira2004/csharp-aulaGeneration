using Aula08_Exercicio2.Model;

namespace Aula08_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario c1 = new Funcionario("Mateus", 100000, 19, 5, "Gerente");
            Gerente c2 = new Gerente(c1.getNome(),c1.getSalario(),c1.getIdade(),c1.getId(),c1.getFuncao(), 100);
            c2.Visualizar();
            c1.setSalario(15000);
            c2.Visualizar();
            Vendedor c3 = new Vendedor(c1.getNome(), c1.getSalario(), c1.getIdade(), c1.getId(), "Vendedor", 100);
            c2.Visualizar();
            c1.setSalario(100);
            c2.Visualizar();
        }
    }
}
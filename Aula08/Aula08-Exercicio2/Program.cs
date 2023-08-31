using Aula08_Exercicio2.Model;

namespace Aula08_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario c1 = new Funcionario("Mateus", 100000, 19, 5, "Dev Junior");
            c1.Visualizar();
            c1.setSalario(15000);
            c1.Visualizar();
        }
    }
}
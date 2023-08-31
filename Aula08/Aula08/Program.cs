using Aula08_Exercicio1.Model;

namespace Aula08_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Mateus", "mateus@gmail.com",19,5,"123456789-00");
            c1.Visualizar();
            c1.setEmail("mateus123@gmail.com");
            c1.Visualizar();
        }
    }
}
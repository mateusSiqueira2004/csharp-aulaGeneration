using Aula08_Exercicio1.Model;

namespace Aula08_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Mateus","mateus@gmail.com","Rua Joaozin",1,"94565-0000",2);
            ModelFisica c2 = new ModelFisica(c1.getNome(),c1.getEmail(),c1.getEndereco(),c1.getId(),c1.getTelefone(),c1.getTipo(), "152.125.540-56");
            c2.Visualizar();
            c1.setEmail("mateus123@gmail.com");
            c2.Visualizar();
            c1.setTipo(1);
            ModelJuridica c3 = new ModelJuridica(c1.getNome(), c1.getEmail(), c1.getEndereco(), c1.getId(), c1.getTelefone(), c1.getTipo(), "12.065.658/0001-50");
            c3.Visualizar();
            c3.setCnpj("51.253.654/0100-65");
            c3.Visualizar();
        }
    }
}
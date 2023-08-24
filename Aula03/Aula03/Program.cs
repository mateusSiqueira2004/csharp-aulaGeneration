namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade; string nome;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade > 0 && idade < 10)
                Console.WriteLine(nome + "O plano de saúde será de: R$100,00");
            else if (idade > 10 && idade < 29)
                Console.WriteLine(nome + "O plano de saúde será de: R$200,00");
            else if (idade > 29 && idade < 45)
                Console.WriteLine(nome + "O plano de saúde será de: R$300,00");
            else if (idade > 45 && idade < 59)
                Console.WriteLine(nome + "O plano de saúde será de: R$500,00");
            else if (idade > 59 && idade < 65)
                Console.WriteLine(nome + "O plano de saúde será de: R$600,00");
            else if (idade > 65)
                Console.WriteLine(nome + "O plano de saúde será de: R$1000,00");
            else
                Console.WriteLine(nome + "Por favor insira um valor de idade valida");

        }
    }
}
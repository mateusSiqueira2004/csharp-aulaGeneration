namespace Aula04_Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, contagem21 = 0, contagem50 = 0;

            while (idade >= 0)
            {
                Console.Write("\n==========================\nDigite sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade <= 21 && idade > 0)
                    contagem21++;
                else if (idade >= 50 && idade > 0)
                    contagem50++;
            }
            Console.WriteLine("O total de pessoas menores de 21 foi de: " + contagem21
                + "\nO total de pessoas maiores de 50 foi de: " + contagem50);
        }
    }
}
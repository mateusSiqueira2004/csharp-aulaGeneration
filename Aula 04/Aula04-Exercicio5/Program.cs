namespace Aula04_Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, resul = 0;

            do
            {
                Console.Write("Digite um número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                {
                    resul += num;
                }
            }
            while (num != 0);

            Console.WriteLine("A soma dos números positivos digitados é: "+ resul);
        }
    }
}
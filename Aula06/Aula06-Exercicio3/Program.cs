namespace Aula06_Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> inteiros = new HashSet<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º numero: ");
                inteiros.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("\nLista de numeros digitados: ");
            foreach (int i in inteiros)
                Console.Write(i + " ");
        }
    }
}
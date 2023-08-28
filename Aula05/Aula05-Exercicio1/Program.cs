namespace Aula05_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inteiros = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int nun; bool confirm = false;

            Console.Write("Digite o numero que deseja procurar: ");
            nun = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < inteiros.Length; i++)
            {
                if (inteiros[i] == nun)
                {
                    Console.Write($"O {nun} está na posição {Array.IndexOf(inteiros, nun)}");
                    confirm = true;
                    break;
                }
            }
            if (confirm == false)
                Console.WriteLine($"{nun} não encontrado!");
        }
    }
}
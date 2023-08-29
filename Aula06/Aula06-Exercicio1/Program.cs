namespace Aula06_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cor = new List<string>();
            for(int i = 0; i < 5; i++) { 
                Console.WriteLine($"Digite a cor: ");
                cor.Add(Console.ReadLine());
            }
            Console.WriteLine("\n\nLista de cores escritas:");
            foreach(var cores in cor)
                Console.Write(cores + " ");
            cor.Sort();
            Console.WriteLine("\n\nLista de cores escritas em ordem crescente:");
            foreach (var cores in cor)
                Console.Write(cores + " ");
            

        }
    }
}
namespace EntradaSaidaDeOperadores_Exercício4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nun1, nun2, nun3, nun4, result;
            Console.WriteLine("Digite o primeiro numero: ");
            nun1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            nun2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            nun3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o quarto numero:");
            nun4 = Convert.ToSingle(Console.ReadLine());

            result = (nun1 * nun2) - (nun3 * nun4);

            Console.WriteLine($"A diferença do produto é: {result:F2}");
        }
    }
}
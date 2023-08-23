namespace EntradaSaidaDeOperadores_Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ntB1, ntB2, ntB3, ntB4, ntF;
            Console.WriteLine("Digite a primeira nota do aluno: ");
            ntB1 = Convert.ToSingle(Console.ReadLine());                               
            Console.WriteLine("Digite a segunda nota do aluno: ");
            ntB2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota do aluno: ");
            ntB3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota do aluno: ");
            ntB4 = Convert.ToSingle(Console.ReadLine());

            ntF = (ntB1 + ntB2 + ntB3 + ntB4) / 4;

            Console.WriteLine($"A média final é: {ntF:F1}");
        }
    }
}
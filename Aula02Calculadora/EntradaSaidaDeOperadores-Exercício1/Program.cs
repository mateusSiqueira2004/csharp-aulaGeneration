namespace EntradaSaidaDeOperadores_Exercício1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioAtg, abono, salarioNv;
            Console.WriteLine("Digite o antigo sálario do funcionario: ");
            salarioAtg = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o Abono do funcionario: ");
            abono = Convert.ToSingle(Console.ReadLine());

            salarioNv = salarioAtg + abono;
            Console.WriteLine("O novo salário será: "+abono);
        }
    }
}
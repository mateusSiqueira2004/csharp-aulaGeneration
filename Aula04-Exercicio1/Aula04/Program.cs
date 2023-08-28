namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nun1, nun2, contador, resul;

            Console.Write("Digite o primeiro valor: ");
            nun1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            nun2 = Convert.ToInt32(Console.ReadLine());

            if (nun1 < nun2)
            {
                for (contador = nun1; contador < nun2; contador++)
                {
                    if (contador % 3 == 0 && contador % 5 == 0)
                    {
                        Console.WriteLine($"O numero {contador} é multiplo de 3 e 5");
                    }
                }
            }
            else
                Console.WriteLine("Operação invalida");
        }
    }
}
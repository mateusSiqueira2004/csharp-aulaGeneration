namespace Aula02Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, div;
            
            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2));
            Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2));

            if (numero2 > 0) {
                div = numero1 / numero2;
                Console.WriteLine($"{numero1} / {numero2} = {div:F2}");
            }
            Console.WriteLine($"{numero1} ^ {numero2} = " + Math.Pow(numero1, numero2));
            Console.WriteLine($"√{numero1} = " + Math.Sqrt(numero1));
        }
    }
}

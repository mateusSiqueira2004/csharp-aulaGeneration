namespace Lista1LacoCondicional_IF_Atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, resul;
            Console.Write("Digite o inteiro A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o inteiro B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o inteiro C: ");
            c = Convert.ToInt32(Console.ReadLine());

            resul = a + b;

            if (resul > c)
                Console.WriteLine($"Os calculo de {a} + {b} = {resul} \nLogo a soma dos valores de A e B é maior que o valor de C");
            else if (resul < c)
                Console.WriteLine($"Os calculo de {a} + {b} = {resul} \nLogo a soma dos valores de A e B é menor que o valor de C");
            else if (resul == c)
                Console.WriteLine($"Os calculo de {a} + {b} = {resul} \nLogo a soma dos valores de A e B é igual ao valor de C");
            else
                Console.WriteLine("insira valores validos");
        }
    }
}
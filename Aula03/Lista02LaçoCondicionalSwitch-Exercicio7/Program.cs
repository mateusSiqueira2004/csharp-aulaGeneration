namespace Lista02LaçoCondicionalSwitch_Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operador;
            float nun1, nun2, resul=0;

            Console.WriteLine("Digite o operador desejado, sendo as opcoes disponiveis + - * /\n");
            operador = Console.ReadLine();
            Console.WriteLine("\nDigite o primeiro valor desejado: ");
            nun1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo valor desejado: ");
            nun2 = Convert.ToInt32(Console.ReadLine());

            switch (operador)
            {
                case "+":
                    resul = nun1 + nun2;
                    break;
                case "-":
                    resul = nun1 - nun2;
                    break;
                case "*":
                    resul = nun1 * nun2;
                    break;
                case "/":
                    if(nun2 == 0)
                        Console.WriteLine("Uma operação de divisão precisa que o segundo valor não seja = 0");
                    else
                        resul = nun1 / nun2;
                    break;
                default: 
                    Console.WriteLine("Operação Inválida!");
                    break;
            }
            Console.WriteLine   ($"\n\nO resultado da sua operação foi: {resul}");
        }
    }
}
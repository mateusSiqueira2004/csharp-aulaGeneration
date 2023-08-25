namespace Lista1LacoCondicional_IF_Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nun, resul;
            Console.Write("Digite o valor desejado para verificar: ");
            nun = Convert.ToInt32(Console.ReadLine());

            resul = nun % 2;
            if (nun == 0)
                Console.WriteLine("Esse numero é nulo");
            else if (nun < 0 && resul != 0)
                Console.WriteLine($"O numero {nun} é inpar e negativo");
            else if (nun > 0 && resul != 0)
                Console.WriteLine($"O numero {nun} é inpar e positivo");
            else if (nun < 0 && resul == 0)
                Console.WriteLine($"O numero {nun} é par e negativo");
            else if (nun > 0 && resul == 0)
                Console.WriteLine($"O numero {nun} é par e positivo");
            else 
                Console.WriteLine("insira valores validos!");
        }
    }
}
namespace Aula05_Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];
            int somaDiagonal = 0, somaDiagonalReversa = 0; string Diagonal = " ",DiagonalReversa = " ";

            for (int i = 0; i < Math.Sqrt(matriz.Length); i++)
            {
                for (int j = 0; j<Math.Sqrt(matriz.Length); j++)
                {
                    Console.WriteLine(
                      $"Digite um valor para a posição [{i}, {j}]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            for (int i = 0; i < Math.Sqrt(matriz.Length); i++)
            {
                Diagonal += matriz[i, i] + " ";
                DiagonalReversa += matriz[i, 2 - i] + " ";
                somaDiagonal += matriz[i, i];
                somaDiagonalReversa += matriz[i, 2 - i];
            }
            Console.WriteLine(
                $"Os valores na diagonal principal é: {Diagonal}\n"+
                $"Os valores na diagonal secundaria é: {DiagonalReversa}\n"+
                $"A soma da Diagonal principal é: {somaDiagonal} \n" +
                $"A soma da Diagonal secundaria é: {somaDiagonalReversa}");



        }
    }
}
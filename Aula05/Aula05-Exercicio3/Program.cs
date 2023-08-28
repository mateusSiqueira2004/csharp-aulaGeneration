namespace Aula05_Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int somaDiagonal = 0, somaDiagonalReversa = 0; string Diagonal = " ",DiagonalReversa = " ";

            for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
            {
                Diagonal += matrix[i, i] + " ";
                DiagonalReversa += matrix[i, 2 - i] + " ";
                somaDiagonal += matrix[i, i];
                somaDiagonalReversa += matrix[i, 2 - i];
            }
            Console.WriteLine(
                $"Os valores na diagonal principal é: {Diagonal}\n"+
                $"Os valores na diagonal secundaria é: {DiagonalReversa}\n"+
                $"A soma da Diagonal principal é: {somaDiagonal} \n" +
                $"A soma da Diagonal secundaria é: {somaDiagonalReversa}");



        }
    }
}
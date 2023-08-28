namespace Aula05_Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { {1,2,3 },{4,5,6 },{7,8,9 } };
            int somaDiagonal = 0, somaDiagonalReversa = 0;

            for (int i = 0; i < Math.Sqrt(matrix.Length); i ++)
            {
                Console.Write($"{matrix[i,i]} \n{matrix[i, 2 - i]} \n");
                somaDiagonal += matrix[i, i];
                somaDiagonalReversa += matrix[i, 2 - i];
            }
            Console.WriteLine(
                $"A soma da Diagonal principal é: {somaDiagonal} \n" +
                $"A soma da Diagonal secundaria é: {somaDiagonalReversa}");

          
           
        }
    }
}
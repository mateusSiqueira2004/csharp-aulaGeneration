namespace Aula05_Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, resul = 0;
            int[] vetorMedia = new int[4];
            int[,] matrizInteiros = new int[4, 10];


            for (int coluna = 0; coluna < matrizInteiros.GetLength(1); coluna++)
            {
                soma = 0;
                for (int linha = 0; linha < matrizInteiros.GetLength(0); linha++)
                {

                    Console.WriteLine(
                        $"Digite um valor para a posição [{linha}, {coluna}]: ");
                    matrizInteiros[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                    soma += matrizInteiros[linha, coluna];
                }
                vetorMedia[coluna] = soma / matrizInteiros.GetLength(0);
                Console.WriteLine($"Soma de todos os elementos da coluna ({coluna + 1}) é: {vetorMedia[coluna]}\n\n");
                vetorMedia[coluna] = 0;
            }
        }
    }
}
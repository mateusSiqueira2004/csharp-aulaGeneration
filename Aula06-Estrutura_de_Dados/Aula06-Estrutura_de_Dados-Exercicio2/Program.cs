namespace Aula06_Estrutura_de_Dados_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> livros = new Stack<string>();
            bool parada = false; string? nome = null;

            while (parada == false)
            {
                int confirm = 0;
                Console.WriteLine(
                    "\n\n*************************************************\n\n" +
                    "             Bem-Vindo\n             ¨¨¨ ¨¨¨¨¨\n" +
                    "\nDigite o numero atribuido a ação desejada:" +
                    "\n1-Adcionar livros na pilha" +
                    "\n2-Listar todos livros" +
                    "\n3-Remover livros da pilha" +
                    "\n4-Sair" +
                    "\n                                    * " +
                    "\n                                   *  " +
                    "\n       **  *****       **       **  **" +
                    "\n       **    *       **  **     **  **" +
                    "\n       **    *      **    **    **  **" +
                    "\n       **    *     ** **** **   **  **" +
                    "\n       **    *    **        **   ****  "+
                    "\n\n*************************************************\n\n");
                confirm = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (confirm == 1)
                {
                    Console.Write(
                        "\n\n*************************************************\n\n" +
                        "Escreva o nome do livros: ");
                    nome = Console.ReadLine();
                    Console.Clear();
                    livros.Push(nome);
                }
                else if (confirm == 2)
                {
                    if (livros.Count() == 0)
                        Console.WriteLine(
                            "\n\n*************************************************\n\n" +
                            "Não há livros na pilha!");
                    else
                    {
                        Console.WriteLine(
                            "\n\n*************************************************\n\n" +
                            "A pilha está atualmente: ");
                        foreach (string s in livros)
                            Console.WriteLine(s);
                    }
                }
                else if (confirm == 3)
                {
                    if (livros.Count() == 0)
                        Console.WriteLine(
                            "\n\n*************************************************\n\n" +
                            "Não há livros na pilha!");
                    else
                    {
                        livros.Pop();
                        Console.WriteLine(
                            "\n\n*************************************************\n\n" +
                            "A pilha está atualmente: ");
                        foreach (string s in livros)
                            Console.WriteLine(s);
                    }
                }
                else if (confirm == 4)
                    parada = true;
                else
                    Console.WriteLine(
                        "\n\n*************************************************\n\n" +
                        "Escreva um valor valido");
            }
        }
    }
}
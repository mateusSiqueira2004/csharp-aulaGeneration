namespace Aula06_Estrutura_de_Dados_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> usuarios = new Queue<string>();
            bool parada = false; string? nome = null;

            while ( parada == false){
                int confirm = 0;
                Console.WriteLine(
                    "\n\n*************************************************\n\n" +
                    "            Bem-Vindo\n" +
                    "             ¨¨¨ ¨¨¨¨¨\n" +
                    "\nDigite o numero atribuido a ação desejada:" +
                    "\n1-Adcionar Cliente na Fila" +
                    "\n2-Listar todos clientes" +
                    "\n3-Remover cliente da fila" +
                    "\n4-Sair" +
                    "\n\n*************************************************\n\n");
                confirm = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (confirm == 1)
                {
                    Console.Write(
                        "\n\n*************************************************\n\n"+
                        "Escreva o nome do Cliente: ");
                    nome = Console.ReadLine();
                    Console.Clear();
                    usuarios.Enqueue(nome);
                }
                else if (confirm == 2)
                {
                    if (usuarios.Count() == 0)
                        Console.WriteLine(
                            "\n\n*************************************************\n\n"+
                            "Não há clientes na fila!");
                    else
                    {
                        Console.WriteLine(
                            "\n\n*************************************************\n\n" + 
                            "A fila está atualmente: ");
                        foreach (string s in usuarios)
                            Console.WriteLine(s);
                    }
                }
                else if (confirm == 3)
                {
                    if (usuarios.Count() == 0)
                        Console.WriteLine(
                            "\n\n*************************************************\n\n" +
                            "Não há clientes na fila!");
                    else
                    {
                        usuarios.Dequeue();
                        Console.WriteLine(
                            "\n\n*************************************************\n\n" +
                            "A fila está atualmente: ");
                        foreach (string s in usuarios)
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
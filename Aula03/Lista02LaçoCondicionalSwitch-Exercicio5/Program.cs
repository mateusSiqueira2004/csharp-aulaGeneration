namespace Lista02LaçoCondicionalSwitch_Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomeProduto = {"Cachorro Quente", "X Salada", "X Bacon", "3-Bauru", "Refrigerante", "Suco de Laranja"};
            float[] id = { 10.00f, 15.00f, 18.00f, 12.00f, 8.00f, 13.00f};
            float qtd, resul = 0.00f; int idSelecionado;

            Console.WriteLine("Id do produto selecionado: \n0-Cachorro Quente \n1-X Salada \n2-X Bacon \n3-Bauru \n4-Refrigerante \n5-Suco de Laranja");
            idSelecionado = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantos produtos foram comprados? ");
            qtd = Convert.ToSingle(Console.ReadLine());

            switch (idSelecionado)
            {
                case 0:
                    resul = id[idSelecionado] * qtd;
                    break;
                case 1: 
                    resul = id[idSelecionado] * qtd;
                    break;
                case 2:
                    resul = id[idSelecionado] * qtd;
                    break;
                case 3:
                    resul = id[idSelecionado] * qtd;
                    break;
                case 4:
                    resul = id[idSelecionado] * qtd;
                    break;
                case 5:
                    resul = id[idSelecionado] * qtd;
                    break;
                default:
                    Console.WriteLine("Id invalida");
                    break;
            }
            Console.WriteLine($"\n\nO produto comprado foi {nomeProduto[idSelecionado]}, sendo comprado uma quantidade de {qtd}\nO valor total foi de R${resul:F2}");

        }
    }
}
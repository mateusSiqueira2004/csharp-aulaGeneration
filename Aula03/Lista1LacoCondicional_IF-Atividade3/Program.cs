using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Lista1LacoCondicional_IF_Atividade3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            run();
        }
        static void run() {
            bool aptidao;
            string? nome, prDoacao;
            int idade;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("\nDigite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEssa é sua primeira doacao? (sim) ou (nao)   ");
            prDoacao = Console.ReadLine();

            if ("sim" == prDoacao)
                aptidao = true;
            else if ("nao" == prDoacao)
                aptidao = false;
            else
            {
                Console.WriteLine("Escreva corretamente conforme o indicado");
                //Console.Clear();
                run();
            }
            if (aptidao = true && idade >= 60)
                Console.WriteLine($"\n{nome}, não pode doar sangue pois pela idade não pode doar sendo a primeira doação");
            else if (idade < 18 || idade > 69)
                Console.WriteLine($"\n{nome}, não pode doar sangue pois a idade é inadequada");
            else
                Console.WriteLine($"\n{nome}, pode ser um doador");

        }
    }
}
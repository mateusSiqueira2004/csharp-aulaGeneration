namespace Aula03_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? cargo, nome;
            float salario, reajuste = 0;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o numero atribuido ao cargo (Digite apenas o numero ao lado do cargo desejado)\n1-Supervisor\n2-Diretor\n3-Gerente\n4-Outros");
            cargo = Console.ReadLine();
            Console.WriteLine("Digite seu salário: ");
            salario = Convert.ToSingle(Console.ReadLine());
          
            switch (cargo)
            {
                case "1":
                    reajuste = (salario * 7) / 100;
                    break;
                case "2":
                    reajuste = (salario * 9) / 100;   
                    break;
                case "3":
                    reajuste = (salario * 5) / 100;
                    break;
                case "4":
                    reajuste = (salario * 12) / 100;
                    break;
                default:
                    Console.WriteLine("Por favor digite um numero valido!");
                    break;
            }
            Console.WriteLine($"{nome} seu reajuste é: {reajuste} \nO seu salario fica em torno de: {salario + reajuste}");
        }
         
    }
}
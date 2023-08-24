namespace Lista02LaçoCondicionalSwitch_Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cargos = {"Gerente", "Vendedor", "Supervisor", "Motorista", "Estoquista", "Tecnico de TI"}, 
                bonus = {"10%","7%","9%","6%","5%","8%"};
            string nome;
            float salario,resul = 0.00f;
            int id;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu salario: ");
            salario = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Escolha o id do seu cargo confome abaixo: \n0-Gerente\n1-Vendedor\n2-Supervisor\n3-Motorista\n4-Estoquista\n5-Tecnico de TI");
            id = Convert.ToInt32(Console.ReadLine());

            switch (id)
            {
                case 0:
                    resul = (salario * 10) / 100;
                    break;

                case 1:
                    resul = (salario * 7) / 100;
                    break;

                case 2:
                    resul = (salario * 9) / 100;
                    break;

                case 3:
                    resul = (salario * 6) / 100;
                    break;

                case 4:
                    resul = (salario * 5) / 100;
                    break;

                case 5:
                    resul = (salario * 8) / 100;
                    break;
                default:
                    Console.WriteLine("Valores Invalidos");
                    break;
            }
            Console.WriteLine($"{nome} seu cargo é {cargos[id]}.\n" +
                $"Seu cargo recebe um bonus de {bonus[id]}, " +
                $"que ao aplicado no seu salario de R${salario:F2} se converte em R${resul:F2}" +
                $"\nSendo assim no total vc recebe R${salario + resul}");
        }
    }
}
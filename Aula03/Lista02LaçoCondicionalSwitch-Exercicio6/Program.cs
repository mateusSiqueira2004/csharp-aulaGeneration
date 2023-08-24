﻿namespace Lista02LaçoCondicionalSwitch_Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cargos = {"Gerente","Vendedor","Supervisor","Motorista","Estoquista","Tecnico de TI"}; 
            int[]    bonus  = {10,7,9,6,5,8};
            string?  nome;
            float    salario, resul = 0;
            int      id;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("\nDigite seu salario: ");
            salario = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nEscolha o id do seu cargo confome abaixo: \n0-Gerente\n1-Vendedor\n2-Supervisor\n3-Motorista\n4-Estoquista\n5-Tecnico de TI\n");
            id = Convert.ToInt32(Console.ReadLine());

            switch (id)
            {
                case 0:
                    resul = (salario * bonus[id]) / 100;
                    break;

                case 1:
                    resul = (salario * bonus[id]) / 100;
                    break;

                case 2:
                    resul = (salario * bonus[id]) / 100;
                    break;

                case 3:
                    resul = (salario * bonus[id]) / 100;
                    break;

                case 4:
                    resul = (salario * bonus[id]) / 100;
                    break;

                case 5:
                    resul = (salario * bonus[id]) / 100;
                    break;
                default:
                    Console.WriteLine("Valores Invalidos");
                    break;
            }
            Console.WriteLine(
                "\n---------------------------------------------------------------------------\n" +
                $"{nome} seu cargo é {cargos[id]}.\n" +
                $"Seu cargo recebe um bonus de {bonus[id]}%, " +
                $"que ao aplicado no seu salario de R${salario:F2} se converte em R${resul:F2}" +
                $"\nSendo assim no total vc recebe R${salario + resul:F2}\n" +
                "\n---------------------------------------------------------------------------");
        }
    }
}
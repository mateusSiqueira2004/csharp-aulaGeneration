namespace EntradaSaidaDeOperadores_Exercício3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float slBruto, hrTrab, diasTrab, hrsTrabNoMes, adcNoturno , hrExtras, desc, slLiquido;
            double diaria, resulHrExtras, resulHrNoturna;

            Console.WriteLine("Adcione o Salario Brunto do funcionario: ");
            slBruto = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nPor quantas horas você trabalha no dia: ");
            hrTrab = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nPor quantos dias você trabalha no mes: ");
            diasTrab = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nHoras noturnas trabalhadas: ");
            adcNoturno = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nAdcione o Horas Extras trabalhadas: ");
            hrExtras = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nAdcione o Desconto no funcionario: ");
            desc = Convert.ToSingle(Console.ReadLine());

            hrsTrabNoMes = hrTrab * diasTrab;
            diaria = slBruto / hrsTrabNoMes;
            resulHrExtras = hrExtras * ((((Double)50 / 100) * diaria ) + diaria);
            resulHrNoturna = adcNoturno * ((((Double)20 / 100) * diaria)+ diaria);
            slLiquido = slBruto + Convert.ToSingle(resulHrNoturna) + Convert.ToSingle(resulHrExtras) /*- desc*/;

            Console.WriteLine($"O salário liquido será: {slLiquido:F2}");
        }
    }
}
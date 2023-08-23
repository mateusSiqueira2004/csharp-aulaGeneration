namespace EntradaSaidaDeOperadores_Exercício3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float slBruto, adcNoturno, hrExtras, desc, slLiquido;

            Console.WriteLine("Adcione o Salario Brunto do funcionario: ");
            slBruto = Convert.ToSingle(Console.ReadLine()); 
            Console.WriteLine("Adcione o Bonus noturno do funcionario: ");
            adcNoturno = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Adcione o Horas Extras do funcionario: ");
            hrExtras = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Adcione o Desconto no funcionario: ");
            desc = Convert.ToSingle(Console.ReadLine());

            slLiquido = slBruto + adcNoturno + (hrExtras * 5) - desc;

            Console.WriteLine($"O salário liquido será: {slLiquido:F2}");
        }
    }
}
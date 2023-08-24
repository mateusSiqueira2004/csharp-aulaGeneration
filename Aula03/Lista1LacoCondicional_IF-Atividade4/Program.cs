namespace Lista1LacoCondicional_IF_Atividade4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int subClasif, clasif, tipoAlim;

            Console.WriteLine("Diga se o animal é\n1-Vertebrado\n2-Invertebrado");
            subClasif = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n----------------------------------------------\n");
            if (subClasif == 1)
            {
                Console.WriteLine("Diga se o animal é\n1-Ave\n2-Mamiféro");
                clasif = Convert.ToInt32(Console.ReadLine());
                if (clasif == 1)
                {
                    Console.WriteLine("\n----------------------------------------------\n");
                    Console.WriteLine("Diga se o animal é\n1-Carnívoro\n2-Onívoro");
                    tipoAlim = Convert.ToInt32(Console.ReadLine());
                    if (tipoAlim == 1)
                        Console.WriteLine("esse animal é uma Águia");
                    
                    else if(tipoAlim == 2)
                        Console.WriteLine("esse animal é uma Pomba");

                    else
                        Console.WriteLine("esse animal não existe");
                }
                else if (clasif == 2)
                {
                    Console.WriteLine("\n----------------------------------------------\n");
                    Console.WriteLine("Diga se o animal é\n1-Onívoro\n2-Herbívoro");
                    tipoAlim = Convert.ToInt32(Console.ReadLine());
                    if (tipoAlim == 1)
                        Console.WriteLine("esse animal é um Humano");
                    else if(tipoAlim == 2)
                        Console.WriteLine("esse animal é uma Vaca");
                    else
                        Console.WriteLine("esse animal não existe");
                }
                else
                    Console.WriteLine("esse animal não existe");
            }
            else if (subClasif == 2)
            {
                Console.WriteLine("Diga se o animal é\n1-Inseto\n2-Anelídeo");
                clasif = Convert.ToInt32(Console.ReadLine());
                if (clasif == 1)
                {
                    Console.WriteLine("\n----------------------------------------------\n");
                    Console.WriteLine("Diga se o animal é\n1-Hematófago\n2-Herbívoro");
                    tipoAlim = Convert.ToInt32(Console.ReadLine());
                    if (tipoAlim == 1)
                        Console.WriteLine("esse animal é uma Pulga");

                    else if (tipoAlim == 2)
                        Console.WriteLine("esse animal é uma Largata");

                    else
                        Console.WriteLine("esse animal não existe");

                }
                else if (clasif == 2)
                {
                    Console.WriteLine("\n----------------------------------------------\n");
                    Console.WriteLine("Diga se o animal é\n1-Hematófago\n2-Onívoro");
                    tipoAlim = Convert.ToInt32(Console.ReadLine());
                    if (tipoAlim == 1)
                        Console.WriteLine("esse animal é uma Sanguessuga");

                    else if (tipoAlim == 2)
                        Console.WriteLine("esse animal é uma Minhoca");

                    else
                        Console.WriteLine("esse animal não existe");
                }
                else
                    Console.WriteLine("esse animal não existe");
            }
            else
                Console.WriteLine("Escreva um valido");
        }
    }
}
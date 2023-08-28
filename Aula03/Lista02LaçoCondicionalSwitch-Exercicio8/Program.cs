using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

namespace Lista02LaçoCondicionalSwitch_Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {banco();}

        class getsEsets
        {   private float _saldo;
            private int _confirm; 
            private string _verif;

            public float Saldo
            {
                get { return _saldo; }
                set => _saldo = value;
            }

            public int Confirm
            {
                get {return _confirm; }
                set => _confirm = value;
            }
         
            public string Verif
            {
                get { return _verif; }
                set => _verif = value;
            }
        }

        static void banco ()
        {
            int id;
            float valor, resul;
            bool parada = false;

            getsEsets chama = new getsEsets();


            while (parada == false) {
                if (chama.Confirm == 1)
                {
                    Console.WriteLine("\n====================================================\n" +
                        "ESCOLHA INSERIDA INVALIDA! TENTE NOVAMENTE\n====================================================\n");
                    chama.Confirm = 0;
                }
                Console.WriteLine("\n\n\n\n\n\n\n------------------------------\n\n" +
                    "Qual comando deseja realizar?\n1-Verificar Saldo\n2-Saquar Dinheiro\n3-Depositar\n4-Cancelar");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\n------------------------------\n");

                switch (id)
                {
                    case 1:
                        if (chama.Verif == "verificado")
                        {
                            Console.WriteLine($"\n\nSeu saldo atual é {chama.Saldo}\n");
                        }
                        else
                        {
                            chama.Saldo = 1000.00f;
                            Console.WriteLine($"\n\nSeu saldo atual é R${chama.Saldo}\n");
                            chama.Verif = "verificado";
                        }
                        break;
                    case 2:

                        if (chama.Verif == "verificado")
                        {
                            Console.WriteLine("Digite o valor que deseja sacar: ");
                            valor = Convert.ToSingle(Console.ReadLine());
                            if (valor > chama.Saldo)
                            {
                                Console.WriteLine("\n\n========================================================\n" +
                                    "Seu saldo é insuficiente!");
                            }
                            else
                            {
                                resul = chama.Saldo - valor;
                                chama.Saldo = resul;
                                Console.WriteLine($"\n\n========================================================\n" +
                                    $"Você sacaou R${valor:F2}, seu saldo atual é de R${resul:F2}");
                            }
                         }
                        else 
                        {
                            Console.WriteLine("\n\n========================================================\n" +
                                "Por motivos de segurança, pedimos que você verifique seu saldo primeiro");
                        }
                        break;
                    case 3:
                        if (chama.Verif == "verificado")
                        {
                            Console.WriteLine("Digite o valor que de deposito: ");
                            valor = Convert.ToSingle(Console.ReadLine());
                            resul = chama.Saldo + valor;
                            chama.Saldo = resul;
                            Console.WriteLine($"\n\n========================================================\n" +
                                $"Você depositou R${valor:F2}, seu saldo atual é de R${resul:F2}");
                        }
                        else {
                            Console.WriteLine("\n\n========================================================\n" +
                                "Por motivos de segurança, pedimos que você verifique seu saldo primeiro");
                        }
                        break;
                    case 4:
                            System.Environment.Exit(1);
                        break;
                    default:
                        chama.Confirm = 1;
                        Console.Clear();
                        break;
                }
            }
        }
    } 
}
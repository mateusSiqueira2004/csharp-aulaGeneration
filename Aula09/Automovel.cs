using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    public class Automovel : Terrestre
    {
        private string placa, cor;
        private int numeroPortas, marcha;

        public Automovel(string placa, string cor, int numeroPortas, int marcha, int roda, int velocidade, int capacidade) : base(capacidade, roda, velocidade)
        {
            this.placa = placa;
            this.cor = cor;
            this.numeroPortas = numeroPortas;
            this.marcha = marcha;
        }
        public string GetCor()
        {
            return cor;
        }

        public void SetCor(string cor)
        {
            this.cor = cor;
        }

        public int GetNumeroPortas()
        {
            return numeroPortas;
        }

        public void SetNumeroPortas(int numeroPortas)
        {
            this.numeroPortas = numeroPortas;
        }

        public string GetPlaca()
        {
            return placa;
        }

        public void SetPlaca(string placa)
        {
            this.placa = placa;
        }

        public int GetMarcha()
        {
            return marcha;
        }

        public void SetMarcha(int marcha)
        {
            this.marcha = marcha;
        }

        public override void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine("cor: " + this.cor);
            Console.WriteLine("Número de portas: " + this.numeroPortas);
            Console.WriteLine("Placa: " + this.placa);
            Console.WriteLine("Marcha: " + this.marcha);

        }
    }
}

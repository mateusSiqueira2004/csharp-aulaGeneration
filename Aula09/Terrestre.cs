using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    public class Terrestre : Transporte
    {
        private int roda, velocidade;
        public Terrestre(int capacidade, int roda, int velocidade) : base(capacidade)
        {
            this.roda = roda;
            this.velocidade = velocidade;
        }
        public int GetNumeroRodas()
        {
            return roda;
        }

        public void SetNumeroRodas(int roda)
        {
            this.roda = roda;
        }

        public float GetVelocidade()
        {
            return velocidade;
        }

        public void SetVelocidade(int velocidade)
        {
            this.velocidade = velocidade;
        }

        public virtual void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine("Número de rodas: " + this.roda + "\nVelocidade: " + this.velocidade);

        }
    }
}

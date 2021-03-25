using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndas
{
    public class Validacoes
    {
        public void ValidaPotencia(int potencia)
        {
            if (potencia > 10 || potencia < 1)
            {
                throw new ArgumentOutOfRangeException("Tá errada essa Potência", nameof(potencia));
            }
        }

        public void ValidaTempo(double tempo)
        {
            if (tempo > 2.0 || tempo < 0.01)
            {
                throw new IndexOutOfRangeException("Tá errado esse Tempo");
            }
        }
    }
}

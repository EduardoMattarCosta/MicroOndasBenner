using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroOndas
{
    public class MicroOndas
    {
        public double tempo { get; private set; }
        public int potencia { get; private set; }
       
        public MicroOndas(double tempo, int potencia)
        {
            
            this.tempo = tempo;
            this.potencia = potencia;
            
            
            Console.WriteLine($"Novo MicroOndas Criado! Potência: {potencia} Tempo: {tempo}");
            MessageBox.Show($"Novo MicroOndas Criado! Potência: {potencia} - Tempo: {tempo}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MicroOndas
{
    class ProcessaInput
    {
       public ProcessaInput(String input)
        {
            if (String.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Digite Potência e Tempo separado por um ponto e vígula ';'. " , nameof(input));;
            }
            else
            {
               GetParametros(input);

                double tempoDouble = Convert.ToDouble(tempo);
                

                int potenciaInt = Convert.ToInt32(potencia);

                var validacoes = new Validacoes();

                validacoes.ValidaTempo(tempoDouble);
                validacoes.ValidaPotencia(potenciaInt);

                MicroOndas microOndas = new MicroOndas(tempoDouble, potenciaInt);
            }
        }

        /// <summary>
        /// Cria um novo microondas passando 30 segundos e potência 8 - On Click
        /// </summary>
        /// <param name="tempo"></param>
        /// <param name="potencia"></param>
        public ProcessaInput(double tempo, int potencia)
        {
            MicroOndas microOndas = new MicroOndas(tempo,potencia);
        }

        private string potencia;
        static string tempo;

        public void GetParametros(String input)
        {
            int indiceDaVirgula = input.IndexOf(';');

            potencia = input.Substring(0, indiceDaVirgula);
            tempo = input.Substring(indiceDaVirgula + 1);
        }
    }
}

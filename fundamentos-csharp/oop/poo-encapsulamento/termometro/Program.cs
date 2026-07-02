using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace termometro
{
    public class Termometro
    {
        private double _temperatura;
        public double Temperatura
        {
            get { return _temperatura; }
            set
            {
                if (value < 273.15)
                {
                    _temperatura = 273.15;
                    Console.WriteLine("Aviso: Temperatura menor que o zero absoluto");
                }
                else
                {
                    _temperatura = value;
                }

            }
        }
        
        

        
        
    }
}

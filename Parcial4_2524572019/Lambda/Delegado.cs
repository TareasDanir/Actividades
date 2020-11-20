using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    
    class Delegado
    {
        public int promedio;
        public int PROMEDIO(int promedio)
        {
            if (promedio > 35)
            {
                Console.WriteLine("Que semana tan calurosa");
            }
            else if (promedio >= 15 && promedio <= 35)
            {
                Console.WriteLine("Que clima tan delicioso");
            }
            else if (promedio<15)
            {
                Console.WriteLine("Que semana tan fria");
            }
            return promedio;
        }
    }
}

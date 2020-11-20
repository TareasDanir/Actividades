using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegado del = new Lambda.Delegado();
            Console.WriteLine("--------------BIENVENIDO--------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Desea calcular el promedio de la temperatura?");
            Console.WriteLine("Ingrese el promedio de la temperatura");
            del.promedio = Convert.ToInt32(Console.ReadLine());
            del.PROMEDIO(del.promedio);
            Console.ReadKey();
        }
    }
}

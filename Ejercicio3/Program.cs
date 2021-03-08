using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Numero: " + i);

                if ( i % 2 == 0)
                {
                   Console.WriteLine("Este es un numero par: " + i);
                }

            }
            Console.Read();

        }
    }
}

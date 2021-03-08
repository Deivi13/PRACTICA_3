using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = (char)90;
           
            do {

                Console.WriteLine(letra);
                letra--;
            } while (letra >= 65);

            Console.Read();


        }
    }
}

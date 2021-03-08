using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            int Numeros;
            Console.WriteLine("Introduzca numeros positivos solamente: ");
            do {
               
                Numeros = int.Parse(Console.ReadLine());

                Numbers.Add(Numeros);
            
            } while (Numeros > 0);

            Console.WriteLine("Numero de elementos: " + Numbers.Count());
            Console.WriteLine("Suma de elementos: " + Numbers.Sum());


            Console.Read();
        }
    }
}

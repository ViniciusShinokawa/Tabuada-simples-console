using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {

        public static void Tabuada(int numero)
        {
            Console.WriteLine("=========================================");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero + "X" + i + " = " + (numero * i));
            }
            Console.WriteLine("=========================================");
          
        
        }

        static void Main(string[] args)
        {
            Tabuada(1);
            Tabuada(2);

        }
    }
}

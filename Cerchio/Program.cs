using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerchio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio cerchio = new Cerchio();
            Console.WriteLine(" ");
            cerchio.raggio=double.Parse(Console.ReadLine());
            Console.WriteLine("{0}", cerchio.calcoloperimetro());
            Console.WriteLine("{0}", cerchio.calcoloarea());
            Console.ReadLine();

        }
    }
}

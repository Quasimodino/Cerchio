using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerchio
{
    internal class Cerchio
    {
        public double raggio { get; set; }
        public double calcoloarea()
        {
            double area;
            area = raggio * raggio * Math.PI;
            return area;
        }
        public double calcoloperimetro()
        {
            double perimetro;
            perimetro = 2 * Math.PI * raggio;
            return perimetro;
        }
    }
}

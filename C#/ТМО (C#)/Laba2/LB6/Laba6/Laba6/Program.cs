using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    class Program
    {
        static public double m = 1;
        static public double Nn = 23;
        static public double N = 4;
        static public double h = 1.5;//90 sec.
        static public double lyambda (double m, double Nn, double N)
        {
            return 12 * (m / (Nn*N));
        }
        static void Main(string[] args)
        {
            double T1 = Nn + 1, T2 = Nn + 200;
        }
    }
}

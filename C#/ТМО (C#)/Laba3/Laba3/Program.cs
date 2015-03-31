using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class functions
    {
        public double factorial(double i)
        {
            if (i == 0)
                return 1;
            return i * factorial(i - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, N = 6, m = 1, Nn = 23;
            double lyambda = 10 * (m / (N * Nn));
            Console.Write("lyambda = " + lyambda + "\n");
            double v = 5 * (m + Nn / (Nn*N));
            Console.Write("v = " + v + "\n");
            double ro = lyambda / v;
            Console.Write("ro = " + ro + "\n");

            double[] P0 = new double[6];
            var func = new functions();
            for (int i = 0; i < 6; ++i)
            {
                P0[i] = Math.Pow(ro, i) / func.factorial(i);
                sum += P0[i];

            }

            double P0_k = 0;
            P0_k = 1/(sum + (Math.Pow(ro, N+1)/(func.factorial(N)*(N-ro))));
            Console.Write(P0_k + +"\n");

            double nul = Math.Pow(sum, (-1));
            double[] Pk = new double[6];
            double sum1 = 0;
            for (int k = 0; k < 6; ++k)
            {
                Pk[k] = (Math.Pow(ro, k) / func.factorial(k)) * nul;
                sum1 += Pk[k];
                Console.Write("i = " + k + ", Pk[k] = " + Pk[k] + "\n");
            }
            Console.Write("\n");

            double P_otk = (Math.Pow(ro, N) / func.factorial(N)) / sum1;
            Console.Write("Imovirnist vydmovy P_otk =  " + P_otk + "\n");

            double M_zan = ro * (1 - P_otk);
            Console.Write("Seredne chyslo zajnatyh vuzliv M_zan = " + M_zan + "\n");

            double M_sv = N - M_zan;
            Console.Write("Seredne chyslo vilnyh vuzliv M_sv = " + M_sv + "\n");

            double Q = 1 - P_otk;
            Console.Write("Vidnosno propuskna zdatnist Q = " + Q + "\n");

            double A = lyambda * Q;
            Console.Write("Absolutna propuskna zdatnist A = " + A + "\n");

            double K_zajn = M_zan / N;
            Console.Write("Koeficient zajnyatosti vuzliv Kz = " + K_zajn +"\n");
        }
    }
}

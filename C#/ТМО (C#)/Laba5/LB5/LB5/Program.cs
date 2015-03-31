using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{
    class Program
    {
        public const double N = 5;
        public const double m = 1;
        public const double Nn = 23;

        static public double factorial(double N)
        {
            if (N == 0)
                return 1;
            return N * factorial(N - 1);
        }

        static public double lyambda(double m, double N, double Nn)
        {
            return 15 * (m / (N * Nn));
        }

        static public double v (double m, double N, double Nn)
        {
            return 3 * ((m + Nn) / (Nn * N));
        }

        static public double sum_ (double ro, double N)
        {
            double sum = 0;
            int i = 0;
            for (i = 0; i <= N; ++i)
            {
                sum += Math.Pow(ro, i) / factorial(i);
            }
            return sum;
        }

        static public double P0_ (double ro, double N)
        {
            double P0_p = 0;
                P0_p = (1/(sum_(ro, N) + (Math.Pow(ro, N+1)/(factorial(N)*(N - ro)))));
            return P0_p;
        }
        static public double[] P_k (double ro, double N)
        {
            double[] p_k = new double[(int)N];
            for (int k = 0; k <= N; ++k)
            {
                if (k > 0 && k < N)
                {
                    p_k[k] = (Math.Pow(ro, k) / factorial(k)) * P0_(ro, N);
                }
                else
                {
                    p_k[k] = (Math.Pow(ro, k) / (Math.Pow(N, k-N) * factorial(N))) * P0_(ro, N);
                }
            }
            return p_k;
        }
        static public double[] dlya_M_viln (double ro, double N)
        {
            double[] sum1 = new double[(int)N];
            int k = 0;
            for (k = 0; k < (int)N; ++k)
            {
                sum1[k] += k * (Math.Pow(ro, k)/factorial(N-k));
            }
            return sum1;
        }

        static void Main(string[] args)
        {
            Console.Write("lyambda = " + lyambda(m, N, Nn) + "\n");
            Console.Write("v = " + v(m, N, Nn) + "\n");
            double ro = lyambda(m, N, Nn) / v(m, N, Nn);
            Console.Write("ro = " + ro + "\n");

            double sum1 = 0;
            double nul = Math.Pow(sum_(ro, N), (-1));
            double[] Pk = new double[(int)10];
            for (int k = 0; k < 10; ++k)
            {
                Pk[k] = (Math.Pow(ro, k) / factorial(k)) * nul;
                sum1 += Pk[k];
               Console.Write("i = " + k + ", Pk[k] = " + Pk[k] + "\n");
            }
            
            Console.Write("\n\nP0 = " + P0_(ro, N) + "\n\n");

            double P_och = (Math.Pow(ro, (N + 1)) / factorial(N) * (N - ro)) * P0_(ro, N);
            Console.Write("Imovirnist najavnosti chergy P_och = " + P_och + "\n\n");

            double P_zajn = (Math.Pow(ro, N) / (factorial(N - 1) * (N - ro))) * P0_(ro, N);
            Console.Write("Imovirnist zajnyatosti vsih vuzliv P_zajn = " + P_zajn + "\n\n");

            double M_vym = P0_(ro, N)*((ro * sum_(ro, N-1)) + ((Math.Pow(ro, N+1)*(N+1-ro))/(factorial(N-1)*Math.Pow(N-ro, 2))));
            Console.Write("Serednya kilkist vymog u systemi M_vym = " + M_vym + "\n\n");

            double M_cher = (Math.Pow(ro, N + 1) * P0_(ro, N)) / (factorial(N-1) * Math.Pow(N-ro, 2));
            Console.Write("Serednya dovzhina chergy M_cher = " + M_cher + "\n\n");

            double sum_M_v = 0;
            for (int p = 0; p < N; ++p)
            {
                sum_M_v += dlya_M_viln(ro, N)[p];
            
            }
            double M_vil = N - ro;/* P0_(ro, N) * sum_M_v;*/
            Console.Write("M_vil = " + M_vil + "\n\n");

            double M_zajn = ro /*N - M_vil*/;
            Console.Write("M_zajn = " + M_zajn + "\n\n");

            double T_och = (Math.Pow(ro, N) / (v(m, N, Nn) * factorial(N - 1) * Math.Pow(N - ro, 2))) * P0_(ro, N);
            Console.Write("Serednij chas ochikuvannya T_och = " + T_och + "\n\n");

            double T_z_och = (Math.Pow(ro, N + 1) / (factorial(N - 1) * Math.Pow(N - ro, 2))) * P0_(ro, N);
            Console.Write("(Chas) vymogy za od. chasu T_zoch = " + T_z_och + "\n\n");

            double T_vymog = T_och + (1 / v(m, N, Nn));
            Console.Write("Serednyj chas T_vym = " + T_vymog + "\n\n");

            double T_s_vym = T_z_och + ro;
            Console.Write("Sumarnyj chas T_s_vym = " + T_s_vym + "\n\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_2
{
    class Program
    {
        static public double factorial(double n)
        {
            if (n == 0)
                return 1;
            return n * factorial(n - 1);
        }

        /*static public double ro(double lyambda, double h)
        {
            double[] sum = new double[23];
            int l = 0;
            for (l = 0; l < 23; ++l)
            {
                sum[l] += Math.Pow((lyambda * h), l);
            }
            return sum;
        }*/

        static public double P_otk(double k, double lyambda_, double h, double m, double Nn, double N)
        {
            double val1 = Math.Pow((lyambda_ * h), k);
            double val2 = factorial(k);
            double val3 = val1 / val2;
            double val4 = Math.Exp(-lyambda_ * h);
            double val5 = val3 * val4;
            return val5;
            /*return (Math.Pow((lyambda * h), k) / factorial(k)) / (ro(lyambda, h) / factorial(k)) ;*/
        }

        /*static public double lyambda_(double m, double Nn, double N)//Nn-номер в журнале, m-номер группы, N-кол-во каналов
        {
            return (10 * m) / (Nn * N);
        }*/
        static void Main(string[] args)
        {
            int k = 0;
            const double N = 3, Nn = 23, m = 1, h = 33, T1 = Nn + 1, T2 = Nn + 200;
            const double lyambda_ = (10 * m) / (Nn * N);
            Console.Write(lyambda_ + "\n");
            const int size = (int)(2 * lyambda_ * (T2 - T1));

            Console.Write("Nomer gruppy i nomer v zhurnale: " + m + ' ' + Nn + '\n');
            double[] r = new double[size];
            Random random = new Random();

            Console.Write("r[i] = ");
            for (int i = 0; i < size; ++i)
            {
                r[i] = random.NextDouble();
                Console.Write(r[i] + " ");//#1
            }
            Console.Write("\n\n");

            double[] Z = new double[size];
            Console.Write("Z[i] = ");
            for (int i = 0; i < size; ++i)
            {
                Z[i] = -(1 / lyambda_) * Math.Log(r[i]);//#3
                Console.Write(Z[i] + ", ");
            }
            Console.Write("\n\n");

            Console.Write("t1 = " + T1 + ", t2 = " + T2 + '\n');
            Console.Write("\n\n");


            List<double> T_post = new List<double>(size);
            double[] T_p = new double[size];
            double K_nad = 0;
            for (k = 0; k < size; ++k)
            {
                double x = 0;
                for (int i = 0; i < k; ++i)
                {
                    x += Z[i];
                }
                if (x + T1 <= T2)
                {
                    T_post.Add(T1 + x);
                }
                else
                {
                    break;
                }
                ++K_nad;
            }
            Console.Write("t[k]: ");
            for (int i = 1; i < T_post.Count; ++i)
            {
                Console.Write(T_post[i] + " ");
            }

            double[] E = new double[size];
            Console.Write("\n\n E[i] = ");
            for (int i = 0; i < E.Length; ++i)
            {
                E[i] = (-h * Math.Log(r[i]));
                Console.Write(E[i] + ", ");
            }
            Console.Write("\n\n");

            Console.Write("T_zvil = ");
            //List<double> T_zvil = new List<double>();
            double[] T_zvil = new double[size];
            for (k = 0; k < size; ++k)
            {
                T_zvil[k] = (T_post[k] + E[k]);
                Console.Write(T_zvil[k] + ", ");
            }
            Console.Write("\n\n");

            double K_zag = 0;
            //Console.Write("r[i]" + "    Z[i]" + "    E[i]" + "    T_post" + "    T_zvil" + "    i" + "\n");
            for (int i = 0; i < size; ++i)
            {
                Console.Write(r[i] + " | " + Z[i] + " | " + E[i] + " | " + T_post[i] + " | " + T_zvil[i] + " | " + i + "\n");
                if (T_zvil[i] == 0)
                {
                    ++K_zag;
                }
            }
            Console.Write("\n\n" + "K_nad = " + K_nad);
            Console.Write("\nK_zag = " + K_zag + "\n\n");

            double P_otk_sh = 0;
            P_otk_sh = K_nad / K_zag;
            Console.Write("P_otk_sh = " + P_otk_sh + "\n");
            Console.Write("P_otk = " + P_otk(k, lyambda_, h, m, Nn, N) + "\n\n");
        }
    }
}

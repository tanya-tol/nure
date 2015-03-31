using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba1
{
    class functions
    {
        public double factorial(double n)
        {
            if (n == 0)
                return 1;
            return n * factorial(n - 1);
        }

        public double P(double k, double t, double lyambda)
        {
            double val1 = Math.Pow((lyambda * t), k);
            double val2 = factorial(k);
            double val3 = val1 / val2;
            double val4 = Math.Exp(-lyambda * t);
            double val5 = val3 * val4;
            return val5;
        }

        public double F(double t, double lyambda)
        {
            return 1 - Math.Exp(-lyambda * t);
        }

        public double lyambda(double m, double N)//#2
        {
            return (10 * m) / N;
        }

        public double teta(double T2, double T1)
        {
            return (T2 - T1) / 25;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double N = 23, m = 1;
            double T1 = N + 1, T2 = N + 5;
            double lyam = ((10 * m) / N);
            Console.Write("Nomer gruppy i nomer v zhurnale: " + m + ' ' + N + '\n');
            double[] z = new double[25];

            Random random = new Random();
            Console.Write("r[i] = ");
            for (int i = 0; i < 25; ++i)
            {
                z[i] = Convert.ToDouble(random.Next(10000)) / 10000;//ot 0 do 1
                Console.Write(z[i] + " ");//#1
            }
            Console.Write('\n');
            double[] Z = new double[23];
            Console.Write("Z[i] = ");
            for (int i = 0; i < 23; ++i)
            {
                Z[i] = -(1 / lyam) * Math.Log(z[i]);//#3
                Console.Write(Z[i] + ", ");
            }
            Console.Write('\n');

            Console.Write("t1 = " + T1 + ", t2 = " + T2 + '\n');

            List<double> tk = new List<double>();
            for (int k = 0; k < 25; ++k)
            {
                double x = 0;
                for (int i = 0; i < k; ++i)
                {
                    x += Z[i];
                }
                if (x + T1 <= T2)
                {
                    tk.Add(T1 + x);
                }
                else
                {
                    break;
                }
            }
            Console.Write("t[k]: ");
            for (int i = 0; i < tk.Count; ++i)
            {
                Console.Write(tk[i] + " ");
            }
            Console.Write('\n');
            double tay = (T2 - T1) / 25;
            Console.Write("tau = " + tay + '\n');

            double tao_original = (T2 - T1) / 25;
            double[] tao_mas = new double[25];
            Console.Write("Mass tao: ");
            for (int i = 0; i < 25; ++i)
            {
                double sump = 0;
                int len_tk = tk.Count;
                for (int k = 0; k < len_tk; ++k)
                    if (tk[k] > T1 && tk[k] < (T1 + tao_original)) sump++;
                tao_mas[i] = sump;
                T1 += tao_original;
                Console.Write(tao_mas[i]);
            }
            Console.Write('\n');

            double[] count_tao = new double[25];
            Hashtable myHT1 = new Hashtable();
            for (int i = 0; i < tao_mas.Length; ++i)
            {
                myHT1[tao_mas[i]] = 0;
            }

            Console.Write("Kol-vo trebovaniy v intervale: kov-vo intervalov " + '\n');
            for (int i = 0; i < tao_mas.Length; ++i)
            {
                int temp = (int)myHT1[tao_mas[i]];
                ++temp;
                myHT1[tao_mas[i]] = temp;
                //Console.Write(", " + i + " " + myHT1[tao_mas[i]] + '\n');
                //Console.Write(temp);
            }

            double sum = 0, Np = 0;
            foreach (double key in myHT1.Keys)//Convert.ToString(key), Convert.ToString(myHT1[key]))
            {
                int fortemp = (int)myHT1[key];
                sum += key * fortemp;
                Np += fortemp;
                Console.WriteLine(String.Format("{0}: {1}", key, myHT1[key]));
            }

            Console.Write("sum = " + sum + ", tao = " + tao_original + '\n');
            double a = (1 / Np) * sum, lyambda_m = a / tao_original;
            Console.Write("Nk = " + Np + ", a =  " + a + ", lyambdaa = " + lyambda_m + '\n');

            T2 = N + 5;
            T1 = N + 1;
            double t = T2 - T1;
            var func = new functions();

            Console.Write("lyambda = " + func.lyambda(m, N) + "\n");
            Console.Write("P(0, t): " + func.P(0, t, func.lyambda(m, N)) + "\n");
            Console.Write("P(1, t): " + func.P(1, t, func.lyambda(m, N)) + "\n");
            Console.Write("P(2, t): " + func.P(2, t, func.lyambda(m, N)) + "\n");
            Console.Write("P(3, t): " + func.P(3, t, func.lyambda(m, N)) + "\n");
            Console.Write("P(4, t): " + func.P(4, t, func.lyambda(m, N)) + "\n");
            Console.Write("P(sum ot [(1+2+3+4), t]: " + (func.P(0, t, func.lyambda(m, N)) + func.P(1, t, func.lyambda(m, N)) + func.P(2, t, func.lyambda(m, N)) + func.P(3, t, func.lyambda(m, N)) + func.P(4, t, func.lyambda(m, N))) + "\n");
            Console.Write("P(>=5, t): " + (1 - (func.P(0, t, func.lyambda(m, N)) + func.P(1, t, func.lyambda(m, N)) + func.P(2, t, func.lyambda(m, N)) + func.P(3, t, func.lyambda(m, N)) + func.P(4, t, func.lyambda(m, N)))) + "\n");
            Console.Write("P(<3, t): " + (func.P(0, t, func.lyambda(m, N)) + func.P(1, t, func.lyambda(m, N)) + func.P(2, t, func.lyambda(m, N)) + "\n"));
            Console.Write("P(<=7, t): " + (func.P(0, t, func.lyambda(m, N)) + func.P(1, t, func.lyambda(m, N)) + func.P(2, t, func.lyambda(m, N)) + func.P(3, t, func.lyambda(m, N)) + func.P(4, t, func.lyambda(m, N)) + func.P(5, t, func.lyambda(m, N)) + func.P(6, t, func.lyambda(m, N)) + func.P(7, t, func.lyambda(m, N))) + "\n");
            Console.Write("F(0.5)-F(0.1): " + (func.F(0.5, func.lyambda(m, N)) - func.F(0.1, func.lyambda(m, N))) + "\n");

            Console.Write("\n");

            Console.Write("lyambda = " + lyambda_m + "\n");
            Console.Write("P(0, t): " + func.P(0, t, lyambda_m) + "\n");
            Console.Write("P(1, t): " + func.P(1, t, lyambda_m) + "\n");
            Console.Write("P(4, t): " + func.P(4, t, lyambda_m) + "\n");
            Console.Write("P(>=5, t): " + (1 - (func.P(0, t, lyambda_m) + func.P(1, t, lyambda_m) + func.P(2, t, lyambda_m) + func.P(3, t, lyambda_m) + func.P(4, t, lyambda_m))) + "\n");
            Console.Write("P(<3, t): " + (func.P(0, t, lyambda_m) + func.P(1, t, lyambda_m) + func.P(2, t, lyambda_m)) + "\n");
            Console.Write("P(<=7, t): " + (func.P(0, t, lyambda_m) + func.P(1, t, lyambda_m) + func.P(2, t, lyambda_m) + func.P(3, t, lyambda_m) + func.P(4, t, lyambda_m) + func.P(5, t, lyambda_m) + func.P(6, t, lyambda_m) + func.P(7, t, lyambda_m)) + "\n");
            Console.Write("F(0.5)-F(0.1): " + (func.F(0.5, lyambda_m) - func.F(0.1, lyambda_m)) + "\n");
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba1
{
    class functions
    {
        public double[] ri(double lyam)
        {
            double[] r = new double[23];
            int i = 0;
            Random random = new Random();
            for (i = 0; i < lyam; ++i)
            {
                r[i] = Convert.ToDouble(random.Next(10000)) / 10000;
                Console.Write(r[i] + " ");
            }
            return r;
        }

        public double[] zi(double lyam, double[] r)
        {
            double[] Z = new double[23];
            for (int i = 0; i < lyam; ++i)
            {
                Z[i] = -(1 / lyam) * Math.Log(r[i]);
                Console.Write(Z[i] + ", ");
            }
            return Z;
        }

        public double[] tk_mas(double[] r, double T1, double T2)
        {
            double[] tk = new double[23];
            for (int k = 0; k < 10; ++k)
            {
                double x = 0;
                for (int i = 0; i < k; ++i)
                {
                    x += r[i];//0.0701
                }
                if (x + T1 <= T2)
                {
                    tk[k] = T1 + x;
                }
                else break;
                Console.Write(tk[k] + ", ");
            }
            return tk;
        }

        public double[] tao_mas(double[] tk, double T1, double tao_original)
        {
            double[] tao_mas = new double[25];
            for (int i = 0; i < 25; ++i)
            {
                double sump = 0;
                for (int k = 0; k < 4; ++k)
                    if (tk[k] > T1 && tk[k] < (T1 + tao_original)) sump++;
                tao_mas[i] = sump;
                T1 += tao_original;
                Console.Write(tao_mas[i] + ", ");
            }
            return tao_mas;
        }

        public double[] trebovanija(double[] tao_mas, double T1, double T2)
        {
            double[] count_tao = new double[25];
            double t = T2 - T1;

            Hashtable myHT1 = new Hashtable();
                for (int i = 0; i < 25; ++i)
                {
                    myHT1[tao_mas[i]] = 0;
                }

                for (int i = 0; i < tao_mas.Length; ++i)
                {
                    int temp = (int)myHT1[tao_mas[i]];
                    ++temp;
                    myHT1[tao_mas[i]] = temp;
                    //Console.Write(", " + i + " " + myHT1[tao_mas[i]] + '\n');
                    //Console.Write(temp);
                }
                Console.Write("\n");
                double sum = 0, Np = 0;
                foreach (double key in myHT1.Keys)
                    {
                        int fortemp = (int)myHT1[key];
                        sum += key * fortemp;
                        Np += fortemp;
                        Console.WriteLine(String.Format("{0}: {1}", key, myHT1[key]));
                    }
                double tao_original = (T2 - T1) / 25;
                Console.Write("sum = " + sum + ", tao = " + tao_original + '\n');
                double a = (1 / Np) * sum, lyambda_m = a / tao_original;
            return count_tao;
        }

        public double[] veroyatnosti(double[] tao_mas, double T1, double T2 /*double lyambda_m*/)
        {
            double[] count_tao = new double[25];
            double t = T2 - T1;

            Hashtable myHT1 = new Hashtable();
                for (int i = 0; i < 25; ++i)
                {
                    myHT1[tao_mas[i]] = 0;
                }

                for (int i = 0; i < tao_mas.Length; ++i)
                {
                    int temp = (int)myHT1[tao_mas[i]];
                    ++temp;
                    myHT1[tao_mas[i]] = temp;
                }
                Console.Write("\n");
                double sum = 0, Np = 0;
                foreach (double key in myHT1.Keys)
                    {
                        int fortemp = (int)myHT1[key];
                        sum += key * fortemp;
                        Np += fortemp;
                    }
                double tao_original = (T2 - T1) / 25;
                double a = (1 / Np) * sum, lyambda_m = a / tao_original;

                var func = new functions();
                Console.Write("Nk = " + Np + ", a =  " + a + ", lyambdaa = " + lyambda_m + '\n');

                //double[] mas = new double[] { func.P(0, t, lyambda_m), func.P(1, t, lyambda_m), func.P(4, t, lyambda_m), (1 - (func.P(0, t, lyambda_m) + func.P(1, t, lyambda_m) + func.P(2, t, lyambda_m) + func.P(3, t, lyambda_m) + func.P(4, t, lyambda_m))), (func.P(0, t, lyambda_m) + func.P(1, t, lyambda_m) + func.P(2, t, lyambda_m)), func.P(0, t, lyambda_m) + func.P(1, t, lyambda_m) + func.P(2, t, lyambda_m) + func.P(3, t, lyambda_m) + func.P(4, t, lyambda_m) + func.P(5, t, lyambda_m) + func.P(6, t, lyambda_m) + func.P(7, t, lyambda_m), (func.F(0.5, lyambda_m) - func.F(0.1, lyambda_m)) };
                Console.Write("lyambda = " + lyambda_m + "\n");
                Console.Write("P(0, t): " + func.P(0, t, lyambda_m) + "\n");
                Console.Write("P(1, t): " + func.P(1, t, lyambda_m) + "\n");
                Console.Write("P(4, t): " + func.P(4, t, lyambda_m) + "\n");
                Console.Write("P(>=5, t): " + (1 - (func.P(0, t, lyambda_m) + func.P(1, t, lyambda_m) + func.P(2, t, lyambda_m) + func.P(3, t, lyambda_m) + func.P(4, t, lyambda_m))) + "\n");
                Console.Write("P(<3, t): " + (func.P(0, t, lyambda_m) + func.P(1, t, lyambda_m) + func.P(2, t, lyambda_m)) + "\n");
                Console.Write("P(<=7, t): " + (func.P(0, t, lyambda_m) + func.P(1, t, lyambda_m) + func.P(2, t, lyambda_m) + func.P(3, t, lyambda_m) + func.P(4, t, lyambda_m) + func.P(5, t, lyambda_m) + func.P(6, t, lyambda_m) + func.P(7, t, lyambda_m)) + "\n");
                Console.Write("F(0.5)-F(0.1): " + (func.F(0.5, lyambda_m) - func.F(0.1, lyambda_m)) + "\n");
                return count_tao;
        }
        public double factorial(double n)
        {
            if (n == 0)
                return 1;
            return n * factorial(n - 1);
        }

        public double P(double k, double t, double lyambda)
        {
            double val1 = Math.Pow((lyambda / t), k);
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
            const int N = 23, Nk = 25;
            const double m = 1;
            double T1 = N + 1, T2 = N + 5;// T1 = 24, T2 = 28           
            Console.Write("Nomer gruppy i nomer v zhurnale: " + m + ' ' + N + "\n");
            Console.Write("Parametr vozle m/N: ");
            double param1 = Convert.ToInt32(Console.ReadLine());
            double param2 = Convert.ToInt32(Console.ReadLine());
            double lyam1 = (param1 * ((10 * m) / N));
            double lyam2 = (param2 * ((10 * m) / N));
            double lyam3 = (((param1 + param2) / 2) * ((10 * m) / N));
            Console.Write("lyambda1 = " + lyam1 + ", lyambda2 = " + lyam2 + "\n\n");

            var func = new functions();
            Console.Write("Nachalnyj massiv r1[i]: ");
            func.ri(lyam1);
            Console.Write("\n\n");

            Console.Write("Nachalnyj massiv r2[i]: ");
            func.ri(lyam2);
            Console.Write("\n\n");

            Console.Write("Nachalnyj massiv r1[i]: ");
            func.ri(lyam1);
            Console.Write("\n\n");

            Console.Write("Z1[i] = ");
            func.zi(lyam1, func.ri(lyam1));
            Console.Write("\n\n");

            Console.Write("Z2[i] = ");
            func.zi(lyam2, func.ri(lyam2));
            Console.Write("\n\n");

            Console.Write("t1 = " + T1 + ", t2 = " + T2 + "\n\n");

            Console.Write("massiv tk1 = ");
            func.tk_mas(func.ri(lyam1), T1, T2);
            Console.Write("\n\n");

            Console.Write("massiv tk2 = ");
            func.tk_mas(func.ri(lyam2), T1, T2); 
            Console.Write("\n\n");
            

            double tay = (T2 - T1) / 25;
            Console.Write("tau = " + tay + "\n");

            Console.Write("Mas tao1 = ");
            double tao_original = (T2 - T1) / 25;
            func.tao_mas(func.tk_mas(func.ri(lyam1), T1, T2), T1, tao_original);
            Console.Write("\n\n");
            Console.Write("Mas tao2 = ");
            func.tao_mas(func.tk_mas(func.ri(lyam2), T1, T2), T1, tao_original);
            Console.Write("\n\n");

            double[] sum = new double[25];
            sum = func.tao_mas(func.tk_mas(func.ri(lyam1), T1, T2), T1, tao_original);
            double[] sum2 = new double[25];
            sum2 = func.tao_mas(func.tk_mas(func.ri(lyam2), T1, T2), T1, tao_original);
            double[] r = new double[25];
            double p = 0;
            Console.Write("\n\n");
            Console.Write("Sum mas_tao = ");
            for (int i = 1; i < 25; i++)
            {
                r[i] = sum[i] + sum2[i];
                ++p;
                Console.Write(r[i]);
            }
            Console.Write("\n\n");
            Console.Write("Kol-vo trebovaniy v intervale 1: kov-vo intervalov " + '\n');
            func.trebovanija(func.tao_mas(func.tk_mas(func.ri(lyam1), T1, T2), T1, tao_original), T1, T2);
            Console.Write("\n");
            Console.Write("Kol-vo trebovaniy v intervale 2: kov-vo intervalov " + '\n');
            func.trebovanija(func.tao_mas(func.tk_mas(func.ri(lyam2), T1, T2), T1, tao_original), T1, T2);

           // double a = (1 / Np) * sum, lyambda_m = a / tao_original;    
            Console.Write("Veroyatnosti: "+ "\n");
            func.veroyatnosti(func.tao_mas(func.tk_mas(func.ri(lyam3), T1, T2), T1, tao_original), T1, T2 /*lyambda_m*/);
            Console.Write("\n");
            func.veroyatnosti(func.tao_mas(func.tk_mas(func.ri(lyam1), T1, T2), T1, tao_original), T1, T2);
            Console.Write("\n");
            func.veroyatnosti(func.tao_mas(func.tk_mas(func.ri(lyam2), T1, T2), T1, tao_original), T1, T2);
          }
    }
}

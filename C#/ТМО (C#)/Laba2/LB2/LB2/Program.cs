using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    class Program
    {
        public static double lymbda1(double m, double N) 
        {
            return 9 * (m / N);
        }

        public static double lymbda2(double m, double N) 
        {
            return 13 * (m / N);
        }

        public static double m=1.0;
        public static double N=23.0;
        public static int n=25;

        //1. Згенерувати випадкові рівномірно розподілені числа
        /*public static  double[] randMas()
        {
            double[] r = new double[n];
            Random random = new Random();
            for(int i=0;i<n;++i) {
                r[i] = Convert.ToDouble(random.Next(10000)) / 10000;
            }
            return r;
        }*/

        //3.одержати     для проміжків між вимогами.
        public static double[] ziMas( double[] mas)
        {
            double[] z1 = new double[n];
            for (int i = 0; i < n; ++i) {
                z1[i] = (-1 /lymbda1(m,N) ) * Math.Log(mas[i]);
            }
            return z1;
        }

        //4.одержати послідовність   моментів надходження вимог
        public static double[] tiMas(double[] mas,double t1,double t2)
        {
            double[] tk = new double[n];

            for (int k = 0; k < n; k++) {
                double x = 0;
                for (int i = 0; i <= k; i++) {
                    x += mas[i];
                }
                if (x+t1 <= t2)
                    tk[k] =  t1+x ;
                else break;
            }
            return tk;
        }

        //5.Для кожного проміжку визначити x () – кількість вимог, що потрапили в проміжок довжиною 
        public static double[] countMass(double[] masTay,double[] tk)
        {
            int count = 0;
            double[] countMas = new double[n];
            for(int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (tk[j] > masTay[i] && tk[j] < masTay[i + 1])
                        count++;
                }
                countMas[i] = count;
                count = 0;
            }

            return countMas;
        }

        public static double[] nkMas(double[] countMas,double t1,double t2)
        {
            double maxk=0;
            for(int i = 0; i < n; ++i)
            {
                if(maxk < countMas[i])
                    maxk = countMas[i];
            }
            Console.Write("\n\n maxk=" + maxk + "\n");

            //Console.Write("tabl3");
            double[] nk = new double[(int)maxk + 1];

            int nK = 0;
            for(int i = 0; i <= maxk; ++i) {
                for(int j=0;j<n;++j)
                {
                    if (countMas[j]==i)
                    {
                        nK++;
                    }
                }
                nk[i]=nK;
                nK=0;
            }
            double lymbdaZag;
            double a;
            double sumN = 0;
            for(int i = 0; i <= maxk; ++i)
            {
                sumN += nk[i] * i;
            }
            a = (1.0/n)*sumN;
            Console.Write("\n a = " + a + "\n");
            lymbdaZag = a / ((t2 - t1)/25);
            Console.Write("\n lymbdaSum = " + lymbdaZag + "\n");
            return nk;

        }
        static void Main(string[] args)
        {
            double l1 = lymbda1(m,N);
            double l2  = lymbda2(m,N);
            Console.Write("l1 = "+ l1+"\n"+"l2 = "+l2);
            //1
            double[] r1 = new double[n];
            double[] r2 = new double[n];
            Random random = new Random();
            Console.Write("\n\n r1 = ");
            for (int i = 0; i < r1.Length; ++i)
            {
                //r1[i] = Convert.ToDouble(random.Next(10000)) / 10000;
                r1[i] = random.NextDouble();
                Console.Write(r1[i] + " ");
            }
            Console.Write("\n\n r2 = ");
            for (int i = 0; i < r2.Length; ++i)
            {
                //r2[i] = Convert.ToDouble(random.Next(10000)) / 10000;
                r2[i] = random.NextDouble();
                Console.Write(r2[i] + " ");
            }

            //2
            double[] z1 = ziMas(r1);
            double[] z2 = ziMas(r2);
            Console.Write("\n\n z1 = ");
            for (int i = 0; i < z1.Length; ++i)
            {
                Console.Write(z1[i] + " ");
            }
            Console.Write("\n\n z2 = ");
            for (int i = 0; i < z2.Length; ++i)
            {
                Console.Write(z2[i] + " ");
            }

            //for 3
            double t1 = N + 1;
            double t2 = N + 5;

            Console.Write("\n\n t1 = " + t1 + ", " + "t2 =  " + t2 + " ");

            //3
            double[] ti1 = tiMas(z1,t1,t2);
            double[] ti2 = tiMas(z2,t1,t2);
            Console.Write("\n\n ti1 = ");
            for (int i = 0; i < ti1.Length; ++i)
            {
                Console.Write(ti1[i] + " ");
            }
            Console.Write("\n\n ti2 = ");
            for (int i = 0; i < ti2.Length; ++i)
            {
                Console.Write(ti2[i] + " ");
            }
            Console.Write("\n");

            //4
            double tay = (t2 - t1) / 25;
            Console.Write("\n tay = " + tay + "\n");
            double[] masTay = new double[n+1];
            double newX = t1;
            Console.Write("\n masTay = ");
            for(int i = 1; i < n+1; ++i)
            {
                masTay[i] =+ newX;
                newX += tay;
                Console.Write(masTay[i] + " ");
            }
        
            //5
            Console.Write("\n\n Tabl1:");
            double[] countMas1 = countMass(masTay,ti1);
            double[] countMas2= countMass(masTay,ti2);
            Console.Write("\n\n countMas1 = x1 ");
            for (int i = 0; i < countMas1.Length; ++i)
            {
                Console.Write(countMas1[i] + " ");
            }
            Console.Write("\n\n countMas2 = x2 ");
            for (int i = 0; i < countMas2.Length; ++i)
            {
                Console.Write(countMas2[i] + " ");
            }
            Console.Write("\n");//окончание 1го шага,2 простейших потока

            Console.Write("\n sumCountMas: x1 + x1 ");
            double[] sumCountMas = new double[n];
            for(int i = 0; i < n; ++i)
            {
                sumCountMas[i] = countMas1[i] + countMas2[i];
                Console.Write(sumCountMas[i] + " ");
            }
        
            Console.Write("\n\n lymbda1 = ");
            Console.Write(lymbda1(1,9));
            Console.Write("\n\n lymbda2 = ");
            Console.Write(lymbda2(1,9));


            double a = lymbda1(1,9);
            double b = lymbda2(1,9);
            Console.Write("\n\n l1 + l2 = ");
            Console.Write(a + b);

            double[] nk = nkMas(sumCountMas,t1,t2);
            for (int i = 0; i < nk.Length; ++i)
            {
                Console.Write("\n nk "+ nk[i] + " ");
            }

            double sumI = 0;

            for(int i = 0; i < nk.Length; ++i)
            {
                sumI += (nk[i]*i);
            }

            double MatO = sumI / n;
            Console.Write("\n\n mat0 = " + MatO);

            double D = 0;
            for (int i = 0; i < sumCountMas.Length; ++i)
            {
                D += Math.Pow((sumCountMas[i] - MatO),2);
                //k = pow(D,2);
            }

            //Console.Write("D="+D);

            double disp = D / (n-1);
            Console.Write("\n\n Dispersiya = " + disp + "\n");
        }
    }
}

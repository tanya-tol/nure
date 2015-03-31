using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace MatStat_lb1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            diagramsToolStripMenuItem.Enabled = false;
        }

        #region Fields

        static double m = 1;

        static double N = 4;

        static double NN = 17;

        static double h = 1;//90 секунд = 1,5 минуты

        static double ny = 1 / h;// - интенсивность обслуживания 

        double lambda = (12 * m) / (N*NN);// - интенсивность потока заявок

        #endregion

        private long fact(long a)
        {

            long f = 1;
            for (long k = 0; k < a; ++k)
            {
                long c = a - k;
                f *= c;
            }
            return f;
        }

        double F(double t, double lambda)
        {
            return (1 - Math.Exp(-lambda * t));
        }

        double calcZi(double val)
        {
            return ((-1 / lambda) * Math.Log(val));
        }

        double calcKSIi(double val)
        {
            return ((-1 / ny) * Math.Log(val));
        }

        double P_ot_t(double t, double lambda, double i)
        {
            return (Math.Pow(lambda * t, i) / fact((long)i)) * Math.Exp(-lambda * t);
        }

        double T1 = NN + 1;

        double T2 = NN + 200;

        List<Trebovanie> list = new List<Trebovanie>();

        Dictionary<double, int> nakopitel = new Dictionary<double, int>();

        List<Trebovanie> rabota_kanalov = new List<Trebovanie>();

        public void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        double calctk(double val)
        {
            return ((-1 / lambda) * Math.Log(val));
        }

        private void calc(double T1, double T2, int maxRi, double[] Ri, double[] Zi, double[] KSIi, double lambda)
        {
            int k_post = 0;

            int k_ocheredi = 0;

            int count_queue = 0;
            do{
                k_post = 0;
                k_ocheredi = 0;
                count_queue = 0;
                nakopitel.Clear();
                rabota_kanalov.Clear();
            textBox1.ScrollBars = ScrollBars.Vertical;
            Random rand = new Random();

            Random randKSI = new Random();

            double[] tk = new double[maxRi];

            double[] KSItk = new double[maxRi];

            double[] p = new double[maxRi];

            for (int i = 0; i < p.Length;++i )
            {
                p[i] = 0;
            }

            textBox1.Text += "T1=" + T1 + "\r\n";

            textBox1.Text += "T2=" + T2 + "\r\n";

            for (int i = 0; i < maxRi; ++i)
                Ri[i] = rand.NextDouble();
            textBox1.Text += "lambda=" + lambda + "\r\n";

            for (int i = 0; i < maxRi; ++i)
            {
                Zi[i] = calcZi(Ri[i]);
                KSIi[i] = calcKSIi(randKSI.NextDouble());
            }

            int k = 0;
            int counttk = 0;
            do
            {
                double sumZi = 0;
                for (int i = 0; i < k + 1; ++i)
                {
                    sumZi += Zi[i];
                }
                tk[k] = T1 + sumZi;
                ++k;
                counttk = k;
                --k;
            } while (tk[k++] <= T2);


            int KSIk = 0;
            int KSIcounttk = 0;
            do
            {
                double sumKSIi = 0;
                for (int i = 0; i < KSIk + 1; ++i)
                {
                    sumKSIi += KSIi[i];
                }
                KSItk[KSIk] = T1 + sumKSIi;
                ++KSIk;
                KSIcounttk = KSIk;
                --KSIk;
            } while (KSItk[KSIk++] <= T2);


            List<double> zayavki = new List<double>();
            //double[] zayavki = new double[counttk];

            for (int i = 0; i < tk.Length; ++i )
            {
                if(tk[i]>T1&&tk[i]<T2)
                {
                    zayavki.Add(tk[i]);
                }
            }

            Queue<Trebovanie> q = new Queue<Trebovanie>();

            double t0 = T1;

            double t1 = T1;

            double t2 = T1;

            double t3 = T1;

            double t4 = T1;

            bool b_queue = false;
          
                for (int i = 0; i < zayavki.Count; ++i)
                {
                    t0 += Zi[i];
                    Trebovanie tr = new Trebovanie(t0);
                    ++k_post;

                queueElement:
                    if (t0 > t1)
                    {

                        t1 = t0;
                        double ksi = calcKSIi(randKSI.NextDouble());
                        t1 += ksi;
                        tr.t_obslugivania = t1;
                        tr.kanal = 1;
                        rabota_kanalov.Add(tr);
                        b_queue = true;
                    }
                    else if (t0 > t2)
                    {
                        t2 = t0;
                        double ksi = calcKSIi(randKSI.NextDouble());
                        t2 += ksi;
                        tr.t_obslugivania = t2;
                        tr.kanal = 2;
                        rabota_kanalov.Add(tr);
                        b_queue = true;
                    }
                    else if (t0 > t3)
                    {
                        t3 = t0;
                        double ksi = calcKSIi(randKSI.NextDouble());
                        t3 += ksi;
                        tr.t_obslugivania = t3;
                        tr.kanal = 3;
                        rabota_kanalov.Add(tr);
                        b_queue = true;
                    }
                    else if (t0 > t4)
                    {
                        t4 = t0;
                        double ksi = calcKSIi(randKSI.NextDouble());
                        t4 += ksi;
                        tr.t_obslugivania = t4;
                        tr.kanal = 4;
                        rabota_kanalov.Add(tr);
                        b_queue = true;
                    }
                    else
                    {
                        if (!q.Contains(tr))
                        {
                            tr.r = t0;
                            q.Enqueue(tr);
                            ++k_ocheredi;
                            ++count_queue;
                            b_queue = false;
                        }
                    }
                    list.Add(tr);
                    for (int j = 0; j < q.Count; ++j)
                    {
                        q.ElementAt(j).r = t0;
                    }
                    if (q.Count != 0 && b_queue == true)
                    {
                        tr = q.Dequeue();
                        --k_ocheredi;
                        goto queueElement;
                    }
                    nakopitel.Add(t0, k_ocheredi);
                }

                textBox1.Text += "k_post: " + k_post + " " + "k_ocheredi: " + count_queue + "\r\n";

            textBox1.Text += "k_ocheredi/k_post: " + ((double)count_queue / (double)k_post) + "\r\n";

            } while (((double)count_queue / (double)k_post) > 0.058);
        }

        private void drawGrafic()
        {
            GraphPane pane = zedGraph.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            pane.XAxis.Title.Text = "";
            pane.YAxis.Title.Text = "";
            pane.Title.Text = "График работы накопителя";
            // Создадим список точек
            PointPairList list = new PointPairList();

            // Интервал, в котором будут лежать точки
            //int xmin = -100;
            //int xmax = 100;

            //int ymin = -100;
            //int ymax = 100;

            //int pointsCount = 50;

            //Random rnd = new Random();

            // Заполняем список точек
            for (int i = 0; i < nakopitel.Count; ++i)
            {
                list.Add(nakopitel.ElementAt(i).Key, nakopitel.ElementAt(i).Value);
            }

            // !!!
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurve = pane.AddCurve("", list, Color.Black, SymbolType.Circle);

            // !!!
            // У кривой линия будет видимой
            myCurve.Line.IsVisible = true;

            // !!!
            // Цвет заполнения отметок (ромбиков) - колубой
            myCurve.Symbol.Fill.Color = Color.Black;

            // !!!
            // Тип заполнения - сплошная заливка
            myCurve.Symbol.Fill.Type = FillType.Solid;

            // !!!
            // Размер ромбиков
            myCurve.Symbol.Size = 5;


            //// Устанавливаем интересующий нас интервал по оси X
            //pane.XAxis.Scale.Min = xmin;
            //pane.XAxis.Scale.Max = xmax;

            //// Устанавливаем интересующий нас интервал по оси Y
            //pane.YAxis.Scale.Min = ymin;
            //pane.YAxis.Scale.Max = ymax;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        private void fxToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void potok1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Potok1 = new Potok1(rabota_kanalov);
            this.AddOwnedForm(Potok1);
            Potok1.Show();
        }

        private void potok2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int maxRi = (int)(2 * lambda * T2);

            double[] Ri = new double[maxRi];

            double[] Zi = new double[maxRi];

            double[] KSIi = new double[maxRi];

            textBox1.Text = "";

            diagramsToolStripMenuItem.Enabled = true;

            calc(T1, T2, maxRi, Ri, Zi, KSIi, lambda);
            drawGrafic();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
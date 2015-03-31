using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace MatStat_lb1
{
    public partial class Potok1 : Form
    {
        public Potok1()
        {
            InitializeComponent();
        }

        public List<Trebovanie> rabota_kanalov = new List<Trebovanie>();

        public Potok1(List<Trebovanie> z)
        {
            this.rabota_kanalov = z;
            InitializeComponent();
        }

        private void drawGrafic(List<Trebovanie> XotTao)
        {
            GraphPane pane = zedGraph.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            pane.XAxis.Title.Text = "";
            pane.YAxis.Title.Text = "";
            pane.Title.Text = "График работы каналов";
            

            rabota_kanalov.Sort();

            //double[] YValues1 = rabota_kanalov.

            // Интервал, в котором будут лежать точки
            //int xmin = -100;
            //int xmax = 100;

            //int ymin = -100;
            //int ymax = 100;

            //int pointsCount = 50;

            //Random rnd = new Random();

            // Заполняем список точек
            for (int i = 0; i < rabota_kanalov.Count; ++i)
            {
                // Создадим список точек
                PointPairList list = new PointPairList();
                list.Add(rabota_kanalov.ElementAt(i).t_postupleniya, rabota_kanalov.ElementAt(i).kanal);
                list.Add(rabota_kanalov.ElementAt(i).t_obslugivania, rabota_kanalov.ElementAt(i).kanal);
                LineItem myCurve = pane.AddCurve("", list, Color.Black, SymbolType.Circle);
                // !!!
                // У кривой линия будет видимой
                myCurve.Line.IsVisible = true;

                //.Line.StepType = StepType.NonStep;

                //myCurve.Line.

                // !!!
                // Цвет заполнения отметок (ромбиков) - колубой
                myCurve.Symbol.Fill.Color = Color.Black;

                // !!!
                // Тип заполнения - сплошная заливка
                myCurve.Symbol.Fill.Type = FillType.Solid;

                // !!!
                // Размер ромбиков
                myCurve.Symbol.Size = 0;
            }

            // !!!
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            

            


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

        private void Potok1_Load(object sender, EventArgs e)
        {
            drawGrafic(rabota_kanalov);
        }
    }
}

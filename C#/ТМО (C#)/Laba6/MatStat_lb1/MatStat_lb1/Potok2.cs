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
    public partial class Potok2 : Form
    {
        public Potok2()
        {
            InitializeComponent();
        }

        public int[] XotTao;

        public Potok2(int[] z)
        { 
             this.XotTao = z;
            InitializeComponent();
        }

        private void drawGrafic(int[] XotTao)
        {
            GraphPane pane = zedGraph.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            pane.XAxis.Title.Text = "";
            pane.YAxis.Title.Text = "";
            pane.Title.Text = "График х(t) potok2";
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
            for (int i = 0; i < 25; ++i)
            {
                list.Add(i + 1, XotTao[i]);
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

        private void Potok2_Load(object sender, EventArgs e)
        {
            drawGrafic(XotTao);
        }
    }
}

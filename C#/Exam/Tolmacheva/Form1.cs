using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tolmacheva
{
    public partial class СCreateButton : Form
    {
        public СCreateButton()
        {
            InitializeComponent();
            
        }

        Tolmacheva.Rectangle figure1;
        Tolmacheva.Triangle figure2;

        public void CreateButton_Click(object sender, EventArgs e)
        {
            figure1 = new Tolmacheva.Rectangle(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            OutLogBox.AppendText("Создана фигура с высотой " + textBox1.Text + " и длиной " + textBox2.Text + ".\n");
        }
        public void butPerimRect_Click(object sender, EventArgs e)
        {
            OutLogBox.AppendText("Периметр прямоугольника: " + figure1.CalcPerimetrRectangle() + "\n");
        }

        public void butSquareRect_Click(object sender, EventArgs e)
        {
            OutLogBox.AppendText("Площадь прямоугольника: " + figure1.CalcSquareRectangle() + "\n");
        }

        public void butPerTriangle_Click(object sender, EventArgs e)
        {
            OutLogBox.AppendText("Периметр треугольника: " + figure2.CalcPerimetrTriangle() + "\n");
        }

        public void butSquareTriangle_Click(object sender, EventArgs e)
        {
            OutLogBox.AppendText("Площадь треугольника: " + figure2.CalcSquareTriangle() + "\n");

        }

        private void CreateButton2_Click_1(object sender, EventArgs e)
        {
            figure2 = new Tolmacheva.Triangle(int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox6.Text), int.Parse(textBox7.Text));
            OutLogBox.AppendText("Создана фигура с ребром " + textBox3.Text + " высотой " + textBox4.Text + "ребром " + textBox6.Text + " ребром " + textBox7.Text + ".\n");

        }
    }
}

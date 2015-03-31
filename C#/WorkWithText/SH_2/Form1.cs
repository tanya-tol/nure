using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SH_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog() ;
            string fileName = openFileDialog1.FileName;

            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
			if(stream != null)
			{
				StreamReader reader = new StreamReader(stream);
				textBox1.Text = reader.ReadToEnd ();

                List<decimal> list_num = new List<decimal>();
                List<string> list_bukvy = new List<string>();
                decimal number;
                string bukvy;
                string str = textBox1.Text;
                string[] nums = str.Split(new char[] { ' ', ',', '.', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int count = 0;
                for (int i = 0; i < nums.Length; ++i)
                {
                    if (decimal.TryParse(nums[i], out number))
                        ++count;
                }
                textBox2.Text = count.ToString();
				stream.Close();

                for (int i = 0; i < nums.Length; ++i)
                {
                    if (decimal.TryParse(nums[i], out number))
                        list_num.Add(number);
                    else list_bukvy.Add(bukvy);
                }
                textBox5.Text = list_num.Min().ToString();
                textBox4.Text = list_num.Max().ToString();

                for (int i = 0; i < nums.Length; ++i)
                {
                    decimal number;
                    if (decimal.TryParse(nums[i], out number))
                        lisr_num.Add(number);
                    elseblisr_words.Add(nums[i]);
                    textBox3.Text = string.Join(", ", list_words.ToArray().Distinct());
                }
			}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fileName = saveFileDialog1.FileName;
            FileStream stream = File.Open(fileName, FileMode.Create, FileAccess.Write);
            if (stream != null)
            {
                StreamWriter writer = new StreamWriter(stream);

                writer.Write(textBox5.Text);
                writer.Write(textBox4.Text);
                writer.Write(textBox3.Text);
                writer.Flush();
                stream.Close();
            }
        }
    }
}

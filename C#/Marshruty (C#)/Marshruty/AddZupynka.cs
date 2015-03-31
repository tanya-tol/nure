using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Marshruty
{
    public partial class AddZupynka : Form
    {
        public AddZupynka()
        {
            InitializeComponent();
        }


        private void DodBut_Click(object sender, EventArgs e)
        {
            if (NazvaBox.Text == String.Empty)
            {
                MessageBox.Show("Заповнені не всі поля!\r\nВсі поля повинні бути заповнені.", "Помилка заповнення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String InsertZupynka = "INSERT INTO Zupynka (Nazva) VALUES('" + NazvaBox.Text + "')";
                using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
                {
                    connection.Open();

                    OleDbCommand cmd = new OleDbCommand(InsertZupynka, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Зупинку додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    return;
                }
                MessageBox.Show("Помилка з'єднання з БД.", "Помилка з'єднаня", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

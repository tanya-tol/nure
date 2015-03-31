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
    public partial class AddPersonal : Form
    {
        public AddPersonal()
        {
            InitializeComponent();
        }

        private void DodBut_Click(object sender, EventArgs e)
        {
            if (FIOBox.Text == String.Empty || ProfBox.Text == String.Empty || RobTelBox.Text == String.Empty || DomTelBox.Text == String.Empty || DomAdressBox.Text == String.Empty)
            {
                MessageBox.Show("Заповнені не всі поля!\r\nВсі поля повинні бути заповнені.", "Помилка заповнення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String InsertPersonal = "INSERT INTO OsobystiDaniPersonala (FIO, Professija, DataPochatRoboty, RobochyjTelephon, DataNarodzhennya, DomTelephon, DomAdresa) VALUES('" + FIOBox.Text + "','" + ProfBox.Text + "','" + DatePochRob.Value.Date.ToString("yyyy-MM-dd") + "','" + RobTelBox.Text + "','" + DateNarod.Value.Date.ToString("yyyy-MM-dd") + "','" + DomTelBox.Text + "','" + DomAdressBox.Text + "')";
                using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
                {
                    connection.Open();

                    OleDbCommand cmd = new OleDbCommand(InsertPersonal, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Персонал додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    return;
                }
                MessageBox.Show("Помилка з'єднання з БД.", "Помилка з'єднаня", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

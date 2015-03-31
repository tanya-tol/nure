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
    public partial class AddAutobus : Form
    {
        public AddAutobus()
        {
            InitializeComponent();
        }

        private void DodBut_Click(object sender, EventArgs e)
        {
            if (GosNomerBox.Text == String.Empty || KilometrBox.Text == String.Empty || MarkaBox.Text == String.Empty || YearBox.Text == String.Empty)
            {
                MessageBox.Show("Заповнені не всі поля!\r\nВсі поля повинні бути заповнені.", "Помилка заповнення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String InsertMarshrut = "INSERT INTO AutobusPark (GosNomerID, SkilkiProjihav, MarkaAutobus, RikVypuska) VALUES('" + GosNomerBox.Text + "','" + KilometrBox.Text + "','" + MarkaBox.Text + "','" + YearBox.Text + "')";
                using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
                {
                    connection.Open();

                    OleDbCommand cmd = new OleDbCommand(InsertMarshrut, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Автобус додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    return;
                }
                MessageBox.Show("Помилка з'єднання з БД.", "Помилка з'єднаня", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FindBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(GosNomerBox.Text))
            {
                
            }
        }

        private void AddAutobus_Load(object sender, EventArgs e)
        {

        }
    }
}

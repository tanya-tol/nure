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
    public partial class ViewAutobus : Form
    {
        public ViewAutobus()
        {
            InitializeComponent();
        }


        private void ViewAutobus_Load(object sender, EventArgs e)
        {
            ViewAutobus_GridLoad();
        }

        private void ViewAutobus_GridLoad()
        {
            String queryAuto = "SELECT GosNomerID AS [ID], SkilkiProjihav AS [Скільки проїхав], MarkaAutobus AS [Марка автобуса], RikVypuska AS [Рік випуска] FROM AutobusPark";

            if (!string.IsNullOrEmpty(NazvaBox.Text) && !NazvaBox.Text.Equals("Гос. номер", StringComparison.OrdinalIgnoreCase))
            {
                queryAuto += " WHERE GosNomerID LIKE '%" + NazvaBox.Text + "%'";
            }

            DataSet AutoDS = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbDataAdapter AutoAdapter = new OleDbDataAdapter(queryAuto, connection);
                OleDbCommandBuilder AutoBuilder = new OleDbCommandBuilder(AutoAdapter);
                AutoAdapter.Fill(AutoDS, "Autobus");
                connection.Close();
            }

            AutoGridView.ReadOnly = true;
            AutoGridView.AllowUserToAddRows = false;
            AutoGridView.AllowUserToDeleteRows = false;
            AutoGridView.AllowUserToOrderColumns = true;
            AutoGridView.RowHeadersVisible = false;
            AutoGridView.DataSource = AutoDS;
            AutoGridView.DataMember = "Autobus";
            AutoGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AutoGridView.Columns["ID"].Visible = true;
        }

        private void NazvaBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NazvaBox.Text))
            {
                NazvaBox.Text = "Гос. номер";
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            ViewAutobus_GridLoad();
        }

        

        private void NazvaBox_Enter(object sender, EventArgs e)
        {
            if (NazvaBox.Text.Equals("Гос. номер", StringComparison.OrdinalIgnoreCase))
            {
                NazvaBox.Text = string.Empty;
            }
        }

        private void ViewAutobus_Load_1(object sender, EventArgs e)
        {

        }

        private void AutoGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            if (AutoGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Ви справді хочите видалити запис?", "Видалення маршруту", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
                    {
                        connection.Open();
                        string DeleteQuery = string.Format("DELETE AutobusPark WHERE GosNomerID = '" + AutoGridView.CurrentRow.Cells[0].Value + "';");
                        OleDbCommand commandUpdate = new OleDbCommand(DeleteQuery, connection);
                        commandUpdate.ExecuteNonQuery();
                        connection.Close();
                    }
                    AutoGridView.Rows.RemoveAt(AutoGridView.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Ви не виділили рядок для видалення!", "Помилка", MessageBoxButtons.OK);
            }
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            AddAutobus AddAutobusWindow = new AddAutobus();
            AddAutobusWindow.Show();
        }
    }
}

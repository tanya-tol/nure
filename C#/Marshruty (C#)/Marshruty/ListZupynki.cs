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
    public partial class ListZupynki : Form
    {
        public ListZupynki()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ListGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Ви справді хочите видалити запис?", "Видалення зупинки", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
                    {
                        connection.Open();
                        string DeleteQuery = string.Format("DELETE Zupynka WHERE ZupynkaID = '" + ListGridView.CurrentRow.Cells[0].Value + "';");
                        OleDbCommand commandUpdate = new OleDbCommand(DeleteQuery, connection);
                        commandUpdate.ExecuteNonQuery();
                        connection.Close();
                    }
                    ListGridView.Rows.RemoveAt(ListGridView.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Ви не виділили рядок для видалення!", "Помилка", MessageBoxButtons.OK);
            }
        }

        private void ListZupynki_Load(object sender, EventArgs e)
        {
            ListZupynki_GridLoad();
        }

        private void ListZupynki_GridLoad()
        {
            String queryZupyn = "SELECT ZupynkaID AS [Номер зупинки], Nazva AS [Назва] FROM Zupynka";

            if (!string.IsNullOrEmpty(NazvaBox.Text) && !NazvaBox.Text.Equals("Назва", StringComparison.OrdinalIgnoreCase))
            {
                queryZupyn += " WHERE Nazva LIKE '%" + NazvaBox.Text + "%'";
            }

            DataSet ZupynDS = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbDataAdapter ZupynAdapter = new OleDbDataAdapter(queryZupyn, connection);
                OleDbCommandBuilder ZupynBuilder = new OleDbCommandBuilder(ZupynAdapter);
                ZupynAdapter.Fill(ZupynDS, "Zupyn");
                connection.Close();
            }

            ListGridView.ReadOnly = true;
            ListGridView.AllowUserToAddRows = false;
            ListGridView.AllowUserToDeleteRows = false;
            ListGridView.AllowUserToOrderColumns = true;
            ListGridView.RowHeadersVisible = false;
            ListGridView.DataSource = ZupynDS;
            ListGridView.DataMember = "Zupyn";
            ListGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void NazvaBox_Enter(object sender, EventArgs e)
        {
            if (NazvaBox.Text.Equals("Назва", StringComparison.OrdinalIgnoreCase))
            {
                NazvaBox.Text = string.Empty;
            }
        }

        private void NazvaBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NazvaBox.Text))
            {
                NazvaBox.Text = "Назва";
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            ListZupynki_GridLoad();
        }
    }
}

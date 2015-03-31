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
    public partial class ViewMarshrut : Form
    {
        public ViewMarshrut()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MarshGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Ви справді хочите видалити запис?", "Видалення маршруту", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
                    {
                        connection.Open();
                        string DeleteQuery = string.Format("DELETE Marshruty WHERE NomerMarshID = '" + MarshGridView.CurrentRow.Cells[0].Value + "';");
                        OleDbCommand commandUpdate = new OleDbCommand(DeleteQuery, connection);
                        commandUpdate.ExecuteNonQuery();
                        connection.Close();
                    }
                    MarshGridView.Rows.RemoveAt(MarshGridView.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Ви не виділили рядок для видалення!", "Помилка", MessageBoxButtons.OK);
            }
        }

        private void ViewMarshrut_Load(object sender, EventArgs e)
        {
            ViewMarshrut_GridLoad();
        }

        private void ViewMarshrut_GridLoad()
        {
            String queryMarsh = "SELECT NomerMarshID AS [ID], Nazva AS [Назва], DovzhinaMarshruta AS [Протяжність маршруту], ChasVDorozi AS [Час в дорозі] FROM Marshruty";

            if (!string.IsNullOrEmpty(NazvaBox.Text) && !NazvaBox.Text.Equals("Назва", StringComparison.OrdinalIgnoreCase))
            {
                queryMarsh += " WHERE Nazva LIKE '%" + NazvaBox.Text + "%'";
            }

            DataSet MarshDS = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbDataAdapter MarshAdapter = new OleDbDataAdapter(queryMarsh, connection);
                OleDbCommandBuilder MarshBuilder = new OleDbCommandBuilder(MarshAdapter);
                MarshAdapter.Fill(MarshDS, "Marshs");
                connection.Close();
            }

            MarshGridView.ReadOnly = true;
            MarshGridView.AllowUserToAddRows = false;
            MarshGridView.AllowUserToDeleteRows = false;
            MarshGridView.AllowUserToOrderColumns = true;
            MarshGridView.RowHeadersVisible = false;
            MarshGridView.DataSource = MarshDS;
            MarshGridView.DataMember = "Marshs";
            MarshGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MarshGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MarshGridView.Columns["ID"].Visible = false;
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
            ViewMarshrut_GridLoad();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddMarshrut AddMarshrutWindow = new AddMarshrut();
            AddMarshrutWindow.Show();
        }
    }
}

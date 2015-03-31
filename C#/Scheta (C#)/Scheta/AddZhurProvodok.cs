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

namespace Scheta
{
    public partial class AddZhurProvodok : Form
    {
        public static string ConnectionString = "Provider=SQLOLEDB;Data Source=Eee_O\\SQLEXPRESS;Initial Catalog=ISBO;Persist Security Info=True;User ID=lab;Password=lab;";
        OleDbConnection connection = new OleDbConnection(ConnectionString);

        public AddZhurProvodok()
        {
            InitializeComponent();
        }

        private void AddZhurProvodok_Load(object sender, EventArgs e)
        {
            String queryAddZhProv = "SELECT id AS [ID], type AS [Type], operation AS [Operation], summa AS [SumProv] FROM ZhurnalProvodok;";

            connection.Open();

            DataSet AddZhProvDS = new DataSet();
            OleDbDataAdapter AddZhProvAdapter = new OleDbDataAdapter(queryAddZhProv, connection);
            OleDbCommandBuilder AddZhProvBuilder = new OleDbCommandBuilder(AddZhProvAdapter);
            AddZhProvAdapter.Fill(AddZhProvDS, "AddZhProv");

            connection.Close();

            AddZhPrGridView.ReadOnly = true;
            AddZhPrGridView.AllowUserToAddRows = false;
            AddZhPrGridView.AllowUserToDeleteRows = false;
            AddZhPrGridView.AllowUserToOrderColumns = true;
            AddZhPrGridView.RowHeadersVisible = false;
            AddZhPrGridView.DataSource = AddZhProvDS;
            AddZhPrGridView.DataMember = "AddZhProv";
            AddZhPrGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AddZhPrGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AddZhPrGridView.Columns["id"].Visible = true;
        }

        private void AddZhPButton_Click(object sender, EventArgs e)
        {
            String InsertAccount = "INSERT INTO ZhurnalProvodok (type, operation, summa) VALUES( '" + TypeTextBox.Text + DocINTextBox.Text + SumProvTextBox.Text +"')";

            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(InsertAccount, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();
                return;
            }
        }

        private void AddZhPrGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            String queryAddZhProv = "SELECT id AS [ID], type AS [Type], operation AS [Operation], summa AS [SumProv] FROM ZhurnalProvodok;";

            connection.Open();

            DataSet AddZhProvDS = new DataSet();
            OleDbDataAdapter AddZhProvAdapter = new OleDbDataAdapter(queryAddZhProv, connection);
            OleDbCommandBuilder AddZhProvBuilder = new OleDbCommandBuilder(AddZhProvAdapter);
            AddZhProvAdapter.Fill(AddZhProvDS, "AddZhProv");

            connection.Close();

            AddZhPrGridView.ReadOnly = true;
            AddZhPrGridView.AllowUserToAddRows = false;
            AddZhPrGridView.AllowUserToDeleteRows = false;
            AddZhPrGridView.AllowUserToOrderColumns = true;
            AddZhPrGridView.RowHeadersVisible = false;
            AddZhPrGridView.DataSource = AddZhProvDS;
            AddZhPrGridView.DataMember = "AddZhProv";
            AddZhPrGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AddZhPrGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AddZhPrGridView.Columns["id"].Visible = true;
        }

        
    }
}

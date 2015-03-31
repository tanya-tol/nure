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
    public partial class AddZhurOperazij : Form
    {
        public static string ConnectionString = "Provider=SQLOLEDB;Data Source=Eee_O\\SQLEXPRESS;Initial Catalog=ISBO;Persist Security Info=True;User ID=lab;Password=lab;";
        OleDbConnection connection = new OleDbConnection(ConnectionString);

        public AddZhurOperazij()
        {
            InitializeComponent();
        }

        private void AddZhOperGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddZhurOperazij_Load(object sender, EventArgs e)
        {
            String queryAddZhOper = "SELECT data AS [Date], price AS [Price], quantity AS [Kil-t'], total AS [SumDoc], type_zn AS [TypDocID], agent_id AS [KAgentID], nomenclature_id AS [NomID] FROM ZhurnalOperations;";

            connection.Open();

            DataSet AddZhOperDS = new DataSet();
            OleDbDataAdapter AddZhOperAdapter = new OleDbDataAdapter(queryAddZhOper, connection);
            OleDbCommandBuilder AddZhOperBuilder = new OleDbCommandBuilder(AddZhOperAdapter);
            AddZhOperAdapter.Fill(AddZhOperDS, "AddZhOper");

            connection.Close();

            AddZhOperGridView.ReadOnly = true;
            AddZhOperGridView.AllowUserToAddRows = false;
            AddZhOperGridView.AllowUserToDeleteRows = false;
            AddZhOperGridView.AllowUserToOrderColumns = true;
            AddZhOperGridView.RowHeadersVisible = false;
            AddZhOperGridView.DataSource = AddZhOperDS;
            AddZhOperGridView.DataMember = "AddZhOper";
            AddZhOperGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AddZhOperGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //AddZhOperGridView.Columns["id"].Visible = true;
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            String InsertZhurOper = "INSERT INTO ZhurnalOperations (data, price, quantity, total, type_zn, agent_id, nomenclature_id) VALUES( '" + dateTimePicker.Text + PriceTextBox.Text + CountTextBox.Text + SumDocTextBox.Text + TypDocINTextBox.Text + KAgentINTextBox.Text + NomINTextBox.Text +"')";

            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(InsertZhurOper, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();
                return;
            }
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            String queryAddZhOper = "SELECT data AS [Date], price AS [Price], quantity AS [Kil-t'], total AS [SumDoc], type_zn AS [TypDocID], agent_id AS [KAgentID], nomenclature_id AS [NomID] FROM ZhurnalOperations;";

            connection.Open();

            DataSet AddZhOperDS = new DataSet();
            OleDbDataAdapter AddZhOperAdapter = new OleDbDataAdapter(queryAddZhOper, connection);
            OleDbCommandBuilder AddZhOperBuilder = new OleDbCommandBuilder(AddZhOperAdapter);
            AddZhOperAdapter.Fill(AddZhOperDS, "AddZhOper");

            connection.Close();

            AddZhOperGridView.ReadOnly = true;
            AddZhOperGridView.AllowUserToAddRows = false;
            AddZhOperGridView.AllowUserToDeleteRows = false;
            AddZhOperGridView.AllowUserToOrderColumns = true;
            AddZhOperGridView.RowHeadersVisible = false;
            AddZhOperGridView.DataSource = AddZhOperDS;
            AddZhOperGridView.DataMember = "AddZhOper";
            AddZhOperGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AddZhOperGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //AddZhOperGridView.Columns["id"].Visible = true;
        }
    }
}

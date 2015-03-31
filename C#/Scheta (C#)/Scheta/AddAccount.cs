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
    public partial class AddAccount : Form
    {
        public static string ConnectionString = "Provider=SQLOLEDB;Data Source=Eee_O\\SQLEXPRESS;Initial Catalog=ISBO;Persist Security Info=True;User ID=lab;Password=lab;";
        OleDbConnection connection = new OleDbConnection(ConnectionString);

        public AddAccount()
        {
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            String queryAddAccount = "SELECT id AS [ID], name AS [Name], primechanija AS [Prymitki] FROM Account;";

            connection.Open();

            DataSet AddAccountDS = new DataSet();
            OleDbDataAdapter AddAccountAdapter = new OleDbDataAdapter(queryAddAccount, connection);
            OleDbCommandBuilder AddAccountBuilder = new OleDbCommandBuilder(AddAccountAdapter);
            AddAccountAdapter.Fill(AddAccountDS, "AddAccount");

            connection.Close();

            AddAccountGridView.ReadOnly = true;
            AddAccountGridView.AllowUserToAddRows = false;
            AddAccountGridView.AllowUserToDeleteRows = false;
            AddAccountGridView.AllowUserToOrderColumns = true;
            AddAccountGridView.RowHeadersVisible = false;
            AddAccountGridView.DataSource = AddAccountDS;
            AddAccountGridView.DataMember = "AddAccount";
            AddAccountGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AddAccountGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AddAccountGridView.Columns["id"].Visible = true;
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            String InsertAccount = "INSERT INTO Account (name) VALUES( '" + NameTextBox.Text + PrymitkyBox.Text + "')";

            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(InsertAccount, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Дані додані!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();
                return;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            String queryAddAccount = "SELECT id AS [ID], name AS [Name], primechanija AS [Prymitki] FROM Account;";

            connection.Open();

            DataSet AddAccountDS = new DataSet();
            OleDbDataAdapter AddAccountAdapter = new OleDbDataAdapter(queryAddAccount, connection);
            OleDbCommandBuilder AddAccountBuilder = new OleDbCommandBuilder(AddAccountAdapter);
            AddAccountAdapter.Fill(AddAccountDS, "AddAccount");

            connection.Close();

            AddAccountGridView.ReadOnly = true;
            AddAccountGridView.AllowUserToAddRows = false;
            AddAccountGridView.AllowUserToDeleteRows = false;
            AddAccountGridView.AllowUserToOrderColumns = true;
            AddAccountGridView.RowHeadersVisible = false;
            AddAccountGridView.DataSource = AddAccountDS;
            AddAccountGridView.DataMember = "AddAccount";
            AddAccountGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AddAccountGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AddAccountGridView.Columns["id"].Visible = true;
        }
    }
}

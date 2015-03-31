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
    public partial class AddTurnSheets : Form
    {
        public static string ConnectionString = "Provider=SQLOLEDB;Data Source=Eee_O\\SQLEXPRESS;Initial Catalog=ISBO;Persist Security Info=True;User ID=lab;Password=lab;";
        OleDbConnection connection = new OleDbConnection(ConnectionString);

        public AddTurnSheets()
        {
            InitializeComponent();
        }

        private void AddTurnSheets_Load(object sender, EventArgs e)
        {
            String queryAddTurnSheets = "SELECT id AS [ID], turn_credit AS [turn_cr], turn_debit AS [turn_d], saldo_beg_credit AS [saldo_beg_cr], saldo_beg_debit AS [saldo_beg_d], saldo_fin_credit AS [saldo_fin_cr], saldo_fin_debit AS [saldo_fin_d] FROM OborotSaldVedom;";

            connection.Open();

            DataSet AddTurnSheetsDS = new DataSet();
            OleDbDataAdapter AddTurnSheetsAdapter = new OleDbDataAdapter(queryAddTurnSheets, connection);
            OleDbCommandBuilder AddTurnBuilder = new OleDbCommandBuilder(AddTurnSheetsAdapter);
            AddTurnSheetsAdapter.Fill(AddTurnSheetsDS, "AddTurnSheets");

            connection.Close();

           AddTurnSheetsGridView.ReadOnly = true;
           AddTurnSheetsGridView.AllowUserToAddRows = false;
           AddTurnSheetsGridView.AllowUserToDeleteRows = false;
           AddTurnSheetsGridView.AllowUserToOrderColumns = true;
           AddTurnSheetsGridView.RowHeadersVisible = false;
           AddTurnSheetsGridView.DataSource = AddTurnSheetsDS;
           AddTurnSheetsGridView.DataMember = "AddTurnSheets";
           AddTurnSheetsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           AddTurnSheetsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           AddTurnSheetsGridView.Columns["id"].Visible = true;
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            String InsertTurnSheets = "INSERT INTO OborotSaldVedom (id, turn_credit, turn_debit, saldo_beg_credit, saldo_beg_debit, saldo_fin_credit, saldo_fin_debit) VALUES( '" + IDTextBox.Text + turnCreditTextBox.Text + turnDebitTextBox.Text + SaldoBegCreditBox.Text + SaldoBegDebitBox.Text + SladoFinCreditBox.Text + SaldoFinDebitBox.Text + "')";

            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(InsertTurnSheets, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Данные добавлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();
                return;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            String queryAddTurnSheets = "SELECT id AS [ID], turn_credit AS [turn_cr], turn_debit AS [turn_d], saldo_beg_credit AS [saldo_beg_cr], saldo_beg_debit AS [saldo_beg_d], saldo_fin_credit AS [saldo_fin_cr], saldo_fin_debit AS [saldo_fin_d] FROM OborotSaldVedom;";
            
            connection.Open();

            DataSet AddTurnSheetsDS = new DataSet();
            OleDbDataAdapter AddTurnSheetsAdapter = new OleDbDataAdapter(queryAddTurnSheets, connection);
            OleDbCommandBuilder AddTurnBuilder = new OleDbCommandBuilder(AddTurnSheetsAdapter);
            AddTurnSheetsAdapter.Fill(AddTurnSheetsDS, "AddTurnSheets");

            connection.Close();

            AddTurnSheetsGridView.ReadOnly = true;
            AddTurnSheetsGridView.AllowUserToAddRows = false;
            AddTurnSheetsGridView.AllowUserToDeleteRows = false;
            AddTurnSheetsGridView.AllowUserToOrderColumns = true;
            AddTurnSheetsGridView.RowHeadersVisible = false;
            AddTurnSheetsGridView.DataSource = AddTurnSheetsDS;
            AddTurnSheetsGridView.DataMember = "AddTurnSheets";
            AddTurnSheetsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AddTurnSheetsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AddTurnSheetsGridView.Columns["id"].Visible = true;
        }

        private void AddTurnSheets_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}

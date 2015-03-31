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
    public partial class ViewAccount : Form
    {
        public ViewAccount()
        {
            InitializeComponent();
        }

        internal void LoadDataGrid(String id)
        {
            String queryAccount = "SELECT id AS [id], name AS [NazvaRachunku], primechanija AS [Prymitki] FROM Account INNER JOIN OborotSaldVedom ON Account.id = OborotSaldVedom.id WHERE id = " + id + ";";
            String queryTurnSheets = "SELECT turn_credit, turn_debit, saldo_beg_credit, saldo_beg_debit, saldo_fin_credit, saldo_fin_debit FROM turnSheets WHERE id = " + id + ";";

            DataSet SheetsDS = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(queryTurnSheets, connection);
                OleDbDataReader line = cmd.ExecuteReader();

                if (line.Read())
                {
                    turn_creditBox.Text = line.GetInt32(0).ToString();
                    turn_debitBox.Text = line.GetInt32(1).ToString();
                    saldo_beg_creditBox.Text = line.GetInt32(2).ToString();

                    saldo_beg_debitBox.Text = line.GetInt32(3).ToString();
                    saldo_fin_creditBox.Text = line.GetInt32(4).ToString();
                    saldo_fin_debitBox.Text = line.GetInt32(5).ToString();
                }

                OleDbDataAdapter SheetsAdapter = new OleDbDataAdapter(queryAccount, connection);
                OleDbCommandBuilder SheetsBuilder = new OleDbCommandBuilder(SheetsAdapter);
                SheetsAdapter.Fill(SheetsDS, "Sheets");
                connection.Close();
            }

            SheetsGridView.ReadOnly = true;
            SheetsGridView.AllowUserToAddRows = false;
            SheetsGridView.AllowUserToDeleteRows = false;
            SheetsGridView.AllowUserToOrderColumns = true;
            SheetsGridView.RowHeadersVisible = false;
            SheetsGridView.DataSource = SheetsDS;
            SheetsGridView.DataMember = "Sheets";
            SheetsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SheetsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ViewAccount_Load(object sender, EventArgs e)
        {

        }
    }
}

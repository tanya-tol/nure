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
    public partial class ViewTurnSheets : Form
    {
        /*public ViewTurnSheets()
        {
            InitializeComponent();
        }

        private void ViewTurnSheets_Load(object sender, EventArgs e)
        {
            ViewTurnSheets_GridLoad();
        }
        private void ViewTurnSheets_GridLoad()
        {
            //String queryAccount = "SELECT id AS [id] FROM Account INNER JOIN turnSheets ON Account.id = turnSheets.id ;";
            String queryTurnSheets = "SELECT turn_credit, turn_debit, saldo_beg_credit, saldo_beg_debit, saldo_fin_credit, saldo_fin_debit FROM turnSheets;";

            DataSet TurnSheetsDS = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(queryTurnSheets, connection);
                OleDbDataReader line = cmd.ExecuteReader();

                /*if (line.Read())
                {
                    turn_creditBox.Text = line.GetInt32(0).ToString();
                    turn_debitBox.Text = line.GetInt32(1).ToString();
                    saldo_beg_creditBox.Text = line.GetInt32(2).ToString();

                    saldo_beg_debitBox.Text = line.GetInt32(3).ToString();
                    saldo_fin_creditBox.Text = line.GetInt32(4).ToString();
                    saldo_fin_debitBox.Text = line.GetInt32(5).ToString();
                }

                OleDbDataAdapter TurnSheetsAdapter = new OleDbDataAdapter(queryTurnSheets, connection);
                OleDbCommandBuilder SheetsPersBuilder = new OleDbCommandBuilder(TurnSheetsAdapter);
                TurnSheetsAdapter.Fill(TurnSheetsDS, "TurnSheets");

                connection.Close();
            }

            TurnSheetsdataGridView.ReadOnly = true;
            TurndataGridView.AllowUserToAddRows = false;
            TurnSheetsdataGridView.AllowUserToDeleteRows = false;
            TurnSheetsdataGridView.AllowUserToOrderColumns = true;
            TurnSheetsdataGridView.RowHeadersVisible = false;
            TurnSheetsdataGridView.DataSource = TurnSheetsDS;
            TurnSheetsdataGridView.DataMember = "TurnSheets";
            TurnSheetsdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TurnSheetsdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }*/
    }
}

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
    public partial class ViewMarshrutZupynka : Form
    {
        public ViewMarshrutZupynka()
        {
            InitializeComponent();
        }

        internal void LoadDataGrid(String NomerMarshID)
        {
            String queryZupynki = "SELECT Nazva AS [Зупинки] FROM MarshrutZupynka INNER JOIN Zupynka ON Zupynka.ZupynkaID = MarshrutZupynka.ZupynkaID WHERE NomerMarshID = " + NomerMarshID + " ORDER BY Poryadok;";
            String queryMarsh = "SELECT Nazva, DovzhinaMarshruta, ChasVDorozi FROM Marshruty WHERE NomerMarshID = " + NomerMarshID  + ";";

            DataSet ZupynkiDS = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(queryMarsh, connection);
                OleDbDataReader line = cmd.ExecuteReader();

                if (line.Read())
                {
                    NazvaBox.Text = line.GetString(0).ToString();
                    ChasBox.Text = line.GetInt32(1).ToString();
                    DovzhinaBox.Text = line.GetInt32(2).ToString();
                }

                OleDbDataAdapter ZupynkiAdapter = new OleDbDataAdapter(queryZupynki, connection);
                OleDbCommandBuilder ZupynkiBuilder = new OleDbCommandBuilder(ZupynkiAdapter);
                ZupynkiAdapter.Fill(ZupynkiDS, "Zupynki");
                connection.Close();
            }

            ZupynkiGridView.ReadOnly = true;
            ZupynkiGridView.AllowUserToAddRows = false;
            ZupynkiGridView.AllowUserToDeleteRows = false;
            ZupynkiGridView.AllowUserToOrderColumns = true;
            ZupynkiGridView.RowHeadersVisible = false;
            ZupynkiGridView.DataSource = ZupynkiDS;
            ZupynkiGridView.DataMember = "Zupynki";
            ZupynkiGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ZupynkiGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

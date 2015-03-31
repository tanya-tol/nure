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
    public partial class FilteringZhProv : Form
    {
        public static string ConnectionString = "Provider=SQLOLEDB;Data Source=Eee_O\\SQLEXPRESS;Initial Catalog=ISBO;Persist Security Info=True;User ID=lab;Password=lab;";
        OleDbConnection connection = new OleDbConnection(ConnectionString);

        public FilteringZhProv()
        {
            InitializeComponent();
        }

        private void FilterZhProvGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            String queryZurnProvodok = "SELECT id AS [ID], type AS [Type], operation AS [Operation], summa AS [SumProvodok] FROM ZhurnalProvodok WHERE id LIKE '" + NomerRahtBox.Text + "' OR type LIKE '" + TypeDocBox.Text + "';";

            connection.Open();

            DataSet ZurnProvodokDS = new DataSet();
            OleDbDataAdapter ZurnProvodokAdapter = new OleDbDataAdapter(queryZurnProvodok, connection);
            OleDbCommandBuilder ZurnProvodokBuilder = new OleDbCommandBuilder(ZurnProvodokAdapter);
            ZurnProvodokAdapter.Fill(ZurnProvodokDS, "ZurnProvodok");

            connection.Close();

            FilterZhProvGridView.ReadOnly = true;
            FilterZhProvGridView.AllowUserToAddRows = false;
            FilterZhProvGridView.AllowUserToDeleteRows = false;
            FilterZhProvGridView.AllowUserToOrderColumns = true;
            FilterZhProvGridView.RowHeadersVisible = false;
            FilterZhProvGridView.DataSource = ZurnProvodokDS;
            FilterZhProvGridView.DataMember = "ZurnProvodok";
            FilterZhProvGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FilterZhProvGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FilterZhProvGridView.Columns["id"].Visible = true;
        }

        private void FilteringZhProv_Load(object sender, EventArgs e)
        {
            String queryZurnProvodok = "SELECT id AS [ID], type AS [Type], operation AS [Operation], summa AS [SumProvodok] FROM ZhurnalProvodok";

            connection.Open();

            DataSet ZurnProvodokDS = new DataSet();
            OleDbDataAdapter ZurnProvodokAdapter = new OleDbDataAdapter(queryZurnProvodok, connection);
            OleDbCommandBuilder ZurnProvodokBuilder = new OleDbCommandBuilder(ZurnProvodokAdapter);
            ZurnProvodokAdapter.Fill(ZurnProvodokDS, "ZurnProvodok");

            connection.Close();

            FilterZhProvGridView.ReadOnly = true;
            FilterZhProvGridView.AllowUserToAddRows = false;
            FilterZhProvGridView.AllowUserToDeleteRows = false;
            FilterZhProvGridView.AllowUserToOrderColumns = true;
            FilterZhProvGridView.RowHeadersVisible = false;
            FilterZhProvGridView.DataSource = ZurnProvodokDS;
            FilterZhProvGridView.DataMember = "ZurnProvodok";
            FilterZhProvGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FilterZhProvGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FilterZhProvGridView.Columns["id"].Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

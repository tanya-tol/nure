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
    public partial class ViewProvodky : Form
    {
        public static string ConnectionString = "Provider=SQLOLEDB;Data Source=Eee_O\\SQLEXPRESS;Initial Catalog=ISBO;Persist Security Info=True;User ID=lab;Password=lab;";
        OleDbConnection connection = new OleDbConnection(ConnectionString);

        public ViewProvodky()
        {
            InitializeComponent();
        }

        private void ViewProvodky_Load(object sender, EventArgs e)
        {
            String queryStorage = "SELECT id AS [ID], quantity AS [Kol-vo], total AS [Vsego], AVG(total/quantity) AS [Srednee] FROM Storage GROUP BY id, quantity, total;";

            connection.Open();

            DataSet ProvodkyDS = new DataSet();
            OleDbDataAdapter ProvodkyAdapter = new OleDbDataAdapter(queryStorage, connection);
            OleDbCommandBuilder ProvodkyBuilder = new OleDbCommandBuilder(ProvodkyAdapter);
            ProvodkyAdapter.Fill(ProvodkyDS, "Provodky");

            connection.Close();

            ProvodkydataGridView.ReadOnly = true;
            ProvodkydataGridView.AllowUserToAddRows = false;
            ProvodkydataGridView.AllowUserToDeleteRows = false;
            ProvodkydataGridView.AllowUserToOrderColumns = true;
            ProvodkydataGridView.RowHeadersVisible = false;
            ProvodkydataGridView.DataSource = ProvodkyDS;
            ProvodkydataGridView.DataMember = "Provodky";
            ProvodkydataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProvodkydataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProvodkydataGridView.Columns["id"].Visible = true;
        }

        private void ProvodkydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            String queryStorage = "update OborotSaldVedom set saldo_beg_debit =(select sum(ZhurnalProvodok.summa) from ZhurnalProvodok,ZhurnalOperations,typeProvodka where ZhurnalProvodok.id=ZhurnalOperations.total and typeProvodka.id=ZhurnalProvodok.type and ZhurnalOperations.data< '2013.12.07' and typeProvodka.debitAccount=OborotSaldVedom.id);  update OborotSaldVedom set saldo_beg_credit =(select sum(ZhurnalProvodok.summa) from ZhurnalProvodok,ZhurnalOperations,typeProvodka where ZhurnalProvodok.id=ZhurnalOperations.total and typeProvodka.id=ZhurnalProvodok.type and ZhurnalOperations.data< '2013.12.07' and typeProvodka.creditAccount= OborotSaldVedom.id ) ";
            connection.Open();

            DataSet ProvodkyDS = new DataSet();
            OleDbDataAdapter ProvodkyAdapter = new OleDbDataAdapter(queryStorage, connection);
            OleDbCommandBuilder ProvodkyBuilder = new OleDbCommandBuilder(ProvodkyAdapter);
            ProvodkyAdapter.Fill(ProvodkyDS, "Provodky");

            connection.Close();

            ProvodkydataGridView.ReadOnly = true;
            ProvodkydataGridView.AllowUserToAddRows = false;
            ProvodkydataGridView.AllowUserToDeleteRows = false;
            ProvodkydataGridView.AllowUserToOrderColumns = true;
            ProvodkydataGridView.RowHeadersVisible = false;
            ProvodkydataGridView.DataSource = ProvodkyDS;
            ProvodkydataGridView.DataMember = "Provodky";
            ProvodkydataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProvodkydataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProvodkydataGridView.Columns["id"].Visible = true;
        }

    }
}

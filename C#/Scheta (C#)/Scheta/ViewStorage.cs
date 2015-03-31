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
    public partial class ViewStorage : Form
    {
        public static string ConnectionString = "Provider=SQLOLEDB;Data Source=Eee_O\\SQLEXPRESS;Initial Catalog=ISBO;Persist Security Info=True;User ID=lab;Password=lab;";
        OleDbConnection connection = new OleDbConnection(ConnectionString);

        public ViewStorage()
        {
            InitializeComponent();
        }
        

        private void ViewStorageGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*StorageGridView.ReadOnly = true;
            StorageGridView.AllowUserToAddRows = false;
            StorageGridView.AllowUserToDeleteRows = false;
            StorageGridView.AllowUserToOrderColumns = true;
            StorageGridView.RowHeadersVisible = false;
            StorageGridView.DataSource = StorageDS;
            StorageGridView.DataMember = "Storage";
            StorageGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StorageGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;*/
        }

        private void ViewStorage_Load(object sender, EventArgs e)
        {
            String queryStorage = "SELECT id AS [ID], quantity AS [Kol-vo], total AS [Vsego], AVG(total/quantity) AS [Srednee] FROM Storage GROUP BY id, quantity, total;";

            connection.Open();

            DataSet ViewStorageDS = new DataSet();
            OleDbDataAdapter ViewStorageAdapter = new OleDbDataAdapter(queryStorage, connection);
            OleDbCommandBuilder ViewStorageBuilder = new OleDbCommandBuilder(ViewStorageAdapter);
            ViewStorageAdapter.Fill(ViewStorageDS, "ViewStorage");

            connection.Close();

            ViewStorageGridView.ReadOnly = true;
            ViewStorageGridView.AllowUserToAddRows = false;
            ViewStorageGridView.AllowUserToDeleteRows = false;
            ViewStorageGridView.AllowUserToOrderColumns = true;
            ViewStorageGridView.RowHeadersVisible = false;
            ViewStorageGridView.DataSource = ViewStorageDS;
            ViewStorageGridView.DataMember = "ViewStorage";
            ViewStorageGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ViewStorageGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewStorageGridView.Columns["id"].Visible = true;
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            /*String queryStorage1 = "update Storage set quantity=(select   case when ZhurnalOperations.id IN(1,2) then quantity+ZhurnalOperations.quantity else quantity-ZhurnalOperations.quantity end from ZhurnalOperations where  ZhurnalOperations.id=Storage.id and ZhurnalOperations.id=1)";
            connection.Open();

            DataSet ViewStorageDS = new DataSet();
            OleDbDataAdapter ViewStorageAdapter = new OleDbDataAdapter(queryStorage1, connection);
            OleDbCommandBuilder ViewStorageBuilder = new OleDbCommandBuilder(ViewStorageAdapter);
            ViewStorageAdapter.Fill(ViewStorageDS, "ViewStorage1");

            connection.Close();

            ViewStorageGridView.ReadOnly = true;
            ViewStorageGridView.AllowUserToAddRows = false;
            ViewStorageGridView.AllowUserToDeleteRows = false;
            ViewStorageGridView.AllowUserToOrderColumns = true;
            ViewStorageGridView.RowHeadersVisible = false;
            ViewStorageGridView.DataSource = ViewStorageDS;
            ViewStorageGridView.DataMember = "ViewStorage1";
            ViewStorageGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ViewStorageGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewStorageGridView.Columns["id"].Visible = true;*/
        }
    }
}

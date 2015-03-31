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
    public partial class FilteringZnOp : Form
    {
        public static string ConnectionString = "Provider=SQLOLEDB;Data Source=Eee_O\\SQLEXPRESS;Initial Catalog=ISBO;Persist Security Info=True;User ID=lab;Password=lab;";
        OleDbConnection connection = new OleDbConnection(ConnectionString);

        public FilteringZnOp()
        {
            InitializeComponent();
        }

        private void FilteringZnOp_Load(object sender, EventArgs e)
        {
            String queryZnOp = "SELECT ZhurnalOperations.id AS [ID], data AS [Data], price AS [Price], quantity AS [Quantity], total AS [Vsego], ZhurnalOperations.type_zn AS [Type], typeDocument.name AS [TypDoc], agent_id AS [AgentID], nomenclature_id AS [NomenclatureID] FROM ZhurnalOperations INNER JOIN typeDocument ON ZhurnalOperations.id = TypeDocument.id;";

            connection.Open();

            DataSet ZnOpDS = new DataSet();
            OleDbDataAdapter ZnOpAdapter = new OleDbDataAdapter(queryZnOp, connection);
            OleDbCommandBuilder ZnOpBuilder = new OleDbCommandBuilder(ZnOpAdapter);
            ZnOpAdapter.Fill(ZnOpDS, "ZnOp");

            connection.Close();

            ZnOpGridView.ReadOnly = true;
            ZnOpGridView.AllowUserToAddRows = false;
            ZnOpGridView.AllowUserToDeleteRows = false;
            ZnOpGridView.AllowUserToOrderColumns = true;
            ZnOpGridView.RowHeadersVisible = false;
            ZnOpGridView.DataSource = ZnOpDS;
            ZnOpGridView.DataMember = "ZnOp";
            ZnOpGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ZnOpGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ZnOpGridView.Columns["id"].Visible = true;
        }

        private void PhilButton_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(domainUpDown1.SelectedItem.ToString());

            String queryZnOp = "SELECT ZhurnalOperations.id AS [ID], data AS [Data], price AS [Price], quantity AS [Quantity], total AS [Vsego], ZhurnalOperations.type_zn AS [Type], typeDocument.name AS [TypDoc], agent_id AS [AgentID], nomenclature_id AS [NomenclatureID] FROM ZhurnalOperations INNER JOIN typeDocument ON ZhurnalOperations.id = TypeDocument.id WHERE ZhurnalOperations.type_zn LIKE '" + value + "%';";

            connection.Open();

            DataSet ZnOpDS = new DataSet();
            OleDbDataAdapter ZnOpAdapter = new OleDbDataAdapter(queryZnOp, connection);
            OleDbCommandBuilder ZnOpBuilder = new OleDbCommandBuilder(ZnOpAdapter);
            ZnOpAdapter.Fill(ZnOpDS, "ZnOp");

            connection.Close();

            ZnOpGridView.ReadOnly = true;
            ZnOpGridView.AllowUserToAddRows = false;
            ZnOpGridView.AllowUserToDeleteRows = false;
            ZnOpGridView.AllowUserToOrderColumns = true;
            ZnOpGridView.RowHeadersVisible = false;
            ZnOpGridView.DataSource = ZnOpDS;
            ZnOpGridView.DataMember = "ZnOp";
            ZnOpGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ZnOpGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ZnOpGridView.Columns["id"].Visible = true;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}

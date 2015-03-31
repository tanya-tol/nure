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
    public partial class EditZhurOperazij : Form
    {
        public static string ConnectionString = "Provider=SQLOLEDB;Data Source=Eee_O\\SQLEXPRESS;Initial Catalog=ISBO;Persist Security Info=True;User ID=lab;Password=lab;";
        OleDbConnection connection = new OleDbConnection(ConnectionString);


        public EditZhurOperazij()
        {
            InitializeComponent();
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            String EditZhurOper = "UPDATE ZhurnalOperations SET price='" + PriceTextBox.Text + "'WHERE id= '" + IDTextBox.Text + "';";
            String update = "SELECT id AS [ID], data AS [Date], price AS [Price], quantity AS [Kil-t'], total AS [SumDoc], type_zn AS [TypDocID], agent_id AS [KAgentID], nomenclature_id AS [NomID] FROM ZhurnalOperations;";
            
            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(EditZhurOper, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Дані були відредаговані!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();
                return;
            }
        }

        private void EditZhurOperazij_Load(object sender, EventArgs e)
        {
            //String queryEditZhOper = "SELECT ZhurnalOperations.id AS [ID], data AS [Date], price AS [Price], quantity AS [Kil-t'], total AS [SumDoc], typeDocument.name AS [TypDoc], agent_id AS [KAgentID], nomenclature_id AS [NomID] FROM ZhurnalOperations INNER JOIN typeDocument ON ZhurnalOperations.id = typeDocument.id;";

            String queryEditZhOper = "SELECT id AS [ID], data AS [Date], price AS [Price], quantity AS [Kil-t'], total AS [SumDoc], type_zn AS [TypDocID], agent_id AS [KAgentID], nomenclature_id AS [NomID] FROM ZhurnalOperations;";

            connection.Open();

            DataSet EditZhOperDS = new DataSet();
            OleDbDataAdapter EditZhOperAdapter = new OleDbDataAdapter(queryEditZhOper, connection);
            OleDbCommandBuilder EditZhOperBuilder = new OleDbCommandBuilder(EditZhOperAdapter);
            EditZhOperAdapter.Fill(EditZhOperDS, "EditZhOper");

            connection.Close();

            EditZhOpGridView.ReadOnly = true;
            EditZhOpGridView.AllowUserToAddRows = false;
            EditZhOpGridView.AllowUserToDeleteRows = false;
            EditZhOpGridView.AllowUserToOrderColumns = true;
            EditZhOpGridView.RowHeadersVisible = false;
            EditZhOpGridView.DataSource = EditZhOperDS;
            EditZhOpGridView.DataMember = "EditZhOper";
            EditZhOpGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EditZhOpGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EditZhOpGridView.Columns["id"].Visible = true;
        }

        private void EditZhOpGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdButton_Click(object sender, EventArgs e)
        {
            String queryEditZhOper = "SELECT id AS [ID], data AS [Date], price AS [Price], quantity AS [Kil-t'], total AS [SumDoc], type_zn AS [TypDocID], agent_id AS [KAgentID], nomenclature_id AS [NomID] FROM ZhurnalOperations;";
            //String queryEditZhOper = "SELECT ZhurnalOperations.id AS [ID], data AS [Date], price AS [Price], quantity AS [Kil-t'], total AS [SumDoc], typeDocument.name AS [TypDoc], agent_id AS [KAgentID], nomenclature_id AS [NomID] FROM ZhurnalOperations INNER JOIN typeDocument ON ZhurnalOperations.id = typeDocument.id;";

            connection.Open();

            DataSet EditZhOperDS = new DataSet();
            OleDbDataAdapter EditZhOperAdapter = new OleDbDataAdapter(queryEditZhOper, connection);
            OleDbCommandBuilder EditZhOperBuilder = new OleDbCommandBuilder(EditZhOperAdapter);
            EditZhOperAdapter.Fill(EditZhOperDS, "EditZhOper");

            connection.Close();

            EditZhOpGridView.ReadOnly = true;
            EditZhOpGridView.AllowUserToAddRows = false;
            EditZhOpGridView.AllowUserToDeleteRows = false;
            EditZhOpGridView.AllowUserToOrderColumns = true;
            EditZhOpGridView.RowHeadersVisible = false;
            EditZhOpGridView.DataSource = EditZhOperDS;
            EditZhOpGridView.DataMember = "EditZhOper";
            EditZhOpGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EditZhOpGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EditZhOpGridView.Columns["id"].Visible = true;
        }

        
    }
}

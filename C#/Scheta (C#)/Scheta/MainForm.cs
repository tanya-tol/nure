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
    public partial class MainForm : Form
    {
        public static string ConnectionString = "Provider=SQLOLEDB;Data Source=Eee_O\\SQLEXPRESS;Initial Catalog=ISBO;Persist Security Info=True;User ID=lab;Password=lab;";
        OleDbConnection connection = new OleDbConnection(ConnectionString);

        public MainForm()
        {
            InitializeComponent();
            MainForm_LoadGrid();
        }

        private void MainForm_LoadGrid()
        {
            String queryAccount = "SELECT id AS [ID], name AS [Name], primechanija AS [Prymitki] FROM Account;";
            String queryTurnSheets = "SELECT turn_credit, turn_debit, saldo_beg_credit, saldo_beg_debit, saldo_fin_credit, saldo_fin_debit FROM OborotSaldVedom ;";
           // String queryZurnOper = "SELECT ZhurnalOperations.id AS [ID], data AS [Date], price AS [Price], quantity AS [Kil-t'], total AS [SumDoc], typeDocument.name AS [TypDoc], agent_id AS [KAgentID], nomenclature_id AS [NomID] FROM ZhurnalOperations INNER JOIN typeDocument ON ZhurnalOperations.id = typeDocument.id;";

            String queryZurnOper = "SELECT ZhurnalOperations.id AS [ID], data AS [Data], price AS [Price], quantity AS [Quantity], total AS [Vsego], typeDocument.name AS [TypDoc], agent_id AS [AgentID], nomenclature_id AS [NomenclatureID] FROM ZhurnalOperations INNER JOIN typeDocument ON ZhurnalOperations.id = typeDocument.id;";
            String queryZurnProvodok = "SELECT id AS [ID], type AS [Type], operation AS [Operation], summa AS [SumProvodok] FROM ZhurnalProvodok";
            
            connection.Open();

            DataSet AccountDS = new DataSet();
            OleDbDataAdapter AccountAdapter = new OleDbDataAdapter(queryAccount, connection);
            OleDbCommandBuilder PersBuilder = new OleDbCommandBuilder(AccountAdapter);
            AccountAdapter.Fill(AccountDS, "Account");

            DataSet TurnSheetsDS = new DataSet();
            OleDbDataAdapter TurnSheetsAdapter = new OleDbDataAdapter(queryTurnSheets, connection);
            OleDbCommandBuilder SheetsPersBuilder = new OleDbCommandBuilder(TurnSheetsAdapter);
            TurnSheetsAdapter.Fill(TurnSheetsDS, "TurnSheets");

            DataSet ZurnOperDS = new DataSet();
            OleDbDataAdapter ZurnOperAdapter = new OleDbDataAdapter(queryZurnOper, connection);
            OleDbCommandBuilder ZurnOperBuilder = new OleDbCommandBuilder(ZurnOperAdapter);
            ZurnOperAdapter.Fill(ZurnOperDS, "ZurnOper");

            DataSet ZurnProvodokDS = new DataSet();
            OleDbDataAdapter ZurnProvodokAdapter = new OleDbDataAdapter(queryZurnProvodok, connection);
            OleDbCommandBuilder ZurnProvodokBuilder = new OleDbCommandBuilder(ZurnProvodokAdapter);
            ZurnProvodokAdapter.Fill(ZurnProvodokDS, "ZurnProvodok");

            connection.Close();

            AccountGridView.ReadOnly = true;
            AccountGridView.AllowUserToAddRows = false;
            AccountGridView.AllowUserToDeleteRows = false;
            AccountGridView.AllowUserToOrderColumns = true;
            AccountGridView.RowHeadersVisible = false;
            AccountGridView.DataSource = AccountDS;
            AccountGridView.DataMember = "Account";
            AccountGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AccountGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccountGridView.Columns["id"].Visible = true;

            TurnSheetsdataGridView.ReadOnly = true;
            TurnSheetsdataGridView.AllowUserToAddRows = false;
            TurnSheetsdataGridView.AllowUserToDeleteRows = false;
            TurnSheetsdataGridView.AllowUserToOrderColumns = true;
            TurnSheetsdataGridView.RowHeadersVisible = false;
            TurnSheetsdataGridView.DataSource = TurnSheetsDS;
            TurnSheetsdataGridView.DataMember = "TurnSheets";
            TurnSheetsdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TurnSheetsdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ZhurnOperationsGridView.ReadOnly = true;
            ZhurnOperationsGridView.AllowUserToAddRows = false;
            ZhurnOperationsGridView.AllowUserToDeleteRows = false;
            ZhurnOperationsGridView.AllowUserToOrderColumns = true;
            ZhurnOperationsGridView.RowHeadersVisible = false;
            ZhurnOperationsGridView.DataSource = ZurnOperDS;
            ZhurnOperationsGridView.DataMember = "ZurnOper";
            ZhurnOperationsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ZhurnOperationsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ZhurnProvodokGridView.ReadOnly = true;
            ZhurnProvodokGridView.AllowUserToAddRows = false;
            ZhurnProvodokGridView.AllowUserToDeleteRows = false;
            ZhurnProvodokGridView.AllowUserToOrderColumns = true;
            ZhurnProvodokGridView.RowHeadersVisible = false;
            ZhurnProvodokGridView.DataSource = ZurnProvodokDS;
            ZhurnProvodokGridView.DataMember = "ZurnProvodok";
            ZhurnProvodokGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ZhurnProvodokGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ZhurnProvodokGridView.Columns["id"].Visible = true;          
        }

        private void AddAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccount AddZupynkaWindow = new AddAccount();
            AddZupynkaWindow.Show();
        }

        private void turnSheetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTurnSheets AddTurnWindow = new AddTurnSheets();
            AddTurnWindow.Show();
        }

        private void ZhurnOperationsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ZhurnProvodokGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddZhProvStripMenu_Click(object sender, EventArgs e)
        {
            AddZhurProvodok AddZnPrWindow = new AddZhurProvodok();
            AddZnPrWindow.Show();
        }

        private void ViewStorageToolStripMenu_Click(object sender, EventArgs e)
        {
            ViewStorage StorageWindow = new ViewStorage();
            StorageWindow.Show();
        }

        private void FilteringZnOpToolStripMenu_Click(object sender, EventArgs e)
        {
            FilteringZnOp FilterWindow = new FilteringZnOp();
            FilterWindow.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AddZhOperToolStripMenu_Click(object sender, EventArgs e)
        {
            AddZhurOperazij AddWindow = new AddZhurOperazij();
            AddWindow.Show();
        }

        private void RedagToolStripMenu_Click(object sender, EventArgs e)
        {
            EditZhurOperazij EditWindow = new EditZhurOperazij();
            EditWindow.Show();
        }

        private void EditZhProvToolStripMenu_Click(object sender, EventArgs e)
        {
            FilteringZhProv FilterWindow = new FilteringZhProv();
            FilterWindow.Show();
        }

        private void ProvodkyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProvodky ViewWindow = new ViewProvodky();
            ViewWindow.Show();
        }
               
        
    }
}

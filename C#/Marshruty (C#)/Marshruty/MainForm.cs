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
    public partial class MainForm : Form
    {
        public static string ConnectionString = "Provider=SQLOLEDB;Data Source=TRON\\SQLEXPRESS;Initial Catalog=Marshruty;Persist Security Info=True;User ID=root;Password=rootpass;";
        OleDbConnection connection = new OleDbConnection(ConnectionString);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_LoadGrid()
        {
            String queryMarsh = "SELECT NomerMarshID AS [ID], Nazva AS [Назва], DovzhinaMarshruta AS [Протяжність маршруту], ChasVDorozi AS [Час в дорозі] FROM Marshruty;";
            String queryAutPark = "SELECT GosNomerID AS [Гос. номер], SkilkiProjihav AS [Пробіг], MarkaAutobus AS [Марка], RikVypuska AS [Рік випуску] FROM AutobusPark;";
            String queryPers = "SELECT FIO AS [ФІО], Professija AS [Професія], DataPochatRoboty AS [Початок роботи], RobochyjTelephon AS [Робочий телефон], DataNarodzhennya AS [Дата народження], DomTelephon AS [Домашній телефон], DomAdresa AS [Домашня адреса] FROM OsobystiDaniPersonala;";

            connection.Open();
            DataSet MarshDS = new DataSet();
            OleDbDataAdapter MarshAdapter = new OleDbDataAdapter(queryMarsh, connection);
            OleDbCommandBuilder MarshBuilder = new OleDbCommandBuilder(MarshAdapter);
            MarshAdapter.Fill(MarshDS, "Marshs");

            DataSet AutParkDS = new DataSet();
            OleDbDataAdapter AutParkAdapter = new OleDbDataAdapter(queryAutPark, connection);
            OleDbCommandBuilder AutParkBuilder = new OleDbCommandBuilder(AutParkAdapter);
            AutParkAdapter.Fill(AutParkDS, "AutParks");

            DataSet PersDS = new DataSet();
            OleDbDataAdapter PersAdapter = new OleDbDataAdapter(queryPers, connection);
            OleDbCommandBuilder PersBuilder = new OleDbCommandBuilder(PersAdapter);
            PersAdapter.Fill(PersDS, "Perss");
            connection.Close();

            MarshGridView.ReadOnly = true;
            MarshGridView.AllowUserToAddRows = false;
            MarshGridView.AllowUserToDeleteRows = false;
            MarshGridView.AllowUserToOrderColumns = true;
            MarshGridView.RowHeadersVisible = false;
            MarshGridView.DataSource = MarshDS;
            MarshGridView.DataMember = "Marshs";
            MarshGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MarshGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MarshGridView.Columns["ID"].Visible = false;

            AutParkGridView.ReadOnly = true;
            AutParkGridView.AllowUserToAddRows = false;
            AutParkGridView.AllowUserToDeleteRows = false;
            AutParkGridView.AllowUserToOrderColumns = true;
            AutParkGridView.RowHeadersVisible = false;
            AutParkGridView.DataSource = AutParkDS;
            AutParkGridView.DataMember = "AutParks";
            AutParkGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutParkGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            PersGridView.ReadOnly = true;
            PersGridView.AllowUserToAddRows = false;
            PersGridView.AllowUserToDeleteRows = false;
            PersGridView.AllowUserToOrderColumns = true;
            PersGridView.RowHeadersVisible = false;
            PersGridView.DataSource = PersDS;
            PersGridView.DataMember = "Perss";
            PersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AddMarshrutyMainMenu_Click(object sender, EventArgs e)
        {
            AddMarshrut AddMarshrutWindow = new AddMarshrut();
            AddMarshrutWindow.Show();
        }

        private void EditMarshrutyMainMenu_Click(object sender, EventArgs e)
        {
            ViewMarshrut ViewMarshrutWindow = new ViewMarshrut();
            ViewMarshrutWindow.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            MainForm_LoadGrid();
            SucurityAccess();
        }

        private void MarshGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewMarshrutZupynka MarshrutZupynka = new ViewMarshrutZupynka();
            MarshrutZupynka.LoadDataGrid(MarshGridView.CurrentRow.Cells[0].Value.ToString());
            MarshrutZupynka.Show();
        }

        private void AddAutobusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAutobus AddAutobusWindow = new AddAutobus();
            AddAutobusWindow.Show();
        }

        private void EditAutoparkMainMenu_Click_1(object sender, EventArgs e)
        {
            ViewAutobus ViewAutobusWindow = new ViewAutobus();
            ViewAutobusWindow.Show();
        }


        private void AddPersonalMainMenu_Click(object sender, EventArgs e)
        {
            AddPersonal AddPersonalWindow = new AddPersonal();
            AddPersonalWindow.Show();
        }

        private void EditPersonalMainMenu_Click(object sender, EventArgs e)
        {
            ViewPersonal ViewPersonalWindow = new ViewPersonal();
            ViewPersonalWindow.Show();
        }

        private void LoginMainMenu_Click(object sender, EventArgs e)
        {
            if (!LogIn.status)
            {
                LogIn LogInWindow = new LogIn();
                LogInWindow.Show();
            }
            else
            {
                if (MessageBox.Show("Ви справді хочите вийти із облікового запису?", "Вихід", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LogIn.status = false;
                    SucurityAccess();
                }
            }
        }

        public void SucurityAccess()
        {
            if (LogIn.status)
            {
                MarshrutyMainMenu.Enabled = true;
                AutoparkMenuItem.Enabled = true;
                PersonalMenuItem.Enabled = true;
                StopMainMenu.Enabled = true;
                LoginMainMenu.Text = "Вихід";
            }
            else
            {
                LoginMainMenu.Text = "Вхід";
                StopMainMenu.Enabled = false;
                MarshrutyMainMenu.Enabled = false;
                AutoparkMenuItem.Enabled = false;
                PersonalMenuItem.Enabled = false;
            }
        }
        
        private void ListStopMainMenu_Click(object sender, EventArgs e)
        {
            ListZupynki ListZupynkiWindow = new ListZupynki();
            ListZupynkiWindow.Show();
        }

        private void AddZupynkaMainMenu_Click(object sender, EventArgs e)
        {
            AddZupynka AddZupynkaWindow = new AddZupynka();
            AddZupynkaWindow.Show();
        }

        private void MarshGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            MainMenu_GridLoad();
        }
        private void MainMenu_GridLoad()
        {
            String queryAuto = "SELECT distinct Marshruty.Nazva AS [Назва маршрута], Zupynka.Nazva AS [Зупинка] FROM Zupynka  INNER JOIN MarshrutZupynka ON Zupynka.ZupynkaID=MarshrutZupynka.ZupynkaID INNER JOIN Marshruty ON MarshrutZupynka.ZupynkaID=Marshruty.NomerMarshID";

            if (!string.IsNullOrEmpty(FindButton.Text) && !FindButton.Text.Equals("Зупинка", StringComparison.OrdinalIgnoreCase))
            {
                queryAuto += " WHERE Zupynka.Nazva LIKE '%" + Find.Text + "%'";
            }

            DataSet FindDS = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbDataAdapter FindAdapter = new OleDbDataAdapter(queryAuto, connection);
                OleDbCommandBuilder FindBuilder = new OleDbCommandBuilder(FindAdapter);
                FindAdapter.Fill(FindDS, "Autobus");
                connection.Close();
            }

            FindGridView.ReadOnly = true;
            FindGridView.AllowUserToAddRows = false;
            FindGridView.AllowUserToDeleteRows = false;
            FindGridView.AllowUserToOrderColumns = true;
            FindGridView.RowHeadersVisible = false;
            FindGridView.DataSource = FindDS;
            FindGridView.DataMember = "Autobus";
            FindGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FindGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //FindGridView.Columns["ID"].Visible = false;
        }
        private void FindGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        

    }
}

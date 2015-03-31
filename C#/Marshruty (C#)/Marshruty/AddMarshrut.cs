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
    public partial class AddMarshrut : Form
    {
        public static string ConnectionString = "Provider=SQLOLEDB;Data Source=TRON\\SQLEXPRESS;Initial Catalog=Marshruty;Persist Security Info=True;User ID=root;Password=rootpass;";
        OleDbConnection connection = new OleDbConnection(ConnectionString);

        public AddMarshrut()
        {
            InitializeComponent();

            DataGridViewTextBoxColumn ZupynkaIDColumn = new DataGridViewTextBoxColumn();
            ZupynkaIDColumn.HeaderText = "ID";
            ZupynkaIDColumn.Name = "ID";

            DataGridViewTextBoxColumn NazvaColumn = new DataGridViewTextBoxColumn();
            NazvaColumn.HeaderText = "Назва зупинки";
            NazvaColumn.Name = "Nazva";

            ZupynkaGridView.Columns.Add(ZupynkaIDColumn);
            ZupynkaGridView.Columns.Add(NazvaColumn);

            ZupynkaGridView.ReadOnly = true;
            ZupynkaGridView.AllowUserToAddRows = false;
            ZupynkaGridView.AllowUserToDeleteRows = false;
            ZupynkaGridView.AllowUserToOrderColumns = true;
            ZupynkaGridView.RowHeadersVisible = false;
            ZupynkaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ZupynkaGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ZupynkaGridView.Columns["ID"].Visible = false;
            ZupynkaGridView.ColumnHeadersVisible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NazvaBox.Text == String.Empty || DovzhinaBox.Text == String.Empty || ChasBox.Text == String.Empty)
            {
                MessageBox.Show("Заповнені не всі поля!\r\nВсі поля повинні бути заповнені.", "Помилка заповнення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if (ZupynkaGridView.RowCount < 2)
            //{
            //    MessageBox.Show("Недостатньо зупинок!\r\nМаршрут повинен мати принаймні 2 зупинки.", "Помилка заповнення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {
                String InsertMarshrut = "INSERT INTO Marshruty (Nazva, DovzhinaMarshruta, ChasVDorozi) VALUES('" + NazvaBox.Text + "','" + DovzhinaBox.Text + "','" + ChasBox.Text + "')"
                                        + "SELECT CAST(scope_identity() AS int)";
                using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
                {
                    connection.Open();

                    OleDbCommand cmd = new OleDbCommand(InsertMarshrut, connection);
                    int NomerMarshID = (int)cmd.ExecuteScalar();

                    for (int i = 0; i < ZupynkaGridView.RowCount; ++i)
                    {
                        String InsertMarshrutZupynka = "INSERT INTO MarshrutZupynka (NomerMarshID, ZupynkaID, Poryadok) VALUES('" + NomerMarshID + "','" + FindZupynkaGridView.Rows[i].Cells[0].Value.ToString() + "', '" + i.ToString() + "')";
                        OleDbCommand cmd2 = new OleDbCommand(InsertMarshrutZupynka, connection);
                        cmd2.ExecuteNonQuery();
                    }

                    connection.Close();
                    MessageBox.Show("Маршрут додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    return;
                }
                MessageBox.Show("Помилка з'єднання з БД.", "Помилка з'єднаня", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FindBox_Enter(object sender, EventArgs e)
        {
            if (FindBox.Text.Equals("Назва зупинки", StringComparison.OrdinalIgnoreCase))
            {
                FindBox.Text = string.Empty;
            }
        }

        private void FindBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FindBox.Text))
            {
                FindBox.Text = "Назва зупинки";
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            String queryFind = "SELECT ZupynkaID AS [ID], Nazva AS [Назва] FROM Zupynka";

            if (!string.IsNullOrEmpty(FindBox.Text) && !FindBox.Text.Equals("Назва зупинки", StringComparison.OrdinalIgnoreCase))
            {
                queryFind += " WHERE Nazva LIKE '%" + FindBox.Text + "%'";
            }

            DataSet FindDS = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbDataAdapter FindAdapter = new OleDbDataAdapter(queryFind, connection);
                OleDbCommandBuilder FindBuilder = new OleDbCommandBuilder(FindAdapter);
                FindAdapter.Fill(FindDS, "Find");
                connection.Close();
            }

            FindZupynkaGridView.ReadOnly = true;
            FindZupynkaGridView.AllowUserToAddRows = false;
            FindZupynkaGridView.AllowUserToDeleteRows = false;
            FindZupynkaGridView.AllowUserToOrderColumns = true;
            FindZupynkaGridView.RowHeadersVisible = false;
            FindZupynkaGridView.DataSource = FindDS;
            FindZupynkaGridView.DataMember = "Find";
            FindZupynkaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FindZupynkaGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FindZupynkaGridView.Columns["ID"].Visible = false;
            FindZupynkaGridView.ColumnHeadersVisible = false;
        }

        private void FindZupynkaGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCell ZupynkaIDCell = new DataGridViewTextBoxCell();
            DataGridViewCell NazvaCell = new DataGridViewTextBoxCell();
            DataGridViewRow row = new DataGridViewRow();
            ZupynkaIDCell.Value = FindZupynkaGridView.CurrentRow.Cells[0].Value.ToString();
            NazvaCell.Value = FindZupynkaGridView.CurrentRow.Cells[1].Value.ToString();
            row.Cells.AddRange(ZupynkaIDCell, NazvaCell);
            this.ZupynkaGridView.Rows.Add(row);
        }

        private void ZupynkaGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ZupynkaGridView.Rows.RemoveAt(ZupynkaGridView.SelectedRows[0].Index);
        }

        private void AddMarshrut_Load(object sender, EventArgs e)
        {

        }

        private void ZupynkaGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

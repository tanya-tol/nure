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
    public partial class ViewPersonal : Form
    {
        public ViewPersonal()
        {
            InitializeComponent();
        }


        private void ViewPersonal_Load(object sender, EventArgs e)
        {
            ViewPersonal_GridLoad();
        }

        private void ViewPersonal_GridLoad()
        {
            String queryPers = "SELECT FIO AS [FIO], Professija AS [Професія], DataPochatRoboty AS [Дата початку роботи], RobochyjTelephon AS [Робочий телефон], DataNarodzhennya AS [Дата народження], DomTelephon AS [Домашній телефон], DomAdresa AS [Домашня адреса] FROM OsobystiDaniPersonala";

            if (!string.IsNullOrEmpty(NazvaBox.Text) && !NazvaBox.Text.Equals("ФИО", StringComparison.OrdinalIgnoreCase))
            {
                queryPers += " WHERE FIO LIKE '%" + NazvaBox.Text + "%'";
            }

            DataSet PersDS = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                connection.Open();
                OleDbDataAdapter PersAdapter = new OleDbDataAdapter(queryPers, connection);
                OleDbCommandBuilder PersBuilder = new OleDbCommandBuilder(PersAdapter);
                PersAdapter.Fill(PersDS, "Pers");
                connection.Close();
            }

            PersonalGridView.ReadOnly = true;
            PersonalGridView.AllowUserToAddRows = false;
            PersonalGridView.AllowUserToDeleteRows = false;
            PersonalGridView.AllowUserToOrderColumns = true;
            PersonalGridView.RowHeadersVisible = false;
            PersonalGridView.DataSource = PersDS;
            PersonalGridView.DataMember = "Pers";
            PersonalGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PersonalGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //PersonalGridView.Columns["ID"].Visible = false;
        }

        private void NazvaBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NazvaBox.Text))
            {
                NazvaBox.Text = "ФИО";
            }
        }


        private void NazvaBox_Enter(object sender, EventArgs e)
        {
            if (NazvaBox.Text.Equals("ФИО", StringComparison.OrdinalIgnoreCase))
            {
                NazvaBox.Text = string.Empty;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPersonal AddPersonalWindow = new AddPersonal();
            AddPersonalWindow.Show();
        }

        private void FindButton_Click_1(object sender, EventArgs e)
        {
            ViewPersonal_GridLoad();
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            if (PersonalGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Ви справді хочите видалити запис?", "Видалення маршруту", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
                    {
                        connection.Open();
                        string DeleteQuery = string.Format("DELETE OsobystiDaniPersonala WHERE FIO = '" + PersonalGridView.CurrentRow.Cells[0].Value + "';");
                        OleDbCommand commandUpdate = new OleDbCommand(DeleteQuery, connection);
                        commandUpdate.ExecuteNonQuery();
                        connection.Close();
                    }
                    PersonalGridView.Rows.RemoveAt(PersonalGridView.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Ви не виділили рядок для видалення!", "Помилка", MessageBoxButtons.OK);
            }
        }

    }
}

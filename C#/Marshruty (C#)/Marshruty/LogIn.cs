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
    public partial class LogIn : Form
    {
        static public bool status = true;
        static public int role;
        static public string username = String.Empty;

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(MainForm.ConnectionString))
            {
                string queryString = "SELECT * FROM UserTable WHERE UserName='" + LoginBox.Text + "'AND UserPassword='" + PasswordBox.Text + "'";
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader line = command.ExecuteReader();

                if (line.Read())
                {
                    int id = line.GetInt32(0);
                    //role = line.GetInt32(1);
                    username = line.GetString(2).ToString();

                    AutorizClose();
                }
                else
                {
                    PasswordBox.Text = String.Empty;
                    MessageBox.Show("Неверный логин или пароль!\r\nПопробуйте еще раз.", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                line.Close();
                return;
            }
            MessageBox.Show("Ошибка подключения к БД.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void AutorizClose()
        {
            status = true;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

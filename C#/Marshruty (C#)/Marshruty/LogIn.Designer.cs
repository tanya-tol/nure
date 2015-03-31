namespace Marshruty
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBeforelogIn = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.loginLebel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBeforelogIn
            // 
            this.TextBeforelogIn.Location = new System.Drawing.Point(16, 9);
            this.TextBeforelogIn.Name = "TextBeforelogIn";
            this.TextBeforelogIn.Size = new System.Drawing.Size(256, 43);
            this.TextBeforelogIn.TabIndex = 7;
            this.TextBeforelogIn.Text = "Для редактування даних в таблицях\r\nВам необхідно авторизуватися";
            this.TextBeforelogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 84);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabel.TabIndex = 14;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // loginLebel
            // 
            this.loginLebel.AutoSize = true;
            this.loginLebel.Location = new System.Drawing.Point(12, 58);
            this.loginLebel.Name = "loginLebel";
            this.loginLebel.Size = new System.Drawing.Size(37, 13);
            this.loginLebel.TabIndex = 13;
            this.loginLebel.Text = "Логін:";
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.DarkGreen;
            this.LogInButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogInButton.Location = new System.Drawing.Point(85, 107);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(187, 35);
            this.LogInButton.TabIndex = 12;
            this.LogInButton.Text = "Підтвердити ауторизацію";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(85, 81);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(187, 20);
            this.PasswordBox.TabIndex = 11;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(85, 55);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(187, 20);
            this.LoginBox.TabIndex = 10;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.loginLebel);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.TextBeforelogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextBeforelogIn;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label loginLebel;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginBox;

    }
}
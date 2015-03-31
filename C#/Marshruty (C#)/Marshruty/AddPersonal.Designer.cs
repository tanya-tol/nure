namespace Marshruty
{
    partial class AddPersonal
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
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.ProfBox = new System.Windows.Forms.TextBox();
            this.RobTelBox = new System.Windows.Forms.TextBox();
            this.DomTelBox = new System.Windows.Forms.TextBox();
            this.DomAdressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DodBut = new System.Windows.Forms.Button();
            this.DatePochRob = new System.Windows.Forms.DateTimePicker();
            this.DateNarod = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // FIOBox
            // 
            this.FIOBox.Location = new System.Drawing.Point(135, 29);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(124, 20);
            this.FIOBox.TabIndex = 0;
            // 
            // ProfBox
            // 
            this.ProfBox.Location = new System.Drawing.Point(135, 56);
            this.ProfBox.Name = "ProfBox";
            this.ProfBox.Size = new System.Drawing.Size(124, 20);
            this.ProfBox.TabIndex = 1;
            // 
            // RobTelBox
            // 
            this.RobTelBox.Location = new System.Drawing.Point(135, 110);
            this.RobTelBox.Name = "RobTelBox";
            this.RobTelBox.Size = new System.Drawing.Size(124, 20);
            this.RobTelBox.TabIndex = 3;
            // 
            // DomTelBox
            // 
            this.DomTelBox.Location = new System.Drawing.Point(135, 162);
            this.DomTelBox.Name = "DomTelBox";
            this.DomTelBox.Size = new System.Drawing.Size(124, 20);
            this.DomTelBox.TabIndex = 5;
            // 
            // DomAdressBox
            // 
            this.DomAdressBox.Location = new System.Drawing.Point(135, 188);
            this.DomAdressBox.Name = "DomAdressBox";
            this.DomAdressBox.Size = new System.Drawing.Size(124, 20);
            this.DomAdressBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Професія";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата поч. роботи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Робочий телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата народження";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дом. телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дом. адреса";
            // 
            // DodBut
            // 
            this.DodBut.BackColor = System.Drawing.Color.DarkGreen;
            this.DodBut.Location = new System.Drawing.Point(19, 218);
            this.DodBut.Name = "DodBut";
            this.DodBut.Size = new System.Drawing.Size(240, 31);
            this.DodBut.TabIndex = 14;
            this.DodBut.Text = "Додати";
            this.DodBut.UseVisualStyleBackColor = false;
            this.DodBut.Click += new System.EventHandler(this.DodBut_Click);
            // 
            // DatePochRob
            // 
            this.DatePochRob.CustomFormat = "dd.mm.yyyy";
            this.DatePochRob.Location = new System.Drawing.Point(135, 83);
            this.DatePochRob.Name = "DatePochRob";
            this.DatePochRob.Size = new System.Drawing.Size(124, 20);
            this.DatePochRob.TabIndex = 15;
            this.DatePochRob.Value = new System.DateTime(2014, 6, 3, 19, 58, 38, 0);
            // 
            // DateNarod
            // 
            this.DateNarod.Location = new System.Drawing.Point(135, 136);
            this.DateNarod.Name = "DateNarod";
            this.DateNarod.Size = new System.Drawing.Size(124, 20);
            this.DateNarod.TabIndex = 16;
            this.DateNarod.Value = new System.DateTime(2014, 6, 3, 0, 0, 0, 0);
            // 
            // AddPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DateNarod);
            this.Controls.Add(this.DatePochRob);
            this.Controls.Add(this.DodBut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DomAdressBox);
            this.Controls.Add(this.DomTelBox);
            this.Controls.Add(this.RobTelBox);
            this.Controls.Add(this.ProfBox);
            this.Controls.Add(this.FIOBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPersonal";
            this.ShowIcon = false;
            this.Text = "Додати людину з персонала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.TextBox ProfBox;
        private System.Windows.Forms.TextBox RobTelBox;
        private System.Windows.Forms.TextBox DomTelBox;
        private System.Windows.Forms.TextBox DomAdressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DodBut;
        private System.Windows.Forms.DateTimePicker DatePochRob;
        private System.Windows.Forms.DateTimePicker DateNarod;
    }
}
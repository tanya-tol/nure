namespace Marshruty
{
    partial class AddAutobus
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
            this.DodBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GosNomerBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KilometrBox = new System.Windows.Forms.TextBox();
            this.MarkaBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DodBut
            // 
            this.DodBut.BackColor = System.Drawing.Color.DarkGreen;
            this.DodBut.Location = new System.Drawing.Point(198, 129);
            this.DodBut.Name = "DodBut";
            this.DodBut.Size = new System.Drawing.Size(199, 40);
            this.DodBut.TabIndex = 0;
            this.DodBut.Text = "Додати";
            this.DodBut.UseVisualStyleBackColor = false;
            this.DodBut.Click += new System.EventHandler(this.DodBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Гос. номер";
            // 
            // GosNomerBox
            // 
            this.GosNomerBox.Location = new System.Drawing.Point(198, 12);
            this.GosNomerBox.Name = "GosNomerBox";
            this.GosNomerBox.Size = new System.Drawing.Size(199, 20);
            this.GosNomerBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Скільки проїхав цей автобус? (км)";
            // 
            // KilometrBox
            // 
            this.KilometrBox.Location = new System.Drawing.Point(198, 38);
            this.KilometrBox.Name = "KilometrBox";
            this.KilometrBox.Size = new System.Drawing.Size(199, 20);
            this.KilometrBox.TabIndex = 4;
            // 
            // MarkaBox
            // 
            this.MarkaBox.Location = new System.Drawing.Point(198, 64);
            this.MarkaBox.Name = "MarkaBox";
            this.MarkaBox.Size = new System.Drawing.Size(199, 20);
            this.MarkaBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Марка автобуса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Рік випуска";
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(198, 90);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(199, 20);
            this.YearBox.TabIndex = 8;
            // 
            // AddAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(409, 183);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MarkaBox);
            this.Controls.Add(this.KilometrBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GosNomerBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DodBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAutobus";
            this.Text = "Додавання автобуса";
            this.Load += new System.EventHandler(this.AddAutobus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GosNomerBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KilometrBox;
        private System.Windows.Forms.TextBox MarkaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YearBox;

    }
}
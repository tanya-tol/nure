namespace Marshruty
{
    partial class AddZupynka
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DodBut = new System.Windows.Forms.Button();
            this.NazvaBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва";
            // 
            // DodBut
            // 
            this.DodBut.BackColor = System.Drawing.Color.DarkGreen;
            this.DodBut.Location = new System.Drawing.Point(66, 62);
            this.DodBut.Name = "DodBut";
            this.DodBut.Size = new System.Drawing.Size(173, 23);
            this.DodBut.TabIndex = 4;
            this.DodBut.Text = "Додати";
            this.DodBut.UseVisualStyleBackColor = false;
            this.DodBut.Click += new System.EventHandler(this.DodBut_Click);
            // 
            // NazvaBox
            // 
            this.NazvaBox.Location = new System.Drawing.Point(66, 36);
            this.NazvaBox.Name = "NazvaBox";
            this.NazvaBox.Size = new System.Drawing.Size(173, 20);
            this.NazvaBox.TabIndex = 2;
            // 
            // AddZupynka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(248, 96);
            this.Controls.Add(this.DodBut);
            this.Controls.Add(this.NazvaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddZupynka";
            this.ShowIcon = false;
            this.Text = "Додати зупинку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DodBut;
        private System.Windows.Forms.TextBox NazvaBox;
    }
}
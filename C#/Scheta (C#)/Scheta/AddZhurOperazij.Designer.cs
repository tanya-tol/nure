namespace Scheta
{
    partial class AddZhurOperazij
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddZhurOperazij));
            this.AddZhOperGridView = new System.Windows.Forms.DataGridView();
            this.AddBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.KAgentINTextBox = new System.Windows.Forms.TextBox();
            this.SumDocTextBox = new System.Windows.Forms.TextBox();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.NomINTextBox = new System.Windows.Forms.TextBox();
            this.TypDocINTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UpdateBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddZhOperGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddZhOperGridView
            // 
            this.AddZhOperGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddZhOperGridView.Location = new System.Drawing.Point(12, 12);
            this.AddZhOperGridView.Name = "AddZhOperGridView";
            this.AddZhOperGridView.Size = new System.Drawing.Size(568, 170);
            this.AddZhOperGridView.TabIndex = 0;
            this.AddZhOperGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddZhOperGridView_CellContentClick);
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(421, 228);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(75, 23);
            this.AddBut.TabIndex = 1;
            this.AddBut.Text = "Додати";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "СумаДок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кіл-ть";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ціна";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "НомІН";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "КАгентІН";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "ТипДокІн";
            // 
            // KAgentINTextBox
            // 
            this.KAgentINTextBox.Location = new System.Drawing.Point(77, 228);
            this.KAgentINTextBox.Name = "KAgentINTextBox";
            this.KAgentINTextBox.Size = new System.Drawing.Size(41, 20);
            this.KAgentINTextBox.TabIndex = 11;
            // 
            // SumDocTextBox
            // 
            this.SumDocTextBox.Location = new System.Drawing.Point(478, 199);
            this.SumDocTextBox.Name = "SumDocTextBox";
            this.SumDocTextBox.Size = new System.Drawing.Size(102, 20);
            this.SumDocTextBox.TabIndex = 12;
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(361, 199);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(45, 20);
            this.CountTextBox.TabIndex = 13;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(238, 199);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(61, 20);
            this.PriceTextBox.TabIndex = 14;
            // 
            // NomINTextBox
            // 
            this.NomINTextBox.Location = new System.Drawing.Point(181, 228);
            this.NomINTextBox.Name = "NomINTextBox";
            this.NomINTextBox.Size = new System.Drawing.Size(39, 20);
            this.NomINTextBox.TabIndex = 15;
            // 
            // TypDocINTextBox
            // 
            this.TypDocINTextBox.Location = new System.Drawing.Point(306, 228);
            this.TypDocINTextBox.Name = "TypDocINTextBox";
            this.TypDocINTextBox.Size = new System.Drawing.Size(100, 20);
            this.TypDocINTextBox.TabIndex = 16;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(53, 199);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker.TabIndex = 17;
            // 
            // UpdateBut
            // 
            this.UpdateBut.Location = new System.Drawing.Point(507, 228);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(75, 23);
            this.UpdateBut.TabIndex = 2;
            this.UpdateBut.Text = "Оновити";
            this.UpdateBut.UseVisualStyleBackColor = true;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // AddZhurOperazij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 261);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.TypDocINTextBox);
            this.Controls.Add(this.NomINTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.SumDocTextBox);
            this.Controls.Add(this.KAgentINTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.AddZhOperGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddZhurOperazij";
            this.Text = "Додати в журнал операцій";
            this.Load += new System.EventHandler(this.AddZhurOperazij_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddZhOperGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AddZhOperGridView;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox KAgentINTextBox;
        private System.Windows.Forms.TextBox SumDocTextBox;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox NomINTextBox;
        private System.Windows.Forms.TextBox TypDocINTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button UpdateBut;
    }
}
namespace Scheta
{
    partial class EditZhurOperazij
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditZhurOperazij));
            this.EditZhOpGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.EditBut = new System.Windows.Forms.Button();
            this.UpdButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditZhOpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EditZhOpGridView
            // 
            this.EditZhOpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditZhOpGridView.Location = new System.Drawing.Point(12, 12);
            this.EditZhOpGridView.Name = "EditZhOpGridView";
            this.EditZhOpGridView.Size = new System.Drawing.Size(482, 150);
            this.EditZhOpGridView.TabIndex = 0;
            this.EditZhOpGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditZhOpGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Редагувати поле:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "price = ";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(557, 35);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(60, 20);
            this.PriceTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "id = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "для";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(557, 85);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(60, 20);
            this.IDTextBox.TabIndex = 6;
            // 
            // EditBut
            // 
            this.EditBut.Location = new System.Drawing.Point(527, 111);
            this.EditBut.Name = "EditBut";
            this.EditBut.Size = new System.Drawing.Size(75, 23);
            this.EditBut.TabIndex = 7;
            this.EditBut.Text = "Редагувати";
            this.EditBut.UseVisualStyleBackColor = true;
            this.EditBut.Click += new System.EventHandler(this.EditBut_Click);
            // 
            // UpdButton
            // 
            this.UpdButton.Location = new System.Drawing.Point(527, 140);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(75, 23);
            this.UpdButton.TabIndex = 8;
            this.UpdButton.Text = "Оновити";
            this.UpdButton.UseVisualStyleBackColor = true;
            this.UpdButton.Click += new System.EventHandler(this.UpdButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditZhurOperazij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpdButton);
            this.Controls.Add(this.EditBut);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditZhOpGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditZhurOperazij";
            this.Text = "Редагування журналу операцій";
            this.Load += new System.EventHandler(this.EditZhurOperazij_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditZhOpGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EditZhOpGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button EditBut;
        private System.Windows.Forms.Button UpdButton;
        private System.Windows.Forms.Button button1;
    }
}
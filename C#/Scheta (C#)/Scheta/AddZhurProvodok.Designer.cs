namespace Scheta
{
    partial class AddZhurProvodok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddZhurProvodok));
            this.AddZhPButton = new System.Windows.Forms.Button();
            this.AddZhPrGridView = new System.Windows.Forms.DataGridView();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.SumProvTextBox = new System.Windows.Forms.TextBox();
            this.DocINTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddZhPrGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddZhPButton
            // 
            this.AddZhPButton.Location = new System.Drawing.Point(12, 74);
            this.AddZhPButton.Name = "AddZhPButton";
            this.AddZhPButton.Size = new System.Drawing.Size(147, 23);
            this.AddZhPButton.TabIndex = 0;
            this.AddZhPButton.Text = "Додати";
            this.AddZhPButton.UseVisualStyleBackColor = true;
            this.AddZhPButton.Click += new System.EventHandler(this.AddZhPButton_Click);
            // 
            // AddZhPrGridView
            // 
            this.AddZhPrGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddZhPrGridView.Location = new System.Drawing.Point(12, 103);
            this.AddZhPrGridView.Name = "AddZhPrGridView";
            this.AddZhPrGridView.Size = new System.Drawing.Size(367, 164);
            this.AddZhPrGridView.TabIndex = 1;
            this.AddZhPrGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddZhPrGridView_CellContentClick);
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(12, 30);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TypeTextBox.TabIndex = 2;
            // 
            // SumProvTextBox
            // 
            this.SumProvTextBox.Location = new System.Drawing.Point(279, 30);
            this.SumProvTextBox.Name = "SumProvTextBox";
            this.SumProvTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumProvTextBox.TabIndex = 4;
            // 
            // DocINTextBox
            // 
            this.DocINTextBox.Location = new System.Drawing.Point(146, 30);
            this.DocINTextBox.Name = "DocINTextBox";
            this.DocINTextBox.Size = new System.Drawing.Size(100, 20);
            this.DocINTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тип проводки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Сума проводки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ДокІН";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(228, 74);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(151, 23);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Оновити";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddZhurProvodok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 279);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocINTextBox);
            this.Controls.Add(this.SumProvTextBox);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.AddZhPrGridView);
            this.Controls.Add(this.AddZhPButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddZhurProvodok";
            this.Text = "AddZhurProvodok";
            this.Load += new System.EventHandler(this.AddZhurProvodok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddZhPrGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddZhPButton;
        private System.Windows.Forms.DataGridView AddZhPrGridView;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox SumProvTextBox;
        private System.Windows.Forms.TextBox DocINTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateButton;
    }
}
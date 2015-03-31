namespace Scheta
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.AddAccountGridView = new System.Windows.Forms.DataGridView();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PrymitkyBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddAccountGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddAccountGridView
            // 
            this.AddAccountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddAccountGridView.Location = new System.Drawing.Point(12, 76);
            this.AddAccountGridView.Name = "AddAccountGridView";
            this.AddAccountGridView.Size = new System.Drawing.Size(418, 174);
            this.AddAccountGridView.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(99, 9);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Назва рахунку";
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(237, 26);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(75, 23);
            this.AddAccountButton.TabIndex = 3;
            this.AddAccountButton.Text = "Додати";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(329, 26);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(81, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Оновити";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Примітки";
            // 
            // PrymitkyBox
            // 
            this.PrymitkyBox.Location = new System.Drawing.Point(99, 45);
            this.PrymitkyBox.Name = "PrymitkyBox";
            this.PrymitkyBox.Size = new System.Drawing.Size(100, 20);
            this.PrymitkyBox.TabIndex = 6;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 262);
            this.Controls.Add(this.PrymitkyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddAccountButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AddAccountGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddAccountGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AddAccountGridView;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrymitkyBox;
    }
}
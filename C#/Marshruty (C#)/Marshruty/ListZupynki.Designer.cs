namespace Marshruty
{
    partial class ListZupynki
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
            this.ListGridView = new System.Windows.Forms.DataGridView();
            this.NazvaBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListGridView
            // 
            this.ListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListGridView.Location = new System.Drawing.Point(12, 41);
            this.ListGridView.Name = "ListGridView";
            this.ListGridView.Size = new System.Drawing.Size(338, 291);
            this.ListGridView.TabIndex = 0;
            // 
            // NazvaBox
            // 
            this.NazvaBox.Location = new System.Drawing.Point(12, 12);
            this.NazvaBox.Name = "NazvaBox";
            this.NazvaBox.Size = new System.Drawing.Size(153, 20);
            this.NazvaBox.TabIndex = 1;
            this.NazvaBox.Text = "Назва";
            this.NazvaBox.Enter += new System.EventHandler(this.NazvaBox_Enter);
            this.NazvaBox.Leave += new System.EventHandler(this.NazvaBox_Leave);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(182, 12);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Пошук";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(275, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ListZupynki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 342);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.NazvaBox);
            this.Controls.Add(this.ListGridView);
            this.Name = "ListZupynki";
            this.Text = "ListZupynki";
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListGridView;
        private System.Windows.Forms.TextBox NazvaBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}
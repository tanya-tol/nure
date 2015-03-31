namespace Marshruty
{
    partial class ViewAutobus
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
            this.AutoGridView = new System.Windows.Forms.DataGridView();
            this.NazvaBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AutoGridView
            // 
            this.AutoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoGridView.Location = new System.Drawing.Point(12, 35);
            this.AutoGridView.Name = "AutoGridView";
            this.AutoGridView.Size = new System.Drawing.Size(659, 314);
            this.AutoGridView.TabIndex = 0;
            this.AutoGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AutoGridView_CellContentClick);
            // 
            // NazvaBox
            // 
            this.NazvaBox.Location = new System.Drawing.Point(12, 9);
            this.NazvaBox.Name = "NazvaBox";
            this.NazvaBox.Size = new System.Drawing.Size(176, 20);
            this.NazvaBox.TabIndex = 1;
            this.NazvaBox.Text = "Гос. номер";
            this.NazvaBox.Enter += new System.EventHandler(this.NazvaBox_Enter);
            this.NazvaBox.Leave += new System.EventHandler(this.NazvaBox_Leave);
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FindButton.Location = new System.Drawing.Point(194, 7);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Пошук";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Location = new System.Drawing.Point(596, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(514, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // ViewAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(683, 361);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.NazvaBox);
            this.Controls.Add(this.AutoGridView);
            this.Name = "ViewAutobus";
            this.Text = "Автобуси";
            this.Load += new System.EventHandler(this.ViewAutobus_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.AutoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AutoGridView;
        private System.Windows.Forms.TextBox NazvaBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
    }
}
namespace Marshruty
{
    partial class ViewMarshrut
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
            this.MarshGridView = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.NazvaBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MarshGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MarshGridView
            // 
            this.MarshGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarshGridView.Location = new System.Drawing.Point(12, 38);
            this.MarshGridView.Name = "MarshGridView";
            this.MarshGridView.Size = new System.Drawing.Size(660, 311);
            this.MarshGridView.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Location = new System.Drawing.Point(597, 7);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FindButton.Location = new System.Drawing.Point(189, 7);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Пошук";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // NazvaBox
            // 
            this.NazvaBox.Location = new System.Drawing.Point(12, 9);
            this.NazvaBox.Name = "NazvaBox";
            this.NazvaBox.Size = new System.Drawing.Size(171, 20);
            this.NazvaBox.TabIndex = 3;
            this.NazvaBox.Text = "Назва";
            this.NazvaBox.Enter += new System.EventHandler(this.NazvaBox_Enter);
            this.NazvaBox.Leave += new System.EventHandler(this.NazvaBox_Leave);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(516, 7);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ViewMarshrut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NazvaBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.MarshGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "ViewMarshrut";
            this.Text = "Редагувати маршрути";
            this.Load += new System.EventHandler(this.ViewMarshrut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MarshGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MarshGridView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox NazvaBox;
        private System.Windows.Forms.Button AddButton;
    }
}
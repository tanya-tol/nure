namespace Marshruty
{
    partial class ViewPersonal
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
            this.PersonalGridView = new System.Windows.Forms.DataGridView();
            this.NazvaBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonalGridView
            // 
            this.PersonalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonalGridView.Location = new System.Drawing.Point(13, 41);
            this.PersonalGridView.Name = "PersonalGridView";
            this.PersonalGridView.Size = new System.Drawing.Size(660, 312);
            this.PersonalGridView.TabIndex = 0;
            // 
            // NazvaBox
            // 
            this.NazvaBox.Location = new System.Drawing.Point(13, 13);
            this.NazvaBox.Name = "NazvaBox";
            this.NazvaBox.Size = new System.Drawing.Size(185, 20);
            this.NazvaBox.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FindButton.Location = new System.Drawing.Point(205, 13);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Пошук";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click_1);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Location = new System.Drawing.Point(598, 9);
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
            this.AddButton.Location = new System.Drawing.Point(516, 9);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ViewPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(685, 365);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.NazvaBox);
            this.Controls.Add(this.PersonalGridView);
            this.Name = "ViewPersonal";
            this.ShowIcon = false;
            this.Text = "Дані персонала";
            ((System.ComponentModel.ISupportInitialize)(this.PersonalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonalGridView;
        private System.Windows.Forms.TextBox NazvaBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
    }
}
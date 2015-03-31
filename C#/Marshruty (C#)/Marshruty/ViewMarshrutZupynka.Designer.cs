namespace Marshruty
{
    partial class ViewMarshrutZupynka
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
            this.ZupynkiGridView = new System.Windows.Forms.DataGridView();
            this.NazvaBox = new System.Windows.Forms.TextBox();
            this.ChasBox = new System.Windows.Forms.TextBox();
            this.DovzhinaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ZupynkiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ZupynkiGridView
            // 
            this.ZupynkiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZupynkiGridView.Location = new System.Drawing.Point(12, 90);
            this.ZupynkiGridView.Name = "ZupynkiGridView";
            this.ZupynkiGridView.Size = new System.Drawing.Size(310, 259);
            this.ZupynkiGridView.TabIndex = 0;
            // 
            // NazvaBox
            // 
            this.NazvaBox.Enabled = false;
            this.NazvaBox.Location = new System.Drawing.Point(156, 12);
            this.NazvaBox.Name = "NazvaBox";
            this.NazvaBox.Size = new System.Drawing.Size(166, 20);
            this.NazvaBox.TabIndex = 1;
            // 
            // ChasBox
            // 
            this.ChasBox.Enabled = false;
            this.ChasBox.Location = new System.Drawing.Point(156, 38);
            this.ChasBox.Name = "ChasBox";
            this.ChasBox.Size = new System.Drawing.Size(166, 20);
            this.ChasBox.TabIndex = 2;
            // 
            // DovzhinaBox
            // 
            this.DovzhinaBox.Enabled = false;
            this.DovzhinaBox.Location = new System.Drawing.Point(156, 64);
            this.DovzhinaBox.Name = "DovzhinaBox";
            this.DovzhinaBox.Size = new System.Drawing.Size(166, 20);
            this.DovzhinaBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Назва маршруту";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Протяжність маршруту";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Час в дорозі";
            // 
            // ViewMarshrutZupynka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DovzhinaBox);
            this.Controls.Add(this.ChasBox);
            this.Controls.Add(this.NazvaBox);
            this.Controls.Add(this.ZupynkiGridView);
            this.Name = "ViewMarshrutZupynka";
            this.Text = "Зупинки на маршруті";
            ((System.ComponentModel.ISupportInitialize)(this.ZupynkiGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ZupynkiGridView;
        private System.Windows.Forms.TextBox NazvaBox;
        private System.Windows.Forms.TextBox ChasBox;
        private System.Windows.Forms.TextBox DovzhinaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
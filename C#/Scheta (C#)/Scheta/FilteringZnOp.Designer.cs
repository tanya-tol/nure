namespace Scheta
{
    partial class FilteringZnOp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilteringZnOp));
            this.ZnOpGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.PhilButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ZnOpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ZnOpGridView
            // 
            this.ZnOpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZnOpGridView.Location = new System.Drawing.Point(12, 12);
            this.ZnOpGridView.Name = "ZnOpGridView";
            this.ZnOpGridView.Size = new System.Drawing.Size(520, 171);
            this.ZnOpGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фільтрація документів за типом:";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Location = new System.Drawing.Point(211, 199);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 2;
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // PhilButton
            // 
            this.PhilButton.Location = new System.Drawing.Point(372, 196);
            this.PhilButton.Name = "PhilButton";
            this.PhilButton.Size = new System.Drawing.Size(75, 23);
            this.PhilButton.TabIndex = 3;
            this.PhilButton.Text = "Go!";
            this.PhilButton.UseVisualStyleBackColor = true;
            this.PhilButton.Click += new System.EventHandler(this.PhilButton_Click);
            // 
            // FilteringZnOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 228);
            this.Controls.Add(this.PhilButton);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZnOpGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilteringZnOp";
            this.Text = "Фільтрація журналу операцій";
            this.Load += new System.EventHandler(this.FilteringZnOp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZnOpGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ZnOpGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button PhilButton;
    }
}
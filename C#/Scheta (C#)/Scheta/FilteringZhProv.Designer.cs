namespace Scheta
{
    partial class FilteringZhProv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilteringZhProv));
            this.FilterZhProvGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeDocBox = new System.Windows.Forms.TextBox();
            this.NomerRahtBox = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FilterZhProvGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterZhProvGridView
            // 
            this.FilterZhProvGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilterZhProvGridView.Location = new System.Drawing.Point(12, 12);
            this.FilterZhProvGridView.Name = "FilterZhProvGridView";
            this.FilterZhProvGridView.Size = new System.Drawing.Size(370, 150);
            this.FilterZhProvGridView.TabIndex = 0;
            this.FilterZhProvGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilterZhProvGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фільтрувати по...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер рахунку";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип документу";
            // 
            // TypeDocBox
            // 
            this.TypeDocBox.Location = new System.Drawing.Point(394, 52);
            this.TypeDocBox.Name = "TypeDocBox";
            this.TypeDocBox.Size = new System.Drawing.Size(76, 20);
            this.TypeDocBox.TabIndex = 4;
            this.TypeDocBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NomerRahtBox
            // 
            this.NomerRahtBox.Location = new System.Drawing.Point(394, 104);
            this.NomerRahtBox.Name = "NomerRahtBox";
            this.NomerRahtBox.Size = new System.Drawing.Size(80, 20);
            this.NomerRahtBox.TabIndex = 5;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(394, 141);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(80, 23);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Go";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // FilteringZhProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 176);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.NomerRahtBox);
            this.Controls.Add(this.TypeDocBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterZhProvGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilteringZhProv";
            this.Text = "Журнал проводок (фільтрація даних)";
            this.Load += new System.EventHandler(this.FilteringZhProv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilterZhProvGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FilterZhProvGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TypeDocBox;
        private System.Windows.Forms.TextBox NomerRahtBox;
        private System.Windows.Forms.Button FilterButton;
    }
}
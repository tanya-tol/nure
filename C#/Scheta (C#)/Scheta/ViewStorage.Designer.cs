namespace Scheta
{
    partial class ViewStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStorage));
            this.ViewStorageGridView = new System.Windows.Forms.DataGridView();
            this.UpdateBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStorageGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewStorageGridView
            // 
            this.ViewStorageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewStorageGridView.Location = new System.Drawing.Point(12, 12);
            this.ViewStorageGridView.Name = "ViewStorageGridView";
            this.ViewStorageGridView.Size = new System.Drawing.Size(410, 206);
            this.ViewStorageGridView.TabIndex = 0;
            this.ViewStorageGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewStorageGridView_CellContentClick);
            // 
            // UpdateBut
            // 
            this.UpdateBut.Location = new System.Drawing.Point(437, 12);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(106, 23);
            this.UpdateBut.TabIndex = 1;
            this.UpdateBut.Text = "Оновити";
            this.UpdateBut.UseVisualStyleBackColor = true;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // ViewStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 231);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.ViewStorageGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewStorage";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.ViewStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewStorageGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewStorageGridView;
        private System.Windows.Forms.Button UpdateBut;
    }
}
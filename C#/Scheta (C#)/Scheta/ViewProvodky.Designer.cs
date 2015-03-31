namespace Scheta
{
    partial class ViewProvodky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProvodky));
            this.ProvodkydataGridView = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProvodkydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProvodkydataGridView
            // 
            this.ProvodkydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProvodkydataGridView.Location = new System.Drawing.Point(12, 12);
            this.ProvodkydataGridView.Name = "ProvodkydataGridView";
            this.ProvodkydataGridView.Size = new System.Drawing.Size(490, 158);
            this.ProvodkydataGridView.TabIndex = 0;
            this.ProvodkydataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProvodkydataGridView_CellContentClick);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(519, 74);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(96, 31);
            this.Update.TabIndex = 1;
            this.Update.Text = "Оновити";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // ViewProvodky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 183);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.ProvodkydataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewProvodky";
            this.Text = "Проводки";
            this.Load += new System.EventHandler(this.ViewProvodky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProvodkydataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProvodkydataGridView;
        private System.Windows.Forms.Button Update;
    }
}
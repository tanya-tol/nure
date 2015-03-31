namespace Scheta
{
    partial class ViewAccount
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
            this.SheetsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SheetsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SheetsGridView
            // 
            this.SheetsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SheetsGridView.Location = new System.Drawing.Point(13, 13);
            this.SheetsGridView.Name = "SheetsGridView";
            this.SheetsGridView.Size = new System.Drawing.Size(483, 237);
            this.SheetsGridView.TabIndex = 0;
            // 
            // ViewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 262);
            this.Controls.Add(this.SheetsGridView);
            this.Name = "ViewAccount";
            this.Text = "ViewTurnSheets";
            this.Load += new System.EventHandler(this.ViewAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SheetsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SheetsGridView;
        private System.Windows.Forms.TextBox turn_creditBox;
        private System.Windows.Forms.TextBox turn_debitBox;
        private System.Windows.Forms.TextBox saldo_beg_creditBox;
        private System.Windows.Forms.TextBox saldo_beg_debitBox;
        private System.Windows.Forms.TextBox saldo_fin_creditBox;
        private System.Windows.Forms.TextBox saldo_fin_debitBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
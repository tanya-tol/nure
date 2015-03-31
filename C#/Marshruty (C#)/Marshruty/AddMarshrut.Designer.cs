namespace Marshruty
{
    partial class AddMarshrut
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
            this.NazvaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DovzhinaBox = new System.Windows.Forms.TextBox();
            this.ChasBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ZupynkaGridView = new System.Windows.Forms.DataGridView();
            this.FindZupynkaGridView = new System.Windows.Forms.DataGridView();
            this.FindButton = new System.Windows.Forms.Button();
            this.FindBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ZupynkaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindZupynkaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NazvaBox
            // 
            this.NazvaBox.Location = new System.Drawing.Point(12, 27);
            this.NazvaBox.Name = "NazvaBox";
            this.NazvaBox.Size = new System.Drawing.Size(186, 20);
            this.NazvaBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва маршрута";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Час в дорозі (хв)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Довжина маршрута (км)";
            // 
            // DovzhinaBox
            // 
            this.DovzhinaBox.Location = new System.Drawing.Point(12, 66);
            this.DovzhinaBox.Name = "DovzhinaBox";
            this.DovzhinaBox.Size = new System.Drawing.Size(186, 20);
            this.DovzhinaBox.TabIndex = 4;
            // 
            // ChasBox
            // 
            this.ChasBox.Location = new System.Drawing.Point(12, 105);
            this.ChasBox.Name = "ChasBox";
            this.ChasBox.Size = new System.Drawing.Size(186, 20);
            this.ChasBox.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DarkGreen;
            this.AddButton.Location = new System.Drawing.Point(12, 323);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(186, 31);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ZupynkaGridView
            // 
            this.ZupynkaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZupynkaGridView.Location = new System.Drawing.Point(208, 27);
            this.ZupynkaGridView.Name = "ZupynkaGridView";
            this.ZupynkaGridView.Size = new System.Drawing.Size(232, 186);
            this.ZupynkaGridView.TabIndex = 7;
            this.ZupynkaGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZupynkaGridView_CellContentClick);
            this.ZupynkaGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ZupynkaGridView_CellMouseDoubleClick);
            // 
            // FindZupynkaGridView
            // 
            this.FindZupynkaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindZupynkaGridView.Location = new System.Drawing.Point(208, 248);
            this.FindZupynkaGridView.Name = "FindZupynkaGridView";
            this.FindZupynkaGridView.Size = new System.Drawing.Size(232, 106);
            this.FindZupynkaGridView.TabIndex = 8;
            this.FindZupynkaGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FindZupynkaGridView_CellMouseDoubleClick);
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.DarkGreen;
            this.FindButton.Location = new System.Drawing.Point(365, 219);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 9;
            this.FindButton.Text = "Пошук";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindBox
            // 
            this.FindBox.Location = new System.Drawing.Point(208, 222);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(151, 20);
            this.FindBox.TabIndex = 10;
            this.FindBox.Text = "Назва зупинки";
            this.FindBox.Enter += new System.EventHandler(this.FindBox_Enter);
            this.FindBox.Leave += new System.EventHandler(this.FindBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Зупинки на маршруті";
            // 
            // AddMarshrut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(452, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FindZupynkaGridView);
            this.Controls.Add(this.ZupynkaGridView);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ChasBox);
            this.Controls.Add(this.DovzhinaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazvaBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddMarshrut";
            this.Text = "Додати маршрут";
            this.Load += new System.EventHandler(this.AddMarshrut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZupynkaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindZupynkaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NazvaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DovzhinaBox;
        private System.Windows.Forms.TextBox ChasBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView ZupynkaGridView;
        private System.Windows.Forms.DataGridView FindZupynkaGridView;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox FindBox;
        private System.Windows.Forms.Label label4;
    }
}
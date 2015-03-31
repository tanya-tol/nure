namespace MatStat_lb1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laba2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potok1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potok2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.diagramsToolStripMenuItem,
            this.laba2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "Laba4";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // diagramsToolStripMenuItem
            // 
            this.diagramsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fxToolStripMenuItem});
            this.diagramsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.diagramsToolStripMenuItem.Name = "diagramsToolStripMenuItem";
            this.diagramsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.diagramsToolStripMenuItem.Text = "Diagrams";
            // 
            // fxToolStripMenuItem
            // 
            this.fxToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fxToolStripMenuItem.Name = "fxToolStripMenuItem";
            this.fxToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.fxToolStripMenuItem.Text = "F(x)=";
            this.fxToolStripMenuItem.Click += new System.EventHandler(this.fxToolStripMenuItem_Click);
            // 
            // laba2ToolStripMenuItem
            // 
            this.laba2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.potok1ToolStripMenuItem,
            this.potok2ToolStripMenuItem,
            this.sumaToolStripMenuItem});
            this.laba2ToolStripMenuItem.Name = "laba2ToolStripMenuItem";
            this.laba2ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.laba2ToolStripMenuItem.Text = "Laba2";
            // 
            // potok1ToolStripMenuItem
            // 
            this.potok1ToolStripMenuItem.Name = "potok1ToolStripMenuItem";
            this.potok1ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.potok1ToolStripMenuItem.Text = "Potok1";
            this.potok1ToolStripMenuItem.Click += new System.EventHandler(this.potok1ToolStripMenuItem_Click);
            // 
            // potok2ToolStripMenuItem
            // 
            this.potok2ToolStripMenuItem.Name = "potok2ToolStripMenuItem";
            this.potok2ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.potok2ToolStripMenuItem.Text = "Potok2";
            this.potok2ToolStripMenuItem.Click += new System.EventHandler(this.potok2ToolStripMenuItem_Click);
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(570, 404);
            this.textBox1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // zedGraph
            // 
            this.zedGraph.ForeColor = System.Drawing.Color.Black;
            this.zedGraph.Location = new System.Drawing.Point(598, 38);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(636, 404);
            this.zedGraph.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 467);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem diagramsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.ToolStripMenuItem fxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laba2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potok1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potok2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;

    }
}


namespace Scheta
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.TableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnSheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOperationsLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DovidnykyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналПроводокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddZhProvStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditZhProvToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.журналОпераційToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddZhOperToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RedagToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FilteringZnOpToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewStorageToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ProvodkyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZvityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AccountGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TurnSheetsdataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ZhurnOperationsGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ZhurnProvodokGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TurnSheetsdataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZhurnOperationsGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZhurnProvodokGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TableToolStripMenuItem,
            this.DovidnykyToolStripMenuItem,
            this.DocumentsToolStripMenuItem,
            this.StorageToolStripMenuItem,
            this.ProvodkyToolStripMenuItem,
            this.ZvityToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(586, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // TableToolStripMenuItem
            // 
            this.TableToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.TableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.AddOperationsLogToolStripMenuItem});
            this.TableToolStripMenuItem.Name = "TableToolStripMenuItem";
            this.TableToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.TableToolStripMenuItem.Text = "Таблиці...";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountToolStripMenuItem,
            this.turnSheetsToolStripMenuItem});
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.AddToolStripMenuItem.Text = "Додати в таблицю...";
            // 
            // AccountToolStripMenuItem
            // 
            this.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem";
            this.AccountToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.AccountToolStripMenuItem.Text = "Account";
            this.AccountToolStripMenuItem.Click += new System.EventHandler(this.AccountToolStripMenuItem_Click);
            // 
            // turnSheetsToolStripMenuItem
            // 
            this.turnSheetsToolStripMenuItem.Name = "turnSheetsToolStripMenuItem";
            this.turnSheetsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.turnSheetsToolStripMenuItem.Text = "ОборотСальдВід";
            this.turnSheetsToolStripMenuItem.Click += new System.EventHandler(this.turnSheetsToolStripMenuItem_Click);
            // 
            // AddOperationsLogToolStripMenuItem
            // 
            this.AddOperationsLogToolStripMenuItem.Name = "AddOperationsLogToolStripMenuItem";
            this.AddOperationsLogToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.AddOperationsLogToolStripMenuItem.Text = "Редагувати таблицю...";
            // 
            // DovidnykyToolStripMenuItem
            // 
            this.DovidnykyToolStripMenuItem.BackColor = System.Drawing.Color.Tomato;
            this.DovidnykyToolStripMenuItem.Name = "DovidnykyToolStripMenuItem";
            this.DovidnykyToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.DovidnykyToolStripMenuItem.Text = "Довідники";
            // 
            // DocumentsToolStripMenuItem
            // 
            this.DocumentsToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.DocumentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.журналПроводокToolStripMenuItem,
            this.журналОпераційToolStripMenuItem});
            this.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem";
            this.DocumentsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.DocumentsToolStripMenuItem.Text = "Документи";
            // 
            // журналПроводокToolStripMenuItem
            // 
            this.журналПроводокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddZhProvStripMenu,
            this.EditZhProvToolStripMenu});
            this.журналПроводокToolStripMenuItem.Name = "журналПроводокToolStripMenuItem";
            this.журналПроводокToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.журналПроводокToolStripMenuItem.Text = "Журнал проводок";
            // 
            // AddZhProvStripMenu
            // 
            this.AddZhProvStripMenu.Name = "AddZhProvStripMenu";
            this.AddZhProvStripMenu.Size = new System.Drawing.Size(142, 22);
            this.AddZhProvStripMenu.Text = "Додати...";
            this.AddZhProvStripMenu.Click += new System.EventHandler(this.AddZhProvStripMenu_Click);
            // 
            // EditZhProvToolStripMenu
            // 
            this.EditZhProvToolStripMenu.Name = "EditZhProvToolStripMenu";
            this.EditZhProvToolStripMenu.Size = new System.Drawing.Size(142, 22);
            this.EditZhProvToolStripMenu.Text = "Фільтрація...";
            this.EditZhProvToolStripMenu.Click += new System.EventHandler(this.EditZhProvToolStripMenu_Click);
            // 
            // журналОпераційToolStripMenuItem
            // 
            this.журналОпераційToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddZhOperToolStripMenu,
            this.RedagToolStripMenu,
            this.FilteringZnOpToolStripMenu});
            this.журналОпераційToolStripMenuItem.Name = "журналОпераційToolStripMenuItem";
            this.журналОпераційToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.журналОпераційToolStripMenuItem.Text = "Журнал операцій";
            // 
            // AddZhOperToolStripMenu
            // 
            this.AddZhOperToolStripMenu.Name = "AddZhOperToolStripMenu";
            this.AddZhOperToolStripMenu.Size = new System.Drawing.Size(143, 22);
            this.AddZhOperToolStripMenu.Text = "Додати...";
            this.AddZhOperToolStripMenu.Click += new System.EventHandler(this.AddZhOperToolStripMenu_Click);
            // 
            // RedagToolStripMenu
            // 
            this.RedagToolStripMenu.Name = "RedagToolStripMenu";
            this.RedagToolStripMenu.Size = new System.Drawing.Size(143, 22);
            this.RedagToolStripMenu.Text = "Редагувати...";
            this.RedagToolStripMenu.Click += new System.EventHandler(this.RedagToolStripMenu_Click);
            // 
            // FilteringZnOpToolStripMenu
            // 
            this.FilteringZnOpToolStripMenu.Name = "FilteringZnOpToolStripMenu";
            this.FilteringZnOpToolStripMenu.Size = new System.Drawing.Size(143, 22);
            this.FilteringZnOpToolStripMenu.Text = "Фільтрація...";
            this.FilteringZnOpToolStripMenu.Click += new System.EventHandler(this.FilteringZnOpToolStripMenu_Click);
            // 
            // StorageToolStripMenuItem
            // 
            this.StorageToolStripMenuItem.BackColor = System.Drawing.Color.Crimson;
            this.StorageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewStorageToolStripMenu});
            this.StorageToolStripMenuItem.Name = "StorageToolStripMenuItem";
            this.StorageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.StorageToolStripMenuItem.Text = "Склад";
            // 
            // ViewStorageToolStripMenu
            // 
            this.ViewStorageToolStripMenu.Name = "ViewStorageToolStripMenu";
            this.ViewStorageToolStripMenu.Size = new System.Drawing.Size(126, 22);
            this.ViewStorageToolStripMenu.Text = "Перегляд";
            this.ViewStorageToolStripMenu.Click += new System.EventHandler(this.ViewStorageToolStripMenu_Click);
            // 
            // ProvodkyToolStripMenuItem
            // 
            this.ProvodkyToolStripMenuItem.BackColor = System.Drawing.Color.Peru;
            this.ProvodkyToolStripMenuItem.Name = "ProvodkyToolStripMenuItem";
            this.ProvodkyToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.ProvodkyToolStripMenuItem.Text = "Проводки";
            this.ProvodkyToolStripMenuItem.Click += new System.EventHandler(this.ProvodkyToolStripMenuItem_Click);
            // 
            // ZvityToolStripMenuItem
            // 
            this.ZvityToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.ZvityToolStripMenuItem.Name = "ZvityToolStripMenuItem";
            this.ZvityToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ZvityToolStripMenuItem.Text = "Звіти";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 224);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 221);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AccountGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(551, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Рахунки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AccountGridView
            // 
            this.AccountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountGridView.Location = new System.Drawing.Point(-4, 0);
            this.AccountGridView.Name = "AccountGridView";
            this.AccountGridView.Size = new System.Drawing.Size(555, 195);
            this.AccountGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TurnSheetsdataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(551, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ОборотСальдВідом";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TurnSheetsdataGridView
            // 
            this.TurnSheetsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TurnSheetsdataGridView.Location = new System.Drawing.Point(-4, 0);
            this.TurnSheetsdataGridView.Name = "TurnSheetsdataGridView";
            this.TurnSheetsdataGridView.Size = new System.Drawing.Size(556, 195);
            this.TurnSheetsdataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ZhurnOperationsGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(551, 195);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "ЖОперацій";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ZhurnOperationsGridView
            // 
            this.ZhurnOperationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZhurnOperationsGridView.Location = new System.Drawing.Point(0, 0);
            this.ZhurnOperationsGridView.Name = "ZhurnOperationsGridView";
            this.ZhurnOperationsGridView.Size = new System.Drawing.Size(563, 195);
            this.ZhurnOperationsGridView.TabIndex = 0;
            this.ZhurnOperationsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZhurnOperationsGridView_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ZhurnProvodokGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(551, 195);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "ЖПроводок";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ZhurnProvodokGridView
            // 
            this.ZhurnProvodokGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZhurnProvodokGridView.Location = new System.Drawing.Point(0, 0);
            this.ZhurnProvodokGridView.Name = "ZhurnProvodokGridView";
            this.ZhurnProvodokGridView.Size = new System.Drawing.Size(555, 195);
            this.ZhurnProvodokGridView.TabIndex = 0;
            this.ZhurnProvodokGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZhurnProvodokGridView_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(586, 263);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "ІСБО";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TurnSheetsdataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ZhurnOperationsGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ZhurnProvodokGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView AccountGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView TurnSheetsdataGridView;
        private System.Windows.Forms.ToolStripMenuItem TableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddOperationsLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DovidnykyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProvodkyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZvityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnSheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView ZhurnOperationsGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView ZhurnProvodokGridView;
        private System.Windows.Forms.ToolStripMenuItem журналПроводокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddZhProvStripMenu;
        private System.Windows.Forms.ToolStripMenuItem EditZhProvToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem журналОпераційToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddZhOperToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem RedagToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem FilteringZnOpToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewStorageToolStripMenu;
    }
}
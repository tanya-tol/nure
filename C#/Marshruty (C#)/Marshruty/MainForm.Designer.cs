namespace Marshruty
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MarshrutyMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMarshrutyMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMarshrutyMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoparkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAutobusMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditAutoparkMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPersonalMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPersonalMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StopMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ListStopMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddZupynkaMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FrontPageTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MarshGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AutParkGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PersGridView = new System.Windows.Forms.DataGridView();
            this.FindTab = new System.Windows.Forms.TabPage();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.TextBox();
            this.FindGridView = new System.Windows.Forms.DataGridView();
            this.MainMenu.SuspendLayout();
            this.FrontPageTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarshGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutParkGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersGridView)).BeginInit();
            this.FindTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.SeaGreen;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MarshrutyMainMenu,
            this.AutoparkMenuItem,
            this.PersonalMenuItem,
            this.LoginMainMenu,
            this.StopMainMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(684, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // MarshrutyMainMenu
            // 
            this.MarshrutyMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMarshrutyMainMenu,
            this.EditMarshrutyMainMenu});
            this.MarshrutyMainMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MarshrutyMainMenu.Name = "MarshrutyMainMenu";
            this.MarshrutyMainMenu.Size = new System.Drawing.Size(79, 20);
            this.MarshrutyMainMenu.Text = "Маршрути";
            // 
            // AddMarshrutyMainMenu
            // 
            this.AddMarshrutyMainMenu.Name = "AddMarshrutyMainMenu";
            this.AddMarshrutyMainMenu.Size = new System.Drawing.Size(206, 22);
            this.AddMarshrutyMainMenu.Text = "Додати";
            this.AddMarshrutyMainMenu.Click += new System.EventHandler(this.AddMarshrutyMainMenu_Click);
            // 
            // EditMarshrutyMainMenu
            // 
            this.EditMarshrutyMainMenu.Name = "EditMarshrutyMainMenu";
            this.EditMarshrutyMainMenu.Size = new System.Drawing.Size(206, 22);
            this.EditMarshrutyMainMenu.Text = "Редагування/Видалення";
            this.EditMarshrutyMainMenu.Click += new System.EventHandler(this.EditMarshrutyMainMenu_Click);
            // 
            // AutoparkMenuItem
            // 
            this.AutoparkMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAutobusMainMenu,
            this.EditAutoparkMainMenu});
            this.AutoparkMenuItem.Name = "AutoparkMenuItem";
            this.AutoparkMenuItem.Size = new System.Drawing.Size(71, 20);
            this.AutoparkMenuItem.Text = "Автопарк";
            // 
            // AddAutobusMainMenu
            // 
            this.AddAutobusMainMenu.Name = "AddAutobusMainMenu";
            this.AddAutobusMainMenu.Size = new System.Drawing.Size(206, 22);
            this.AddAutobusMainMenu.Text = "Додати";
            this.AddAutobusMainMenu.Click += new System.EventHandler(this.AddAutobusToolStripMenuItem_Click);
            // 
            // EditAutoparkMainMenu
            // 
            this.EditAutoparkMainMenu.Name = "EditAutoparkMainMenu";
            this.EditAutoparkMainMenu.Size = new System.Drawing.Size(206, 22);
            this.EditAutoparkMainMenu.Text = "Редагування/Видалення";
            this.EditAutoparkMainMenu.Click += new System.EventHandler(this.EditAutoparkMainMenu_Click_1);
            // 
            // PersonalMenuItem
            // 
            this.PersonalMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPersonalMainMenu,
            this.EditPersonalMainMenu});
            this.PersonalMenuItem.Name = "PersonalMenuItem";
            this.PersonalMenuItem.Size = new System.Drawing.Size(74, 20);
            this.PersonalMenuItem.Text = "Персонал";
            // 
            // AddPersonalMainMenu
            // 
            this.AddPersonalMainMenu.Name = "AddPersonalMainMenu";
            this.AddPersonalMainMenu.Size = new System.Drawing.Size(206, 22);
            this.AddPersonalMainMenu.Text = "Додати";
            this.AddPersonalMainMenu.Click += new System.EventHandler(this.AddPersonalMainMenu_Click);
            // 
            // EditPersonalMainMenu
            // 
            this.EditPersonalMainMenu.Name = "EditPersonalMainMenu";
            this.EditPersonalMainMenu.Size = new System.Drawing.Size(206, 22);
            this.EditPersonalMainMenu.Text = "Редагування/Видалення";
            this.EditPersonalMainMenu.Click += new System.EventHandler(this.EditPersonalMainMenu_Click);
            // 
            // LoginMainMenu
            // 
            this.LoginMainMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LoginMainMenu.Name = "LoginMainMenu";
            this.LoginMainMenu.Size = new System.Drawing.Size(40, 20);
            this.LoginMainMenu.Text = "Вхід";
            this.LoginMainMenu.Click += new System.EventHandler(this.LoginMainMenu_Click);
            // 
            // StopMainMenu
            // 
            this.StopMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListStopMainMenu,
            this.AddZupynkaMainMenu});
            this.StopMainMenu.Name = "StopMainMenu";
            this.StopMainMenu.Size = new System.Drawing.Size(66, 20);
            this.StopMainMenu.Text = "Зупинки";
            // 
            // ListStopMainMenu
            // 
            this.ListStopMainMenu.Name = "ListStopMainMenu";
            this.ListStopMainMenu.Size = new System.Drawing.Size(186, 22);
            this.ListStopMainMenu.Text = "Список всіх зупинок";
            this.ListStopMainMenu.Click += new System.EventHandler(this.ListStopMainMenu_Click);
            // 
            // AddZupynkaMainMenu
            // 
            this.AddZupynkaMainMenu.Name = "AddZupynkaMainMenu";
            this.AddZupynkaMainMenu.Size = new System.Drawing.Size(186, 22);
            this.AddZupynkaMainMenu.Text = "Додати";
            this.AddZupynkaMainMenu.Click += new System.EventHandler(this.AddZupynkaMainMenu_Click);
            // 
            // FrontPageTab
            // 
            this.FrontPageTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FrontPageTab.Controls.Add(this.tabPage1);
            this.FrontPageTab.Controls.Add(this.tabPage2);
            this.FrontPageTab.Controls.Add(this.tabPage3);
            this.FrontPageTab.Controls.Add(this.FindTab);
            this.FrontPageTab.Location = new System.Drawing.Point(13, 38);
            this.FrontPageTab.Name = "FrontPageTab";
            this.FrontPageTab.SelectedIndex = 0;
            this.FrontPageTab.Size = new System.Drawing.Size(659, 361);
            this.FrontPageTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage1.Controls.Add(this.MarshGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Маршрути";
            // 
            // MarshGridView
            // 
            this.MarshGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MarshGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.MarshGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarshGridView.Location = new System.Drawing.Point(0, 0);
            this.MarshGridView.Name = "MarshGridView";
            this.MarshGridView.Size = new System.Drawing.Size(651, 335);
            this.MarshGridView.TabIndex = 0;
            this.MarshGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MarshGridView_CellContentClick);
            this.MarshGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MarshGridView_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tabPage2.Controls.Add(this.AutParkGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Автопарк";
            // 
            // AutParkGridView
            // 
            this.AutParkGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutParkGridView.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.AutParkGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutParkGridView.Location = new System.Drawing.Point(0, 0);
            this.AutParkGridView.Name = "AutParkGridView";
            this.AutParkGridView.Size = new System.Drawing.Size(651, 335);
            this.AutParkGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage3.Controls.Add(this.PersGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(651, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Персонал";
            // 
            // PersGridView
            // 
            this.PersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.PersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersGridView.Location = new System.Drawing.Point(0, 0);
            this.PersGridView.Name = "PersGridView";
            this.PersGridView.Size = new System.Drawing.Size(651, 335);
            this.PersGridView.TabIndex = 0;
            // 
            // FindTab
            // 
            this.FindTab.Controls.Add(this.FindLabel);
            this.FindTab.Controls.Add(this.FindButton);
            this.FindTab.Controls.Add(this.Find);
            this.FindTab.Controls.Add(this.FindGridView);
            this.FindTab.Location = new System.Drawing.Point(4, 22);
            this.FindTab.Name = "FindTab";
            this.FindTab.Padding = new System.Windows.Forms.Padding(3);
            this.FindTab.Size = new System.Drawing.Size(651, 335);
            this.FindTab.TabIndex = 3;
            this.FindTab.Text = "Пошук";
            this.FindTab.UseVisualStyleBackColor = true;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(485, 27);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(86, 13);
            this.FindLabel.TabIndex = 3;
            this.FindLabel.Text = "Назва зупинки:";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(488, 81);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(142, 23);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Пошук";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(485, 55);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(145, 20);
            this.Find.TabIndex = 1;
            // 
            // FindGridView
            // 
            this.FindGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindGridView.Location = new System.Drawing.Point(6, 6);
            this.FindGridView.Name = "FindGridView";
            this.FindGridView.Size = new System.Drawing.Size(473, 323);
            this.FindGridView.TabIndex = 0;
            this.FindGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FindGridView_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.FrontPageTab);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "MainForm";
            this.Text = "Міські маршрути";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.FrontPageTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarshGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AutParkGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersGridView)).EndInit();
            this.FindTab.ResumeLayout(false);
            this.FindTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.TabControl FrontPageTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView MarshGridView;
        private System.Windows.Forms.DataGridView AutParkGridView;
        private System.Windows.Forms.DataGridView PersGridView;
        private System.Windows.Forms.ToolStripMenuItem MarshrutyMainMenu;
        private System.Windows.Forms.ToolStripMenuItem AddMarshrutyMainMenu;
        private System.Windows.Forms.ToolStripMenuItem EditMarshrutyMainMenu;
        private System.Windows.Forms.ToolStripMenuItem AutoparkMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddAutobusMainMenu;
        private System.Windows.Forms.ToolStripMenuItem EditAutoparkMainMenu;
        private System.Windows.Forms.ToolStripMenuItem PersonalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPersonalMainMenu;
        private System.Windows.Forms.ToolStripMenuItem EditPersonalMainMenu;
        private System.Windows.Forms.ToolStripMenuItem LoginMainMenu;
        private System.Windows.Forms.ToolStripMenuItem StopMainMenu;
        private System.Windows.Forms.ToolStripMenuItem ListStopMainMenu;
        private System.Windows.Forms.ToolStripMenuItem AddZupynkaMainMenu;
        private System.Windows.Forms.TabPage FindTab;
        private System.Windows.Forms.DataGridView FindGridView;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox Find;
    }
}


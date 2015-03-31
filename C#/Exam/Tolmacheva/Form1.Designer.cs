namespace Tolmacheva
{
    partial class СCreateButton
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.OutLogBox = new System.Windows.Forms.TextBox();
            this.butPerimRect = new System.Windows.Forms.Button();
            this.butSquareRect = new System.Windows.Forms.Button();
            this.butPerTriangle = new System.Windows.Forms.Button();
            this.butSquareTriangle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CreateButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "длина (а)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "высота (b)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Прямоугольник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Треугольник";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "основа треугольника (а)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(31, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "высота треугольника (h)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 20);
            this.textBox4.TabIndex = 9;
            // 
            // OutLogBox
            // 
            this.OutLogBox.Location = new System.Drawing.Point(166, 170);
            this.OutLogBox.Multiline = true;
            this.OutLogBox.Name = "OutLogBox";
            this.OutLogBox.Size = new System.Drawing.Size(235, 127);
            this.OutLogBox.TabIndex = 10;
            // 
            // butPerimRect
            // 
            this.butPerimRect.Location = new System.Drawing.Point(166, 18);
            this.butPerimRect.Name = "butPerimRect";
            this.butPerimRect.Size = new System.Drawing.Size(226, 23);
            this.butPerimRect.TabIndex = 11;
            this.butPerimRect.Text = "Посчитать периметр прямоугольника";
            this.butPerimRect.UseVisualStyleBackColor = true;
            this.butPerimRect.Click += new System.EventHandler(this.butPerimRect_Click);
            // 
            // butSquareRect
            // 
            this.butSquareRect.Location = new System.Drawing.Point(166, 49);
            this.butSquareRect.Name = "butSquareRect";
            this.butSquareRect.Size = new System.Drawing.Size(226, 23);
            this.butSquareRect.TabIndex = 12;
            this.butSquareRect.Text = "Посчитать площадь прямоугольника";
            this.butSquareRect.UseVisualStyleBackColor = true;
            this.butSquareRect.Click += new System.EventHandler(this.butSquareRect_Click);
            // 
            // butPerTriangle
            // 
            this.butPerTriangle.Location = new System.Drawing.Point(166, 83);
            this.butPerTriangle.Name = "butPerTriangle";
            this.butPerTriangle.Size = new System.Drawing.Size(226, 23);
            this.butPerTriangle.TabIndex = 13;
            this.butPerTriangle.Text = "Посчитать периметр треугольника";
            this.butPerTriangle.UseVisualStyleBackColor = true;
            this.butPerTriangle.Click += new System.EventHandler(this.butPerTriangle_Click);
            // 
            // butSquareTriangle
            // 
            this.butSquareTriangle.Location = new System.Drawing.Point(166, 112);
            this.butSquareTriangle.Name = "butSquareTriangle";
            this.butSquareTriangle.Size = new System.Drawing.Size(226, 23);
            this.butSquareTriangle.TabIndex = 14;
            this.butSquareTriangle.Text = "Посчитать площадь треугольника";
            this.butSquareTriangle.UseVisualStyleBackColor = true;
            this.butSquareTriangle.Click += new System.EventHandler(this.butSquareTriangle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "сторона b";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(15, 234);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(38, 20);
            this.textBox6.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "сторона с";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(14, 273);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(39, 20);
            this.textBox7.TabIndex = 18;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(70, 34);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 19;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CreateButton2
            // 
            this.CreateButton2.Location = new System.Drawing.Point(70, 274);
            this.CreateButton2.Name = "CreateButton2";
            this.CreateButton2.Size = new System.Drawing.Size(75, 23);
            this.CreateButton2.TabIndex = 20;
            this.CreateButton2.Text = "Создать";
            this.CreateButton2.UseVisualStyleBackColor = true;
            this.CreateButton2.Click += new System.EventHandler(this.CreateButton2_Click_1);
            // 
            // СCreateButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 323);
            this.Controls.Add(this.CreateButton2);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.butSquareTriangle);
            this.Controls.Add(this.butPerTriangle);
            this.Controls.Add(this.butSquareRect);
            this.Controls.Add(this.butPerimRect);
            this.Controls.Add(this.OutLogBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "СCreateButton";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox OutLogBox;
        private System.Windows.Forms.Button butPerimRect;
        private System.Windows.Forms.Button butSquareRect;
        private System.Windows.Forms.Button butPerTriangle;
        private System.Windows.Forms.Button butSquareTriangle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button CreateButton2;
    }
}


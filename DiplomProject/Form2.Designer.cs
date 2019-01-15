namespace DiplomProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пвапвToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВсеВопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВопросыДаНетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВопросыСЧисловымВводомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВопросыССопоставлениемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВопросыСУпорядочиваниемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.показатьВсеВопросыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.create_testbtn = new System.Windows.Forms.Button();
            this.тестыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаToolStripMenuItem,
            this.тестыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пвапвToolStripMenuItem,
            this.показатьВсеВопросыToolStripMenuItem,
            this.показатьВопросыДаНетToolStripMenuItem,
            this.показатьВопросыСЧисловымВводомToolStripMenuItem,
            this.показатьВопросыССопоставлениемToolStripMenuItem,
            this.показатьВопросыСУпорядочиваниемToolStripMenuItem,
            this.toolStripMenuItem1,
            this.показатьВсеВопросыToolStripMenuItem1});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // пвапвToolStripMenuItem
            // 
            this.пвапвToolStripMenuItem.Name = "пвапвToolStripMenuItem";
            this.пвапвToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.пвапвToolStripMenuItem.Text = "Показать вопросы с единичным выбором  ";
            // 
            // показатьВсеВопросыToolStripMenuItem
            // 
            this.показатьВсеВопросыToolStripMenuItem.Name = "показатьВсеВопросыToolStripMenuItem";
            this.показатьВсеВопросыToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.показатьВсеВопросыToolStripMenuItem.Text = "Показать вопросы с множественным выбором";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // показатьВопросыДаНетToolStripMenuItem
            // 
            this.показатьВопросыДаНетToolStripMenuItem.Name = "показатьВопросыДаНетToolStripMenuItem";
            this.показатьВопросыДаНетToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.показатьВопросыДаНетToolStripMenuItem.Text = "Показать вопросы Да/Нет";
            // 
            // показатьВопросыСЧисловымВводомToolStripMenuItem
            // 
            this.показатьВопросыСЧисловымВводомToolStripMenuItem.Name = "показатьВопросыСЧисловымВводомToolStripMenuItem";
            this.показатьВопросыСЧисловымВводомToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.показатьВопросыСЧисловымВводомToolStripMenuItem.Text = "Показать вопросы с Числовым вводом ";
            // 
            // показатьВопросыССопоставлениемToolStripMenuItem
            // 
            this.показатьВопросыССопоставлениемToolStripMenuItem.Name = "показатьВопросыССопоставлениемToolStripMenuItem";
            this.показатьВопросыССопоставлениемToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.показатьВопросыССопоставлениемToolStripMenuItem.Text = "Показать вопросы с сопоставлением";
            // 
            // показатьВопросыСУпорядочиваниемToolStripMenuItem
            // 
            this.показатьВопросыСУпорядочиваниемToolStripMenuItem.Name = "показатьВопросыСУпорядочиваниемToolStripMenuItem";
            this.показатьВопросыСУпорядочиваниемToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.показатьВопросыСУпорядочиваниемToolStripMenuItem.Text = "Показать вопросы с упорядочиванием";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(333, 6);
            // 
            // показатьВсеВопросыToolStripMenuItem1
            // 
            this.показатьВсеВопросыToolStripMenuItem1.Name = "показатьВсеВопросыToolStripMenuItem1";
            this.показатьВсеВопросыToolStripMenuItem1.Size = new System.Drawing.Size(336, 22);
            this.показатьВсеВопросыToolStripMenuItem1.Text = "Показать все вопросы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вопросы";
            // 
            // create_testbtn
            // 
            this.create_testbtn.Location = new System.Drawing.Point(159, 27);
            this.create_testbtn.Name = "create_testbtn";
            this.create_testbtn.Size = new System.Drawing.Size(109, 32);
            this.create_testbtn.TabIndex = 2;
            this.create_testbtn.Text = "Создать тест: ";
            this.create_testbtn.UseVisualStyleBackColor = true;
            this.create_testbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // тестыToolStripMenuItem
            // 
            this.тестыToolStripMenuItem.Name = "тестыToolStripMenuItem";
            this.тестыToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.тестыToolStripMenuItem.Text = "Тесты";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Создать вопрос: ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.create_testbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Вопросник";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пвапвToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеВопросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВопросыДаНетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВопросыСЧисловымВводомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВопросыССопоставлениемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВопросыСУпорядочиваниемToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеВопросыToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create_testbtn;
        private System.Windows.Forms.ToolStripMenuItem тестыToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}
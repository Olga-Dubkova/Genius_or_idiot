namespace GeniyIdiotWinFormsApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextButton = new System.Windows.Forms.Button();
            this.questionNumberLable = new System.Windows.Forms.Label();
            this.questionTextLable = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьЗановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВопросовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(153, 280);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(228, 64);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionNumberLable
            // 
            this.questionNumberLable.AutoSize = true;
            this.questionNumberLable.Location = new System.Drawing.Point(208, 53);
            this.questionNumberLable.Name = "questionNumberLable";
            this.questionNumberLable.Size = new System.Drawing.Size(94, 20);
            this.questionNumberLable.TabIndex = 1;
            this.questionNumberLable.Text = "Вопрос № 1";
            // 
            // questionTextLable
            // 
            this.questionTextLable.AutoSize = true;
            this.questionTextLable.Location = new System.Drawing.Point(12, 138);
            this.questionTextLable.Name = "questionTextLable";
            this.questionTextLable.Size = new System.Drawing.Size(109, 20);
            this.questionTextLable.TabIndex = 2;
            this.questionTextLable.Text = "Текст Вопроса";
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(208, 194);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(125, 27);
            this.userAnswerTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.результатыToolStripMenuItem,
            this.начатьЗановоToolStripMenuItem,
            this.списокВопросовToolStripMenuItem,
            this.добавитьВопросToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.файлToolStripMenuItem.Text = "Меню";
            // 
            // результатыToolStripMenuItem
            // 
            this.результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            this.результатыToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.результатыToolStripMenuItem.Text = "Результаты";
            this.результатыToolStripMenuItem.Click += new System.EventHandler(this.результатыToolStripMenuItem_Click);
            // 
            // начатьЗановоToolStripMenuItem
            // 
            this.начатьЗановоToolStripMenuItem.Name = "начатьЗановоToolStripMenuItem";
            this.начатьЗановоToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.начатьЗановоToolStripMenuItem.Text = "Начать заново";
            this.начатьЗановоToolStripMenuItem.Click += new System.EventHandler(this.начатьЗановоToolStripMenuItem_Click);
            // 
            // списокВопросовToolStripMenuItem
            // 
            this.списокВопросовToolStripMenuItem.Name = "списокВопросовToolStripMenuItem";
            this.списокВопросовToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.списокВопросовToolStripMenuItem.Text = "Список вопросов";
            this.списокВопросовToolStripMenuItem.Click += new System.EventHandler(this.списокВопросовToolStripMenuItem_Click);
            // 
            // добавитьВопросToolStripMenuItem
            // 
            this.добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            this.добавитьВопросToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.добавитьВопросToolStripMenuItem.Text = "Добавить вопрос";
            this.добавитьВопросToolStripMenuItem.Click += new System.EventHandler(this.добавитьВопросToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 398);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.questionTextLable);
            this.Controls.Add(this.questionNumberLable);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Гений Идиот";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label questionNumberLable;
        private System.Windows.Forms.Label questionTextLable;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьЗановоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВопросовToolStripMenuItem;
    }
}

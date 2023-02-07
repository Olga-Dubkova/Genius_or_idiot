namespace GeniyIdiotWinFormsApp
{
    partial class NewQuestionForm
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
            this.addQuestionLabel = new System.Windows.Forms.Label();
            this.addQuestionTextBox = new System.Windows.Forms.TextBox();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addAnswerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addQuestionLabel
            // 
            this.addQuestionLabel.AutoSize = true;
            this.addQuestionLabel.Location = new System.Drawing.Point(22, 45);
            this.addQuestionLabel.Name = "addQuestionLabel";
            this.addQuestionLabel.Size = new System.Drawing.Size(108, 20);
            this.addQuestionLabel.TabIndex = 0;
            this.addQuestionLabel.Text = "Текст вопроса";
            // 
            // addQuestionTextBox
            // 
            this.addQuestionTextBox.Location = new System.Drawing.Point(163, 42);
            this.addQuestionTextBox.Name = "addQuestionTextBox";
            this.addQuestionTextBox.Size = new System.Drawing.Size(421, 27);
            this.addQuestionTextBox.TabIndex = 1;
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.Location = new System.Drawing.Point(218, 157);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(161, 41);
            this.AddQuestionButton.TabIndex = 2;
            this.AddQuestionButton.Text = "Добавить";
            this.AddQuestionButton.UseVisualStyleBackColor = true;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ответ на вопрос";
            // 
            // addAnswerTextBox
            // 
            this.addAnswerTextBox.Location = new System.Drawing.Point(163, 92);
            this.addAnswerTextBox.Name = "addAnswerTextBox";
            this.addAnswerTextBox.Size = new System.Drawing.Size(421, 27);
            this.addAnswerTextBox.TabIndex = 4;
            // 
            // NewQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 230);
            this.Controls.Add(this.addAnswerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddQuestionButton);
            this.Controls.Add(this.addQuestionTextBox);
            this.Controls.Add(this.addQuestionLabel);
            this.Name = "NewQuestionForm";
            this.Text = "Добавить вопрос";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addQuestionLabel;
        public System.Windows.Forms.TextBox addQuestionTextBox;
        private System.Windows.Forms.Button AddQuestionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addAnswerTextBox;
    }
}
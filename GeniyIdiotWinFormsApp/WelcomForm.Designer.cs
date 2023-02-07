namespace GeniyIdiotWinFormsApp
{
    partial class WelcomForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.startBatton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в игру Гений Идиот!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите Ваше имя!";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(58, 99);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(222, 27);
            this.userNameTextBox.TabIndex = 2;
            // 
            // startBatton
            // 
            this.startBatton.Location = new System.Drawing.Point(58, 151);
            this.startBatton.Name = "startBatton";
            this.startBatton.Size = new System.Drawing.Size(222, 46);
            this.startBatton.TabIndex = 3;
            this.startBatton.Text = "Начать игру";
            this.startBatton.UseVisualStyleBackColor = true;
            this.startBatton.Click += new System.EventHandler(this.startBatton_Click);
            // 
            // WelcomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 233);
            this.Controls.Add(this.startBatton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WelcomForm";
            this.Text = "Гений Идиот";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button startBatton;
    }
}
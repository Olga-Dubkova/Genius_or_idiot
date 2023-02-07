namespace GeniyIdiotWinFormsApp
{
    partial class QuestionsListForm
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
            this.questionsdataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsdataGridView
            // 
            this.questionsdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.questionsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.questionsdataGridView.Location = new System.Drawing.Point(-7, 0);
            this.questionsdataGridView.MultiSelect = false;
            this.questionsdataGridView.Name = "questionsdataGridView";
            this.questionsdataGridView.RowHeadersWidth = 51;
            this.questionsdataGridView.RowTemplate.Height = 29;
            this.questionsdataGridView.Size = new System.Drawing.Size(642, 291);
            this.questionsdataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Текст";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 74;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ответ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 77;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuestionsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.questionsdataGridView);
            this.Name = "QuestionsListForm";
            this.Text = "Вопросы";
            this.Load += new System.EventHandler(this.QuestionsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView questionsdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
    }
}
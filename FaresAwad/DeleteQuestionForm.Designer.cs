namespace C__Project.FaresAwad
{
    partial class DeleteQuestionForm
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
            btnRemoveQuestion = new Button();
            txtQuestionIdToRemove = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRemoveQuestion
            // 
            btnRemoveQuestion.Location = new Point(82, 187);
            btnRemoveQuestion.Name = "btnRemoveQuestion";
            btnRemoveQuestion.Size = new Size(448, 29);
            btnRemoveQuestion.TabIndex = 0;
            btnRemoveQuestion.Text = "Remove";
            btnRemoveQuestion.UseVisualStyleBackColor = true;
            btnRemoveQuestion.Click += btnRemoveQuestion_Click;
            // 
            // txtQuestionIdToRemove
            // 
            txtQuestionIdToRemove.Location = new Point(178, 136);
            txtQuestionIdToRemove.Name = "txtQuestionIdToRemove";
            txtQuestionIdToRemove.Size = new Size(270, 27);
            txtQuestionIdToRemove.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 87);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 2;
            label1.Text = "QuestionID To Remove";
            // 
            // DeleteQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 313);
            Controls.Add(label1);
            Controls.Add(txtQuestionIdToRemove);
            Controls.Add(btnRemoveQuestion);
            Name = "DeleteQuestionForm";
            Text = "DeleteQuestionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemoveQuestion;
        private TextBox txtQuestionIdToRemove;
        private Label label1;
    }
}
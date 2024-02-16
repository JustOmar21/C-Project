namespace C__Project.FaresAwad
{
    partial class AddQuestionToExamForm
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
            txtCourseIdToSearch = new TextBox();
            label1 = new Label();
            btnShowQuestion = new Button();
            btnAddQuestionToExam = new Button();
            label2 = new Label();
            txtCourseIdToAdd = new TextBox();
            label3 = new Label();
            txtQuestionIdToAdd = new TextBox();
            label4 = new Label();
            txtExamIdToAdd = new TextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            txtQuestionDegreeToAdd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCourseIdToSearch
            // 
            txtCourseIdToSearch.Location = new Point(12, 39);
            txtCourseIdToSearch.Name = "txtCourseIdToSearch";
            txtCourseIdToSearch.Size = new Size(447, 27);
            txtCourseIdToSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 2;
            label1.Text = "Course Id";
            // 
            // btnShowQuestion
            // 
            btnShowQuestion.Location = new Point(12, 71);
            btnShowQuestion.Name = "btnShowQuestion";
            btnShowQuestion.Size = new Size(447, 29);
            btnShowQuestion.TabIndex = 3;
            btnShowQuestion.Text = "Show Questions";
            btnShowQuestion.UseVisualStyleBackColor = true;
            btnShowQuestion.Click += btnShowQuestion_Click;
            // 
            // btnAddQuestionToExam
            // 
            btnAddQuestionToExam.Location = new Point(496, 39);
            btnAddQuestionToExam.Name = "btnAddQuestionToExam";
            btnAddQuestionToExam.Size = new Size(274, 29);
            btnAddQuestionToExam.TabIndex = 4;
            btnAddQuestionToExam.Text = "Add Question To Exam";
            btnAddQuestionToExam.UseVisualStyleBackColor = true;
            btnAddQuestionToExam.Click += btnAddQuestionToExam_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(496, 80);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 5;
            label2.Text = "Course ID";
            // 
            // txtCourseIdToAdd
            // 
            txtCourseIdToAdd.Location = new Point(496, 117);
            txtCourseIdToAdd.Name = "txtCourseIdToAdd";
            txtCourseIdToAdd.Size = new Size(274, 27);
            txtCourseIdToAdd.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(496, 256);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 5;
            label3.Text = "Question ID";
            // 
            // txtQuestionIdToAdd
            // 
            txtQuestionIdToAdd.Location = new Point(496, 293);
            txtQuestionIdToAdd.Name = "txtQuestionIdToAdd";
            txtQuestionIdToAdd.Size = new Size(274, 27);
            txtQuestionIdToAdd.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(496, 169);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 5;
            label4.Text = "Exam ID";
            // 
            // txtExamIdToAdd
            // 
            txtExamIdToAdd.Location = new Point(496, 206);
            txtExamIdToAdd.Name = "txtExamIdToAdd";
            txtExamIdToAdd.Size = new Size(274, 27);
            txtExamIdToAdd.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(447, 319);
            dataGridView1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(496, 345);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 5;
            label5.Text = "Question Degree";
            // 
            // txtQuestionDegreeToAdd
            // 
            txtQuestionDegreeToAdd.Location = new Point(496, 382);
            txtQuestionDegreeToAdd.Name = "txtQuestionDegreeToAdd";
            txtQuestionDegreeToAdd.Size = new Size(274, 27);
            txtQuestionDegreeToAdd.TabIndex = 6;
            // 
            // AddQuestionToExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtQuestionDegreeToAdd);
            Controls.Add(txtExamIdToAdd);
            Controls.Add(txtQuestionIdToAdd);
            Controls.Add(txtCourseIdToAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAddQuestionToExam);
            Controls.Add(btnShowQuestion);
            Controls.Add(label1);
            Controls.Add(txtCourseIdToSearch);
            Name = "AddQuestionToExamForm";
            Text = "AddQuestionToExamForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCourseIdToSearch;
        private Label label1;
        private Button btnShowQuestion;
        private Button btnAddQuestionToExam;
        private Label label2;
        private TextBox txtCourseIdToAdd;
        private Label label3;
        private TextBox txtQuestionIdToAdd;
        private Label label4;
        private TextBox txtExamIdToAdd;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox txtQuestionDegreeToAdd;
    }
}
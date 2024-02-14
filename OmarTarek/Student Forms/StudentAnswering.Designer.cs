namespace C__Project.OmarTarek.Student_Forms
{
    partial class StudentAnswering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAnswering));
            questionLBL = new Label();
            choice1 = new RadioButton();
            choice2 = new RadioButton();
            choice3 = new RadioButton();
            choice4 = new RadioButton();
            timeLBL = new Label();
            timeLeftLBL = new Label();
            nextQuestionBTN = new Button();
            prevQuestionButton = new Button();
            exitExamBTN = new Button();
            questionBodyTXT = new RichTextBox();
            choice1TXT = new RichTextBox();
            choice2TXT = new RichTextBox();
            choice3TXT = new RichTextBox();
            choice4TXT = new RichTextBox();
            SuspendLayout();
            // 
            // questionLBL
            // 
            questionLBL.AutoSize = true;
            questionLBL.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionLBL.Location = new Point(12, 9);
            questionLBL.Name = "questionLBL";
            questionLBL.Size = new Size(183, 46);
            questionLBL.TabIndex = 0;
            questionLBL.Text = "Question 1";
            // 
            // choice1
            // 
            choice1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            choice1.Location = new Point(12, 224);
            choice1.Name = "choice1";
            choice1.Size = new Size(23, 36);
            choice1.TabIndex = 2;
            choice1.TabStop = true;
            choice1.Text = "Radio 1";
            choice1.UseVisualStyleBackColor = true;
            choice1.CheckedChanged += choice1_CheckedChanged;
            // 
            // choice2
            // 
            choice2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            choice2.Location = new Point(400, 224);
            choice2.Name = "choice2";
            choice2.Size = new Size(23, 36);
            choice2.TabIndex = 3;
            choice2.TabStop = true;
            choice2.Text = "Radio 1";
            choice2.UseVisualStyleBackColor = true;
            choice2.CheckedChanged += choice2_CheckedChanged;
            // 
            // choice3
            // 
            choice3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            choice3.Location = new Point(12, 314);
            choice3.Name = "choice3";
            choice3.Size = new Size(23, 36);
            choice3.TabIndex = 4;
            choice3.TabStop = true;
            choice3.Text = "Radio 1";
            choice3.UseVisualStyleBackColor = true;
            choice3.CheckedChanged += choice3_CheckedChanged;
            // 
            // choice4
            // 
            choice4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            choice4.Location = new Point(400, 314);
            choice4.Name = "choice4";
            choice4.Size = new Size(23, 36);
            choice4.TabIndex = 5;
            choice4.TabStop = true;
            choice4.Text = "Radio 1";
            choice4.UseVisualStyleBackColor = true;
            choice4.CheckedChanged += choice4_CheckedChanged;
            // 
            // timeLBL
            // 
            timeLBL.AutoSize = true;
            timeLBL.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLBL.Location = new Point(615, 20);
            timeLBL.Name = "timeLBL";
            timeLBL.Size = new Size(76, 31);
            timeLBL.TabIndex = 12;
            timeLBL.Text = "label1";
            // 
            // timeLeftLBL
            // 
            timeLeftLBL.AutoSize = true;
            timeLeftLBL.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLeftLBL.Location = new Point(459, 20);
            timeLeftLBL.Name = "timeLeftLBL";
            timeLeftLBL.Size = new Size(119, 31);
            timeLeftLBL.TabIndex = 13;
            timeLeftLBL.Text = "Time Left :";
            // 
            // nextQuestionBTN
            // 
            nextQuestionBTN.Location = new Point(429, 409);
            nextQuestionBTN.Name = "nextQuestionBTN";
            nextQuestionBTN.Size = new Size(335, 29);
            nextQuestionBTN.TabIndex = 14;
            nextQuestionBTN.Text = "Next Question";
            nextQuestionBTN.UseVisualStyleBackColor = true;
            nextQuestionBTN.Click += nextQuestionBTN_Click;
            // 
            // prevQuestionButton
            // 
            prevQuestionButton.Location = new Point(41, 409);
            prevQuestionButton.Name = "prevQuestionButton";
            prevQuestionButton.Size = new Size(335, 29);
            prevQuestionButton.TabIndex = 15;
            prevQuestionButton.Text = "Previous Question";
            prevQuestionButton.UseVisualStyleBackColor = true;
            prevQuestionButton.Click += prevQuestionButton_Click;
            // 
            // exitExamBTN
            // 
            exitExamBTN.Location = new Point(201, 23);
            exitExamBTN.Name = "exitExamBTN";
            exitExamBTN.Size = new Size(252, 29);
            exitExamBTN.TabIndex = 1;
            exitExamBTN.Text = "Exit Exam";
            exitExamBTN.UseVisualStyleBackColor = true;
            exitExamBTN.Click += exitExamBTN_Click;
            // 
            // questionBodyTXT
            // 
            questionBodyTXT.BorderStyle = BorderStyle.None;
            questionBodyTXT.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionBodyTXT.Location = new Point(12, 64);
            questionBodyTXT.Name = "questionBodyTXT";
            questionBodyTXT.ReadOnly = true;
            questionBodyTXT.Size = new Size(776, 154);
            questionBodyTXT.TabIndex = 16;
            questionBodyTXT.Text = resources.GetString("questionBodyTXT.Text");
            // 
            // choice1TXT
            // 
            choice1TXT.BorderStyle = BorderStyle.None;
            choice1TXT.Location = new Point(41, 236);
            choice1TXT.Name = "choice1TXT";
            choice1TXT.ReadOnly = true;
            choice1TXT.Size = new Size(335, 70);
            choice1TXT.TabIndex = 17;
            choice1TXT.Text = resources.GetString("choice1TXT.Text");
            choice1TXT.MouseDown += choice1TXT_MouseDown;
            // 
            // choice2TXT
            // 
            choice2TXT.BorderStyle = BorderStyle.None;
            choice2TXT.Location = new Point(429, 236);
            choice2TXT.Name = "choice2TXT";
            choice2TXT.ReadOnly = true;
            choice2TXT.Size = new Size(335, 70);
            choice2TXT.TabIndex = 18;
            choice2TXT.Text = resources.GetString("choice2TXT.Text");
            choice2TXT.MouseDown += choice2TXT_MouseDown;
            // 
            // choice3TXT
            // 
            choice3TXT.BorderStyle = BorderStyle.None;
            choice3TXT.Location = new Point(41, 326);
            choice3TXT.Name = "choice3TXT";
            choice3TXT.ReadOnly = true;
            choice3TXT.Size = new Size(335, 70);
            choice3TXT.TabIndex = 19;
            choice3TXT.Text = resources.GetString("choice3TXT.Text");
            choice3TXT.MouseDown += choice3TXT_MouseDown;
            // 
            // choice4TXT
            // 
            choice4TXT.BorderStyle = BorderStyle.None;
            choice4TXT.Location = new Point(429, 326);
            choice4TXT.Name = "choice4TXT";
            choice4TXT.ReadOnly = true;
            choice4TXT.Size = new Size(335, 70);
            choice4TXT.TabIndex = 20;
            choice4TXT.Text = resources.GetString("choice4TXT.Text");
            choice4TXT.MouseDown += choice4TXT_MouseDown;
            // 
            // StudentAnswering
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(choice4TXT);
            Controls.Add(choice3TXT);
            Controls.Add(choice2TXT);
            Controls.Add(choice1TXT);
            Controls.Add(questionBodyTXT);
            Controls.Add(exitExamBTN);
            Controls.Add(prevQuestionButton);
            Controls.Add(nextQuestionBTN);
            Controls.Add(timeLeftLBL);
            Controls.Add(timeLBL);
            Controls.Add(choice4);
            Controls.Add(choice3);
            Controls.Add(choice2);
            Controls.Add(choice1);
            Controls.Add(questionLBL);
            Name = "StudentAnswering";
            Text = "StudentAnswering";
            FormClosing += StudentAnswering_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionLBL;
        private RadioButton choice1;
        private RadioButton choice2;
        private RadioButton choice3;
        private RadioButton choice4;
        private Label timeLBL;
        private Label timeLeftLBL;
        private Button nextQuestionBTN;
        private Button prevQuestionButton;
        private Button exitExamBTN;
        private RichTextBox questionBodyTXT;
        private RichTextBox choice1TXT;
        private RichTextBox choice2TXT;
        private RichTextBox choice3TXT;
        private RichTextBox choice4TXT;
    }
}
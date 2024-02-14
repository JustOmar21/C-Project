namespace C__Project
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            coursesBTN = new Button();
            examsBTN = new Button();
            studentsToExamBTN = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "Branches";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(98, 9);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(97, 22);
            button2.TabIndex = 1;
            button2.Text = "Departments";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(200, 9);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(97, 22);
            button3.TabIndex = 2;
            button3.Text = "Tracks";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(10, 52);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 3;
            button4.Text = "Intakes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(98, 52);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(97, 22);
            button5.TabIndex = 4;
            button5.Text = "Classes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(200, 52);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(97, 22);
            button6.TabIndex = 5;
            button6.Text = "Students";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(10, 92);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(287, 20);
            button7.TabIndex = 6;
            button7.Text = "Student Exam";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(10, 128);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(287, 20);
            button8.TabIndex = 7;
            button8.Text = "Login";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(10, 160);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(287, 20);
            button9.TabIndex = 8;
            button9.Text = "Student Profile";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(10, 191);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(287, 20);
            button10.TabIndex = 9;
            button10.Text = "Student Classes";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // coursesBTN
            // 
            coursesBTN.Location = new Point(303, 9);
            coursesBTN.Name = "coursesBTN";
            coursesBTN.Size = new Size(97, 22);
            coursesBTN.TabIndex = 10;
            coursesBTN.Text = "Courses";
            coursesBTN.UseVisualStyleBackColor = true;
            coursesBTN.Click += coursesBTN_Click;
            // 
            // examsBTN
            // 
            examsBTN.Location = new Point(303, 52);
            examsBTN.Name = "examsBTN";
            examsBTN.Size = new Size(97, 22);
            examsBTN.TabIndex = 11;
            examsBTN.Text = "Exams";
            examsBTN.UseVisualStyleBackColor = true;
            examsBTN.Click += examsBTN_Click;
            // 
            // studentsToExamBTN
            // 
            studentsToExamBTN.Location = new Point(303, 90);
            studentsToExamBTN.Name = "studentsToExamBTN";
            studentsToExamBTN.Size = new Size(148, 22);
            studentsToExamBTN.TabIndex = 12;
            studentsToExamBTN.Text = "Students To Exam";
            studentsToExamBTN.UseVisualStyleBackColor = true;
            studentsToExamBTN.Click += studentsToExamBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(studentsToExamBTN);
            Controls.Add(examsBTN);
            Controls.Add(coursesBTN);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button coursesBTN;
        private Button examsBTN;
        private Button studentsToExamBTN;
    }
}

namespace C__Project.OmarTarek.Admin_Forms
{
    partial class AdminProfile
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
            mgrBTN = new Button();
            instructorsBTN = new Button();
            returnBTN = new Button();
            coursesBTN = new Button();
            studentBTN = new Button();
            classesBTN = new Button();
            intakeBTN = new Button();
            trackBTN = new Button();
            deptBTN = new Button();
            branchBTN = new Button();
            assignClassBTN = new Button();
            SuspendLayout();
            // 
            // mgrBTN
            // 
            mgrBTN.Location = new Point(427, 223);
            mgrBTN.Name = "mgrBTN";
            mgrBTN.Size = new Size(361, 29);
            mgrBTN.TabIndex = 42;
            mgrBTN.Text = "Managers";
            mgrBTN.UseVisualStyleBackColor = true;
            mgrBTN.Click += mgrBTN_Click;
            // 
            // instructorsBTN
            // 
            instructorsBTN.Location = new Point(12, 170);
            instructorsBTN.Name = "instructorsBTN";
            instructorsBTN.Size = new Size(409, 29);
            instructorsBTN.TabIndex = 41;
            instructorsBTN.Text = "Instructors";
            instructorsBTN.UseVisualStyleBackColor = true;
            instructorsBTN.Click += instructorsBTN_Click;
            // 
            // returnBTN
            // 
            returnBTN.Location = new Point(12, 415);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(776, 29);
            returnBTN.TabIndex = 40;
            returnBTN.Text = "Logout";
            returnBTN.UseVisualStyleBackColor = true;
            returnBTN.Click += returnBTN_Click;
            // 
            // coursesBTN
            // 
            coursesBTN.Location = new Point(12, 54);
            coursesBTN.Margin = new Padding(3, 4, 3, 4);
            coursesBTN.Name = "coursesBTN";
            coursesBTN.Size = new Size(409, 29);
            coursesBTN.TabIndex = 39;
            coursesBTN.Text = "Courses";
            coursesBTN.UseVisualStyleBackColor = true;
            coursesBTN.Click += coursesBTN_Click;
            // 
            // studentBTN
            // 
            studentBTN.Location = new Point(427, 108);
            studentBTN.Name = "studentBTN";
            studentBTN.Size = new Size(361, 29);
            studentBTN.TabIndex = 38;
            studentBTN.Text = "Students";
            studentBTN.UseVisualStyleBackColor = true;
            studentBTN.Click += studentBTN_Click;
            // 
            // classesBTN
            // 
            classesBTN.Location = new Point(427, 170);
            classesBTN.Name = "classesBTN";
            classesBTN.Size = new Size(361, 29);
            classesBTN.TabIndex = 37;
            classesBTN.Text = "Classes";
            classesBTN.UseVisualStyleBackColor = true;
            classesBTN.Click += classesBTN_Click;
            // 
            // intakeBTN
            // 
            intakeBTN.Location = new Point(12, 108);
            intakeBTN.Name = "intakeBTN";
            intakeBTN.Size = new Size(409, 29);
            intakeBTN.TabIndex = 36;
            intakeBTN.Text = "Intakes";
            intakeBTN.UseVisualStyleBackColor = true;
            intakeBTN.Click += intakeBTN_Click;
            // 
            // trackBTN
            // 
            trackBTN.Location = new Point(427, 53);
            trackBTN.Name = "trackBTN";
            trackBTN.Size = new Size(361, 29);
            trackBTN.TabIndex = 35;
            trackBTN.Text = "Tracks";
            trackBTN.UseVisualStyleBackColor = true;
            trackBTN.Click += trackBTN_Click;
            // 
            // deptBTN
            // 
            deptBTN.Location = new Point(12, 6);
            deptBTN.Name = "deptBTN";
            deptBTN.Size = new Size(409, 29);
            deptBTN.TabIndex = 34;
            deptBTN.Text = "Departments";
            deptBTN.UseVisualStyleBackColor = true;
            deptBTN.Click += deptBTN_Click;
            // 
            // branchBTN
            // 
            branchBTN.Location = new Point(427, 6);
            branchBTN.Name = "branchBTN";
            branchBTN.Size = new Size(361, 29);
            branchBTN.TabIndex = 33;
            branchBTN.Text = "Branches";
            branchBTN.UseVisualStyleBackColor = true;
            branchBTN.Click += branchBTN_Click;
            // 
            // assignClassBTN
            // 
            assignClassBTN.Location = new Point(12, 223);
            assignClassBTN.Name = "assignClassBTN";
            assignClassBTN.Size = new Size(409, 29);
            assignClassBTN.TabIndex = 43;
            assignClassBTN.Text = "Assign Classes and Courses";
            assignClassBTN.UseVisualStyleBackColor = true;
            // 
            // AdminProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(assignClassBTN);
            Controls.Add(mgrBTN);
            Controls.Add(instructorsBTN);
            Controls.Add(returnBTN);
            Controls.Add(coursesBTN);
            Controls.Add(studentBTN);
            Controls.Add(classesBTN);
            Controls.Add(intakeBTN);
            Controls.Add(trackBTN);
            Controls.Add(deptBTN);
            Controls.Add(branchBTN);
            Name = "AdminProfile";
            Text = "Dashboard";
            FormClosing += ManagerProfile_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button mgrBTN;
        private Button instructorsBTN;
        private Button returnBTN;
        private Button coursesBTN;
        private Button studentBTN;
        private Button classesBTN;
        private Button intakeBTN;
        private Button trackBTN;
        private Button deptBTN;
        private Button branchBTN;
        private Button assignClassBTN;
    }
}
namespace C__Project.OmarTarek.Student_Forms
{
    partial class StudentProfile
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
            idLBL = new Label();
            IDTXT = new Label();
            nameTXT = new Label();
            nameLBL = new Label();
            emailTXT = new Label();
            emailLBL = new Label();
            dobTXT = new Label();
            dobLBL = new Label();
            intakeTXT = new Label();
            intakeLBL = new Label();
            trackTXT = new Label();
            trackLBL = new Label();
            classTXT = new Label();
            classLBL = new Label();
            returnBTN = new Button();
            classesBTN = new Button();
            examsBTN = new Button();
            changePassBTN = new Button();
            SuspendLayout();
            // 
            // idLBL
            // 
            idLBL.AutoSize = true;
            idLBL.Location = new Point(12, 71);
            idLBL.Name = "idLBL";
            idLBL.Size = new Size(59, 20);
            idLBL.TabIndex = 0;
            idLBL.Text = "ID       : ";
            // 
            // IDTXT
            // 
            IDTXT.AutoSize = true;
            IDTXT.Location = new Point(74, 71);
            IDTXT.Name = "IDTXT";
            IDTXT.Size = new Size(50, 20);
            IDTXT.TabIndex = 1;
            IDTXT.Text = "label1";
            // 
            // nameTXT
            // 
            nameTXT.AutoSize = true;
            nameTXT.Location = new Point(74, 129);
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(50, 20);
            nameTXT.TabIndex = 3;
            nameTXT.Text = "label1";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(12, 129);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(56, 20);
            nameLBL.TabIndex = 2;
            nameLBL.Text = "Name :";
            // 
            // emailTXT
            // 
            emailTXT.AutoSize = true;
            emailTXT.Location = new Point(74, 187);
            emailTXT.Name = "emailTXT";
            emailTXT.Size = new Size(50, 20);
            emailTXT.TabIndex = 5;
            emailTXT.Text = "label1";
            // 
            // emailLBL
            // 
            emailLBL.AutoSize = true;
            emailLBL.Location = new Point(12, 187);
            emailLBL.Name = "emailLBL";
            emailLBL.Size = new Size(53, 20);
            emailLBL.TabIndex = 4;
            emailLBL.Text = "Email :";
            // 
            // dobTXT
            // 
            dobTXT.AutoSize = true;
            dobTXT.Location = new Point(74, 241);
            dobTXT.Name = "dobTXT";
            dobTXT.Size = new Size(50, 20);
            dobTXT.TabIndex = 7;
            dobTXT.Text = "label1";
            // 
            // dobLBL
            // 
            dobLBL.AutoSize = true;
            dobLBL.Location = new Point(12, 241);
            dobLBL.Name = "dobLBL";
            dobLBL.Size = new Size(51, 20);
            dobLBL.TabIndex = 6;
            dobLBL.Text = "DOB  :";
            // 
            // intakeTXT
            // 
            intakeTXT.AutoSize = true;
            intakeTXT.Location = new Point(74, 298);
            intakeTXT.Name = "intakeTXT";
            intakeTXT.Size = new Size(50, 20);
            intakeTXT.TabIndex = 9;
            intakeTXT.Text = "label1";
            // 
            // intakeLBL
            // 
            intakeLBL.AutoSize = true;
            intakeLBL.Location = new Point(12, 298);
            intakeLBL.Name = "intakeLBL";
            intakeLBL.Size = new Size(52, 20);
            intakeLBL.TabIndex = 8;
            intakeLBL.Text = "Intake:";
            // 
            // trackTXT
            // 
            trackTXT.AutoSize = true;
            trackTXT.Location = new Point(74, 349);
            trackTXT.Name = "trackTXT";
            trackTXT.Size = new Size(50, 20);
            trackTXT.TabIndex = 11;
            trackTXT.Text = "label1";
            // 
            // trackLBL
            // 
            trackLBL.AutoSize = true;
            trackLBL.Location = new Point(12, 349);
            trackLBL.Name = "trackLBL";
            trackLBL.Size = new Size(50, 20);
            trackLBL.TabIndex = 10;
            trackLBL.Text = "Track :";
            // 
            // classTXT
            // 
            classTXT.AutoSize = true;
            classTXT.Location = new Point(74, 397);
            classTXT.Name = "classTXT";
            classTXT.Size = new Size(50, 20);
            classTXT.TabIndex = 13;
            classTXT.Text = "label1";
            // 
            // classLBL
            // 
            classLBL.AutoSize = true;
            classLBL.Location = new Point(12, 397);
            classLBL.Name = "classLBL";
            classLBL.Size = new Size(49, 20);
            classLBL.TabIndex = 12;
            classLBL.Text = "Class :";
            // 
            // returnBTN
            // 
            returnBTN.Location = new Point(12, 12);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(776, 29);
            returnBTN.TabIndex = 14;
            returnBTN.Text = "Logout";
            returnBTN.UseVisualStyleBackColor = true;
            returnBTN.Click += returnBTN_Click;
            // 
            // classesBTN
            // 
            classesBTN.Location = new Point(677, 67);
            classesBTN.Name = "classesBTN";
            classesBTN.Size = new Size(111, 29);
            classesBTN.TabIndex = 17;
            classesBTN.Text = "Classes";
            classesBTN.UseVisualStyleBackColor = true;
            classesBTN.Click += classesBTN_Click;
            // 
            // examsBTN
            // 
            examsBTN.Location = new Point(677, 120);
            examsBTN.Margin = new Padding(3, 4, 3, 4);
            examsBTN.Name = "examsBTN";
            examsBTN.Size = new Size(111, 29);
            examsBTN.TabIndex = 18;
            examsBTN.Text = "Exams";
            examsBTN.UseVisualStyleBackColor = true;
            examsBTN.Click += examsBTN_Click;
            // 
            // changePassBTN
            // 
            changePassBTN.Location = new Point(614, 408);
            changePassBTN.Margin = new Padding(3, 4, 3, 4);
            changePassBTN.Name = "changePassBTN";
            changePassBTN.Size = new Size(174, 29);
            changePassBTN.TabIndex = 19;
            changePassBTN.Text = "Change Password";
            changePassBTN.UseVisualStyleBackColor = true;
            changePassBTN.Click += changePassBTN_Click;
            // 
            // StudentProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(changePassBTN);
            Controls.Add(examsBTN);
            Controls.Add(classesBTN);
            Controls.Add(returnBTN);
            Controls.Add(classTXT);
            Controls.Add(classLBL);
            Controls.Add(trackTXT);
            Controls.Add(trackLBL);
            Controls.Add(intakeTXT);
            Controls.Add(intakeLBL);
            Controls.Add(dobTXT);
            Controls.Add(dobLBL);
            Controls.Add(emailTXT);
            Controls.Add(emailLBL);
            Controls.Add(nameTXT);
            Controls.Add(nameLBL);
            Controls.Add(IDTXT);
            Controls.Add(idLBL);
            Name = "StudentProfile";
            Text = "StudentProfile";
            FormClosing += StudentProfile_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLBL;
        private Label IDTXT;
        private Label nameTXT;
        private Label nameLBL;
        private Label emailTXT;
        private Label emailLBL;
        private Label dobTXT;
        private Label dobLBL;
        private Label intakeTXT;
        private Label intakeLBL;
        private Label trackTXT;
        private Label trackLBL;
        private Label classTXT;
        private Label classLBL;
        private Button returnBTN;
        private Button classesBTN;
        private Button examsBTN;
        private Button changePassBTN;
    }
}
namespace C__Project.FaresAwad
{
    partial class AddQuestionForm
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
            btnSave = new Button();
            txtCourseId = new TextBox();
            txtBody = new TextBox();
            txtType = new TextBox();
            txtCorrectChoiceNumber = new TextBox();
            txtChoiceNumber1 = new TextBox();
            txtChoiceNumber2 = new TextBox();
            txtChoiceNumber3 = new TextBox();
            txtChoiceNumber4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(134, 373);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(595, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Add the new question";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtCourseId
            // 
            txtCourseId.Location = new Point(341, 38);
            txtCourseId.Name = "txtCourseId";
            txtCourseId.Size = new Size(388, 27);
            txtCourseId.TabIndex = 1;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(341, 96);
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(388, 27);
            txtBody.TabIndex = 1;
            // 
            // txtType
            // 
            txtType.Location = new Point(341, 147);
            txtType.Name = "txtType";
            txtType.Size = new Size(388, 27);
            txtType.TabIndex = 1;
            // 
            // txtCorrectChoiceNumber
            // 
            txtCorrectChoiceNumber.Location = new Point(341, 203);
            txtCorrectChoiceNumber.Name = "txtCorrectChoiceNumber";
            txtCorrectChoiceNumber.Size = new Size(388, 27);
            txtCorrectChoiceNumber.TabIndex = 1;
            // 
            // txtChoiceNumber1
            // 
            txtChoiceNumber1.Location = new Point(539, 263);
            txtChoiceNumber1.Name = "txtChoiceNumber1";
            txtChoiceNumber1.Size = new Size(190, 27);
            txtChoiceNumber1.TabIndex = 1;
            // 
            // txtChoiceNumber2
            // 
            txtChoiceNumber2.Location = new Point(221, 263);
            txtChoiceNumber2.Name = "txtChoiceNumber2";
            txtChoiceNumber2.Size = new Size(190, 27);
            txtChoiceNumber2.TabIndex = 1;
            // 
            // txtChoiceNumber3
            // 
            txtChoiceNumber3.Location = new Point(539, 314);
            txtChoiceNumber3.Name = "txtChoiceNumber3";
            txtChoiceNumber3.Size = new Size(190, 27);
            txtChoiceNumber3.TabIndex = 1;
            // 
            // txtChoiceNumber4
            // 
            txtChoiceNumber4.Location = new Point(221, 314);
            txtChoiceNumber4.Name = "txtChoiceNumber4";
            txtChoiceNumber4.Size = new Size(190, 27);
            txtChoiceNumber4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 321);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 2;
            label1.Text = "Choice 4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 321);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Choice 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 270);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Choice 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 270);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 2;
            label4.Text = "Choice 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 210);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 2;
            label5.Text = "Correct Choice Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(134, 154);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 2;
            label6.Text = "Question Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(134, 103);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 2;
            label7.Text = "Question Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(134, 45);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 2;
            label8.Text = "Course ID";
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtChoiceNumber4);
            Controls.Add(txtChoiceNumber3);
            Controls.Add(txtChoiceNumber2);
            Controls.Add(txtChoiceNumber1);
            Controls.Add(txtCorrectChoiceNumber);
            Controls.Add(txtType);
            Controls.Add(txtBody);
            Controls.Add(txtCourseId);
            Controls.Add(btnSave);
            Name = "AddQuestionForm";
            Text = "AddQuestionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtCourseId;
        private TextBox txtBody;
        private TextBox txtType;
        private TextBox txtCorrectChoiceNumber;
        private TextBox txtChoiceNumber1;
        private TextBox txtChoiceNumber2;
        private TextBox txtChoiceNumber3;
        private TextBox txtChoiceNumber4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
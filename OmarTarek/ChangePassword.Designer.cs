namespace C__Project.OmarTarek
{
    partial class ChangePassword
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
            oldPassTXT = new TextBox();
            newPassTXT = new TextBox();
            newPassAgainTXT = new TextBox();
            changeBTN = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            oldPassValiLBL = new Label();
            newPassValiLBL = new Label();
            confirmPassLBL = new Label();
            returnBTN = new Button();
            SuspendLayout();
            // 
            // oldPassTXT
            // 
            oldPassTXT.Location = new Point(12, 125);
            oldPassTXT.Name = "oldPassTXT";
            oldPassTXT.PasswordChar = '*';
            oldPassTXT.Size = new Size(776, 27);
            oldPassTXT.TabIndex = 0;
            oldPassTXT.TextChanged += oldPassTXT_TextChanged;
            // 
            // newPassTXT
            // 
            newPassTXT.Location = new Point(12, 204);
            newPassTXT.Name = "newPassTXT";
            newPassTXT.PasswordChar = '*';
            newPassTXT.Size = new Size(776, 27);
            newPassTXT.TabIndex = 1;
            newPassTXT.TextChanged += newPassTXT_TextChanged;
            // 
            // newPassAgainTXT
            // 
            newPassAgainTXT.Location = new Point(12, 288);
            newPassAgainTXT.Name = "newPassAgainTXT";
            newPassAgainTXT.PasswordChar = '*';
            newPassAgainTXT.Size = new Size(776, 27);
            newPassAgainTXT.TabIndex = 2;
            newPassAgainTXT.TextChanged += newPassAgainTXT_TextChanged;
            // 
            // changeBTN
            // 
            changeBTN.Enabled = false;
            changeBTN.Location = new Point(12, 372);
            changeBTN.Name = "changeBTN";
            changeBTN.Size = new Size(776, 29);
            changeBTN.TabIndex = 3;
            changeBTN.Text = "Change Password";
            changeBTN.UseVisualStyleBackColor = true;
            changeBTN.Click += changeBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 102);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "Old Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 181);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 265);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 6;
            label3.Text = "Confirm New Password";
            // 
            // oldPassValiLBL
            // 
            oldPassValiLBL.AutoSize = true;
            oldPassValiLBL.ForeColor = Color.Red;
            oldPassValiLBL.Location = new Point(0, 155);
            oldPassValiLBL.Name = "oldPassValiLBL";
            oldPassValiLBL.Size = new Size(804, 20);
            oldPassValiLBL.TabIndex = 7;
            oldPassValiLBL.Text = "Password must be at least 8 characters and  at least contains one uppercase letter , one lowercase letter and one number";
            oldPassValiLBL.Visible = false;
            // 
            // newPassValiLBL
            // 
            newPassValiLBL.AutoSize = true;
            newPassValiLBL.ForeColor = Color.Red;
            newPassValiLBL.Location = new Point(0, 234);
            newPassValiLBL.Name = "newPassValiLBL";
            newPassValiLBL.Size = new Size(804, 20);
            newPassValiLBL.TabIndex = 8;
            newPassValiLBL.Text = "Password must be at least 8 characters and  at least contains one uppercase letter , one lowercase letter and one number";
            newPassValiLBL.Visible = false;
            // 
            // confirmPassLBL
            // 
            confirmPassLBL.AutoSize = true;
            confirmPassLBL.ForeColor = Color.Red;
            confirmPassLBL.Location = new Point(0, 318);
            confirmPassLBL.Name = "confirmPassLBL";
            confirmPassLBL.Size = new Size(275, 20);
            confirmPassLBL.TabIndex = 9;
            confirmPassLBL.Text = "New Password and this are not the same";
            confirmPassLBL.Visible = false;
            // 
            // returnBTN
            // 
            returnBTN.Location = new Point(12, 12);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(94, 29);
            returnBTN.TabIndex = 10;
            returnBTN.Text = "Return";
            returnBTN.UseVisualStyleBackColor = true;
            returnBTN.Click += returnBTN_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnBTN);
            Controls.Add(confirmPassLBL);
            Controls.Add(newPassValiLBL);
            Controls.Add(oldPassValiLBL);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(changeBTN);
            Controls.Add(newPassAgainTXT);
            Controls.Add(newPassTXT);
            Controls.Add(oldPassTXT);
            Name = "ChangePassword";
            Text = "ChangePassword";
            FormClosing += ChangePassword_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox oldPassTXT;
        private TextBox newPassTXT;
        private TextBox newPassAgainTXT;
        private Button changeBTN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label oldPassValiLBL;
        private Label newPassValiLBL;
        private Label confirmPassLBL;
        private Button returnBTN;
    }
}
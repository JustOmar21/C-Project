namespace C__Project.OmarTarek.Manager_Forms
{
    partial class AddManager
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
            salaryValiLBL = new Label();
            salaryLBL = new Label();
            salaryTXT = new TextBox();
            titleValiLBL = new Label();
            titleLBL = new Label();
            titleTXT = new TextBox();
            printBTN = new Button();
            dobLBL = new Label();
            dobDP = new DateTimePicker();
            emailValiLBL = new Label();
            emailLBL = new Label();
            emailTXT = new TextBox();
            returnButton = new Button();
            updateBTN = new Button();
            exitModiBTN = new Button();
            deleteBTN = new Button();
            SearchTXT = new TextBox();
            nameValiLBL = new Label();
            idTXT = new TextBox();
            addBTN = new Button();
            nameLBL = new Label();
            nameTXT = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // salaryValiLBL
            // 
            salaryValiLBL.AutoSize = true;
            salaryValiLBL.ForeColor = Color.Red;
            salaryValiLBL.Location = new Point(477, 363);
            salaryValiLBL.Name = "salaryValiLBL";
            salaryValiLBL.Size = new Size(226, 20);
            salaryValiLBL.TabIndex = 78;
            salaryValiLBL.Text = "Numbers Only, at minimum 4000";
            salaryValiLBL.Visible = false;
            // 
            // salaryLBL
            // 
            salaryLBL.AutoSize = true;
            salaryLBL.Location = new Point(478, 310);
            salaryLBL.Name = "salaryLBL";
            salaryLBL.Size = new Size(49, 20);
            salaryLBL.TabIndex = 77;
            salaryLBL.Text = "Salary";
            // 
            // salaryTXT
            // 
            salaryTXT.Location = new Point(478, 333);
            salaryTXT.MaxLength = 50;
            salaryTXT.Name = "salaryTXT";
            salaryTXT.Size = new Size(315, 27);
            salaryTXT.TabIndex = 76;
            salaryTXT.TextChanged += salaryTXT_TextChanged;
            // 
            // titleValiLBL
            // 
            titleValiLBL.AutoSize = true;
            titleValiLBL.ForeColor = Color.Red;
            titleValiLBL.Location = new Point(477, 278);
            titleValiLBL.Name = "titleValiLBL";
            titleValiLBL.Size = new Size(290, 20);
            titleValiLBL.TabIndex = 75;
            titleValiLBL.Text = "3 - 50 Characters, letters and numbers only";
            titleValiLBL.Visible = false;
            // 
            // titleLBL
            // 
            titleLBL.AutoSize = true;
            titleLBL.Location = new Point(478, 225);
            titleLBL.Name = "titleLBL";
            titleLBL.Size = new Size(38, 20);
            titleLBL.TabIndex = 74;
            titleLBL.Text = "Title";
            // 
            // titleTXT
            // 
            titleTXT.Location = new Point(478, 248);
            titleTXT.MaxLength = 50;
            titleTXT.Name = "titleTXT";
            titleTXT.Size = new Size(315, 27);
            titleTXT.TabIndex = 73;
            titleTXT.TextChanged += titleTXT_TextChanged;
            // 
            // printBTN
            // 
            printBTN.Location = new Point(226, 13);
            printBTN.Name = "printBTN";
            printBTN.Size = new Size(245, 29);
            printBTN.TabIndex = 72;
            printBTN.Text = "Print";
            printBTN.UseVisualStyleBackColor = true;
            printBTN.Click += printBTN_Click;
            // 
            // dobLBL
            // 
            dobLBL.AutoSize = true;
            dobLBL.Location = new Point(475, 162);
            dobLBL.Name = "dobLBL";
            dobLBL.Size = new Size(94, 20);
            dobLBL.TabIndex = 71;
            dobLBL.Text = "Date of Birth";
            // 
            // dobDP
            // 
            dobDP.Location = new Point(477, 185);
            dobDP.Name = "dobDP";
            dobDP.Size = new Size(314, 27);
            dobDP.TabIndex = 70;
            // 
            // emailValiLBL
            // 
            emailValiLBL.AutoSize = true;
            emailValiLBL.ForeColor = Color.Red;
            emailValiLBL.Location = new Point(477, 139);
            emailValiLBL.Name = "emailValiLBL";
            emailValiLBL.Size = new Size(132, 20);
            emailValiLBL.TabIndex = 69;
            emailValiLBL.Text = "Enter a valid email";
            emailValiLBL.Visible = false;
            // 
            // emailLBL
            // 
            emailLBL.AutoSize = true;
            emailLBL.Location = new Point(478, 86);
            emailLBL.Name = "emailLBL";
            emailLBL.Size = new Size(46, 20);
            emailLBL.TabIndex = 68;
            emailLBL.Text = "Email";
            // 
            // emailTXT
            // 
            emailTXT.Location = new Point(478, 109);
            emailTXT.MaxLength = 50;
            emailTXT.Name = "emailTXT";
            emailTXT.Size = new Size(315, 27);
            emailTXT.TabIndex = 67;
            emailTXT.TextChanged += emailTXT_TextChanged;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(5, 13);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(215, 29);
            returnButton.TabIndex = 63;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(572, 417);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(74, 29);
            updateBTN.TabIndex = 58;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Visible = false;
            updateBTN.Click += updateBTN_Click;
            // 
            // exitModiBTN
            // 
            exitModiBTN.Location = new Point(652, 417);
            exitModiBTN.Name = "exitModiBTN";
            exitModiBTN.Size = new Size(144, 29);
            exitModiBTN.TabIndex = 61;
            exitModiBTN.Text = "Exit Modification";
            exitModiBTN.UseVisualStyleBackColor = true;
            exitModiBTN.Visible = false;
            exitModiBTN.Click += exitModiBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(476, 417);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(90, 29);
            deleteBTN.TabIndex = 60;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Visible = false;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // SearchTXT
            // 
            SearchTXT.Location = new Point(5, 48);
            SearchTXT.Name = "SearchTXT";
            SearchTXT.PlaceholderText = "Search by name";
            SearchTXT.Size = new Size(466, 27);
            SearchTXT.TabIndex = 66;
            SearchTXT.TextChanged += SearchTXT_TextChanged;
            // 
            // nameValiLBL
            // 
            nameValiLBL.AutoSize = true;
            nameValiLBL.ForeColor = Color.Red;
            nameValiLBL.Location = new Point(476, 58);
            nameValiLBL.Name = "nameValiLBL";
            nameValiLBL.Size = new Size(290, 20);
            nameValiLBL.TabIndex = 65;
            nameValiLBL.Text = "3- 50 Characters , letters and numbers only";
            nameValiLBL.Visible = false;
            // 
            // idTXT
            // 
            idTXT.Location = new Point(5, 417);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(315, 27);
            idTXT.TabIndex = 64;
            idTXT.Visible = false;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(478, 416);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(318, 29);
            addBTN.TabIndex = 62;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(477, 5);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(49, 20);
            nameLBL.TabIndex = 59;
            nameLBL.Text = "Name";
            // 
            // nameTXT
            // 
            nameTXT.Location = new Point(477, 28);
            nameTXT.MaxLength = 50;
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(315, 27);
            nameTXT.TabIndex = 57;
            nameTXT.TextChanged += nameTXT_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(466, 364);
            dataGridView1.TabIndex = 56;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // AddManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(salaryValiLBL);
            Controls.Add(salaryLBL);
            Controls.Add(salaryTXT);
            Controls.Add(titleValiLBL);
            Controls.Add(titleLBL);
            Controls.Add(titleTXT);
            Controls.Add(printBTN);
            Controls.Add(dobLBL);
            Controls.Add(dobDP);
            Controls.Add(emailValiLBL);
            Controls.Add(emailLBL);
            Controls.Add(emailTXT);
            Controls.Add(returnButton);
            Controls.Add(updateBTN);
            Controls.Add(exitModiBTN);
            Controls.Add(deleteBTN);
            Controls.Add(SearchTXT);
            Controls.Add(nameValiLBL);
            Controls.Add(idTXT);
            Controls.Add(addBTN);
            Controls.Add(nameLBL);
            Controls.Add(nameTXT);
            Controls.Add(dataGridView1);
            Name = "AddManager";
            Text = "Add Manager";
            FormClosing += AddManager_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label salaryValiLBL;
        private Label salaryLBL;
        private TextBox salaryTXT;
        private Label titleValiLBL;
        private Label titleLBL;
        private TextBox titleTXT;
        private Button printBTN;
        private Label dobLBL;
        private DateTimePicker dobDP;
        private Label emailValiLBL;
        private Label emailLBL;
        private TextBox emailTXT;
        private Button returnButton;
        private Button updateBTN;
        private Button exitModiBTN;
        private Button deleteBTN;
        private TextBox SearchTXT;
        private Label nameValiLBL;
        private TextBox idTXT;
        private Button addBTN;
        private Label nameLBL;
        private TextBox nameTXT;
        private DataGridView dataGridView1;
    }
}
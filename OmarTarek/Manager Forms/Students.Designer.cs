namespace C__Project.OmarTarek
{
    partial class Students
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
            trackCB = new ComboBox();
            returnButton = new Button();
            updateBTN = new Button();
            exitModiBTN = new Button();
            deleteBTN = new Button();
            SearchTXT = new TextBox();
            nameValiLBL = new Label();
            idTXT = new TextBox();
            addBTN = new Button();
            trackLBL = new Label();
            nameLBL = new Label();
            nameTXT = new TextBox();
            dataGridView1 = new DataGridView();
            emailValiLBL = new Label();
            emailLBL = new Label();
            emailTXT = new TextBox();
            dobDP = new DateTimePicker();
            dobLBL = new Label();
            intakeCB = new ComboBox();
            intakeLBL = new Label();
            classCB = new ComboBox();
            classLBL = new Label();
            intakeNullBTN = new Button();
            trackNullBTN = new Button();
            classNullBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // trackCB
            // 
            trackCB.FormattingEnabled = true;
            trackCB.Location = new Point(477, 304);
            trackCB.Name = "trackCB";
            trackCB.Size = new Size(218, 28);
            trackCB.TabIndex = 26;
            trackCB.SelectedIndexChanged += trackCB_SelectedIndexChanged;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(6, 9);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(466, 29);
            returnButton.TabIndex = 33;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(573, 413);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(74, 29);
            updateBTN.TabIndex = 27;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Visible = false;
            updateBTN.Click += updateBTN_Click;
            // 
            // exitModiBTN
            // 
            exitModiBTN.Location = new Point(653, 413);
            exitModiBTN.Name = "exitModiBTN";
            exitModiBTN.Size = new Size(144, 29);
            exitModiBTN.TabIndex = 31;
            exitModiBTN.Text = "Exit Modification";
            exitModiBTN.UseVisualStyleBackColor = true;
            exitModiBTN.Visible = false;
            exitModiBTN.Click += exitModiBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(477, 413);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(90, 29);
            deleteBTN.TabIndex = 29;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Visible = false;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // SearchTXT
            // 
            SearchTXT.Location = new Point(6, 44);
            SearchTXT.Name = "SearchTXT";
            SearchTXT.PlaceholderText = "Search by name";
            SearchTXT.Size = new Size(466, 27);
            SearchTXT.TabIndex = 36;
            SearchTXT.TextChanged += SearchTXT_TextChanged;
            // 
            // nameValiLBL
            // 
            nameValiLBL.AutoSize = true;
            nameValiLBL.ForeColor = Color.Red;
            nameValiLBL.Location = new Point(477, 54);
            nameValiLBL.Name = "nameValiLBL";
            nameValiLBL.Size = new Size(290, 20);
            nameValiLBL.TabIndex = 35;
            nameValiLBL.Text = "3- 50 Characters , letters and numbers only";
            nameValiLBL.Visible = false;
            // 
            // idTXT
            // 
            idTXT.Location = new Point(6, 413);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(315, 27);
            idTXT.TabIndex = 34;
            idTXT.Visible = false;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(479, 412);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(318, 29);
            addBTN.TabIndex = 32;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // trackLBL
            // 
            trackLBL.AutoSize = true;
            trackLBL.Location = new Point(476, 281);
            trackLBL.Name = "trackLBL";
            trackLBL.Size = new Size(43, 20);
            trackLBL.TabIndex = 30;
            trackLBL.Text = "Track";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(478, 1);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(49, 20);
            nameLBL.TabIndex = 28;
            nameLBL.Text = "Name";
            // 
            // nameTXT
            // 
            nameTXT.Location = new Point(478, 24);
            nameTXT.MaxLength = 50;
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(315, 27);
            nameTXT.TabIndex = 25;
            nameTXT.TextChanged += nameTXT_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(466, 364);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // emailValiLBL
            // 
            emailValiLBL.AutoSize = true;
            emailValiLBL.ForeColor = Color.Red;
            emailValiLBL.Location = new Point(478, 135);
            emailValiLBL.Name = "emailValiLBL";
            emailValiLBL.Size = new Size(132, 20);
            emailValiLBL.TabIndex = 39;
            emailValiLBL.Text = "Enter a valid email";
            emailValiLBL.Visible = false;
            // 
            // emailLBL
            // 
            emailLBL.AutoSize = true;
            emailLBL.Location = new Point(479, 82);
            emailLBL.Name = "emailLBL";
            emailLBL.Size = new Size(46, 20);
            emailLBL.TabIndex = 38;
            emailLBL.Text = "Email";
            // 
            // emailTXT
            // 
            emailTXT.Location = new Point(479, 105);
            emailTXT.MaxLength = 50;
            emailTXT.Name = "emailTXT";
            emailTXT.Size = new Size(315, 27);
            emailTXT.TabIndex = 37;
            emailTXT.TextChanged += emailTXT_TextChanged;
            // 
            // dobDP
            // 
            dobDP.Location = new Point(477, 181);
            dobDP.Name = "dobDP";
            dobDP.Size = new Size(315, 27);
            dobDP.TabIndex = 40;
            // 
            // dobLBL
            // 
            dobLBL.AutoSize = true;
            dobLBL.Location = new Point(476, 158);
            dobLBL.Name = "dobLBL";
            dobLBL.Size = new Size(94, 20);
            dobLBL.TabIndex = 41;
            dobLBL.Text = "Date of Birth";
            // 
            // intakeCB
            // 
            intakeCB.FormattingEnabled = true;
            intakeCB.Location = new Point(477, 245);
            intakeCB.Name = "intakeCB";
            intakeCB.Size = new Size(218, 28);
            intakeCB.TabIndex = 42;
            // 
            // intakeLBL
            // 
            intakeLBL.AutoSize = true;
            intakeLBL.Location = new Point(476, 222);
            intakeLBL.Name = "intakeLBL";
            intakeLBL.Size = new Size(49, 20);
            intakeLBL.TabIndex = 43;
            intakeLBL.Text = "Intake";
            // 
            // classCB
            // 
            classCB.FormattingEnabled = true;
            classCB.Location = new Point(478, 361);
            classCB.Name = "classCB";
            classCB.Size = new Size(217, 28);
            classCB.TabIndex = 44;
            // 
            // classLBL
            // 
            classLBL.AutoSize = true;
            classLBL.Location = new Point(477, 338);
            classLBL.Name = "classLBL";
            classLBL.Size = new Size(42, 20);
            classLBL.TabIndex = 45;
            classLBL.Text = "Class";
            // 
            // intakeNullBTN
            // 
            intakeNullBTN.Location = new Point(703, 245);
            intakeNullBTN.Name = "intakeNullBTN";
            intakeNullBTN.Size = new Size(94, 29);
            intakeNullBTN.TabIndex = 46;
            intakeNullBTN.Text = "Set Null";
            intakeNullBTN.UseVisualStyleBackColor = true;
            intakeNullBTN.Click += intakeNullBTN_Click;
            // 
            // trackNullBTN
            // 
            trackNullBTN.Location = new Point(703, 304);
            trackNullBTN.Name = "trackNullBTN";
            trackNullBTN.Size = new Size(94, 29);
            trackNullBTN.TabIndex = 47;
            trackNullBTN.Text = "Set Null";
            trackNullBTN.UseVisualStyleBackColor = true;
            trackNullBTN.Click += trackNullBTN_Click;
            // 
            // classNullBTN
            // 
            classNullBTN.Location = new Point(703, 361);
            classNullBTN.Name = "classNullBTN";
            classNullBTN.Size = new Size(94, 29);
            classNullBTN.TabIndex = 48;
            classNullBTN.Text = "Set Null";
            classNullBTN.UseVisualStyleBackColor = true;
            classNullBTN.Click += classNullBTN_Click;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(classNullBTN);
            Controls.Add(trackNullBTN);
            Controls.Add(intakeNullBTN);
            Controls.Add(classCB);
            Controls.Add(classLBL);
            Controls.Add(intakeCB);
            Controls.Add(intakeLBL);
            Controls.Add(dobLBL);
            Controls.Add(dobDP);
            Controls.Add(emailValiLBL);
            Controls.Add(emailLBL);
            Controls.Add(emailTXT);
            Controls.Add(trackCB);
            Controls.Add(returnButton);
            Controls.Add(updateBTN);
            Controls.Add(exitModiBTN);
            Controls.Add(deleteBTN);
            Controls.Add(SearchTXT);
            Controls.Add(nameValiLBL);
            Controls.Add(idTXT);
            Controls.Add(addBTN);
            Controls.Add(trackLBL);
            Controls.Add(nameLBL);
            Controls.Add(nameTXT);
            Controls.Add(dataGridView1);
            Name = "Students";
            Text = "Students";
            FormClosing += Students_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox trackCB;
        private Button returnButton;
        private Button updateBTN;
        private Button exitModiBTN;
        private Button deleteBTN;
        private TextBox SearchTXT;
        private Label nameValiLBL;
        private TextBox idTXT;
        private Button addBTN;
        private Label trackLBL;
        private Label nameLBL;
        private TextBox nameTXT;
        private DataGridView dataGridView1;
        private Label emailValiLBL;
        private Label emailLBL;
        private TextBox emailTXT;
        private DateTimePicker dobDP;
        private Label dobLBL;
        private ComboBox intakeCB;
        private Label intakeLBL;
        private ComboBox classCB;
        private Label classLBL;
        private Button intakeNullBTN;
        private Button trackNullBTN;
        private Button classNullBTN;
    }
}
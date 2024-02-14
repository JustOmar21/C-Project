namespace C__Project.Khateep
{
    partial class Exams
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
            returnButton = new Button();
            dataGridView1 = new DataGridView();
            nameTXT = new TextBox();
            nameLBL = new Label();
            deptLBL = new Label();
            addBTN = new Button();
            idTXT = new TextBox();
            nameValiLBL = new Label();
            deleteBTN = new Button();
            exitModiBTN = new Button();
            updateBTN = new Button();
            SearchTXT = new TextBox();
            corsCB = new ComboBox();
            endLBL = new Label();
            startLBL = new Label();
            endTimeDP = new DateTimePicker();
            startTimeDP = new DateTimePicker();
            printBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // returnButton
            // 
            returnButton.Location = new Point(14, 19);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(467, 29);
            returnButton.TabIndex = 65;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(467, 364);
            dataGridView1.TabIndex = 66;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // nameTXT
            // 
            nameTXT.Location = new Point(489, 131);
            nameTXT.MaxLength = 50;
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(315, 27);
            nameTXT.TabIndex = 67;
            nameTXT.TextChanged += nameTXT_TextChanged;
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(489, 108);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(49, 20);
            nameLBL.TabIndex = 71;
            nameLBL.Text = "Name";
            nameLBL.Click += nameLBL_Click;
            // 
            // deptLBL
            // 
            deptLBL.AutoSize = true;
            deptLBL.Location = new Point(486, 313);
            deptLBL.Name = "deptLBL";
            deptLBL.Size = new Size(60, 20);
            deptLBL.TabIndex = 73;
            deptLBL.Text = "Courses";
            // 
            // addBTN
            // 
            addBTN.Location = new Point(486, 397);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(315, 29);
            addBTN.TabIndex = 75;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // idTXT
            // 
            idTXT.Location = new Point(76, 54);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(315, 27);
            idTXT.TabIndex = 77;
            idTXT.Visible = false;
            idTXT.TextChanged += idTXT_TextChanged;
            // 
            // nameValiLBL
            // 
            nameValiLBL.AutoSize = true;
            nameValiLBL.ForeColor = Color.Red;
            nameValiLBL.Location = new Point(488, 160);
            nameValiLBL.Name = "nameValiLBL";
            nameValiLBL.Size = new Size(294, 20);
            nameValiLBL.TabIndex = 78;
            nameValiLBL.Text = "3 - 50 Characters , letters and numbers only";
            nameValiLBL.Visible = false;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(485, 432);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(151, 29);
            deleteBTN.TabIndex = 72;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Visible = false;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // exitModiBTN
            // 
            exitModiBTN.Location = new Point(651, 432);
            exitModiBTN.Name = "exitModiBTN";
            exitModiBTN.Size = new Size(151, 29);
            exitModiBTN.TabIndex = 74;
            exitModiBTN.Text = "Exit Modification";
            exitModiBTN.UseVisualStyleBackColor = true;
            exitModiBTN.Visible = false;
            exitModiBTN.Click += exitModiBTN_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(487, 372);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(315, 29);
            updateBTN.TabIndex = 70;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Visible = false;
            updateBTN.Click += updateBTN_Click;
            // 
            // SearchTXT
            // 
            SearchTXT.Location = new Point(14, 80);
            SearchTXT.Name = "SearchTXT";
            SearchTXT.PlaceholderText = "Search by name";
            SearchTXT.Size = new Size(466, 27);
            SearchTXT.TabIndex = 79;
            // 
            // corsCB
            // 
            corsCB.FormattingEnabled = true;
            corsCB.Location = new Point(487, 336);
            corsCB.Name = "corsCB";
            corsCB.Size = new Size(315, 28);
            corsCB.TabIndex = 69;
            // 
            // endLBL
            // 
            endLBL.AutoSize = true;
            endLBL.Location = new Point(489, 259);
            endLBL.Name = "endLBL";
            endLBL.Size = new Size(71, 20);
            endLBL.TabIndex = 83;
            endLBL.Text = "End Time";
            // 
            // startLBL
            // 
            startLBL.AutoSize = true;
            startLBL.Location = new Point(488, 180);
            startLBL.Name = "startLBL";
            startLBL.Size = new Size(77, 20);
            startLBL.TabIndex = 82;
            startLBL.Text = "Start Time";
            // 
            // endTimeDP
            // 
            endTimeDP.CustomFormat = "yyyy/MM/dd hh:mm tt";
            endTimeDP.Format = DateTimePickerFormat.Custom;
            endTimeDP.Location = new Point(489, 281);
            endTimeDP.Name = "endTimeDP";
            endTimeDP.Size = new Size(314, 27);
            endTimeDP.TabIndex = 81;
            endTimeDP.ValueChanged += endTimeDP_ValueChanged;
            // 
            // startTimeDP
            // 
            startTimeDP.CustomFormat = "yyyy/MM/dd hh:mm tt";
            startTimeDP.Format = DateTimePickerFormat.Custom;
            startTimeDP.Location = new Point(488, 203);
            startTimeDP.Name = "startTimeDP";
            startTimeDP.Size = new Size(314, 27);
            startTimeDP.TabIndex = 80;
            startTimeDP.ValueChanged += startTimeDP_ValueChanged;
            // 
            // printBTN
            // 
            printBTN.Location = new Point(487, 19);
            printBTN.Name = "printBTN";
            printBTN.Size = new Size(317, 29);
            printBTN.TabIndex = 84;
            printBTN.Text = "Print";
            printBTN.UseVisualStyleBackColor = true;
            printBTN.Click += printBTN_Click;
            // 
            // Exams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 473);
            Controls.Add(printBTN);
            Controls.Add(endLBL);
            Controls.Add(startLBL);
            Controls.Add(endTimeDP);
            Controls.Add(startTimeDP);
            Controls.Add(corsCB);
            Controls.Add(updateBTN);
            Controls.Add(exitModiBTN);
            Controls.Add(deleteBTN);
            Controls.Add(SearchTXT);
            Controls.Add(nameValiLBL);
            Controls.Add(idTXT);
            Controls.Add(addBTN);
            Controls.Add(deptLBL);
            Controls.Add(nameLBL);
            Controls.Add(nameTXT);
            Controls.Add(dataGridView1);
            Controls.Add(returnButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Exams";
            Text = "Exams";
            FormClosing += Exams_FormClosing;
            Load += Exams_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button returnButton;
        private DataGridView dataGridView1;
        private TextBox nameTXT;
        private Label nameLBL;
        private Label deptLBL;
        private Button addBTN;
        private TextBox idTXT;
        private Label nameValiLBL;
        private Button deleteBTN;
        private Button exitModiBTN;
        private Button updateBTN;
        private TextBox SearchTXT;
        private ComboBox corsCB;
        private Label endLBL;
        private Label startLBL;
        private DateTimePicker endTimeDP;
        private DateTimePicker startTimeDP;
        private Button printBTN;
    }
}
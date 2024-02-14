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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // returnButton
            // 
            returnButton.Location = new Point(12, 14);
            returnButton.Margin = new Padding(3, 2, 3, 2);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(409, 22);
            returnButton.TabIndex = 65;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 85);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(409, 273);
            dataGridView1.TabIndex = 66;
            // 
            // nameTXT
            // 
            nameTXT.Location = new Point(428, 54);
            nameTXT.Margin = new Padding(3, 2, 3, 2);
            nameTXT.MaxLength = 50;
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(276, 23);
            nameTXT.TabIndex = 67;
            nameTXT.TextChanged += nameTXT_TextChanged;
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(428, 37);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(39, 15);
            nameLBL.TabIndex = 71;
            nameLBL.Text = "Name";
            nameLBL.Click += nameLBL_Click;
            // 
            // deptLBL
            // 
            deptLBL.AutoSize = true;
            deptLBL.Location = new Point(425, 235);
            deptLBL.Name = "deptLBL";
            deptLBL.Size = new Size(49, 15);
            deptLBL.TabIndex = 73;
            deptLBL.Text = "Courses";
            // 
            // addBTN
            // 
            addBTN.Location = new Point(425, 298);
            addBTN.Margin = new Padding(3, 2, 3, 2);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(276, 22);
            addBTN.TabIndex = 75;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // idTXT
            // 
            idTXT.Location = new Point(428, 15);
            idTXT.Margin = new Padding(3, 2, 3, 2);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(276, 23);
            idTXT.TabIndex = 77;
            idTXT.Visible = false;
            idTXT.TextChanged += idTXT_TextChanged;
            // 
            // nameValiLBL
            // 
            nameValiLBL.AutoSize = true;
            nameValiLBL.ForeColor = Color.Red;
            nameValiLBL.Location = new Point(427, 76);
            nameValiLBL.Name = "nameValiLBL";
            nameValiLBL.Size = new Size(235, 15);
            nameValiLBL.TabIndex = 78;
            nameValiLBL.Text = "3 - 50 Characters , letters and numbers only";
            nameValiLBL.Visible = false;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(424, 324);
            deleteBTN.Margin = new Padding(3, 2, 3, 2);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(132, 22);
            deleteBTN.TabIndex = 72;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Visible = false;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // exitModiBTN
            // 
            exitModiBTN.Location = new Point(570, 324);
            exitModiBTN.Margin = new Padding(3, 2, 3, 2);
            exitModiBTN.Name = "exitModiBTN";
            exitModiBTN.Size = new Size(132, 22);
            exitModiBTN.TabIndex = 74;
            exitModiBTN.Text = "Exit Modification";
            exitModiBTN.UseVisualStyleBackColor = true;
            exitModiBTN.Visible = false;
            exitModiBTN.Click += exitModiBTN_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(426, 279);
            updateBTN.Margin = new Padding(3, 2, 3, 2);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(276, 22);
            updateBTN.TabIndex = 70;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Visible = false;
            updateBTN.Click += updateBTN_Click;
            // 
            // SearchTXT
            // 
            SearchTXT.Location = new Point(12, 60);
            SearchTXT.Margin = new Padding(3, 2, 3, 2);
            SearchTXT.Name = "SearchTXT";
            SearchTXT.PlaceholderText = "Search by name";
            SearchTXT.Size = new Size(408, 23);
            SearchTXT.TabIndex = 79;
            // 
            // corsCB
            // 
            corsCB.FormattingEnabled = true;
            corsCB.Location = new Point(426, 252);
            corsCB.Margin = new Padding(3, 2, 3, 2);
            corsCB.Name = "corsCB";
            corsCB.Size = new Size(276, 23);
            corsCB.TabIndex = 69;
            // 
            // endLBL
            // 
            endLBL.AutoSize = true;
            endLBL.Location = new Point(428, 194);
            endLBL.Name = "endLBL";
            endLBL.Size = new Size(56, 15);
            endLBL.TabIndex = 83;
            endLBL.Text = "End Time";
            // 
            // startLBL
            // 
            startLBL.AutoSize = true;
            startLBL.Location = new Point(427, 135);
            startLBL.Name = "startLBL";
            startLBL.Size = new Size(60, 15);
            startLBL.TabIndex = 82;
            startLBL.Text = "Start Time";
            // 
            // endTimeDP
            // 
            endTimeDP.Format = DateTimePickerFormat.Time;
            endTimeDP.Location = new Point(428, 211);
            endTimeDP.Margin = new Padding(3, 2, 3, 2);
            endTimeDP.Name = "endTimeDP";
            endTimeDP.Size = new Size(275, 23);
            endTimeDP.TabIndex = 81;
            // 
            // startTimeDP
            // 
            startTimeDP.Format = DateTimePickerFormat.Time;
            startTimeDP.Location = new Point(427, 152);
            startTimeDP.Margin = new Padding(3, 2, 3, 2);
            startTimeDP.Name = "startTimeDP";
            startTimeDP.Size = new Size(275, 23);
            startTimeDP.TabIndex = 80;
            // 
            // Exams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 355);
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
            Name = "Exams";
            Text = "Exams";
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
    }
}
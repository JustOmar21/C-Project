namespace C__Project.OmarTarek.Student_Forms
{
    partial class StudentExams
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
            dataGridView1 = new DataGridView();
            examNameLBL = new Label();
            examName = new Label();
            enterBTN = new Button();
            returnBTN = new Button();
            startTime = new Label();
            startTimeLBL = new Label();
            refreshBTN = new Button();
            endTime = new Label();
            endTimeLBL = new Label();
            date = new Label();
            dateLBL = new Label();
            idLBL = new Label();
            SearchTXT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 75);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(429, 276);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // examNameLBL
            // 
            examNameLBL.AutoSize = true;
            examNameLBL.Location = new Point(443, 45);
            examNameLBL.Margin = new Padding(2, 0, 2, 0);
            examNameLBL.Name = "examNameLBL";
            examNameLBL.Size = new Size(89, 20);
            examNameLBL.TabIndex = 1;
            examNameLBL.Text = "Exam Name";
            // 
            // examName
            // 
            examName.AutoSize = true;
            examName.Location = new Point(497, 75);
            examName.Margin = new Padding(2, 0, 2, 0);
            examName.Name = "examName";
            examName.Size = new Size(0, 20);
            examName.TabIndex = 2;
            // 
            // enterBTN
            // 
            enterBTN.Enabled = false;
            enterBTN.Location = new Point(443, 323);
            enterBTN.Margin = new Padding(2);
            enterBTN.Name = "enterBTN";
            enterBTN.Size = new Size(90, 27);
            enterBTN.TabIndex = 3;
            enterBTN.Text = "Enter";
            enterBTN.UseVisualStyleBackColor = true;
            enterBTN.Click += enterBTN_Click;
            // 
            // returnBTN
            // 
            returnBTN.Location = new Point(541, 323);
            returnBTN.Margin = new Padding(2);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(90, 27);
            returnBTN.TabIndex = 4;
            returnBTN.Text = "Return";
            returnBTN.UseVisualStyleBackColor = true;
            returnBTN.Click += returnBTN_Click;
            // 
            // startTime
            // 
            startTime.AutoSize = true;
            startTime.Location = new Point(497, 197);
            startTime.Margin = new Padding(2, 0, 2, 0);
            startTime.Name = "startTime";
            startTime.Size = new Size(0, 20);
            startTime.TabIndex = 6;
            // 
            // startTimeLBL
            // 
            startTimeLBL.AutoSize = true;
            startTimeLBL.Location = new Point(443, 167);
            startTimeLBL.Margin = new Padding(2, 0, 2, 0);
            startTimeLBL.Name = "startTimeLBL";
            startTimeLBL.Size = new Size(77, 20);
            startTimeLBL.TabIndex = 5;
            startTimeLBL.Text = "Start Time";
            // 
            // refreshBTN
            // 
            refreshBTN.Location = new Point(10, 10);
            refreshBTN.Margin = new Padding(2);
            refreshBTN.Name = "refreshBTN";
            refreshBTN.Size = new Size(429, 27);
            refreshBTN.TabIndex = 7;
            refreshBTN.Text = "Refresh";
            refreshBTN.UseVisualStyleBackColor = true;
            refreshBTN.Click += refreshBTN_Click;
            // 
            // endTime
            // 
            endTime.AutoSize = true;
            endTime.Location = new Point(497, 260);
            endTime.Margin = new Padding(2, 0, 2, 0);
            endTime.Name = "endTime";
            endTime.Size = new Size(0, 20);
            endTime.TabIndex = 9;
            // 
            // endTimeLBL
            // 
            endTimeLBL.AutoSize = true;
            endTimeLBL.Location = new Point(443, 230);
            endTimeLBL.Margin = new Padding(2, 0, 2, 0);
            endTimeLBL.Name = "endTimeLBL";
            endTimeLBL.Size = new Size(71, 20);
            endTimeLBL.TabIndex = 8;
            endTimeLBL.Text = "End Time";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(497, 129);
            date.Margin = new Padding(2, 0, 2, 0);
            date.Name = "date";
            date.Size = new Size(0, 20);
            date.TabIndex = 11;
            // 
            // dateLBL
            // 
            dateLBL.AutoSize = true;
            dateLBL.Location = new Point(443, 99);
            dateLBL.Margin = new Padding(2, 0, 2, 0);
            dateLBL.Name = "dateLBL";
            dateLBL.Size = new Size(41, 20);
            dateLBL.TabIndex = 10;
            dateLBL.Text = "Date";
            // 
            // idLBL
            // 
            idLBL.AutoSize = true;
            idLBL.Location = new Point(443, 5);
            idLBL.Margin = new Padding(2, 0, 2, 0);
            idLBL.Name = "idLBL";
            idLBL.Size = new Size(50, 20);
            idLBL.TabIndex = 12;
            idLBL.Text = "label1";
            idLBL.Visible = false;
            // 
            // SearchTXT
            // 
            SearchTXT.Location = new Point(10, 42);
            SearchTXT.Name = "SearchTXT";
            SearchTXT.PlaceholderText = "Search by name";
            SearchTXT.Size = new Size(429, 27);
            SearchTXT.TabIndex = 24;
            SearchTXT.TextChanged += SearchTXT_TextChanged;
            // 
            // StudentExams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(SearchTXT);
            Controls.Add(idLBL);
            Controls.Add(date);
            Controls.Add(dateLBL);
            Controls.Add(endTime);
            Controls.Add(endTimeLBL);
            Controls.Add(refreshBTN);
            Controls.Add(startTime);
            Controls.Add(startTimeLBL);
            Controls.Add(returnBTN);
            Controls.Add(enterBTN);
            Controls.Add(examName);
            Controls.Add(examNameLBL);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "StudentExams";
            Text = "Exam";
            FormClosing += StudentExams_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label examNameLBL;
        private Label examName;
        private Button enterBTN;
        private Button returnBTN;
        private Label startTime;
        private Label startTimeLBL;
        private Button refreshBTN;
        private Label endTime;
        private Label endTimeLBL;
        private Label date;
        private Label dateLBL;
        private Label idLBL;
        private TextBox SearchTXT;
    }
}
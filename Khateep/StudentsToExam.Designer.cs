namespace C__Project.Khateep
{
    partial class StudentsToExam
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
            stdCB = new ComboBox();
            deptLBL = new Label();
            exmCB = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SearchTXT = new TextBox();
            dataGridView1 = new DataGridView();
            returnButton = new Button();
            updateBTN = new Button();
            exitModiBTN = new Button();
            deleteBTN = new Button();
            addBTN = new Button();
            idTXT = new TextBox();
            degreeNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)degreeNum).BeginInit();
            SuspendLayout();
            // 
            // stdCB
            // 
            stdCB.FormattingEnabled = true;
            stdCB.Location = new Point(444, 118);
            stdCB.Margin = new Padding(3, 2, 3, 2);
            stdCB.Name = "stdCB";
            stdCB.Size = new Size(276, 23);
            stdCB.TabIndex = 74;
            // 
            // deptLBL
            // 
            deptLBL.AutoSize = true;
            deptLBL.Location = new Point(443, 101);
            deptLBL.Name = "deptLBL";
            deptLBL.Size = new Size(48, 15);
            deptLBL.TabIndex = 75;
            deptLBL.Text = "Student";
            // 
            // exmCB
            // 
            exmCB.FormattingEnabled = true;
            exmCB.Location = new Point(443, 66);
            exmCB.Margin = new Padding(3, 2, 3, 2);
            exmCB.Name = "exmCB";
            exmCB.Size = new Size(276, 23);
            exmCB.TabIndex = 76;
            exmCB.SelectedIndexChanged += exmCB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 49);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 77;
            label1.Text = "Exam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 157);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 79;
            label2.Text = "Degree";
            // 
            // SearchTXT
            // 
            SearchTXT.Location = new Point(12, 67);
            SearchTXT.Margin = new Padding(3, 2, 3, 2);
            SearchTXT.Name = "SearchTXT";
            SearchTXT.PlaceholderText = "Search by name";
            SearchTXT.Size = new Size(408, 23);
            SearchTXT.TabIndex = 82;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 92);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(409, 273);
            dataGridView1.TabIndex = 81;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(12, 21);
            returnButton.Margin = new Padding(3, 2, 3, 2);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(409, 22);
            returnButton.TabIndex = 80;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(443, 287);
            updateBTN.Margin = new Padding(3, 2, 3, 2);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(276, 22);
            updateBTN.TabIndex = 83;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Visible = false;
            updateBTN.Click += updateBTN_Click;
            // 
            // exitModiBTN
            // 
            exitModiBTN.Location = new Point(587, 332);
            exitModiBTN.Margin = new Padding(3, 2, 3, 2);
            exitModiBTN.Name = "exitModiBTN";
            exitModiBTN.Size = new Size(132, 22);
            exitModiBTN.TabIndex = 85;
            exitModiBTN.Text = "Exit Modification";
            exitModiBTN.UseVisualStyleBackColor = true;
            exitModiBTN.Visible = false;
            exitModiBTN.Click += exitModiBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(441, 332);
            deleteBTN.Margin = new Padding(3, 2, 3, 2);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(132, 22);
            deleteBTN.TabIndex = 84;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Visible = false;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(442, 306);
            addBTN.Margin = new Padding(3, 2, 3, 2);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(276, 22);
            addBTN.TabIndex = 86;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // idTXT
            // 
            idTXT.Location = new Point(444, 11);
            idTXT.Margin = new Padding(3, 2, 3, 2);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(276, 23);
            idTXT.TabIndex = 87;
            idTXT.Visible = false;
            idTXT.TextChanged += degreeTXT_TextChanged;
            // 
            // degreeNum
            // 
            degreeNum.Location = new Point(442, 184);
            degreeNum.Margin = new Padding(3, 2, 3, 2);
            degreeNum.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            degreeNum.Name = "degreeNum";
            degreeNum.Size = new Size(275, 23);
            degreeNum.TabIndex = 88;
            // 
            // StudentsToExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(degreeNum);
            Controls.Add(idTXT);
            Controls.Add(updateBTN);
            Controls.Add(exitModiBTN);
            Controls.Add(deleteBTN);
            Controls.Add(addBTN);
            Controls.Add(SearchTXT);
            Controls.Add(dataGridView1);
            Controls.Add(returnButton);
            Controls.Add(label2);
            Controls.Add(exmCB);
            Controls.Add(label1);
            Controls.Add(stdCB);
            Controls.Add(deptLBL);
            Name = "StudentsToExam";
            Text = "StudentsToExam";
            FormClosing += StudentsToExam_FormClosing;
            Load += StudentsToExam_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)degreeNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox stdCB;
        private Label deptLBL;
        private ComboBox exmCB;
        private Label label1;
        private Label label2;
        private TextBox SearchTXT;
        private DataGridView dataGridView1;
        private Button returnButton;
        private Button updateBTN;
        private Button exitModiBTN;
        private Button deleteBTN;
        private Button addBTN;
        private TextBox idTXT;
        private NumericUpDown degreeNum;
    }
}
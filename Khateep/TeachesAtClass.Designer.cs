namespace C__Project.Khateep
{
    partial class TeachesAtClass
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
            updateBTN = new Button();
            exitModiBTN = new Button();
            deleteBTN = new Button();
            addBTN = new Button();
            SearchTXT = new TextBox();
            dataGridView1 = new DataGridView();
            returnButton = new Button();
            courseCB = new ComboBox();
            courseLBL = new Label();
            classCB = new ComboBox();
            classLBL = new Label();
            instructorCB = new ComboBox();
            instructorLBL = new Label();
            setNullBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(506, 377);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(315, 29);
            updateBTN.TabIndex = 95;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Visible = false;
            updateBTN.Click += updateBTN_Click;
            // 
            // exitModiBTN
            // 
            exitModiBTN.Location = new Point(671, 437);
            exitModiBTN.Name = "exitModiBTN";
            exitModiBTN.Size = new Size(151, 29);
            exitModiBTN.TabIndex = 97;
            exitModiBTN.Text = "Exit Modification";
            exitModiBTN.UseVisualStyleBackColor = true;
            exitModiBTN.Visible = false;
            exitModiBTN.Click += exitModiBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(504, 437);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(151, 29);
            deleteBTN.TabIndex = 96;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Visible = false;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(505, 403);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(315, 29);
            addBTN.TabIndex = 98;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // SearchTXT
            // 
            SearchTXT.Location = new Point(14, 84);
            SearchTXT.Name = "SearchTXT";
            SearchTXT.PlaceholderText = "Search by Course name";
            SearchTXT.Size = new Size(466, 27);
            SearchTXT.TabIndex = 94;
            SearchTXT.TextChanged += SearchTXT_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(467, 364);
            dataGridView1.TabIndex = 93;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(14, 23);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(467, 29);
            returnButton.TabIndex = 92;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // courseCB
            // 
            courseCB.FormattingEnabled = true;
            courseCB.Location = new Point(506, 83);
            courseCB.Name = "courseCB";
            courseCB.Size = new Size(315, 28);
            courseCB.TabIndex = 90;
            // 
            // courseLBL
            // 
            courseLBL.AutoSize = true;
            courseLBL.Location = new Point(505, 60);
            courseLBL.Name = "courseLBL";
            courseLBL.Size = new Size(54, 20);
            courseLBL.TabIndex = 91;
            courseLBL.Text = "Course";
            // 
            // classCB
            // 
            classCB.FormattingEnabled = true;
            classCB.Location = new Point(507, 152);
            classCB.Name = "classCB";
            classCB.Size = new Size(315, 28);
            classCB.TabIndex = 88;
            // 
            // classLBL
            // 
            classLBL.AutoSize = true;
            classLBL.Location = new Point(506, 129);
            classLBL.Name = "classLBL";
            classLBL.Size = new Size(56, 20);
            classLBL.TabIndex = 89;
            classLBL.Text = "Classes";
            // 
            // instructorCB
            // 
            instructorCB.FormattingEnabled = true;
            instructorCB.Location = new Point(507, 221);
            instructorCB.Name = "instructorCB";
            instructorCB.Size = new Size(315, 28);
            instructorCB.TabIndex = 100;
            // 
            // instructorLBL
            // 
            instructorLBL.AutoSize = true;
            instructorLBL.Location = new Point(506, 199);
            instructorLBL.Name = "instructorLBL";
            instructorLBL.Size = new Size(71, 20);
            instructorLBL.TabIndex = 101;
            instructorLBL.Text = "Instructor";
            // 
            // setNullBTN
            // 
            setNullBTN.Location = new Point(828, 220);
            setNullBTN.Name = "setNullBTN";
            setNullBTN.Size = new Size(74, 29);
            setNullBTN.TabIndex = 102;
            setNullBTN.Text = "Set Null";
            setNullBTN.UseVisualStyleBackColor = true;
            setNullBTN.Click += setNullBTN_Click;
            // 
            // TeachesAtClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(setNullBTN);
            Controls.Add(instructorCB);
            Controls.Add(instructorLBL);
            Controls.Add(updateBTN);
            Controls.Add(exitModiBTN);
            Controls.Add(deleteBTN);
            Controls.Add(addBTN);
            Controls.Add(SearchTXT);
            Controls.Add(dataGridView1);
            Controls.Add(returnButton);
            Controls.Add(courseCB);
            Controls.Add(courseLBL);
            Controls.Add(classCB);
            Controls.Add(classLBL);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TeachesAtClass";
            Text = "TeachesAt";
            FormClosing += TeachesAt_FormClosing;
            Load += TeachesAt_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button updateBTN;
        private Button exitModiBTN;
        private Button deleteBTN;
        private Button addBTN;
        private TextBox SearchTXT;
        private DataGridView dataGridView1;
        private Button returnButton;
        private ComboBox courseCB;
        private Label courseLBL;
        private ComboBox classCB;
        private Label classLBL;
        private ComboBox instructorCB;
        private Label instructorLBL;
        private Button setNullBTN;
    }
}
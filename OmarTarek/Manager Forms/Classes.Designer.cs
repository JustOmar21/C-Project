namespace C__Project.OmarTarek
{
    partial class Classes
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
            updateBTN = new Button();
            exitModiBTN = new Button();
            deleteBTN = new Button();
            SearchTXT = new TextBox();
            nameValiLBL = new Label();
            idTXT = new TextBox();
            addBTN = new Button();
            branchLBL = new Label();
            nameLBL = new Label();
            nameTXT = new TextBox();
            dataGridView1 = new DataGridView();
            branchCB = new ComboBox();
            floorLBL = new Label();
            floorNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)floorNum).BeginInit();
            SuspendLayout();
            // 
            // returnButton
            // 
            returnButton.Location = new Point(6, 9);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(466, 29);
            returnButton.TabIndex = 20;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(479, 369);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(315, 29);
            updateBTN.TabIndex = 17;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Visible = false;
            updateBTN.Click += updateBTN_Click;
            // 
            // exitModiBTN
            // 
            exitModiBTN.Location = new Point(643, 404);
            exitModiBTN.Name = "exitModiBTN";
            exitModiBTN.Size = new Size(151, 29);
            exitModiBTN.TabIndex = 19;
            exitModiBTN.Text = "Exit Modification";
            exitModiBTN.UseVisualStyleBackColor = true;
            exitModiBTN.Visible = false;
            exitModiBTN.Click += exitModiBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(477, 404);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(151, 29);
            deleteBTN.TabIndex = 18;
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
            SearchTXT.TabIndex = 23;
            SearchTXT.TextChanged += SearchTXT_TextChanged;
            // 
            // nameValiLBL
            // 
            nameValiLBL.AutoSize = true;
            nameValiLBL.ForeColor = Color.Red;
            nameValiLBL.Location = new Point(478, 171);
            nameValiLBL.Name = "nameValiLBL";
            nameValiLBL.Size = new Size(290, 20);
            nameValiLBL.TabIndex = 21;
            nameValiLBL.Text = "3- 50 Characters , letters and numbers only";
            nameValiLBL.Visible = false;
            // 
            // idTXT
            // 
            idTXT.Location = new Point(478, 44);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(315, 27);
            idTXT.TabIndex = 20;
            idTXT.Visible = false;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(478, 369);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(315, 29);
            addBTN.TabIndex = 19;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // branchLBL
            // 
            branchLBL.AutoSize = true;
            branchLBL.Location = new Point(478, 285);
            branchLBL.Name = "branchLBL";
            branchLBL.Size = new Size(54, 20);
            branchLBL.TabIndex = 18;
            branchLBL.Text = "Branch";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(479, 118);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(49, 20);
            nameLBL.TabIndex = 17;
            nameLBL.Text = "Name";
            // 
            // nameTXT
            // 
            nameTXT.Location = new Point(479, 141);
            nameTXT.MaxLength = 50;
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(315, 27);
            nameTXT.TabIndex = 15;
            nameTXT.TextChanged += nameTXT_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(466, 364);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // branchCB
            // 
            branchCB.FormattingEnabled = true;
            branchCB.Location = new Point(479, 308);
            branchCB.Name = "branchCB";
            branchCB.Size = new Size(315, 28);
            branchCB.TabIndex = 16;
            // 
            // floorLBL
            // 
            floorLBL.AutoSize = true;
            floorLBL.Location = new Point(479, 200);
            floorLBL.Name = "floorLBL";
            floorLBL.Size = new Size(43, 20);
            floorLBL.TabIndex = 25;
            floorLBL.Text = "Floor";
            // 
            // floorNum
            // 
            floorNum.Location = new Point(479, 223);
            floorNum.Name = "floorNum";
            floorNum.Size = new Size(314, 27);
            floorNum.TabIndex = 27;
            // 
            // Classes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(floorNum);
            Controls.Add(floorLBL);
            Controls.Add(branchCB);
            Controls.Add(returnButton);
            Controls.Add(updateBTN);
            Controls.Add(exitModiBTN);
            Controls.Add(deleteBTN);
            Controls.Add(SearchTXT);
            Controls.Add(nameValiLBL);
            Controls.Add(idTXT);
            Controls.Add(addBTN);
            Controls.Add(branchLBL);
            Controls.Add(nameLBL);
            Controls.Add(nameTXT);
            Controls.Add(dataGridView1);
            Name = "Classes";
            Text = "Department";
            FormClosing += Department_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)floorNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox branchCB;
        private Button returnButton;
        private Button updateBTN;
        private Button exitModiBTN;
        private Button deleteBTN;
        private TextBox SearchTXT;
        private Label nameValiLBL;
        private TextBox idTXT;
        private Button addBTN;
        private Label branchLBL;
        private Label nameLBL;
        private TextBox nameTXT;
        private DataGridView dataGridView1;
        private Label floorLBL;
        private NumericUpDown floorNum;
    }
}
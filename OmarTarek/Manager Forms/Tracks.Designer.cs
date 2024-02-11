namespace C__Project.OmarTarek
{
    partial class Tracks
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
            deptCB = new ComboBox();
            returnButton = new Button();
            updateBTN = new Button();
            exitModiBTN = new Button();
            deleteBTN = new Button();
            SearchTXT = new TextBox();
            nameValiLBL = new Label();
            idTXT = new TextBox();
            addBTN = new Button();
            deptLBL = new Label();
            nameLBL = new Label();
            nameTXT = new TextBox();
            dataGridView1 = new DataGridView();
            descValiLBL = new Label();
            descLBL = new Label();
            descTXT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // deptCB
            // 
            deptCB.FormattingEnabled = true;
            deptCB.Location = new Point(479, 300);
            deptCB.Name = "deptCB";
            deptCB.Size = new Size(315, 28);
            deptCB.TabIndex = 27;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(6, 9);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(467, 29);
            returnButton.TabIndex = 33;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(479, 361);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(315, 29);
            updateBTN.TabIndex = 28;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Visible = false;
            updateBTN.Click += updateBTN_Click;
            // 
            // exitModiBTN
            // 
            exitModiBTN.Location = new Point(643, 396);
            exitModiBTN.Name = "exitModiBTN";
            exitModiBTN.Size = new Size(151, 29);
            exitModiBTN.TabIndex = 31;
            exitModiBTN.Text = "Exit Modification";
            exitModiBTN.UseVisualStyleBackColor = true;
            exitModiBTN.Visible = false;
            exitModiBTN.Click += exitModiBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(477, 396);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(151, 29);
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
            nameValiLBL.Location = new Point(477, 126);
            nameValiLBL.Name = "nameValiLBL";
            nameValiLBL.Size = new Size(294, 20);
            nameValiLBL.TabIndex = 35;
            nameValiLBL.Text = "3 - 50 Characters , letters and numbers only";
            nameValiLBL.Visible = false;
            // 
            // idTXT
            // 
            idTXT.Location = new Point(478, 44);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(315, 27);
            idTXT.TabIndex = 34;
            idTXT.Visible = false;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(478, 361);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(315, 29);
            addBTN.TabIndex = 32;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // deptLBL
            // 
            deptLBL.AutoSize = true;
            deptLBL.Location = new Point(478, 277);
            deptLBL.Name = "deptLBL";
            deptLBL.Size = new Size(89, 20);
            deptLBL.TabIndex = 30;
            deptLBL.Text = "Department";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(478, 73);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(49, 20);
            nameLBL.TabIndex = 28;
            nameLBL.Text = "Name";
            // 
            // nameTXT
            // 
            nameTXT.Location = new Point(478, 96);
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
            dataGridView1.Size = new Size(467, 364);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // descValiLBL
            // 
            descValiLBL.AutoSize = true;
            descValiLBL.ForeColor = Color.Red;
            descValiLBL.Location = new Point(478, 248);
            descValiLBL.Name = "descValiLBL";
            descValiLBL.Size = new Size(128, 20);
            descValiLBL.TabIndex = 39;
            descValiLBL.Text = "1 - 200 Characters";
            descValiLBL.Visible = false;
            // 
            // descLBL
            // 
            descLBL.AutoSize = true;
            descLBL.Location = new Point(478, 150);
            descLBL.Name = "descLBL";
            descLBL.Size = new Size(85, 20);
            descLBL.TabIndex = 38;
            descLBL.Text = "Description";
            // 
            // descTXT
            // 
            descTXT.Location = new Point(479, 173);
            descTXT.MaxLength = 200;
            descTXT.Multiline = true;
            descTXT.Name = "descTXT";
            descTXT.Size = new Size(315, 72);
            descTXT.TabIndex = 26;
            descTXT.TextChanged += descTXT_TextChanged;
            // 
            // Tracks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(descValiLBL);
            Controls.Add(descLBL);
            Controls.Add(descTXT);
            Controls.Add(deptCB);
            Controls.Add(returnButton);
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
            Name = "Tracks";
            Text = "Tracks";
            FormClosing += Tracks_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox deptCB;
        private Button returnButton;
        private Button updateBTN;
        private Button exitModiBTN;
        private Button deleteBTN;
        private TextBox SearchTXT;
        private Label nameValiLBL;
        private TextBox idTXT;
        private Button addBTN;
        private Label deptLBL;
        private Label nameLBL;
        private TextBox nameTXT;
        private DataGridView dataGridView1;
        private Label descValiLBL;
        private Label descLBL;
        private TextBox descTXT;
    }
}
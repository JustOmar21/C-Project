namespace C__Project.OmarTarek
{
    partial class Branches
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
            nameTXT = new TextBox();
            locationTXT = new TextBox();
            nameLBL = new Label();
            locationLBL = new Label();
            addBTN = new Button();
            idTXT = new TextBox();
            nameValiLBL = new Label();
            locationValiLBL = new Label();
            SearchTXT = new TextBox();
            deleteBTN = new Button();
            exitModiBTN = new Button();
            updateBTN = new Button();
            returnButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(465, 364);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // nameTXT
            // 
            nameTXT.Location = new Point(475, 138);
            nameTXT.MaxLength = 50;
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(315, 27);
            nameTXT.TabIndex = 1;
            nameTXT.TextChanged += nameTXT_TextChanged;
            // 
            // locationTXT
            // 
            locationTXT.Location = new Point(474, 213);
            locationTXT.MaxLength = 50;
            locationTXT.Name = "locationTXT";
            locationTXT.Size = new Size(315, 27);
            locationTXT.TabIndex = 2;
            locationTXT.TextChanged += locationTXT_TextChanged;
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(475, 115);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(49, 20);
            nameLBL.TabIndex = 3;
            nameLBL.Text = "Name";
            // 
            // locationLBL
            // 
            locationLBL.AutoSize = true;
            locationLBL.Location = new Point(474, 190);
            locationLBL.Name = "locationLBL";
            locationLBL.Size = new Size(66, 20);
            locationLBL.TabIndex = 4;
            locationLBL.Text = "Location";
            // 
            // addBTN
            // 
            addBTN.Location = new Point(474, 274);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(315, 29);
            addBTN.TabIndex = 5;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // idTXT
            // 
            idTXT.Location = new Point(474, 41);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(315, 27);
            idTXT.TabIndex = 6;
            idTXT.Visible = false;
            // 
            // nameValiLBL
            // 
            nameValiLBL.AutoSize = true;
            nameValiLBL.ForeColor = Color.Red;
            nameValiLBL.Location = new Point(474, 168);
            nameValiLBL.Name = "nameValiLBL";
            nameValiLBL.Size = new Size(290, 20);
            nameValiLBL.TabIndex = 7;
            nameValiLBL.Text = "3- 50 Characters , letters and numbers only";
            nameValiLBL.Visible = false;
            // 
            // locationValiLBL
            // 
            locationValiLBL.AutoSize = true;
            locationValiLBL.ForeColor = Color.Red;
            locationValiLBL.Location = new Point(474, 243);
            locationValiLBL.Name = "locationValiLBL";
            locationValiLBL.Size = new Size(290, 20);
            locationValiLBL.TabIndex = 8;
            locationValiLBL.Text = "3- 50 Characters , letters and numbers only";
            locationValiLBL.Visible = false;
            // 
            // SearchTXT
            // 
            SearchTXT.Location = new Point(2, 41);
            SearchTXT.Name = "SearchTXT";
            SearchTXT.PlaceholderText = "Search by name";
            SearchTXT.Size = new Size(465, 27);
            SearchTXT.TabIndex = 9;
            SearchTXT.TextChanged += SearchTXT_TextChanged;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(473, 309);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(151, 29);
            deleteBTN.TabIndex = 10;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Visible = false;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // exitModiBTN
            // 
            exitModiBTN.Location = new Point(639, 309);
            exitModiBTN.Name = "exitModiBTN";
            exitModiBTN.Size = new Size(151, 29);
            exitModiBTN.TabIndex = 11;
            exitModiBTN.Text = "Exit Modification";
            exitModiBTN.UseVisualStyleBackColor = true;
            exitModiBTN.Visible = false;
            exitModiBTN.Click += exitModiBTN_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(475, 274);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(315, 29);
            updateBTN.TabIndex = 12;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Visible = false;
            updateBTN.Click += updateBTN_Click;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(2, 6);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(465, 29);
            returnButton.TabIndex = 13;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // Branches
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnButton);
            Controls.Add(updateBTN);
            Controls.Add(exitModiBTN);
            Controls.Add(deleteBTN);
            Controls.Add(SearchTXT);
            Controls.Add(locationValiLBL);
            Controls.Add(nameValiLBL);
            Controls.Add(idTXT);
            Controls.Add(addBTN);
            Controls.Add(locationLBL);
            Controls.Add(nameLBL);
            Controls.Add(locationTXT);
            Controls.Add(nameTXT);
            Controls.Add(dataGridView1);
            Name = "Branches";
            Text = "Branch";
            FormClosing += Branches_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox nameTXT;
        private TextBox locationTXT;
        private Label nameLBL;
        private Label locationLBL;
        private Button addBTN;
        private TextBox idTXT;
        private Label nameValiLBL;
        private Label locationValiLBL;
        private TextBox SearchTXT;
        private Button deleteBTN;
        private Button exitModiBTN;
        private Button updateBTN;
        private Button returnButton;
    }
}
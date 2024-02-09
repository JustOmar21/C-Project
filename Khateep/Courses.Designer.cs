namespace C__Project.Khateep
{
    partial class Courses
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
            SearchTXT = new TextBox();
            dataGridView1 = new DataGridView();
            addBTN = new Button();
            nameLBL = new Label();
            nameTXT = new TextBox();
            deleteBTN = new Button();
            updateBTN = new Button();
            exitModiBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // returnButton
            // 
            returnButton.Location = new Point(12, 13);
            returnButton.Margin = new Padding(3, 2, 3, 2);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(409, 22);
            returnButton.TabIndex = 38;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // SearchTXT
            // 
            SearchTXT.Location = new Point(12, 39);
            SearchTXT.Margin = new Padding(3, 2, 3, 2);
            SearchTXT.Name = "SearchTXT";
            SearchTXT.PlaceholderText = "Search by name";
            SearchTXT.Size = new Size(408, 23);
            SearchTXT.TabIndex = 39;
            SearchTXT.TextChanged += SearchTXT_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 64);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(409, 273);
            dataGridView1.TabIndex = 37;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(493, 314);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(210, 23);
            addBTN.TabIndex = 40;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(427, -3);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(39, 15);
            nameLBL.TabIndex = 42;
            nameLBL.Text = "Name";
            // 
            // nameTXT
            // 
            nameTXT.Location = new Point(427, 14);
            nameTXT.Margin = new Padding(3, 2, 3, 2);
            nameTXT.MaxLength = 50;
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(276, 23);
            nameTXT.TabIndex = 41;
            nameTXT.TextChanged += nameTXT_TextChanged;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(465, 281);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(75, 23);
            deleteBTN.TabIndex = 43;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(564, 281);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(75, 23);
            updateBTN.TabIndex = 44;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Click += updateBTN_Click;
            // 
            // exitModiBTN
            // 
            exitModiBTN.Location = new Point(660, 281);
            exitModiBTN.Name = "exitModiBTN";
            exitModiBTN.Size = new Size(112, 23);
            exitModiBTN.TabIndex = 45;
            exitModiBTN.Text = "Exit Modification";
            exitModiBTN.UseVisualStyleBackColor = true;
            exitModiBTN.Click += exitModiBTN_Click;
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 378);
            Controls.Add(exitModiBTN);
            Controls.Add(updateBTN);
            Controls.Add(deleteBTN);
            Controls.Add(nameLBL);
            Controls.Add(nameTXT);
            Controls.Add(addBTN);
            Controls.Add(returnButton);
            Controls.Add(SearchTXT);
            Controls.Add(dataGridView1);
            Name = "Courses";
            Text = "Courses";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnButton;
        private TextBox SearchTXT;
        private DataGridView dataGridView1;
        private Button addBTN;
        private Label nameLBL;
        private TextBox nameTXT;
        private Button deleteBTN;
        private Button updateBTN;
        private Button exitModiBTN;
    }
}
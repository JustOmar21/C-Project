
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
            nameValiLBL = new Label();
            descritionLBL = new Label();
            descritionTXT = new TextBox();
            descriptionValiLBL = new Label();
            maxDegreeNum = new NumericUpDown();
            minDegreeNum = new NumericUpDown();
            minDegreeLBL = new Label();
            maxDegreeLBL = new Label();
            idTXT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxDegreeNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minDegreeNum).BeginInit();
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
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(493, 339);
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
            nameLBL.Location = new Point(427, 47);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(39, 15);
            nameLBL.TabIndex = 42;
            nameLBL.Text = "Name";
            // 
            // nameTXT
            // 
            nameTXT.Location = new Point(427, 64);
            nameTXT.Margin = new Padding(3, 2, 3, 2);
            nameTXT.MaxLength = 50;
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(345, 23);
            nameTXT.TabIndex = 41;
            nameTXT.TextChanged += nameTXT_TextChanged;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(465, 306);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(75, 23);
            deleteBTN.TabIndex = 43;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(564, 306);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(75, 23);
            updateBTN.TabIndex = 44;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Click += updateBTN_Click;
            // 
            // exitModiBTN
            // 
            exitModiBTN.Location = new Point(660, 306);
            exitModiBTN.Name = "exitModiBTN";
            exitModiBTN.Size = new Size(112, 23);
            exitModiBTN.TabIndex = 45;
            exitModiBTN.Text = "Exit Modification";
            exitModiBTN.UseVisualStyleBackColor = true;
            exitModiBTN.Click += exitModiBTN_Click;
            // 
            // nameValiLBL
            // 
            nameValiLBL.AutoSize = true;
            nameValiLBL.ForeColor = Color.Red;
            nameValiLBL.Location = new Point(427, 92);
            nameValiLBL.Name = "nameValiLBL";
            nameValiLBL.Size = new Size(232, 15);
            nameValiLBL.TabIndex = 46;
            nameValiLBL.Text = "3- 50 Characters , letters and numbers only";
            nameValiLBL.Visible = false;
            nameValiLBL.Click += nameValiLBL_Click;
            // 
            // descritionLBL
            // 
            descritionLBL.AutoSize = true;
            descritionLBL.Location = new Point(427, 118);
            descritionLBL.Name = "descritionLBL";
            descritionLBL.Size = new Size(67, 15);
            descritionLBL.TabIndex = 47;
            descritionLBL.Text = "Description";
            // 
            // descritionTXT
            // 
            descritionTXT.Location = new Point(427, 136);
            descritionTXT.Multiline = true;
            descritionTXT.Name = "descritionTXT";
            descritionTXT.Size = new Size(344, 35);
            descritionTXT.TabIndex = 48;
            descritionTXT.TextChanged += descritionTXT_TextChanged;
            // 
            // descriptionValiLBL
            // 
            descriptionValiLBL.AutoSize = true;
            descriptionValiLBL.ForeColor = Color.Red;
            descriptionValiLBL.Location = new Point(427, 174);
            descriptionValiLBL.Name = "descriptionValiLBL";
            descriptionValiLBL.Size = new Size(232, 15);
            descriptionValiLBL.TabIndex = 49;
            descriptionValiLBL.Text = "3- 50 Characters , letters and numbers only";
            descriptionValiLBL.Visible = false;
            // 
            // maxDegreeNum
            // 
            maxDegreeNum.Location = new Point(427, 217);
            maxDegreeNum.Margin = new Padding(3, 2, 3, 2);
            maxDegreeNum.Name = "maxDegreeNum";
            maxDegreeNum.Size = new Size(275, 23);
            maxDegreeNum.TabIndex = 57;
            // 
            // minDegreeNum
            // 
            minDegreeNum.Location = new Point(427, 281);
            minDegreeNum.Margin = new Padding(3, 2, 3, 2);
            minDegreeNum.Name = "minDegreeNum";
            minDegreeNum.Size = new Size(275, 23);
            minDegreeNum.TabIndex = 59;
            // 
            // minDegreeLBL
            // 
            minDegreeLBL.AutoSize = true;
            minDegreeLBL.Location = new Point(426, 264);
            minDegreeLBL.Name = "minDegreeLBL";
            minDegreeLBL.Size = new Size(68, 15);
            minDegreeLBL.TabIndex = 58;
            minDegreeLBL.Text = "Min Degree";
            minDegreeLBL.Click += label1_Click;
            // 
            // maxDegreeLBL
            // 
            maxDegreeLBL.AutoSize = true;
            maxDegreeLBL.Location = new Point(427, 200);
            maxDegreeLBL.Name = "maxDegreeLBL";
            maxDegreeLBL.Size = new Size(70, 15);
            maxDegreeLBL.TabIndex = 60;
            maxDegreeLBL.Text = "Max Degree";
            // 
            // idTXT
            // 
            idTXT.Location = new Point(427, 11);
            idTXT.Margin = new Padding(3, 2, 3, 2);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(276, 23);
            idTXT.TabIndex = 61;
            idTXT.Visible = false;
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 378);
            Controls.Add(idTXT);
            Controls.Add(maxDegreeLBL);
            Controls.Add(minDegreeNum);
            Controls.Add(minDegreeLBL);
            Controls.Add(maxDegreeNum);
            Controls.Add(descriptionValiLBL);
            Controls.Add(descritionTXT);
            Controls.Add(descritionLBL);
            Controls.Add(nameValiLBL);
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
            FormClosing += Courses_FormClosing;
            Load += Courses_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxDegreeNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)minDegreeNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void nameValiLBL_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private Label nameValiLBL;
        private Label descritionLBL;
        private TextBox descritionTXT;
        private Label descriptionValiLBL;
        private NumericUpDown maxDegreeNum;
        private NumericUpDown minDegreeNum;
        private Label minDegreeLBL;
        private Label maxDegreeLBL;
        private TextBox idTXT;
    }
}
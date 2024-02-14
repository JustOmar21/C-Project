
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
            printBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxDegreeNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minDegreeNum).BeginInit();
            SuspendLayout();
            // 
            // returnButton
            // 
            returnButton.Location = new Point(14, 17);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(467, 29);
            returnButton.TabIndex = 38;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // SearchTXT
            // 
            SearchTXT.Location = new Point(14, 52);
            SearchTXT.Name = "SearchTXT";
            SearchTXT.PlaceholderText = "Search by name";
            SearchTXT.Size = new Size(466, 27);
            SearchTXT.TabIndex = 39;
            SearchTXT.TextChanged += SearchTXT_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(467, 364);
            dataGridView1.TabIndex = 37;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(563, 452);
            addBTN.Margin = new Padding(3, 4, 3, 4);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(240, 31);
            addBTN.TabIndex = 40;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(488, 63);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(49, 20);
            nameLBL.TabIndex = 42;
            nameLBL.Text = "Name";
            // 
            // nameTXT
            // 
            nameTXT.Location = new Point(488, 85);
            nameTXT.MaxLength = 50;
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(394, 27);
            nameTXT.TabIndex = 41;
            nameTXT.TextChanged += nameTXT_TextChanged;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(531, 408);
            deleteBTN.Margin = new Padding(3, 4, 3, 4);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(86, 31);
            deleteBTN.TabIndex = 43;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(645, 408);
            updateBTN.Margin = new Padding(3, 4, 3, 4);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(86, 31);
            updateBTN.TabIndex = 44;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Click += updateBTN_Click;
            // 
            // exitModiBTN
            // 
            exitModiBTN.Location = new Point(754, 408);
            exitModiBTN.Margin = new Padding(3, 4, 3, 4);
            exitModiBTN.Name = "exitModiBTN";
            exitModiBTN.Size = new Size(128, 31);
            exitModiBTN.TabIndex = 45;
            exitModiBTN.Text = "Exit Modification";
            exitModiBTN.UseVisualStyleBackColor = true;
            exitModiBTN.Click += exitModiBTN_Click;
            // 
            // nameValiLBL
            // 
            nameValiLBL.AutoSize = true;
            nameValiLBL.ForeColor = Color.Red;
            nameValiLBL.Location = new Point(488, 123);
            nameValiLBL.Name = "nameValiLBL";
            nameValiLBL.Size = new Size(290, 20);
            nameValiLBL.TabIndex = 46;
            nameValiLBL.Text = "3- 50 Characters , letters and numbers only";
            nameValiLBL.Visible = false;
            nameValiLBL.Click += nameValiLBL_Click;
            // 
            // descritionLBL
            // 
            descritionLBL.AutoSize = true;
            descritionLBL.Location = new Point(488, 157);
            descritionLBL.Name = "descritionLBL";
            descritionLBL.Size = new Size(85, 20);
            descritionLBL.TabIndex = 47;
            descritionLBL.Text = "Description";
            // 
            // descritionTXT
            // 
            descritionTXT.Location = new Point(488, 181);
            descritionTXT.Margin = new Padding(3, 4, 3, 4);
            descritionTXT.Multiline = true;
            descritionTXT.Name = "descritionTXT";
            descritionTXT.Size = new Size(393, 45);
            descritionTXT.TabIndex = 48;
            descritionTXT.TextChanged += descritionTXT_TextChanged;
            // 
            // descriptionValiLBL
            // 
            descriptionValiLBL.AutoSize = true;
            descriptionValiLBL.ForeColor = Color.Red;
            descriptionValiLBL.Location = new Point(488, 232);
            descriptionValiLBL.Name = "descriptionValiLBL";
            descriptionValiLBL.Size = new Size(290, 20);
            descriptionValiLBL.TabIndex = 49;
            descriptionValiLBL.Text = "3- 50 Characters , letters and numbers only";
            descriptionValiLBL.Visible = false;
            // 
            // maxDegreeNum
            // 
            maxDegreeNum.Location = new Point(488, 289);
            maxDegreeNum.Name = "maxDegreeNum";
            maxDegreeNum.Size = new Size(314, 27);
            maxDegreeNum.TabIndex = 57;
            // 
            // minDegreeNum
            // 
            minDegreeNum.Location = new Point(488, 375);
            minDegreeNum.Name = "minDegreeNum";
            minDegreeNum.Size = new Size(314, 27);
            minDegreeNum.TabIndex = 59;
            // 
            // minDegreeLBL
            // 
            minDegreeLBL.AutoSize = true;
            minDegreeLBL.Location = new Point(487, 352);
            minDegreeLBL.Name = "minDegreeLBL";
            minDegreeLBL.Size = new Size(87, 20);
            minDegreeLBL.TabIndex = 58;
            minDegreeLBL.Text = "Min Degree";
            minDegreeLBL.Click += label1_Click;
            // 
            // maxDegreeLBL
            // 
            maxDegreeLBL.AutoSize = true;
            maxDegreeLBL.Location = new Point(488, 267);
            maxDegreeLBL.Name = "maxDegreeLBL";
            maxDegreeLBL.Size = new Size(90, 20);
            maxDegreeLBL.TabIndex = 60;
            maxDegreeLBL.Text = "Max Degree";
            // 
            // idTXT
            // 
            idTXT.Location = new Point(63, 454);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(315, 27);
            idTXT.TabIndex = 61;
            idTXT.Visible = false;
            // 
            // printBTN
            // 
            printBTN.Location = new Point(488, 17);
            printBTN.Name = "printBTN";
            printBTN.Size = new Size(394, 29);
            printBTN.TabIndex = 62;
            printBTN.Text = "Print";
            printBTN.UseVisualStyleBackColor = true;
            printBTN.Click += printBTN_Click;
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 504);
            Controls.Add(printBTN);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Button printBTN;
    }
}
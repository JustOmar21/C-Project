namespace C__Project.OmarTarek
{
    partial class Intakes
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
            nameLBL = new Label();
            nameTXT = new TextBox();
            dataGridView1 = new DataGridView();
            startTimeDP = new DateTimePicker();
            endTimeDP = new DateTimePicker();
            startLBL = new Label();
            endLBL = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // returnButton
            // 
            returnButton.Location = new Point(6, 9);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(467, 29);
            returnButton.TabIndex = 50;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(480, 351);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(315, 29);
            updateBTN.TabIndex = 44;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Visible = false;
            updateBTN.Click += updateBTN_Click;
            // 
            // exitModiBTN
            // 
            exitModiBTN.Location = new Point(643, 386);
            exitModiBTN.Name = "exitModiBTN";
            exitModiBTN.Size = new Size(151, 29);
            exitModiBTN.TabIndex = 48;
            exitModiBTN.Text = "Exit Modification";
            exitModiBTN.UseVisualStyleBackColor = true;
            exitModiBTN.Visible = false;
            exitModiBTN.Click += exitModiBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(477, 386);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(151, 29);
            deleteBTN.TabIndex = 46;
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
            SearchTXT.TabIndex = 53;
            SearchTXT.TextChanged += SearchTXT_TextChanged;
            // 
            // nameValiLBL
            // 
            nameValiLBL.AutoSize = true;
            nameValiLBL.ForeColor = Color.Red;
            nameValiLBL.Location = new Point(478, 151);
            nameValiLBL.Name = "nameValiLBL";
            nameValiLBL.Size = new Size(294, 20);
            nameValiLBL.TabIndex = 52;
            nameValiLBL.Text = "3 - 50 Characters , letters and numbers only";
            nameValiLBL.Visible = false;
            // 
            // idTXT
            // 
            idTXT.Location = new Point(478, 44);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(315, 27);
            idTXT.TabIndex = 51;
            idTXT.Visible = false;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(478, 351);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(315, 29);
            addBTN.TabIndex = 49;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(479, 98);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(49, 20);
            nameLBL.TabIndex = 45;
            nameLBL.Text = "Name";
            // 
            // nameTXT
            // 
            nameTXT.Location = new Point(479, 121);
            nameTXT.MaxLength = 50;
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(315, 27);
            nameTXT.TabIndex = 41;
            nameTXT.TextChanged += nameTXT_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(467, 364);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // startTimeDP
            // 
            startTimeDP.Location = new Point(479, 207);
            startTimeDP.Name = "startTimeDP";
            startTimeDP.Size = new Size(314, 27);
            startTimeDP.TabIndex = 54;
            startTimeDP.ValueChanged += startTimeDP_ValueChanged;
            // 
            // endTimeDP
            // 
            endTimeDP.Location = new Point(479, 286);
            endTimeDP.Name = "endTimeDP";
            endTimeDP.Size = new Size(314, 27);
            endTimeDP.TabIndex = 55;
            // 
            // startLBL
            // 
            startLBL.AutoSize = true;
            startLBL.Location = new Point(479, 184);
            startLBL.Name = "startLBL";
            startLBL.Size = new Size(77, 20);
            startLBL.TabIndex = 56;
            startLBL.Text = "Start Time";
            // 
            // endLBL
            // 
            endLBL.AutoSize = true;
            endLBL.Location = new Point(480, 263);
            endLBL.Name = "endLBL";
            endLBL.Size = new Size(71, 20);
            endLBL.TabIndex = 57;
            endLBL.Text = "End Time";
            // 
            // Intakes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(endLBL);
            Controls.Add(startLBL);
            Controls.Add(endTimeDP);
            Controls.Add(startTimeDP);
            Controls.Add(returnButton);
            Controls.Add(updateBTN);
            Controls.Add(exitModiBTN);
            Controls.Add(deleteBTN);
            Controls.Add(SearchTXT);
            Controls.Add(nameValiLBL);
            Controls.Add(idTXT);
            Controls.Add(addBTN);
            Controls.Add(nameLBL);
            Controls.Add(nameTXT);
            Controls.Add(dataGridView1);
            Name = "Intakes";
            Text = "Intake";
            FormClosing += Intakes_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button returnButton;
        private Button updateBTN;
        private Button exitModiBTN;
        private Button deleteBTN;
        private TextBox SearchTXT;
        private Label nameValiLBL;
        private TextBox idTXT;
        private Button addBTN;
        private Label nameLBL;
        private TextBox nameTXT;
        private DataGridView dataGridView1;
        private DateTimePicker startTimeDP;
        private DateTimePicker endTimeDP;
        private Label startLBL;
        private Label endLBL;
    }
}
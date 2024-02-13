namespace C__Project.OmarTarek.Student_Forms
{
    partial class StudentClasses
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
            returnBTN = new Button();
            SearchTXT = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // returnBTN
            // 
            returnBTN.Location = new Point(12, 409);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(776, 29);
            returnBTN.TabIndex = 0;
            returnBTN.Text = "Return";
            returnBTN.UseVisualStyleBackColor = true;
            returnBTN.Click += returnBTN_Click;
            // 
            // SearchTXT
            // 
            SearchTXT.Location = new Point(12, 12);
            SearchTXT.Name = "SearchTXT";
            SearchTXT.PlaceholderText = "Search by name";
            SearchTXT.Size = new Size(776, 27);
            SearchTXT.TabIndex = 24;
            SearchTXT.TextChanged += SearchTXT_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 358);
            dataGridView1.TabIndex = 25;
            // 
            // StudentClasses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(SearchTXT);
            Controls.Add(returnBTN);
            Name = "StudentClasses";
            Text = "My Classes";
            FormClosing += StudentClasses_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnBTN;
        private TextBox SearchTXT;
        private DataGridView dataGridView1;
    }
}
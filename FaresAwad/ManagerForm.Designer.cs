namespace C__Project.FaresAwad
{
    partial class ManagerForm
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
            dataGridView = new DataGridView();
            txtId = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            pickDateTime = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comIntake = new ComboBox();
            comTrack = new ComboBox();
            comClass = new ComboBox();
            intakeNull = new Button();
            classNull = new Button();
            trackNull = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label4 = new Label();
            txtTitle = new TextBox();
            label8 = new Label();
            txtSalary = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(3, 80);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(412, 367);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(3, 47);
            txtId.Name = "txtId";
            txtId.Size = new Size(412, 27);
            txtId.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(3, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(412, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 8);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(441, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 27);
            txtName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 66);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(441, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(157, 27);
            txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 124);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 5;
            label3.Text = "Date Of Birth";
            // 
            // pickDateTime
            // 
            pickDateTime.Location = new Point(441, 147);
            pickDateTime.Name = "pickDateTime";
            pickDateTime.Size = new Size(330, 27);
            pickDateTime.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(437, 309);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 11;
            label5.Text = "Class";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(437, 250);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 12;
            label6.Text = "Track";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(437, 185);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 9;
            label7.Text = "Intake";
            // 
            // comIntake
            // 
            comIntake.FormattingEnabled = true;
            comIntake.Location = new Point(441, 217);
            comIntake.Name = "comIntake";
            comIntake.Size = new Size(181, 28);
            comIntake.TabIndex = 13;
            // 
            // comTrack
            // 
            comTrack.FormattingEnabled = true;
            comTrack.Location = new Point(441, 273);
            comTrack.Name = "comTrack";
            comTrack.Size = new Size(181, 28);
            comTrack.TabIndex = 14;
            // 
            // comClass
            // 
            comClass.FormattingEnabled = true;
            comClass.Location = new Point(441, 332);
            comClass.Name = "comClass";
            comClass.Size = new Size(181, 28);
            comClass.TabIndex = 15;
            // 
            // intakeNull
            // 
            intakeNull.Location = new Point(637, 216);
            intakeNull.Name = "intakeNull";
            intakeNull.Size = new Size(134, 29);
            intakeNull.TabIndex = 16;
            intakeNull.Text = "Set Null";
            intakeNull.UseVisualStyleBackColor = true;
            // 
            // classNull
            // 
            classNull.Location = new Point(637, 331);
            classNull.Name = "classNull";
            classNull.Size = new Size(134, 29);
            classNull.TabIndex = 17;
            classNull.Text = "Set Null";
            classNull.UseVisualStyleBackColor = true;
            // 
            // trackNull
            // 
            trackNull.Location = new Point(637, 273);
            trackNull.Name = "trackNull";
            trackNull.Size = new Size(134, 29);
            trackNull.TabIndex = 18;
            trackNull.Text = "Set Null";
            trackNull.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(441, 390);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(108, 29);
            btnCreate.TabIndex = 19;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(555, 390);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 29);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(663, 390);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 29);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(610, 8);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 3;
            label4.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(614, 31);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(157, 27);
            txtTitle.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(610, 66);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 5;
            label8.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(614, 89);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(157, 27);
            txtSalary.TabIndex = 6;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(trackNull);
            Controls.Add(classNull);
            Controls.Add(intakeNull);
            Controls.Add(comClass);
            Controls.Add(comTrack);
            Controls.Add(comIntake);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(pickDateTime);
            Controls.Add(label3);
            Controls.Add(txtSalary);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtId);
            Controls.Add(dataGridView);
            Name = "ManagerForm";
            Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private TextBox txtId;
        private Button btnSearch;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private DateTimePicker pickDateTime;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comIntake;
        private ComboBox comTrack;
        private ComboBox comClass;
        private Button intakeNull;
        private Button classNull;
        private Button trackNull;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label4;
        private TextBox txtTitle;
        private Label label8;
        private TextBox txtSalary;
    }
}
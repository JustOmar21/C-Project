﻿namespace C__Project.FaresAwad
{
    partial class InstructorForm
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
            label1 = new Label();
            btnAdd = new Button();
            btnDisplay = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAddEx = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(488, 236);
            dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 249);
            label1.Name = "label1";
            label1.Size = new Size(358, 32);
            label1.TabIndex = 1;
            label1.Text = "Choose what you want to do:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(74, 335);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(358, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adding a Question To Course";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(74, 293);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(358, 29);
            btnDisplay.TabIndex = 3;
            btnDisplay.Text = "Displaying the Courses the instructor teaches";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(74, 420);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(358, 29);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Editing a question";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(74, 462);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(358, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Deleting a question";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddEx
            // 
            btnAddEx.Location = new Point(74, 378);
            btnAddEx.Name = "btnAddEx";
            btnAddEx.Size = new Size(358, 29);
            btnAddEx.TabIndex = 6;
            btnAddEx.Text = "Add a Question To Exam";
            btnAddEx.UseVisualStyleBackColor = true;
            btnAddEx.Click += btnAddEx_Click;
            // 
            // button1
            // 
            button1.Location = new Point(74, 508);
            button1.Name = "button1";
            button1.Size = new Size(358, 29);
            button1.TabIndex = 7;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 549);
            Controls.Add(button1);
            Controls.Add(btnAddEx);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnDisplay);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(dataGridView);
            Name = "InstructorForm";
            Text = "InstructorForm";
            FormClosing += InstructorForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label label1;
        private Button btnAdd;
        private Button btnDisplay;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAddEx;
        private Button button1;
    }
}
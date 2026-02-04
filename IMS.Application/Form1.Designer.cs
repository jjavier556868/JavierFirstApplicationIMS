namespace IMS.Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBoxSearch = new TextBox();
            txtBoxID = new TextBox();
            txtBoxName = new TextBox();
            txtBoxDescription = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(427, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 374);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 37);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Search Program";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 113);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 288);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 203);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Name";
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(23, 55);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(310, 23);
            txtBoxSearch.TabIndex = 5;
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            // 
            // txtBoxID
            // 
            txtBoxID.Location = new Point(23, 131);
            txtBoxID.Name = "txtBoxID";
            txtBoxID.Size = new Size(310, 23);
            txtBoxID.TabIndex = 6;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(24, 221);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(310, 23);
            txtBoxName.TabIndex = 7;
            txtBoxName.KeyDown += txtBoxName_KeyDown;
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(24, 306);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(310, 23);
            txtBoxDescription.TabIndex = 8;
            txtBoxDescription.KeyDown += txtBoxDescription_KeyDown;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(23, 352);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(310, 33);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(23, 391);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(310, 33);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtBoxDescription);
            Controls.Add(txtBoxName);
            Controls.Add(txtBoxID);
            Controls.Add(txtBoxSearch);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxSearch;
        private TextBox txtBoxID;
        private TextBox txtBoxName;
        private TextBox txtBoxDescription;
        private Button btnSave;
        private Button btnDelete;
    }
}

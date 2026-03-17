namespace ActivityC__genese
{
    partial class StudentList
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
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            dgvStudents = new DataGridView();
            btnSaveRecord = new Button();
            txtAge = new TextBox();
            cmbSection = new ComboBox();
            cmbCourse = new ComboBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            btnDeleteRecord = new Button();
            txtID = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(153, 30);
            label1.Name = "label1";
            label1.Size = new Size(315, 37);
            label1.TabIndex = 0;
            label1.Text = "STUDENT MASTER LIST";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 13F);
            txtSearch.Location = new Point(21, 95);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(279, 31);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnSearch.Location = new Point(319, 95);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(202, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnRefresh.Location = new Point(527, 95);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 31);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(21, 144);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(620, 469);
            dgvStudents.TabIndex = 4;
            dgvStudents.CellClick += dgvStudents_CellClick;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSaveRecord.Location = new Point(811, 456);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(298, 41);
            btnSaveRecord.TabIndex = 23;
            btnSaveRecord.Text = "SAVE RECORD";
            btnSaveRecord.UseVisualStyleBackColor = true;
            btnSaveRecord.Click += btnSaveRecord_Click;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 13F);
            txtAge.Location = new Point(811, 401);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "age";
            txtAge.Size = new Size(298, 31);
            txtAge.TabIndex = 22;
            // 
            // cmbSection
            // 
            cmbSection.Font = new Font("Segoe UI", 13F);
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(811, 351);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(298, 31);
            cmbSection.TabIndex = 21;
            // 
            // cmbCourse
            // 
            cmbCourse.Font = new Font("Segoe UI", 13F);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(811, 296);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(298, 31);
            cmbCourse.TabIndex = 20;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 13F);
            txtLastName.Location = new Point(811, 236);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "last name";
            txtLastName.Size = new Size(298, 31);
            txtLastName.TabIndex = 19;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 13F);
            txtFirstName.Location = new Point(811, 183);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "first name";
            txtFirstName.Size = new Size(298, 31);
            txtFirstName.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label6.Location = new Point(725, 407);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 17;
            label6.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label5.Location = new Point(701, 351);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 16;
            label5.Text = "Section:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.Location = new Point(706, 296);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 15;
            label4.Text = "Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(675, 242);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 14;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.Location = new Point(673, 189);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 13;
            label2.Text = "First Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.Location = new Point(776, 73);
            label7.Name = "label7";
            label7.Size = new Size(333, 28);
            label7.TabIndex = 12;
            label7.Text = "UPDATE STUDENT INFORMATION";
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDeleteRecord.Location = new Point(811, 503);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(298, 41);
            btnDeleteRecord.TabIndex = 24;
            btnDeleteRecord.Text = "DELETE RECORD";
            btnDeleteRecord.UseVisualStyleBackColor = true;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Segoe UI", 13F);
            txtID.Location = new Point(811, 131);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID";
            txtID.Size = new Size(298, 31);
            txtID.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label8.Location = new Point(740, 134);
            label8.Name = "label8";
            label8.Size = new Size(36, 25);
            label8.TabIndex = 26;
            label8.Text = "ID:";
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 665);
            Controls.Add(label8);
            Controls.Add(txtID);
            Controls.Add(btnDeleteRecord);
            Controls.Add(btnSaveRecord);
            Controls.Add(txtAge);
            Controls.Add(cmbSection);
            Controls.Add(cmbCourse);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(dgvStudents);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "StudentList";
            Text = "StudentList";
            Load += StudentList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private DataGridView dgvStudents;
        private Button btnSaveRecord;
        private TextBox txtAge;
        private ComboBox cmbSection;
        private ComboBox cmbCourse;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Button btnDeleteRecord;
        private TextBox txtID;
        private Label label8;
    }
}
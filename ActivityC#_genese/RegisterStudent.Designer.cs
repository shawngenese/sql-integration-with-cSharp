namespace ActivityC__genese
{
    partial class RegisterStudent
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            cmbCourse = new ComboBox();
            cmbSection = new ComboBox();
            txtAge = new TextBox();
            btnSaveRecord = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(175, 56);
            label1.Name = "label1";
            label1.Size = new Size(347, 28);
            label1.TabIndex = 0;
            label1.Text = "REGISTER STUDENT INFORMATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.Location = new Point(65, 136);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(67, 189);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.Location = new Point(98, 243);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 3;
            label4.Text = "Course:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label5.Location = new Point(93, 298);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 4;
            label5.Text = "Section:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label6.Location = new Point(117, 354);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 5;
            label6.Text = "Age:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 13F);
            txtFirstName.Location = new Point(203, 130);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "first name";
            txtFirstName.Size = new Size(298, 31);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 13F);
            txtLastName.Location = new Point(203, 183);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "last name";
            txtLastName.Size = new Size(298, 31);
            txtLastName.TabIndex = 7;
            // 
            // cmbCourse
            // 
            cmbCourse.Font = new Font("Segoe UI", 13F);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "ACT", "BSOA", "HM" });
            cmbCourse.Location = new Point(203, 243);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(298, 31);
            cmbCourse.TabIndex = 8;
            // 
            // cmbSection
            // 
            cmbSection.Font = new Font("Segoe UI", 13F);
            cmbSection.FormattingEnabled = true;
            cmbSection.Items.AddRange(new object[] { "1A", "1B", "1C", "1D", "1E" });
            cmbSection.Location = new Point(203, 298);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(298, 31);
            cmbSection.TabIndex = 9;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 13F);
            txtAge.Location = new Point(203, 348);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "age";
            txtAge.Size = new Size(298, 31);
            txtAge.TabIndex = 10;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSaveRecord.Location = new Point(203, 403);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(298, 41);
            btnSaveRecord.TabIndex = 11;
            btnSaveRecord.Text = "SAVE RECORD";
            btnSaveRecord.UseVisualStyleBackColor = true;
            btnSaveRecord.Click += btnSaveRecord_Click;
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 491);
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
            Controls.Add(label1);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private ComboBox cmbCourse;
        private ComboBox cmbSection;
        private TextBox txtAge;
        private Button btnSaveRecord;
    }
}
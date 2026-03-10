namespace ActivityC__genese
{
    partial class Dashboard
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
            btnRegisterStudent = new Button();
            btnStudentList = new Button();
            SuspendLayout();
            // 
            // btnRegisterStudent
            // 
            btnRegisterStudent.BackColor = SystemColors.GradientActiveCaption;
            btnRegisterStudent.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterStudent.Location = new Point(97, 185);
            btnRegisterStudent.Name = "btnRegisterStudent";
            btnRegisterStudent.Size = new Size(298, 81);
            btnRegisterStudent.TabIndex = 0;
            btnRegisterStudent.Text = "REGISTER STUDENT";
            btnRegisterStudent.UseVisualStyleBackColor = false;
            // 
            // btnStudentList
            // 
            btnStudentList.BackColor = SystemColors.GradientActiveCaption;
            btnStudentList.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentList.Location = new Point(421, 185);
            btnStudentList.Name = "btnStudentList";
            btnStudentList.Size = new Size(298, 81);
            btnStudentList.TabIndex = 1;
            btnStudentList.Text = "STUDENT LIST";
            btnStudentList.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStudentList);
            Controls.Add(btnRegisterStudent);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegisterStudent;
        private Button btnStudentList;
    }
}
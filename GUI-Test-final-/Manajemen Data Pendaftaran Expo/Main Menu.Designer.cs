using System.Windows.Forms;

namespace Manajemen_Data_Pendaftaran_Expo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Registration = new Button();
            PrivilegedAccess = new Button();
            Merchandise = new Button();
            Schedule = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // Registration
            // 
            Registration.BackColor = Color.Transparent;
            Registration.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Registration.ForeColor = SystemColors.Highlight;
            Registration.Location = new Point(12, 365);
            Registration.Name = "Registration";
            Registration.Size = new Size(299, 133);
            Registration.TabIndex = 1;
            Registration.Text = "Registration";
            Registration.UseVisualStyleBackColor = false;
            Registration.Click += registration_Click;
            // 
            // PrivilegedAccess
            // 
            PrivilegedAccess.BackColor = Color.Transparent;
            PrivilegedAccess.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrivilegedAccess.ForeColor = SystemColors.Highlight;
            PrivilegedAccess.Location = new Point(389, 365);
            PrivilegedAccess.Name = "PrivilegedAccess";
            PrivilegedAccess.Size = new Size(299, 133);
            PrivilegedAccess.TabIndex = 4;
            PrivilegedAccess.Text = "Privileged Access";
            PrivilegedAccess.UseVisualStyleBackColor = false;
            PrivilegedAccess.Click += PrivilegedAccess_Click_1;
            // 
            // Merchandise
            // 
            Merchandise.BackColor = Color.Transparent;
            Merchandise.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Merchandise.ForeColor = SystemColors.Highlight;
            Merchandise.Location = new Point(12, 541);
            Merchandise.Name = "Merchandise";
            Merchandise.Size = new Size(299, 133);
            Merchandise.TabIndex = 5;
            Merchandise.Text = "Merchandise";
            Merchandise.UseVisualStyleBackColor = false;
            Merchandise.Click += Merchandise_Click;
            // 
            // Schedule
            // 
            Schedule.BackColor = Color.Transparent;
            Schedule.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Schedule.ForeColor = SystemColors.Highlight;
            Schedule.Location = new Point(389, 541);
            Schedule.Name = "Schedule";
            Schedule.Size = new Size(299, 133);
            Schedule.TabIndex = 6;
            Schedule.Text = "Youtube";
            Schedule.UseVisualStyleBackColor = false;
            Schedule.Click += schedule_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(65, 126);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(560, 86);
            label2.TabIndex = 7;
            label2.Text = "E-Idol Menu  2025";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 797);
            Controls.Add(label2);
            Controls.Add(Schedule);
            Controls.Add(Merchandise);
            Controls.Add(PrivilegedAccess);
            Controls.Add(Registration);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Registration;
        private Button PrivilegedAccess;
        private Button Merchandise;
        private Button Schedule;
        private Label label2;
    }
}

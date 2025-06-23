namespace Manajemen_Data_Pendaftaran_Expo
{
    partial class Payment_Classes
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            VIPbutton = new Button();
            Regularbutton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 77);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 40);
            label2.TabIndex = 7;
            label2.Text = "First Class";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(148, 117);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 40);
            label1.TabIndex = 8;
            label1.Text = "VIP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(493, 77);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 40);
            label3.TabIndex = 9;
            label3.Text = "Regular Class";
            // 
            // VIPbutton
            // 
            VIPbutton.BackColor = Color.Transparent;
            VIPbutton.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VIPbutton.ForeColor = Color.ForestGreen;
            VIPbutton.Location = new Point(92, 212);
            VIPbutton.Name = "VIPbutton";
            VIPbutton.Size = new Size(172, 52);
            VIPbutton.TabIndex = 23;
            VIPbutton.Text = "$74.99";
            VIPbutton.UseVisualStyleBackColor = false;
            VIPbutton.Click += vipbutton_Click;
            // 
            // Regularbutton
            // 
            Regularbutton.BackColor = Color.Transparent;
            Regularbutton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Regularbutton.Location = new Point(498, 212);
            Regularbutton.Name = "Regularbutton";
            Regularbutton.Size = new Size(172, 52);
            Regularbutton.TabIndex = 24;
            Regularbutton.Text = "$54.99";
            Regularbutton.UseVisualStyleBackColor = false;
            Regularbutton.Click += regularbutton_Click;
            // 
            // Payment_Classes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.about_main12;
            ClientSize = new Size(800, 398);
            Controls.Add(Regularbutton);
            Controls.Add(VIPbutton);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Payment_Classes";
            Text = "Payment_Classes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Button VIPbutton;
        private Button Regularbutton;
    }
}
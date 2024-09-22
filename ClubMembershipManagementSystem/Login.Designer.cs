using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

namespace  ClubMembershipManagementSystem
{
    partial class Login
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UserNametb = new TextBox();
            Passwordtb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 354);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(312, 18);
            label1.Name = "label1";
            label1.Size = new Size(143, 26);
            label1.TabIndex = 0;
            label1.Text = "AIUB CLUB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(205, 125);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 2;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(205, 188);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // UserNametb
            // 
            UserNametb.Location = new Point(288, 125);
            UserNametb.Name = "UserNametb";
            UserNametb.Size = new Size(234, 23);
            UserNametb.TabIndex = 4;
            UserNametb.TextChanged += UserNametb_TextChanged;
            // 
            // Passwordtb
            // 
            Passwordtb.Location = new Point(288, 188);
            Passwordtb.Name = "Passwordtb";
            Passwordtb.Size = new Size(234, 23);
            Passwordtb.TabIndex = 5;
            Passwordtb.TextChanged += Passwordtb_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Sienna;
            button1.Location = new Point(277, 281);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 6;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += LogIn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Sienna;
            button2.Location = new Point(380, 281);
            button2.Name = "button2";
            button2.Size = new Size(75, 33);
            button2.TabIndex = 7;
            button2.Text = "SIGNUP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += SignUpButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(622, 354);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Passwordtb);
            Controls.Add(UserNametb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UserNametb;
        private TextBox Passwordtb;
        private Button button1;
        private Button button2;
    }
}

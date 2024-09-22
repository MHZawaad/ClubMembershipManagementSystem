using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

namespace ClubMembershipManagementSystem
{
    partial class SignUp
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
            Passwordtb = new TextBox();
            UseraNametb = new TextBox();
            Password = new Label();
            UserName = new Label();
            panel1 = new Panel();
            label1 = new Label();
            SignUpButton = new Button();
            Back = new Button();
            ConfirmPasswordtb = new TextBox();
            ConfirmPassword = new Label();
            FullNametb = new TextBox();
            FullName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Passwordtb
            // 
            Passwordtb.Location = new Point(287, 194);
            Passwordtb.Name = "Passwordtb";
            Passwordtb.Size = new Size(234, 23);
            Passwordtb.TabIndex = 13;
            Passwordtb.TextChanged += Passwordtb_TextChanged;
            // 
            // UseraNametb
            // 
            UseraNametb.Location = new Point(287, 136);
            UseraNametb.Name = "UseraNametb";
            UseraNametb.Size = new Size(234, 23);
            UseraNametb.TabIndex = 12;
            UseraNametb.TextChanged += UseraNametb_TextChanged;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.ForeColor = Color.SaddleBrown;
            Password.Location = new Point(199, 198);
            Password.Name = "Password";
            Password.Size = new Size(72, 19);
            Password.TabIndex = 11;
            Password.Text = "Password";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserName.ForeColor = Color.SaddleBrown;
            UserName.Location = new Point(194, 136);
            UserName.Name = "UserName";
            UserName.Size = new Size(81, 19);
            UserName.TabIndex = 10;
            UserName.Text = "UserName";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 484);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(29, 95);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 2;
            label1.Text = "Admin ";
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.Snow;
            SignUpButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpButton.ForeColor = Color.Sienna;
            SignUpButton.Location = new Point(395, 292);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(87, 33);
            SignUpButton.TabIndex = 43;
            SignUpButton.Text = "SignUp";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.Snow;
            Back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.Sienna;
            Back.Location = new Point(287, 292);
            Back.Name = "Back";
            Back.Size = new Size(75, 33);
            Back.TabIndex = 44;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // ConfirmPasswordtb
            // 
            ConfirmPasswordtb.Location = new Point(287, 223);
            ConfirmPasswordtb.Name = "ConfirmPasswordtb";
            ConfirmPasswordtb.Size = new Size(234, 23);
            ConfirmPasswordtb.TabIndex = 46;
            ConfirmPasswordtb.TextChanged += ConfirmPasswordtb_TextChanged;
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.AutoSize = true;
            ConfirmPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmPassword.ForeColor = Color.SaddleBrown;
            ConfirmPassword.Location = new Point(155, 227);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.Size = new Size(126, 19);
            ConfirmPassword.TabIndex = 45;
            ConfirmPassword.Text = "ConfirmPassword";
            // 
            // FullNametb
            // 
            FullNametb.Location = new Point(287, 165);
            FullNametb.Name = "FullNametb";
            FullNametb.Size = new Size(234, 23);
            FullNametb.TabIndex = 48;
            FullNametb.TextChanged += FullNametb_TextChanged;
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullName.ForeColor = Color.SaddleBrown;
            FullName.Location = new Point(194, 165);
            FullName.Name = "FullName";
            FullName.Size = new Size(74, 19);
            FullName.TabIndex = 47;
            FullName.Text = "FullName";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 484);
            Controls.Add(FullNametb);
            Controls.Add(FullName);
            Controls.Add(ConfirmPasswordtb);
            Controls.Add(ConfirmPassword);
            Controls.Add(Back);
            Controls.Add(SignUpButton);
            Controls.Add(Passwordtb);
            Controls.Add(UseraNametb);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(panel1);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Passwordtb;
        private TextBox UseraNametb;
        private Label Password;
        private Label UserName;
        private Panel panel1;
        private Label label1;
        private Button SignUpButton;
        private Button Back;
        private TextBox ConfirmPasswordtb;
        private Label ConfirmPassword;
        private TextBox FullNametb;
        private Label FullName;
    }
}
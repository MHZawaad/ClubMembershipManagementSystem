using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

namespace ClubMembershipManagementSystem
{
    partial class Menu
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
            panel1 = new Panel();
            label2 = new Label();
            MembershipButton = new Button();
            SignOut = new Button();
            AdminButton = new Button();
            PaymentHistoryButton = new Button();
            PackagesButton = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(MembershipButton);
            panel1.Controls.Add(SignOut);
            panel1.Controls.Add(AdminButton);
            panel1.Controls.Add(PaymentHistoryButton);
            panel1.Controls.Add(PackagesButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 405);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(41, 55);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 11;
            label2.Text = "Menu";
            // 
            // MembershipButton
            // 
            MembershipButton.BackColor = Color.Snow;
            MembershipButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MembershipButton.ForeColor = Color.Sienna;
            MembershipButton.Location = new Point(41, 98);
            MembershipButton.Name = "MembershipButton";
            MembershipButton.Size = new Size(303, 33);
            MembershipButton.TabIndex = 20;
            MembershipButton.Text = "Membership";
            MembershipButton.UseVisualStyleBackColor = false;
            MembershipButton.Click += Membership_Click;
            // 
            // SignOut
            // 
            SignOut.BackColor = Color.Snow;
            SignOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignOut.ForeColor = Color.Sienna;
            SignOut.Location = new Point(41, 340);
            SignOut.Name = "SignOut";
            SignOut.Size = new Size(303, 33);
            SignOut.TabIndex = 25;
            SignOut.Text = "SignOut";
            SignOut.UseVisualStyleBackColor = false;
            SignOut.Click += SignOut_Click;
            // 
            // AdminButton
            // 
            AdminButton.BackColor = Color.Snow;
            AdminButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminButton.ForeColor = Color.Sienna;
            AdminButton.Location = new Point(41, 215);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(303, 33);
            AdminButton.TabIndex = 23;
            AdminButton.Text = "Admin";
            AdminButton.UseVisualStyleBackColor = false;
            AdminButton.Click += Admin_Click;
            // 
            // PaymentHistoryButton
            // 
            PaymentHistoryButton.BackColor = Color.Snow;
            PaymentHistoryButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentHistoryButton.ForeColor = Color.Sienna;
            PaymentHistoryButton.Location = new Point(41, 176);
            PaymentHistoryButton.Name = "PaymentHistoryButton";
            PaymentHistoryButton.Size = new Size(303, 33);
            PaymentHistoryButton.TabIndex = 24;
            PaymentHistoryButton.Text = "Payment History";
            PaymentHistoryButton.UseVisualStyleBackColor = false;
            PaymentHistoryButton.Click += PaymentHistory_Click;
            // 
            // PackagesButton
            // 
            PackagesButton.BackColor = Color.Snow;
            PackagesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PackagesButton.ForeColor = Color.Sienna;
            PackagesButton.Location = new Point(41, 137);
            PackagesButton.Name = "PackagesButton";
            PackagesButton.Size = new Size(303, 33);
            PackagesButton.TabIndex = 21;
            PackagesButton.Text = "Packages";
            PackagesButton.UseVisualStyleBackColor = false;
            PackagesButton.Click += Packages_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(397, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 405);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 405);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Menu";
            Text = "Admin_Control";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button MembershipButton;
        private Button PackagesButton;
        private Button AdminButton;
        private Button PaymentHistoryButton;
        private Button SignOut;
        private PictureBox pictureBox1;
    }
}
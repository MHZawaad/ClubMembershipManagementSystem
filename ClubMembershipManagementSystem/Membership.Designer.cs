namespace ClubMembershipManagementSystem
{
    partial class Membership
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
            Packages = new Button();
            button3 = new Button();
            Catalogue = new Button();
            PaymentHistory = new Button();
            SignOut = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // Packages
            // 
            Packages.Location = new Point(150, 12);
            Packages.Name = "Packages";
            Packages.Size = new Size(109, 23);
            Packages.TabIndex = 1;
            Packages.Text = "Packages";
            Packages.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(282, 12);
            button3.Name = "button3";
            button3.Size = new Size(109, 23);
            button3.TabIndex = 2;
            button3.Text = "Purchase History";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Catalogue
            // 
            Catalogue.Location = new Point(414, 12);
            Catalogue.Name = "Catalogue";
            Catalogue.Size = new Size(109, 23);
            Catalogue.TabIndex = 3;
            Catalogue.Text = "Catalogue";
            Catalogue.UseVisualStyleBackColor = true;
            // 
            // PaymentHistory
            // 
            PaymentHistory.Location = new Point(548, 12);
            PaymentHistory.Name = "PaymentHistory";
            PaymentHistory.Size = new Size(109, 23);
            PaymentHistory.TabIndex = 4;
            PaymentHistory.Text = "Payment History";
            PaymentHistory.UseVisualStyleBackColor = true;
            // 
            // SignOut
            // 
            SignOut.Location = new Point(679, 12);
            SignOut.Name = "SignOut";
            SignOut.Size = new Size(109, 23);
            SignOut.TabIndex = 5;
            SignOut.Text = "Sign Out";
            SignOut.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(5, 12);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 0;
            button1.Text = "Membership";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(129, 12);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 1;
            button2.Text = "Packages";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(253, 12);
            button4.Name = "button4";
            button4.Size = new Size(115, 23);
            button4.TabIndex = 2;
            button4.Text = "PurchaseHistory";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(377, 12);
            button5.Name = "button5";
            button5.Size = new Size(115, 23);
            button5.TabIndex = 3;
            button5.Text = "Perks";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(501, 12);
            button6.Name = "button6";
            button6.Size = new Size(115, 23);
            button6.TabIndex = 4;
            button6.Text = "PaymentHistory";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(625, 12);
            button7.Name = "button7";
            button7.Size = new Size(115, 23);
            button7.TabIndex = 5;
            button7.Text = "SignOut";
            button7.UseVisualStyleBackColor = true;
            // 
            // Membership
            // 
            ClientSize = new Size(743, 325);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Membership";
            ResumeLayout(false);
        }

        #endregion

        private Button Membership;
        private Button Packages;
        private Button button3;
        private Button Catalogue;
        private Button PaymentHistory;
        private Button SignOut;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
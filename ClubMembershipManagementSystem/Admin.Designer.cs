namespace ClubMembershipManagementSystem
{
    partial class Admin
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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            SignOut = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(136, 180);
            button6.Name = "button6";
            button6.Size = new Size(115, 23);
            button6.TabIndex = 16;
            button6.Text = "PaymentHistory";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(204, 66);
            button5.Name = "button5";
            button5.Size = new Size(115, 23);
            button5.TabIndex = 15;
            button5.Text = "Perks";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(204, 121);
            button4.Name = "button4";
            button4.Size = new Size(115, 23);
            button4.TabIndex = 14;
            button4.Text = "PurchaseHistory";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(64, 121);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 13;
            button2.Text = "Packages";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(64, 66);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 12;
            button1.Text = "Membership";
            button1.UseVisualStyleBackColor = true;
            // 
            // SignOut
            // 
            SignOut.Location = new Point(293, 12);
            SignOut.Name = "SignOut";
            SignOut.Size = new Size(115, 23);
            SignOut.TabIndex = 24;
            SignOut.Text = "SignOut";
            SignOut.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SignOut);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
        }

        #endregion
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
        private Button SignOut;
    }
}
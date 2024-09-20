namespace ClubMembershipManagementSystem
{
    partial class PurchaseHistory
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
            button7 = new Button();
            PaymentHistory = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Location = new Point(655, 12);
            button7.Name = "button7";
            button7.Size = new Size(115, 23);
            button7.TabIndex = 11;
            button7.Text = "SignOut";
            button7.UseVisualStyleBackColor = true;
            // 
            // PaymentHistory
            // 
            PaymentHistory.Location = new Point(531, 12);
            PaymentHistory.Name = "PaymentHistory";
            PaymentHistory.Size = new Size(115, 23);
            PaymentHistory.TabIndex = 10;
            PaymentHistory.Text = "PaymentHistory";
            PaymentHistory.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(407, 12);
            button5.Name = "button5";
            button5.Size = new Size(115, 23);
            button5.TabIndex = 9;
            button5.Text = "Perks";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(283, 12);
            button4.Name = "button4";
            button4.Size = new Size(115, 23);
            button4.TabIndex = 8;
            button4.Text = "PurchaseHistory";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(159, 12);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 7;
            button2.Text = "Packages";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(35, 12);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 6;
            button1.Text = "Membership";
            button1.UseVisualStyleBackColor = true;
            // 
            // PurchaseHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(PaymentHistory);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PurchaseHistory";
            Text = "PurchaseHoistory";
            ResumeLayout(false);
        }

        #endregion

        private Button button7;
        private Button PaymentHistory;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
    }
}
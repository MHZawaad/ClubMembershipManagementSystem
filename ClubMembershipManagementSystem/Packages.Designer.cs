namespace ClubMembershipManagementSystem
{
    partial class Packages
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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            PackagesList = new DataGridView();
            AddButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            PackagePricetb = new TextBox();
            PackageDiscounttb = new TextBox();
            PackagePricelb = new Label();
            PackageDiscountlb = new Label();
            PackageNametb = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PackagesList).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Location = new Point(642, 12);
            button7.Name = "button7";
            button7.Size = new Size(115, 23);
            button7.TabIndex = 11;
            button7.Text = "SignOut";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(518, 12);
            button6.Name = "button6";
            button6.Size = new Size(115, 23);
            button6.TabIndex = 10;
            button6.Text = "PaymentHistory";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(394, 12);
            button5.Name = "button5";
            button5.Size = new Size(115, 23);
            button5.TabIndex = 9;
            button5.Text = "Perks";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(270, 12);
            button4.Name = "button4";
            button4.Size = new Size(115, 23);
            button4.TabIndex = 8;
            button4.Text = "PurchaseHistory";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(146, 12);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 7;
            button2.Text = "Packages";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(22, 12);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 6;
            button1.Text = "Membership";
            button1.UseVisualStyleBackColor = true;
            // 
            // PackagesList
            // 
            PackagesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PackagesList.Location = new Point(296, 72);
            PackagesList.Name = "PackagesList";
            PackagesList.Size = new Size(240, 150);
            PackagesList.TabIndex = 12;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(22, 160);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(115, 23);
            AddButton.TabIndex = 13;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(166, 160);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(115, 23);
            DeleteButton.TabIndex = 14;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(102, 199);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(115, 23);
            UpdateButton.TabIndex = 15;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // PackagePricetb
            // 
            PackagePricetb.Location = new Point(117, 85);
            PackagePricetb.Name = "PackagePricetb";
            PackagePricetb.Size = new Size(100, 23);
            PackagePricetb.TabIndex = 16;
            PackagePricetb.TextChanged += PackagePricetb_TextChanged;
            // 
            // PackageDiscounttb
            // 
            PackageDiscounttb.Location = new Point(116, 122);
            PackageDiscounttb.Name = "PackageDiscounttb";
            PackageDiscounttb.Size = new Size(100, 23);
            PackageDiscounttb.TabIndex = 17;
            PackageDiscounttb.TextChanged += PackageDiscounttb_TextChanged;
            // 
            // PackagePricelb
            // 
            PackagePricelb.AutoSize = true;
            PackagePricelb.Location = new Point(56, 93);
            PackagePricelb.Name = "PackagePricelb";
            PackagePricelb.Size = new Size(33, 15);
            PackagePricelb.TabIndex = 18;
            PackagePricelb.Text = "Price";
            // 
            // PackageDiscountlb
            // 
            PackageDiscountlb.AutoSize = true;
            PackageDiscountlb.Location = new Point(56, 125);
            PackageDiscountlb.Name = "PackageDiscountlb";
            PackageDiscountlb.Size = new Size(54, 15);
            PackageDiscountlb.TabIndex = 19;
            PackageDiscountlb.Text = "Discount";
            // 
            // PackageNametb
            // 
            PackageNametb.Location = new Point(117, 56);
            PackageNametb.Name = "PackageNametb";
            PackageNametb.Size = new Size(100, 23);
            PackageNametb.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 56);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 21;
            label1.Text = "Name";
            // 
            // Packages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(PackageNametb);
            Controls.Add(PackageDiscountlb);
            Controls.Add(PackagePricelb);
            Controls.Add(PackageDiscounttb);
            Controls.Add(PackagePricetb);
            Controls.Add(UpdateButton);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(PackagesList);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Packages";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)PackagesList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
        private DataGridView PackagesList;
        private Button AddButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private TextBox PackagePricetb;
        private TextBox PackageDiscounttb;
        private Label PackagePricelb;
        private Label PackageDiscountlb;
        private TextBox PackageNametb;
        private Label label1;
    }
}
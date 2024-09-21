﻿namespace ClubMembershipManagementSystem
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            PackageList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PackageList).BeginInit();
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 172);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 17;
            label4.Text = "Confir Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 129);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 85);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 15;
            label2.Text = "UserName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 42);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(140, 169);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // PackageList
            // 
            PackageList.AllowDrop = true;
            PackageList.BorderStyle = BorderStyle.None;
            PackageList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PackageList.Location = new Point(392, 82);
            PackageList.Name = "PackageList";
            PackageList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PackageList.Size = new Size(240, 150);
            PackageList.TabIndex = 18;
            // 
            // Membership
            // 
            ClientSize = new Size(743, 325);
            Controls.Add(PackageList);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Membership";
            ((System.ComponentModel.ISupportInitialize)PackageList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button Packages;
        private Button button3;
        private Button Catalogue;
        private Button PaymentHistory;
        private Button SignOut;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView PackageList;
    }
}
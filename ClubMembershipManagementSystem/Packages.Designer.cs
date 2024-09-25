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
            PackageList = new DataGridView();
            AddButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            PackagePricetb = new TextBox();
            PackageDiscounttb = new TextBox();
            PackagePricelb = new Label();
            PackageDiscountlb = new Label();
            PackageNametb = new TextBox();
            label1 = new Label();
            PackageBack = new Button();
            SignOut = new Button();
            PackageSearchtb = new TextBox();
            PackageSearch = new Button();
            PackageRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)PackageList).BeginInit();
            SuspendLayout();
            // 
            // PackageList
            // 
            PackageList.AllowDrop = true;
            PackageList.BorderStyle = BorderStyle.None;
            PackageList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PackageList.Location = new Point(302, 85);
            PackageList.Name = "PackageList";
            PackageList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PackageList.Size = new Size(240, 150);
            PackageList.TabIndex = 12;
            PackageList.CellContentClick += PackagesList_CellContentClick;
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
            DeleteButton.Location = new Point(86, 199);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(115, 23);
            DeleteButton.TabIndex = 14;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(146, 160);
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
            // 
            // PackageDiscounttb
            // 
            PackageDiscounttb.Location = new Point(116, 122);
            PackageDiscounttb.Name = "PackageDiscounttb";
            PackageDiscounttb.Size = new Size(100, 23);
            PackageDiscounttb.TabIndex = 17;
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
            // PackageBack
            // 
            PackageBack.Location = new Point(22, 12);
            PackageBack.Name = "PackageBack";
            PackageBack.Size = new Size(115, 23);
            PackageBack.TabIndex = 22;
            PackageBack.Text = "Back";
            PackageBack.UseVisualStyleBackColor = true;
            PackageBack.Click += PackageBack_Click;
            // 
            // SignOut
            // 
            SignOut.Location = new Point(427, 12);
            SignOut.Name = "SignOut";
            SignOut.Size = new Size(115, 23);
            SignOut.TabIndex = 23;
            SignOut.Text = "SignOut";
            SignOut.UseVisualStyleBackColor = true;
            SignOut.Click += SignOut_Click;
            // 
            // PackageSearchtb
            // 
            PackageSearchtb.Location = new Point(372, 49);
            PackageSearchtb.Name = "PackageSearchtb";
            PackageSearchtb.PlaceholderText = "Insert ID";
            PackageSearchtb.Size = new Size(100, 23);
            PackageSearchtb.TabIndex = 24;
            PackageSearchtb.Text = "search only";
            // 
            // PackageSearch
            // 
            PackageSearch.Location = new Point(478, 49);
            PackageSearch.Name = "PackageSearch";
            PackageSearch.Size = new Size(53, 22);
            PackageSearch.TabIndex = 26;
            PackageSearch.Text = "Search";
            PackageSearch.UseVisualStyleBackColor = true;
            PackageSearch.Click += PackageSearch_Click;
            // 
            // PackageRefresh
            // 
            PackageRefresh.Location = new Point(302, 49);
            PackageRefresh.Name = "PackageRefresh";
            PackageRefresh.Size = new Size(64, 22);
            PackageRefresh.TabIndex = 27;
            PackageRefresh.Text = "Refresh";
            PackageRefresh.UseVisualStyleBackColor = true;
            PackageRefresh.Click += PackageRefresh_Click;
            // 
            // Packages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PackageRefresh);
            Controls.Add(PackageSearch);
            Controls.Add(PackageSearchtb);
            Controls.Add(SignOut);
            Controls.Add(PackageBack);
            Controls.Add(label1);
            Controls.Add(PackageNametb);
            Controls.Add(PackageDiscountlb);
            Controls.Add(PackagePricelb);
            Controls.Add(PackageDiscounttb);
            Controls.Add(PackagePricetb);
            Controls.Add(UpdateButton);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(PackageList);
            Name = "Packages";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)PackageList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView PackageList;
        private Button AddButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private TextBox PackagePricetb;
        private TextBox PackageDiscounttb;
        private Label PackagePricelb;
        private Label PackageDiscountlb;
        private TextBox PackageNametb;
        private Label label1;
        private Button PackageBack;
        private Button SignOut;
        private TextBox PackageSearchtb;
        private Button PackageSearch;
        private Button PackageRefresh;
    }
}
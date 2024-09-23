using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

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
            Back = new Button();
            FullNametb = new TextBox();
            UserNametb = new TextBox();
            UserName = new Label();
            panel1 = new Panel();
            FullName = new Label();
            Password = new Label();
            Passwordtb = new TextBox();
            Lister = new DataGridView();
            Delete = new Button();
            Update = new Button();
            Refresh = new Button();
            Search = new Button();
            SignOut = new Button();
            UserIDtb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Lister).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.Snow;
            Back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.Sienna;
            Back.Location = new Point(199, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 33);
            Back.TabIndex = 20;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // FullNametb
            // 
            FullNametb.Location = new Point(316, 133);
            FullNametb.Name = "FullNametb";
            FullNametb.Size = new Size(234, 23);
            FullNametb.TabIndex = 19;
            // 
            // UserNametb
            // 
            UserNametb.Location = new Point(316, 95);
            UserNametb.Name = "UserNametb";
            UserNametb.Size = new Size(234, 23);
            UserNametb.TabIndex = 18;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserName.ForeColor = Color.SaddleBrown;
            UserName.Location = new Point(224, 95);
            UserName.Name = "UserName";
            UserName.Size = new Size(81, 19);
            UserName.TabIndex = 16;
            UserName.Text = "UserName";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 471);
            panel1.TabIndex = 15;
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullName.ForeColor = Color.SaddleBrown;
            FullName.Location = new Point(236, 133);
            FullName.Name = "FullName";
            FullName.Size = new Size(74, 19);
            FullName.TabIndex = 21;
            FullName.Text = "FullName";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.ForeColor = Color.SaddleBrown;
            Password.Location = new Point(238, 162);
            Password.Name = "Password";
            Password.Size = new Size(72, 19);
            Password.TabIndex = 23;
            Password.Text = "Password";
            // 
            // Passwordtb
            // 
            Passwordtb.Location = new Point(316, 162);
            Passwordtb.Name = "Passwordtb";
            Passwordtb.Size = new Size(234, 23);
            Passwordtb.TabIndex = 24;
            // 
            // Lister
            // 
            Lister.BackgroundColor = Color.White;
            Lister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Lister.Location = new Point(611, 109);
            Lister.Name = "Lister";
            Lister.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Lister.Size = new Size(367, 337);
            Lister.TabIndex = 30;
            Lister.CellContentClick += Lister_CellContentClick;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Snow;
            Delete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.ForeColor = Color.Sienna;
            Delete.Location = new Point(389, 395);
            Delete.Name = "Delete";
            Delete.Size = new Size(126, 33);
            Delete.TabIndex = 44;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click_1;
            // 
            // Update
            // 
            Update.BackColor = Color.Snow;
            Update.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.ForeColor = Color.Sienna;
            Update.Location = new Point(236, 395);
            Update.Name = "Update";
            Update.Size = new Size(126, 33);
            Update.TabIndex = 43;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click_1;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(724, 59);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(64, 22);
            Refresh.TabIndex = 48;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // Search
            // 
            Search.Location = new Point(900, 59);
            Search.Name = "Search";
            Search.Size = new Size(53, 22);
            Search.TabIndex = 47;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click_1;
            // 
            // SignOut
            // 
            SignOut.Location = new Point(849, 22);
            SignOut.Name = "SignOut";
            SignOut.Size = new Size(115, 23);
            SignOut.TabIndex = 45;
            SignOut.Text = "SignOut";
            SignOut.UseVisualStyleBackColor = true;
            SignOut.Click += SignOut_Click;
            // 
            // UserIDtb
            // 
            UserIDtb.Location = new Point(794, 59);
            UserIDtb.Name = "UserIDtb";
            UserIDtb.PlaceholderText = "Insert ID";
            UserIDtb.Size = new Size(100, 23);
            UserIDtb.TabIndex = 46;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 471);
            Controls.Add(Refresh);
            Controls.Add(Search);
            Controls.Add(UserIDtb);
            Controls.Add(SignOut);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Lister);
            Controls.Add(Password);
            Controls.Add(Passwordtb);
            Controls.Add(FullName);
            Controls.Add(Back);
            Controls.Add(FullNametb);
            Controls.Add(UserNametb);
            Controls.Add(UserName);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Purchase _History";
            ((System.ComponentModel.ISupportInitialize)Lister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private TextBox FullNametb;
        private TextBox UserNametb;
        private Label UserName;
        private Panel panel1;
        private Label FullName;
        private Label Password;
        private TextBox Passwordtb;
        private DataGridView Lister;
        private Button Delete;
        private Button Update;
        private Button Refresh;
        private Button Search;
        private Button SignOut;
        private TextBox UserIDtb;
    }
}
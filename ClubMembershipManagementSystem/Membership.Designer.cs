using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

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
            Add = new Button();
            Lister = new DataGridView();
            DateJoineddt = new DateTimePicker();
            DateOfBirthdt = new DateTimePicker();
            PhoneNumbertb = new TextBox();
            FullNametb = new TextBox();
            label1 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            SignOut = new Button();
            label2 = new Label();
            Back = new Button();
            label6 = new Label();
            Emailtb = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            Adresstb = new TextBox();
            Statustb = new TextBox();
            PackageIDtb = new TextBox();
            Update = new Button();
            Delete = new Button();
            Refresh = new Button();
            Search = new Button();
            DateLeftdt = new DateTimePicker();
            label4 = new Label();
            MembershipIDtb = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)Lister).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Add
            // 
            Add.BackColor = Color.Snow;
            Add.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.ForeColor = Color.Sienna;
            Add.Location = new Point(19, 419);
            Add.Name = "Add";
            Add.Size = new Size(126, 33);
            Add.TabIndex = 29;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Lister
            // 
            Lister.BackgroundColor = Color.White;
            Lister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Lister.Location = new Point(547, 75);
            Lister.Name = "Lister";
            Lister.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Lister.Size = new Size(470, 355);
            Lister.TabIndex = 17;
            Lister.CellContentClick += Lister_CellContentClick;
            // 
            // DateJoineddt
            // 
            DateJoineddt.Location = new Point(207, 250);
            DateJoineddt.Name = "DateJoineddt";
            DateJoineddt.Size = new Size(234, 23);
            DateJoineddt.TabIndex = 27;
            // 
            // DateOfBirthdt
            // 
            DateOfBirthdt.Location = new Point(207, 221);
            DateOfBirthdt.Name = "DateOfBirthdt";
            DateOfBirthdt.Size = new Size(234, 23);
            DateOfBirthdt.TabIndex = 26;
            // 
            // PhoneNumbertb
            // 
            PhoneNumbertb.Location = new Point(207, 163);
            PhoneNumbertb.Name = "PhoneNumbertb";
            PhoneNumbertb.Size = new Size(234, 23);
            PhoneNumbertb.TabIndex = 25;
            // 
            // FullNametb
            // 
            FullNametb.Location = new Point(207, 105);
            FullNametb.Name = "FullNametb";
            FullNametb.Size = new Size(234, 23);
            FullNametb.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(26, 167);
            label1.Name = "label1";
            label1.Size = new Size(119, 19);
            label1.TabIndex = 22;
            label1.Text = "Contact Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(29, 254);
            label7.Name = "label7";
            label7.Size = new Size(111, 19);
            label7.TabIndex = 21;
            label7.Text = "Date of Joining";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(29, 225);
            label5.Name = "label5";
            label5.Size = new Size(94, 19);
            label5.TabIndex = 19;
            label5.Text = "Date of birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(29, 109);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 16;
            label3.Text = "Full Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(SignOut);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Back);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 55);
            panel1.TabIndex = 15;
            // 
            // SignOut
            // 
            SignOut.BackColor = Color.Snow;
            SignOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignOut.ForeColor = Color.Sienna;
            SignOut.Location = new Point(702, 16);
            SignOut.Name = "SignOut";
            SignOut.Size = new Size(303, 33);
            SignOut.TabIndex = 42;
            SignOut.Text = "SignOut";
            SignOut.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(412, 22);
            label2.Name = "label2";
            label2.Size = new Size(194, 21);
            label2.TabIndex = 1;
            label2.Text = "Membership Information";
            // 
            // Back
            // 
            Back.BackColor = Color.Snow;
            Back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.Sienna;
            Back.Location = new Point(56, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 33);
            Back.TabIndex = 39;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(29, 194);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 31;
            label6.Text = "Email";
            // 
            // Emailtb
            // 
            Emailtb.Location = new Point(207, 192);
            Emailtb.Name = "Emailtb";
            Emailtb.Size = new Size(234, 23);
            Emailtb.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SaddleBrown;
            label8.Location = new Point(26, 138);
            label8.Name = "label8";
            label8.Size = new Size(64, 19);
            label8.TabIndex = 33;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SaddleBrown;
            label9.Location = new Point(29, 341);
            label9.Name = "label9";
            label9.Size = new Size(51, 19);
            label9.TabIndex = 34;
            label9.Text = "Status";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SaddleBrown;
            label10.Location = new Point(29, 312);
            label10.Name = "label10";
            label10.Size = new Size(88, 19);
            label10.TabIndex = 35;
            label10.Text = "Package ID";
            // 
            // Adresstb
            // 
            Adresstb.Location = new Point(207, 134);
            Adresstb.Name = "Adresstb";
            Adresstb.Size = new Size(234, 23);
            Adresstb.TabIndex = 36;
            // 
            // Statustb
            // 
            Statustb.Location = new Point(207, 337);
            Statustb.Name = "Statustb";
            Statustb.Size = new Size(234, 23);
            Statustb.TabIndex = 37;
            // 
            // PackageIDtb
            // 
            PackageIDtb.Location = new Point(207, 308);
            PackageIDtb.Name = "PackageIDtb";
            PackageIDtb.Size = new Size(234, 23);
            PackageIDtb.TabIndex = 38;
            // 
            // Update
            // 
            Update.BackColor = Color.Snow;
            Update.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.ForeColor = Color.Sienna;
            Update.Location = new Point(160, 419);
            Update.Name = "Update";
            Update.Size = new Size(126, 33);
            Update.TabIndex = 40;
            Update.Text = "UPDATE";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Snow;
            Delete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.ForeColor = Color.Sienna;
            Delete.Location = new Point(315, 419);
            Delete.Name = "Delete";
            Delete.Size = new Size(126, 33);
            Delete.TabIndex = 41;
            Delete.Text = "DELETE";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(130, 376);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(79, 22);
            Refresh.TabIndex = 61;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // Search
            // 
            Search.Location = new Point(230, 376);
            Search.Name = "Search";
            Search.Size = new Size(87, 22);
            Search.TabIndex = 60;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // DateLeftdt
            // 
            DateLeftdt.Location = new Point(207, 279);
            DateLeftdt.Name = "DateLeftdt";
            DateLeftdt.Size = new Size(234, 23);
            DateLeftdt.TabIndex = 63;
            DateLeftdt.ValueChanged += DateLeftdt_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(29, 282);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 62;
            label4.Text = "DateLeft";
            // 
            // MembershipIDtb
            // 
            MembershipIDtb.Location = new Point(207, 76);
            MembershipIDtb.Name = "MembershipIDtb";
            MembershipIDtb.Size = new Size(234, 23);
            MembershipIDtb.TabIndex = 65;
            MembershipIDtb.Text = "search only";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SaddleBrown;
            label11.Location = new Point(29, 80);
            label11.Name = "label11";
            label11.Size = new Size(116, 19);
            label11.TabIndex = 64;
            label11.Text = "Membership ID";
            // 
            // Membership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 464);
            Controls.Add(MembershipIDtb);
            Controls.Add(label11);
            Controls.Add(DateLeftdt);
            Controls.Add(label4);
            Controls.Add(Refresh);
            Controls.Add(Search);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(PackageIDtb);
            Controls.Add(Statustb);
            Controls.Add(Adresstb);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(Emailtb);
            Controls.Add(label6);
            Controls.Add(Add);
            Controls.Add(Lister);
            Controls.Add(DateJoineddt);
            Controls.Add(DateOfBirthdt);
            Controls.Add(PhoneNumbertb);
            Controls.Add(FullNametb);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Membership";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Membership";
            ((System.ComponentModel.ISupportInitialize)Lister).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add;
        private DataGridView Lister;
        private DateTimePicker DateJoineddt;
        private DateTimePicker DateOfBirthdt;
        private TextBox PhoneNumbertb;
        private TextBox FullNametb;
        private Label label1;
        private Label label7;
        private Label label5;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Label label6;
        private TextBox Emailtb;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox Adresstb;
        private TextBox Statustb;
        private TextBox PackageIDtb;
        private Button Back;
        private Button Update;
        private Button Delete;
        private Button SignOut;
        private Button Refresh;
        private Button Search;
        private DateTimePicker DateLeftdt;
        private Label label4;
        private TextBox MembershipIDtb;
        private Label label11;
    }
}
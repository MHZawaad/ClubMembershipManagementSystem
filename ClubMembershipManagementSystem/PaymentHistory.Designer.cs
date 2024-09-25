using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

namespace ClubMembershipManagementSystem
{
    partial class PaymentHistory
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
            label3 = new Label();
            Totaltb = new TextBox();
            MemberShipId = new Label();
            Back = new Button();
            MemberShipIdtb = new TextBox();
            Lister = new DataGridView();
            label10 = new Label();
            label4 = new Label();
            Refresh = new Button();
            Search = new Button();
            SignOut = new Button();
            AmountPaidtb = new TextBox();
            Add = new Button();
            Delete = new Button();
            label1 = new Label();
            PaymentHistoryIDtb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Lister).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(39, 222);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 36;
            label3.Text = "Total";
            // 
            // Totaltb
            // 
            Totaltb.Location = new Point(155, 222);
            Totaltb.Name = "Totaltb";
            Totaltb.Size = new Size(191, 23);
            Totaltb.TabIndex = 37;
            // 
            // MemberShipId
            // 
            MemberShipId.AutoSize = true;
            MemberShipId.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MemberShipId.ForeColor = Color.SaddleBrown;
            MemberShipId.Location = new Point(39, 142);
            MemberShipId.Name = "MemberShipId";
            MemberShipId.Size = new Size(110, 19);
            MemberShipId.TabIndex = 35;
            MemberShipId.Text = "MemberShipId";
            // 
            // Back
            // 
            Back.BackColor = Color.Snow;
            Back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.Sienna;
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 33);
            Back.TabIndex = 34;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // MemberShipIdtb
            // 
            MemberShipIdtb.Location = new Point(155, 142);
            MemberShipIdtb.Name = "MemberShipIdtb";
            MemberShipIdtb.Size = new Size(191, 23);
            MemberShipIdtb.TabIndex = 33;
            // 
            // Lister
            // 
            Lister.BackgroundColor = Color.White;
            Lister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Lister.Location = new Point(383, 23);
            Lister.Name = "Lister";
            Lister.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Lister.Size = new Size(613, 433);
            Lister.TabIndex = 44;
            Lister.CellContentClick += Lister_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SaddleBrown;
            label10.Location = new Point(39, 257);
            label10.Name = "label10";
            label10.Size = new Size(90, 19);
            label10.TabIndex = 52;
            label10.Text = "AmountPaid";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(168, 24);
            label4.Name = "label4";
            label4.Size = new Size(131, 21);
            label4.TabIndex = 2;
            label4.Text = "Payment History";
            // 
            // Refresh
            // 
            Refresh.Location = new Point(155, 184);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(79, 22);
            Refresh.TabIndex = 57;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click_1;
            // 
            // Search
            // 
            Search.Location = new Point(259, 184);
            Search.Name = "Search";
            Search.Size = new Size(87, 22);
            Search.TabIndex = 56;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // SignOut
            // 
            SignOut.Location = new Point(197, 423);
            SignOut.Name = "SignOut";
            SignOut.Size = new Size(126, 33);
            SignOut.TabIndex = 58;
            SignOut.Text = "SignOut";
            SignOut.UseVisualStyleBackColor = true;
            SignOut.Click += SignOut_Click;
            // 
            // AmountPaidtb
            // 
            AmountPaidtb.Location = new Point(155, 257);
            AmountPaidtb.Name = "AmountPaidtb";
            AmountPaidtb.Size = new Size(191, 23);
            AmountPaidtb.TabIndex = 60;
            // 
            // Add
            // 
            Add.Location = new Point(197, 384);
            Add.Name = "Add";
            Add.Size = new Size(126, 33);
            Add.TabIndex = 59;
            Add.Text = "Add";
            Add.Click += Add_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(54, 423);
            Delete.Name = "Delete";
            Delete.Size = new Size(126, 33);
            Delete.TabIndex = 61;
            Delete.Text = "Delete";
            Delete.Click += Delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(39, 108);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 63;
            label1.Text = "PaymentID";
            // 
            // PaymentHistoryIDtb
            // 
            PaymentHistoryIDtb.Location = new Point(155, 108);
            PaymentHistoryIDtb.Name = "PaymentHistoryIDtb";
            PaymentHistoryIDtb.Size = new Size(191, 23);
            PaymentHistoryIDtb.TabIndex = 62;
            PaymentHistoryIDtb.TextChanged += PaymentHistoryIDtb_TextChanged;
            // 
            // PaymentHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 483);
            Controls.Add(label1);
            Controls.Add(PaymentHistoryIDtb);
            Controls.Add(Delete);
            Controls.Add(SignOut);
            Controls.Add(Refresh);
            Controls.Add(Search);
            Controls.Add(label4);
            Controls.Add(Add);
            Controls.Add(label10);
            Controls.Add(AmountPaidtb);
            Controls.Add(Lister);
            Controls.Add(label3);
            Controls.Add(Totaltb);
            Controls.Add(MemberShipId);
            Controls.Add(Back);
            Controls.Add(MemberShipIdtb);
            Name = "PaymentHistory";
            ((System.ComponentModel.ISupportInitialize)Lister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox Totaltb;
        private Label MemberShipId;
        private Button Back;
        private TextBox MemberShipIdtb;
        private DataGridView Lister;
        private Label label10;
        private Label label4;
        private Button Refresh;
        private Button Search;
        private Button SignOut;
        private TextBox AmountPaidtb;
        private Button Add;
        private Button Delete;
        private Label label1;
        private TextBox PaymentHistoryIDtb;
    }
}
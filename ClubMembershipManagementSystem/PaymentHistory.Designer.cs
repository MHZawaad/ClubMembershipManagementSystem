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
            label5 = new Label();
            Deductiontb = new TextBox();
            label6 = new Label();
            label7 = new Label();
            PrevBalancetb = new TextBox();
            PaymentDatedt = new DateTimePicker();
            Lister = new DataGridView();
            Delete = new Button();
            Update = new Button();
            Balancetb = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label4 = new Label();
            Refresh = new Button();
            Search = new Button();
            SignOut = new Button();
            NetTotaltb = new TextBox();
            AmountPaidtb = new TextBox();
            Add = new Button();
            ((System.ComponentModel.ISupportInitialize)Lister).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(26, 147);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 36;
            label3.Text = "Total";
            // 
            // Totaltb
            // 
            Totaltb.Location = new Point(142, 147);
            Totaltb.Name = "Totaltb";
            Totaltb.Size = new Size(191, 23);
            Totaltb.TabIndex = 37;
            // 
            // MemberShipId
            // 
            MemberShipId.AutoSize = true;
            MemberShipId.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MemberShipId.ForeColor = Color.SaddleBrown;
            MemberShipId.Location = new Point(26, 67);
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
            Back.Click += button1_Click;
            // 
            // MemberShipIdtb
            // 
            MemberShipIdtb.Location = new Point(142, 67);
            MemberShipIdtb.Name = "MemberShipIdtb";
            MemberShipIdtb.Size = new Size(191, 23);
            MemberShipIdtb.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(26, 176);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 38;
            label5.Text = "Deduction";
            // 
            // Deductiontb
            // 
            Deductiontb.Location = new Point(142, 176);
            Deductiontb.Name = "Deductiontb";
            Deductiontb.Size = new Size(191, 23);
            Deductiontb.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(25, 205);
            label6.Name = "label6";
            label6.Size = new Size(94, 19);
            label6.TabIndex = 40;
            label6.Text = "PrevBalance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(30, 335);
            label7.Name = "label7";
            label7.Size = new Size(42, 19);
            label7.TabIndex = 41;
            label7.Text = "Date";
            // 
            // PrevBalancetb
            // 
            PrevBalancetb.Location = new Point(142, 205);
            PrevBalancetb.Name = "PrevBalancetb";
            PrevBalancetb.Size = new Size(191, 23);
            PrevBalancetb.TabIndex = 42;
            // 
            // PaymentDatedt
            // 
            PaymentDatedt.Location = new Point(99, 332);
            PaymentDatedt.Name = "PaymentDatedt";
            PaymentDatedt.Size = new Size(234, 23);
            PaymentDatedt.TabIndex = 43;
            // 
            // Lister
            // 
            Lister.BackgroundColor = Color.White;
            Lister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Lister.Location = new Point(383, 23);
            Lister.Name = "Lister";
            Lister.Size = new Size(613, 433);
            Lister.TabIndex = 44;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Snow;
            Delete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.ForeColor = Color.Sienna;
            Delete.Location = new Point(54, 423);
            Delete.Name = "Delete";
            Delete.Size = new Size(126, 33);
            Delete.TabIndex = 47;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            Update.BackColor = Color.Snow;
            Update.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.ForeColor = Color.Sienna;
            Update.Location = new Point(197, 382);
            Update.Name = "Update";
            Update.Size = new Size(126, 33);
            Update.TabIndex = 46;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            // 
            // Balancetb
            // 
            Balancetb.Location = new Point(142, 292);
            Balancetb.Name = "Balancetb";
            Balancetb.Size = new Size(191, 23);
            Balancetb.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SaddleBrown;
            label9.Location = new Point(26, 292);
            label9.Name = "label9";
            label9.Size = new Size(63, 19);
            label9.TabIndex = 54;
            label9.Text = "Balance";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SaddleBrown;
            label10.Location = new Point(26, 263);
            label10.Name = "label10";
            label10.Size = new Size(90, 19);
            label10.TabIndex = 52;
            label10.Text = "AmountPaid";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SaddleBrown;
            label11.Location = new Point(25, 234);
            label11.Name = "label11";
            label11.Size = new Size(68, 19);
            label11.TabIndex = 51;
            label11.Text = "NetTotal";
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
            Refresh.Location = new Point(142, 109);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(79, 22);
            Refresh.TabIndex = 57;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            Search.Location = new Point(246, 109);
            Search.Name = "Search";
            Search.Size = new Size(87, 22);
            Search.TabIndex = 56;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            // 
            // SignOut
            // 
            SignOut.Location = new Point(197, 423);
            SignOut.Name = "SignOut";
            SignOut.Size = new Size(126, 33);
            SignOut.TabIndex = 58;
            SignOut.Text = "SignOut";
            SignOut.UseVisualStyleBackColor = true;
            // 
            // NetTotaltb
            // 
            NetTotaltb.Location = new Point(142, 234);
            NetTotaltb.Name = "NetTotaltb";
            NetTotaltb.Size = new Size(191, 23);
            NetTotaltb.TabIndex = 61;
            // 
            // AmountPaidtb
            // 
            AmountPaidtb.Location = new Point(142, 263);
            AmountPaidtb.Name = "AmountPaidtb";
            AmountPaidtb.Size = new Size(191, 23);
            AmountPaidtb.TabIndex = 60;
            // 
            // Add
            // 
            Add.Location = new Point(54, 382);
            Add.Name = "Add";
            Add.Size = new Size(126, 33);
            Add.TabIndex = 59;
            Add.Text = "Add";
            // 
            // PaymentHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 483);
            Controls.Add(SignOut);
            Controls.Add(Refresh);
            Controls.Add(Search);
            Controls.Add(label4);
            Controls.Add(Balancetb);
            Controls.Add(Add);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(AmountPaidtb);
            Controls.Add(label11);
            Controls.Add(NetTotaltb);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Lister);
            Controls.Add(PaymentDatedt);
            Controls.Add(PrevBalancetb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Deductiontb);
            Controls.Add(label5);
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
        private Label label5;
        private TextBox Deductiontb;
        private Label label6;
        private Label label7;
        private TextBox PrevBalancetb;
        private DateTimePicker PaymentDatedt;
        private DataGridView Lister;
        private Button Delete;
        private Button Update;
        private TextBox Balancetb;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label4;
        private Button Refresh;
        private Button Search;
        private Button SignOut;
        private TextBox NetTotaltb;
        private TextBox AmountPaidtb;
        private Button Add;
    }
}
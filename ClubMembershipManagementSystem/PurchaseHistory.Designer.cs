using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

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
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Sienna;
            button1.Location = new Point(324, 417);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 20;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(365, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(365, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 23);
            textBox1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(199, 58);
            label2.Name = "label2";
            label2.Size = new Size(150, 19);
            label2.TabIndex = 16;
            label2.Text = "Purchase History  ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 471);
            panel1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(23, 76);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 2;
            label4.Text = "Purchase History";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(260, 95);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 21;
            label1.Text = "Member ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(286, 138);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 23;
            label3.Text = "Perk ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(365, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 23);
            textBox3.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(365, 180);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(199, 23);
            dateTimePicker2.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(226, 180);
            label7.Name = "label7";
            label7.Size = new Size(123, 19);
            label7.TabIndex = 28;
            label7.Text = "Date of purchase";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(620, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(367, 337);
            dataGridView1.TabIndex = 30;
            // 
            // button4
            // 
            button4.BackColor = Color.Snow;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Sienna;
            button4.Location = new Point(308, 313);
            button4.Name = "button4";
            button4.Size = new Size(126, 33);
            button4.TabIndex = 44;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Snow;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Sienna;
            button3.Location = new Point(438, 244);
            button3.Name = "button3";
            button3.Size = new Size(126, 33);
            button3.TabIndex = 43;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Sienna;
            button2.Location = new Point(248, 244);
            button2.Name = "button2";
            button2.Size = new Size(126, 33);
            button2.TabIndex = 42;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = false;
            // 
            // PurchaseHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 471);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "PurchaseHistory";
            Text = "Purchase _History";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Label label1;
        private Label label3;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
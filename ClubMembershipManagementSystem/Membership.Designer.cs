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
            button2 = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Sienna;
            button2.Location = new Point(26, 419);
            button2.Name = "button2";
            button2.Size = new Size(126, 33);
            button2.TabIndex = 29;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(547, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(470, 355);
            dataGridView1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(131, 195);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(199, 23);
            dateTimePicker2.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(107, 156);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(199, 23);
            dateTimePicker1.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 23);
            textBox3.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 23);
            textBox1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(12, 235);
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
            label7.Location = new Point(12, 195);
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
            label5.Location = new Point(12, 159);
            label5.Name = "label5";
            label5.Size = new Size(94, 19);
            label5.TabIndex = 19;
            label5.Text = "Date of birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(89, 19);
            label4.TabIndex = 18;
            label4.Text = "Member ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 16;
            label3.Text = "Full Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 55);
            panel1.TabIndex = 15;
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
            // textBox4
            // 
            textBox4.Location = new Point(107, 117);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 23);
            textBox4.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(12, 269);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 31;
            label6.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 23);
            textBox2.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SaddleBrown;
            label8.Location = new Point(12, 315);
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
            label9.Location = new Point(279, 121);
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
            label10.Location = new Point(12, 363);
            label10.Name = "label10";
            label10.Size = new Size(88, 19);
            label10.TabIndex = 35;
            label10.Text = "Package ID";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(82, 315);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(371, 23);
            textBox5.TabIndex = 36;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(336, 121);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(180, 23);
            textBox6.TabIndex = 37;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(106, 363);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(180, 23);
            textBox7.TabIndex = 38;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Sienna;
            button1.Location = new Point(466, 419);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 39;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Snow;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Sienna;
            button3.Location = new Point(160, 419);
            button3.Name = "button3";
            button3.Size = new Size(126, 33);
            button3.TabIndex = 40;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Snow;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Sienna;
            button4.Location = new Point(315, 419);
            button4.Name = "button4";
            button4.Size = new Size(126, 33);
            button4.TabIndex = 41;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = false;
            // 
            // Membership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 464);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Membership";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Membership";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}
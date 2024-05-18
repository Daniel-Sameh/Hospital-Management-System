using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hospital
{
    partial class Doctorview
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            DoctorName = new Label();
            Speciality = new Label();
            logoutlinkLabel = new LinkLabel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            submitbutton = new Button();
            hidingpanel = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            label7 = new Label();
            panel3 = new Panel();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Maroon;
            flowLayoutPanel1.Location = new Point(287, 99);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(622, 481);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 95);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 1;
            label1.Text = "Hello,";
            label1.Click += label1_Click;
            // 
            // DoctorName
            // 
            DoctorName.AutoSize = true;
            DoctorName.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorName.Location = new Point(0, 136);
            DoctorName.Name = "DoctorName";
            DoctorName.Size = new Size(175, 38);
            DoctorName.TabIndex = 0;
            DoctorName.Text = "Doctorname";
            DoctorName.TextAlign = ContentAlignment.BottomLeft;
            DoctorName.Click += DoctorName_Click;
            // 
            // Speciality
            // 
            Speciality.AutoSize = true;
            Speciality.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Speciality.Location = new Point(0, 182);
            Speciality.Name = "Speciality";
            Speciality.Size = new Size(112, 31);
            Speciality.TabIndex = 0;
            Speciality.Text = "Speciality";
            Speciality.Click += Speciality_Click;
            // 
            // logoutlinkLabel
            // 
            logoutlinkLabel.AutoSize = true;
            logoutlinkLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutlinkLabel.LinkColor = Color.DarkRed;
            logoutlinkLabel.Location = new Point(95, 732);
            logoutlinkLabel.Name = "logoutlinkLabel";
            logoutlinkLabel.Size = new Size(62, 20);
            logoutlinkLabel.TabIndex = 0;
            logoutlinkLabel.TabStop = true;
            logoutlinkLabel.Text = "Logout";
            logoutlinkLabel.LinkClicked += logoutlinkLabel_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Red_Simple_Medical_Health_Logo;
            pictureBox1.Location = new Point(-38, -77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 241);
            label2.Name = "label2";
            label2.Size = new Size(150, 31);
            label2.TabIndex = 2;
            label2.Text = "Prescription:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 303);
            label3.Name = "label3";
            label3.Size = new Size(107, 17);
            label3.TabIndex = 3;
            label3.Text = "Medicine:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 297);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 346);
            label4.Name = "label4";
            label4.Size = new Size(85, 17);
            label4.TabIndex = 5;
            label4.Text = "Dosage:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 340);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Console", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 380);
            label5.Name = "label5";
            label5.Size = new Size(96, 17);
            label5.TabIndex = 7;
            label5.Text = "Details:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 400);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(262, 99);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // submitbutton
            // 
            submitbutton.BackColor = Color.Maroon;
            submitbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitbutton.ForeColor = Color.Transparent;
            submitbutton.Location = new Point(84, 516);
            submitbutton.Name = "submitbutton";
            submitbutton.Size = new Size(103, 36);
            submitbutton.TabIndex = 10;
            submitbutton.Text = "Submit";
            submitbutton.UseVisualStyleBackColor = false;
            submitbutton.Click += submitbutton_Click;
            // 
            // hidingpanel
            // 
            hidingpanel.Location = new Point(0, 231);
            hidingpanel.Name = "hidingpanel";
            hidingpanel.Size = new Size(281, 334);
            hidingpanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Location = new Point(-12, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 3);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(287, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 680);
            panel2.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Peru;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(290, 641);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Size = new Size(619, 133);
            dataGridView1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 587);
            label6.Name = "label6";
            label6.Size = new Size(236, 31);
            label6.TabIndex = 15;
            label6.Text = "Add Assisting Nurse:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(50, 641);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(181, 28);
            comboBox2.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(84, 675);
            button1.Name = "button1";
            button1.Size = new Size(91, 34);
            button1.TabIndex = 17;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Peru;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label7.ForeColor = Color.AliceBlue;
            label7.Location = new Point(296, 584);
            label7.Name = "label7";
            label7.Size = new Size(257, 41);
            label7.TabIndex = 18;
            label7.Text = "Assistant Nurses:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Peru;
            panel3.Location = new Point(290, 555);
            panel3.Name = "panel3";
            panel3.Size = new Size(619, 169);
            panel3.TabIndex = 19;
            // 
            // Doctorview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(905, 774);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(hidingpanel);
            Controls.Add(submitbutton);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(logoutlinkLabel);
            Controls.Add(Speciality);
            Controls.Add(DoctorName);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Doctorview";
            Text = "Doctorview";
            Load += Doctorview_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label DoctorName;
        private Label Speciality;
        private LinkLabel logoutlinkLabel;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private RichTextBox richTextBox1;
        private Button submitbutton;
        private Panel hidingpanel;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label6;
        private ComboBox comboBox2;
        private Button button1;
        private Label label7;
        private Panel panel3;
    }
}
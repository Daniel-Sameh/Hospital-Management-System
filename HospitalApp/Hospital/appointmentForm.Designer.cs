namespace Hospital
{
    partial class appointmentForm
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
            label1 = new Label();
            label2 = new Label();
            patientlabel = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            doctorlabel = new Label();
            label3 = new Label();
            doctorlabel2 = new Label();
            atlabel = new Label();
            panel2 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            monthCalendar1 = new MonthCalendar();
            label4 = new Label();
            rservebutton = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 48);
            label1.Name = "label1";
            label1.Size = new Size(381, 41);
            label1.TabIndex = 0;
            label1.Text = "Appointment Reservation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 104);
            label2.Name = "label2";
            label2.Size = new Size(112, 38);
            label2.TabIndex = 1;
            label2.Text = "Patient:";
            // 
            // patientlabel
            // 
            patientlabel.AutoSize = true;
            patientlabel.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientlabel.Location = new Point(140, 112);
            patientlabel.Name = "patientlabel";
            patientlabel.Size = new Size(65, 30);
            patientlabel.TabIndex = 2;
            patientlabel.Text = "Null";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(doctorlabel);
            panel1.Location = new Point(0, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 383);
            panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.AliceBlue;
            groupBox1.Location = new Point(3, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 298);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose only one doctor";
            // 
            // doctorlabel
            // 
            doctorlabel.AutoSize = true;
            doctorlabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorlabel.ForeColor = Color.AliceBlue;
            doctorlabel.Location = new Point(140, 16);
            doctorlabel.Name = "doctorlabel";
            doctorlabel.Size = new Size(104, 38);
            doctorlabel.TabIndex = 4;
            doctorlabel.Text = "Doctor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(78, 188);
            label3.Name = "label3";
            label3.Size = new Size(437, 38);
            label3.TabIndex = 5;
            label3.Text = "Appointment Added Successfully";
            // 
            // doctorlabel2
            // 
            doctorlabel2.AutoSize = true;
            doctorlabel2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorlabel2.Location = new Point(78, 270);
            doctorlabel2.Name = "doctorlabel2";
            doctorlabel2.Size = new Size(116, 38);
            doctorlabel2.TabIndex = 6;
            doctorlabel2.Text = "Doctor/";
            // 
            // atlabel
            // 
            atlabel.AutoSize = true;
            atlabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            atlabel.Location = new Point(78, 340);
            atlabel.Name = "atlabel";
            atlabel.Size = new Size(61, 38);
            atlabel.TabIndex = 7;
            atlabel.Text = "At: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(monthCalendar1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(403, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(407, 383);
            panel2.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(157, 320);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.ForeColor = Color.AliceBlue;
            label5.Location = new Point(79, 318);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 8;
            label5.Text = "Hour:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.DarkCyan;
            monthCalendar1.Location = new Point(70, 82);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            monthCalendar1.TitleBackColor = Color.DarkCyan;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.AliceBlue;
            label4.Location = new Point(157, 16);
            label4.Name = "label4";
            label4.Size = new Size(77, 38);
            label4.TabIndex = 6;
            label4.Text = "Date";
            // 
            // rservebutton
            // 
            rservebutton.BackColor = Color.CadetBlue;
            rservebutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rservebutton.ForeColor = Color.AliceBlue;
            rservebutton.Location = new Point(642, 53);
            rservebutton.Name = "rservebutton";
            rservebutton.Size = new Size(116, 38);
            rservebutton.TabIndex = 9;
            rservebutton.Text = "reserve";
            rservebutton.UseVisualStyleBackColor = false;
            rservebutton.Click += rservebutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar;
            pictureBox1.Location = new Point(33, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(574, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 27);
            textBox1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(392, 117);
            label6.Name = "label6";
            label6.Size = new Size(176, 25);
            label6.TabIndex = 12;
            label6.Text = "Appointment Type:";
            // 
            // appointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 534);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(rservebutton);
            Controls.Add(panel2);
            Controls.Add(patientlabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(doctorlabel2);
            Controls.Add(atlabel);
            Name = "appointmentForm";
            Text = "appointmentForm";
            Load += appointmentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label patientlabel;
        private Panel panel1;
        private Label doctorlabel;
        private GroupBox groupBox1;
        private Label label3;
        private Label doctorlabel2;
        private Label atlabel;
        private Panel panel2;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private Button rservebutton;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label6;
    }
}
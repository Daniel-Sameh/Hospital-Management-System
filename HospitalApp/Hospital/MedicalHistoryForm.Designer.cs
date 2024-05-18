namespace Hospital
{
    partial class MedicalHistoryForm
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
            panel1 = new Panel();
            label6 = new Label();
            ADMINID = new Label();
            label2 = new Label();
            PATIENTID = new Label();
            DETAILS = new TextBox();
            label4 = new Label();
            Patient_ID = new Label();
            panel2 = new Panel();
            button1 = new Button();
            DATEID = new Label();
            monthCalendar1 = new MonthCalendar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSeaGreen;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(-2, -1);
            label1.Name = "label1";
            label1.Size = new Size(640, 46);
            label1.TabIndex = 0;
            label1.Text = "Add a Medical History";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ADMINID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PATIENTID);
            panel1.Controls.Add(DETAILS);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Patient_ID);
            panel1.Location = new Point(-2, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 412);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(72, 17);
            label6.Name = "label6";
            label6.Size = new Size(150, 32);
            label6.TabIndex = 8;
            label6.Text = "YOUR INFO:";
            // 
            // ADMINID
            // 
            ADMINID.AutoSize = true;
            ADMINID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADMINID.Location = new Point(154, 110);
            ADMINID.Name = "ADMINID";
            ADMINID.Size = new Size(89, 25);
            ADMINID.TabIndex = 7;
            ADMINID.Text = "AdminID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 110);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 6;
            label2.Text = "Your Admin ID: ";
            // 
            // PATIENTID
            // 
            PATIENTID.AutoSize = true;
            PATIENTID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            PATIENTID.Location = new Point(96, 61);
            PATIENTID.Name = "PATIENTID";
            PATIENTID.Size = new Size(43, 25);
            PATIENTID.TabIndex = 4;
            PATIENTID.Text = "PID";
            // 
            // DETAILS
            // 
            DETAILS.Location = new Point(14, 212);
            DETAILS.Multiline = true;
            DETAILS.Name = "DETAILS";
            DETAILS.Size = new Size(266, 186);
            DETAILS.TabIndex = 3;
            DETAILS.TextChanged += DETAILS_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(14, 160);
            label4.Name = "label4";
            label4.Size = new Size(218, 25);
            label4.TabIndex = 2;
            label4.Text = "Medical Record Details: ";
            // 
            // Patient_ID
            // 
            Patient_ID.AutoSize = true;
            Patient_ID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Patient_ID.Location = new Point(14, 61);
            Patient_ID.Name = "Patient_ID";
            Patient_ID.Size = new Size(85, 25);
            Patient_ID.TabIndex = 0;
            Patient_ID.Text = "Your ID: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(DATEID);
            panel2.Controls.Add(monthCalendar1);
            panel2.Location = new Point(297, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 412);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(88, 323);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DATEID
            // 
            DATEID.AutoSize = true;
            DATEID.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DATEID.Location = new Point(88, 32);
            DATEID.Name = "DATEID";
            DATEID.Size = new Size(165, 30);
            DATEID.TabIndex = 1;
            DATEID.Text = "Choose a Date: ";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(50, 94);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // MedicalHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "MedicalHistoryForm";
            Text = "MedicalHistoryForm";
            Load += MedicalHistoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label Patient_ID;
        private Panel panel2;
        private MonthCalendar monthCalendar1;
        private Label PATIENTID;
        private TextBox DETAILS;
        private Button button1;
        private Label DATEID;
        private Label ADMINID;
        private Label label2;
        private Label label6;
    }
}
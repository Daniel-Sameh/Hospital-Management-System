namespace Hospital
{
    partial class Patient
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Patient_name = new Label();
            Make_appoint = new Button();
            view_appoint = new Button();
            Add_Medical_History = new Button();
            View_Medical_History = new Button();
            DataGrid = new DataGridView();
            Phone_label = new Label();
            phone_number = new Label();
            mail_label = new Label();
            Patient_email = new Label();
            label1 = new Label();
            panel1 = new Panel();
            Admin_ID = new Label();
            label3 = new Label();
            listView1 = new ListView();
            View_Prescriptions = new Button();
            label2 = new Label();
            label4 = new Label();
            app_sum = new Label();
            label6 = new Label();
            pres_sum = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Patient_name
            // 
            Patient_name.AutoSize = true;
            Patient_name.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Patient_name.Location = new Point(422, 11);
            Patient_name.Name = "Patient_name";
            Patient_name.Size = new Size(79, 30);
            Patient_name.TabIndex = 1;
            Patient_name.Text = "pname";
            // 
            // Make_appoint
            // 
            Make_appoint.BackColor = SystemColors.ControlLight;
            Make_appoint.Location = new Point(24, 178);
            Make_appoint.Name = "Make_appoint";
            Make_appoint.Size = new Size(125, 57);
            Make_appoint.TabIndex = 2;
            Make_appoint.Text = "Make appointment";
            Make_appoint.UseVisualStyleBackColor = false;
            Make_appoint.Click += Make_appoint_Click;
            // 
            // view_appoint
            // 
            view_appoint.BackColor = SystemColors.ControlLight;
            view_appoint.Location = new Point(175, 178);
            view_appoint.Name = "view_appoint";
            view_appoint.Size = new Size(122, 57);
            view_appoint.TabIndex = 3;
            view_appoint.Text = "View appointments";
            view_appoint.UseVisualStyleBackColor = false;
            view_appoint.Click += view_appoint_Click;
            // 
            // Add_Medical_History
            // 
            Add_Medical_History.BackColor = SystemColors.ControlLight;
            Add_Medical_History.Location = new Point(320, 178);
            Add_Medical_History.Name = "Add_Medical_History";
            Add_Medical_History.Size = new Size(127, 57);
            Add_Medical_History.TabIndex = 4;
            Add_Medical_History.Text = "Add Medical History";
            Add_Medical_History.UseVisualStyleBackColor = false;
            Add_Medical_History.Click += Add_Medical_History_Click;
            // 
            // View_Medical_History
            // 
            View_Medical_History.BackColor = SystemColors.ControlLight;
            View_Medical_History.Location = new Point(472, 178);
            View_Medical_History.Name = "View_Medical_History";
            View_Medical_History.Size = new Size(138, 57);
            View_Medical_History.TabIndex = 5;
            View_Medical_History.Text = "View Medical History";
            View_Medical_History.UseVisualStyleBackColor = false;
            View_Medical_History.Click += View_Medical_History_Click;
            // 
            // DataGrid
            // 
            DataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGrid.BorderStyle = BorderStyle.None;
            DataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            DataGrid.Location = new Point(12, 275);
            DataGrid.Name = "DataGrid";
            dataGridViewCellStyle6.BackColor = Color.FromArgb(238, 239, 249);
            DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            DataGrid.Size = new Size(776, 260);
            DataGrid.TabIndex = 6;
            DataGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Phone_label
            // 
            Phone_label.AutoSize = true;
            Phone_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Phone_label.Location = new Point(3, 47);
            Phone_label.Name = "Phone_label";
            Phone_label.Size = new Size(159, 25);
            Phone_label.TabIndex = 7;
            Phone_label.Text = "Phone Number: ";
            // 
            // phone_number
            // 
            phone_number.AutoSize = true;
            phone_number.Location = new Point(168, 55);
            phone_number.Name = "phone_number";
            phone_number.Size = new Size(56, 15);
            phone_number.TabIndex = 8;
            phone_number.Text = "Pnumber";
            // 
            // mail_label
            // 
            mail_label.AutoSize = true;
            mail_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mail_label.Location = new Point(583, 47);
            mail_label.Name = "mail_label";
            mail_label.Size = new Size(69, 25);
            mail_label.TabIndex = 9;
            mail_label.Text = "email: ";
            mail_label.Click += mail_label_Click;
            // 
            // Patient_email
            // 
            Patient_email.AutoSize = true;
            Patient_email.Location = new Point(645, 53);
            Patient_email.Name = "Patient_email";
            Patient_email.Size = new Size(37, 15);
            Patient_email.TabIndex = 10;
            Patient_email.Text = "Pmail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 3);
            label1.Name = "label1";
            label1.Size = new Size(152, 40);
            label1.TabIndex = 0;
            label1.Text = "Welcome,";
            // 
            // panel1
            // 
            panel1.BackColor = Color.OldLace;
            panel1.Controls.Add(pres_sum);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(app_sum);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Admin_ID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Patient_email);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(mail_label);
            panel1.Controls.Add(Patient_name);
            panel1.Controls.Add(phone_number);
            panel1.Controls.Add(Phone_label);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 120);
            panel1.TabIndex = 11;
            // 
            // Admin_ID
            // 
            Admin_ID.AutoSize = true;
            Admin_ID.Location = new Point(476, 53);
            Admin_ID.Name = "Admin_ID";
            Admin_ID.Size = new Size(54, 15);
            Admin_ID.TabIndex = 12;
            Admin_ID.Text = "AdminID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(287, 47);
            label3.Name = "label3";
            label3.Size = new Size(189, 25);
            label3.TabIndex = 11;
            label3.Text = "Responsible admin: ";
            // 
            // listView1
            // 
            listView1.BackColor = Color.White;
            listView1.Location = new Point(-3, 115);
            listView1.Name = "listView1";
            listView1.Size = new Size(810, 145);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // View_Prescriptions
            // 
            View_Prescriptions.BackColor = SystemColors.ControlLight;
            View_Prescriptions.Location = new Point(642, 178);
            View_Prescriptions.Name = "View_Prescriptions";
            View_Prescriptions.Size = new Size(134, 57);
            View_Prescriptions.TabIndex = 13;
            View_Prescriptions.Text = "View Prescriptions";
            View_Prescriptions.UseVisualStyleBackColor = false;
            View_Prescriptions.Click += View_Prescriptions_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(261, 141);
            label2.Name = "label2";
            label2.Size = new Size(319, 25);
            label2.TabIndex = 14;
            label2.Text = "What would You Like to do Today?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 88);
            label4.Name = "label4";
            label4.Size = new Size(227, 25);
            label4.TabIndex = 13;
            label4.Text = "Total appointments fees: ";
            // 
            // app_sum
            // 
            app_sum.AutoSize = true;
            app_sum.Location = new Point(225, 96);
            app_sum.Name = "app_sum";
            app_sum.Size = new Size(31, 15);
            app_sum.TabIndex = 14;
            app_sum.Text = "total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(422, 82);
            label6.Name = "label6";
            label6.Size = new Size(277, 32);
            label6.TabIndex = 15;
            label6.Text = "Total Prescriptions fees: ";
            // 
            // pres_sum
            // 
            pres_sum.AutoSize = true;
            pres_sum.Location = new Point(697, 96);
            pres_sum.Name = "pres_sum";
            pres_sum.Size = new Size(31, 15);
            pres_sum.TabIndex = 16;
            pres_sum.Text = "total";
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(label2);
            Controls.Add(View_Prescriptions);
            Controls.Add(DataGrid);
            Controls.Add(View_Medical_History);
            Controls.Add(Add_Medical_History);
            Controls.Add(view_appoint);
            Controls.Add(Make_appoint);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Name = "Patient";
            Text = "Form2";
            Load += Patient_Load;
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Patient_name;
        private Button Make_appoint;
        private Button view_appoint;
        private Button Add_Medical_History;
        private Button View_Medical_History;
        private DataGridView DataGrid;
        private Label Phone_label;
        private Label phone_number;
        private Label mail_label;
        private Label Patient_email;
        private Label label1;
        private Panel panel1;
        private ListView listView1;
        private Button View_Prescriptions;
        private Label label2;
        private Label label3;
        private Label Admin_ID;
        private Label pres_sum;
        private Label label6;
        private Label app_sum;
        private Label label4;
    }
}
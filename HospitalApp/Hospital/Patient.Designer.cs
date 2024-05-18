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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            pres_sum = new Label();
            label6 = new Label();
            app_sum = new Label();
            label4 = new Label();
            Admin_ID = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            View_Prescriptions = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Patient_name
            // 
            Patient_name.AutoSize = true;
            Patient_name.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Patient_name.Location = new Point(513, 49);
            Patient_name.Name = "Patient_name";
            Patient_name.Size = new Size(112, 34);
            Patient_name.TabIndex = 1;
            Patient_name.Text = "pname";
            // 
            // Make_appoint
            // 
            Make_appoint.BackColor = Color.GhostWhite;
            Make_appoint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Make_appoint.Location = new Point(27, 265);
            Make_appoint.Margin = new Padding(3, 4, 3, 4);
            Make_appoint.Name = "Make_appoint";
            Make_appoint.Size = new Size(143, 76);
            Make_appoint.TabIndex = 2;
            Make_appoint.Text = "Make appointment";
            Make_appoint.UseVisualStyleBackColor = false;
            Make_appoint.Click += Make_appoint_Click;
            // 
            // view_appoint
            // 
            view_appoint.BackColor = Color.GhostWhite;
            view_appoint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            view_appoint.Location = new Point(200, 265);
            view_appoint.Margin = new Padding(3, 4, 3, 4);
            view_appoint.Name = "view_appoint";
            view_appoint.Size = new Size(139, 76);
            view_appoint.TabIndex = 3;
            view_appoint.Text = "View appointments";
            view_appoint.UseVisualStyleBackColor = false;
            view_appoint.Click += view_appoint_Click;
            // 
            // Add_Medical_History
            // 
            Add_Medical_History.BackColor = Color.GhostWhite;
            Add_Medical_History.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Medical_History.Location = new Point(366, 265);
            Add_Medical_History.Margin = new Padding(3, 4, 3, 4);
            Add_Medical_History.Name = "Add_Medical_History";
            Add_Medical_History.Size = new Size(145, 76);
            Add_Medical_History.TabIndex = 4;
            Add_Medical_History.Text = "Add Medical History";
            Add_Medical_History.UseVisualStyleBackColor = false;
            Add_Medical_History.Click += Add_Medical_History_Click;
            // 
            // View_Medical_History
            // 
            View_Medical_History.BackColor = Color.GhostWhite;
            View_Medical_History.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            View_Medical_History.Location = new Point(539, 265);
            View_Medical_History.Margin = new Padding(3, 4, 3, 4);
            View_Medical_History.Name = "View_Medical_History";
            View_Medical_History.Size = new Size(158, 76);
            View_Medical_History.TabIndex = 5;
            View_Medical_History.Text = "View Medical History";
            View_Medical_History.UseVisualStyleBackColor = false;
            View_Medical_History.Click += View_Medical_History_Click;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AllowUserToResizeColumns = false;
            DataGrid.AllowUserToResizeRows = false;
            DataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGrid.BackgroundColor = Color.Peru;
            DataGrid.BorderStyle = BorderStyle.None;
            DataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            DataGrid.EnableHeadersVisualStyles = false;
            DataGrid.Location = new Point(12, 401);
            DataGrid.Margin = new Padding(3, 4, 3, 4);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersVisible = false;
            DataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(238, 239, 249);
            DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DataGrid.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGrid.Size = new Size(887, 168);
            DataGrid.TabIndex = 6;
            DataGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Phone_label
            // 
            Phone_label.AutoSize = true;
            Phone_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Phone_label.Location = new Point(3, 119);
            Phone_label.Name = "Phone_label";
            Phone_label.Size = new Size(202, 32);
            Phone_label.TabIndex = 7;
            Phone_label.Text = "Phone Number: ";
            // 
            // phone_number
            // 
            phone_number.AutoSize = true;
            phone_number.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phone_number.Location = new Point(194, 120);
            phone_number.Name = "phone_number";
            phone_number.Size = new Size(107, 31);
            phone_number.TabIndex = 8;
            phone_number.Text = "Pnumber";
            // 
            // mail_label
            // 
            mail_label.AutoSize = true;
            mail_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mail_label.Location = new Point(501, 119);
            mail_label.Name = "mail_label";
            mail_label.Size = new Size(90, 32);
            mail_label.TabIndex = 9;
            mail_label.Text = "email: ";
            mail_label.Click += mail_label_Click;
            // 
            // Patient_email
            // 
            Patient_email.AutoSize = true;
            Patient_email.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Patient_email.Location = new Point(584, 120);
            Patient_email.Name = "Patient_email";
            Patient_email.Size = new Size(71, 31);
            Patient_email.TabIndex = 10;
            Patient_email.Text = "Pmail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 33);
            label1.Name = "label1";
            label1.Size = new Size(194, 50);
            label1.TabIndex = 0;
            label1.Text = "Welcome,";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
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
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 189);
            panel1.TabIndex = 11;
            // 
            // pres_sum
            // 
            pres_sum.AutoSize = true;
            pres_sum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pres_sum.Location = new Point(764, 151);
            pres_sum.Name = "pres_sum";
            pres_sum.Size = new Size(61, 31);
            pres_sum.TabIndex = 16;
            pres_sum.Text = "total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label6.Location = new Point(501, 149);
            label6.Name = "label6";
            label6.Size = new Size(277, 32);
            label6.TabIndex = 15;
            label6.Text = "Total Prescriptions fees: ";
            // 
            // app_sum
            // 
            app_sum.AutoSize = true;
            app_sum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            app_sum.Location = new Point(281, 150);
            app_sum.Name = "app_sum";
            app_sum.Size = new Size(61, 31);
            app_sum.TabIndex = 14;
            app_sum.Text = "total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 150);
            label4.Name = "label4";
            label4.Size = new Size(289, 32);
            label4.TabIndex = 13;
            label4.Text = "Total appointments fees: ";
            // 
            // Admin_ID
            // 
            Admin_ID.AutoSize = true;
            Admin_ID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Admin_ID.Location = new Point(274, 87);
            Admin_ID.Name = "Admin_ID";
            Admin_ID.Size = new Size(68, 20);
            Admin_ID.TabIndex = 12;
            Admin_ID.Text = "AdminID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 83);
            label3.Name = "label3";
            label3.Size = new Size(179, 25);
            label3.TabIndex = 11;
            label3.Text = "Responsible admin: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Red_Simple_Medical_Health_Logo;
            pictureBox1.Location = new Point(-46, -61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Maroon;
            listView1.Location = new Point(-3, 187);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(925, 192);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // View_Prescriptions
            // 
            View_Prescriptions.BackColor = Color.GhostWhite;
            View_Prescriptions.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            View_Prescriptions.Location = new Point(734, 265);
            View_Prescriptions.Margin = new Padding(3, 4, 3, 4);
            View_Prescriptions.Name = "View_Prescriptions";
            View_Prescriptions.Size = new Size(153, 76);
            View_Prescriptions.TabIndex = 13;
            View_Prescriptions.Text = "View Prescriptions";
            View_Prescriptions.UseVisualStyleBackColor = false;
            View_Prescriptions.Click += View_Prescriptions_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Maroon;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(258, 215);
            label2.Name = "label2";
            label2.Size = new Size(408, 32);
            label2.TabIndex = 14;
            label2.Text = "What would You Like to do Today?";
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(914, 591);
            Controls.Add(label2);
            Controls.Add(View_Prescriptions);
            Controls.Add(DataGrid);
            Controls.Add(View_Medical_History);
            Controls.Add(Add_Medical_History);
            Controls.Add(view_appoint);
            Controls.Add(Make_appoint);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Patient";
            Text = "Form2";
            Load += Patient_Load;
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}
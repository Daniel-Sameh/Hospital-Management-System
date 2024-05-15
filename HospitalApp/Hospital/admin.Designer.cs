namespace Hospital
{
    partial class admin
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
            label1 = new Label();
            adminName = new Label();
            panelOnlyDisplay = new Panel();
            pictureBox1 = new PictureBox();
            addSubmitbutton = new Button();
            numericUpDownPhone = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            phonelabel = new Label();
            gendercomboBox = new ComboBox();
            genderlabel = new Label();
            lastnametextBox = new TextBox();
            lastnamelabel = new Label();
            firstnametextBox = new TextBox();
            firstnameLabel = new Label();
            textBoxPass = new TextBox();
            passLabel = new Label();
            textBoxEmail = new TextBox();
            emailLabel = new Label();
            idLabel = new Label();
            numericUpDown2 = new NumericUpDown();
            button2 = new Button();
            addPatientbutton = new Button();
            logoutlinkLabel = new LinkLabel();
            button1 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView1 = new DataGridView();
            panelOnlyDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(147, 60);
            label1.Name = "label1";
            label1.Size = new Size(111, 37);
            label1.TabIndex = 0;
            label1.Text = "Admin:";
            label1.Click += label1_Click;
            // 
            // adminName
            // 
            adminName.AutoSize = true;
            adminName.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminName.ForeColor = Color.AliceBlue;
            adminName.Location = new Point(250, 69);
            adminName.Name = "adminName";
            adminName.Size = new Size(72, 28);
            adminName.TabIndex = 1;
            adminName.Text = "Null";
            adminName.UseWaitCursor = true;
            // 
            // panelOnlyDisplay
            // 
            panelOnlyDisplay.BackColor = Color.Maroon;
            panelOnlyDisplay.BorderStyle = BorderStyle.FixedSingle;
            panelOnlyDisplay.Controls.Add(pictureBox1);
            panelOnlyDisplay.Controls.Add(addSubmitbutton);
            panelOnlyDisplay.Controls.Add(numericUpDownPhone);
            panelOnlyDisplay.Controls.Add(dateTimePicker1);
            panelOnlyDisplay.Controls.Add(label9);
            panelOnlyDisplay.Controls.Add(phonelabel);
            panelOnlyDisplay.Controls.Add(gendercomboBox);
            panelOnlyDisplay.Controls.Add(genderlabel);
            panelOnlyDisplay.Controls.Add(lastnametextBox);
            panelOnlyDisplay.Controls.Add(lastnamelabel);
            panelOnlyDisplay.Controls.Add(firstnametextBox);
            panelOnlyDisplay.Controls.Add(firstnameLabel);
            panelOnlyDisplay.Controls.Add(textBoxPass);
            panelOnlyDisplay.Controls.Add(passLabel);
            panelOnlyDisplay.Controls.Add(textBoxEmail);
            panelOnlyDisplay.Controls.Add(emailLabel);
            panelOnlyDisplay.Controls.Add(idLabel);
            panelOnlyDisplay.Controls.Add(numericUpDown2);
            panelOnlyDisplay.Controls.Add(button2);
            panelOnlyDisplay.Controls.Add(addPatientbutton);
            panelOnlyDisplay.Controls.Add(logoutlinkLabel);
            panelOnlyDisplay.Controls.Add(button1);
            panelOnlyDisplay.Controls.Add(label1);
            panelOnlyDisplay.Controls.Add(adminName);
            panelOnlyDisplay.Location = new Point(-3, 0);
            panelOnlyDisplay.Name = "panelOnlyDisplay";
            panelOnlyDisplay.Size = new Size(933, 154);
            panelOnlyDisplay.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Red_Simple_Medical_Health_Logo__2_;
            pictureBox1.Location = new Point(3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // addSubmitbutton
            // 
            addSubmitbutton.Location = new Point(394, 375);
            addSubmitbutton.Name = "addSubmitbutton";
            addSubmitbutton.Size = new Size(94, 29);
            addSubmitbutton.TabIndex = 58;
            addSubmitbutton.Text = "Submit";
            addSubmitbutton.UseVisualStyleBackColor = true;
            addSubmitbutton.Click += addSubmitbutton_Click;
            // 
            // numericUpDownPhone
            // 
            numericUpDownPhone.Location = new Point(613, 263);
            numericUpDownPhone.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numericUpDownPhone.Name = "numericUpDownPhone";
            numericUpDownPhone.Size = new Size(201, 27);
            numericUpDownPhone.TabIndex = 57;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(613, 302);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.AliceBlue;
            label9.Location = new Point(480, 298);
            label9.Name = "label9";
            label9.Size = new Size(124, 31);
            label9.TabIndex = 55;
            label9.Text = "BirthDate: ";
            // 
            // phonelabel
            // 
            phonelabel.AutoSize = true;
            phonelabel.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phonelabel.ForeColor = Color.AliceBlue;
            phonelabel.Location = new Point(480, 256);
            phonelabel.Name = "phonelabel";
            phonelabel.Size = new Size(89, 31);
            phonelabel.TabIndex = 54;
            phonelabel.Text = "Phone: ";
            // 
            // gendercomboBox
            // 
            gendercomboBox.FormattingEnabled = true;
            gendercomboBox.Items.AddRange(new object[] { "Male", "Female" });
            gendercomboBox.Location = new Point(147, 298);
            gendercomboBox.Name = "gendercomboBox";
            gendercomboBox.Size = new Size(201, 28);
            gendercomboBox.TabIndex = 53;
            // 
            // genderlabel
            // 
            genderlabel.AutoSize = true;
            genderlabel.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genderlabel.ForeColor = Color.AliceBlue;
            genderlabel.Location = new Point(14, 292);
            genderlabel.Name = "genderlabel";
            genderlabel.Size = new Size(95, 31);
            genderlabel.TabIndex = 52;
            genderlabel.Text = "Gender:";
            // 
            // lastnametextBox
            // 
            lastnametextBox.Location = new Point(147, 256);
            lastnametextBox.Name = "lastnametextBox";
            lastnametextBox.Size = new Size(201, 27);
            lastnametextBox.TabIndex = 51;
            // 
            // lastnamelabel
            // 
            lastnamelabel.AutoSize = true;
            lastnamelabel.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastnamelabel.ForeColor = Color.AliceBlue;
            lastnamelabel.Location = new Point(14, 247);
            lastnamelabel.Name = "lastnamelabel";
            lastnamelabel.Size = new Size(133, 31);
            lastnamelabel.TabIndex = 50;
            lastnamelabel.Text = "Last Name: ";
            // 
            // firstnametextBox
            // 
            firstnametextBox.Location = new Point(147, 217);
            firstnametextBox.Name = "firstnametextBox";
            firstnametextBox.Size = new Size(201, 27);
            firstnametextBox.TabIndex = 49;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstnameLabel.ForeColor = Color.AliceBlue;
            firstnameLabel.Location = new Point(14, 213);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(136, 31);
            firstnameLabel.TabIndex = 48;
            firstnameLabel.Text = "First Name: ";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(602, 217);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(203, 27);
            textBoxPass.TabIndex = 47;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passLabel.ForeColor = Color.AliceBlue;
            passLabel.Location = new Point(480, 217);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(120, 31);
            passLabel.TabIndex = 46;
            passLabel.Text = "Password:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(602, 178);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(203, 27);
            textBoxEmail.TabIndex = 45;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Variable Display Semib", 13F, FontStyle.Bold);
            emailLabel.ForeColor = Color.AliceBlue;
            emailLabel.Location = new Point(480, 175);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(71, 30);
            emailLabel.TabIndex = 44;
            emailLabel.Text = "Email:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idLabel.ForeColor = Color.AliceBlue;
            idLabel.Location = new Point(14, 171);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(124, 31);
            idLabel.TabIndex = 38;
            idLabel.Text = "Patient ID: ";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(156, 175);
            numericUpDown2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 37;
            // 
            // button2
            // 
            button2.Location = new Point(661, 60);
            button2.Name = "button2";
            button2.Size = new Size(134, 36);
            button2.TabIndex = 5;
            button2.Text = "Show All Patients";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // addPatientbutton
            // 
            addPatientbutton.Location = new Point(801, 60);
            addPatientbutton.Name = "addPatientbutton";
            addPatientbutton.Size = new Size(118, 36);
            addPatientbutton.TabIndex = 3;
            addPatientbutton.Text = "Add Patient";
            addPatientbutton.UseVisualStyleBackColor = true;
            addPatientbutton.Click += addPatientbutton_Click;
            // 
            // logoutlinkLabel
            // 
            logoutlinkLabel.AutoSize = true;
            logoutlinkLabel.LinkColor = Color.FromArgb(128, 255, 128);
            logoutlinkLabel.Location = new Point(838, 8);
            logoutlinkLabel.Name = "logoutlinkLabel";
            logoutlinkLabel.Size = new Size(53, 20);
            logoutlinkLabel.TabIndex = 3;
            logoutlinkLabel.TabStop = true;
            logoutlinkLabel.Text = "logout";
            logoutlinkLabel.LinkClicked += logoutlinkLabel_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(490, 60);
            button1.Name = "button1";
            button1.Size = new Size(165, 36);
            button1.TabIndex = 4;
            button1.Text = "Show Added Patients";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Firebrick;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(-3, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Firebrick;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.AliceBlue;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(933, 297);
            dataGridView1.TabIndex = 3;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(929, 450);
            Controls.Add(panelOnlyDisplay);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "admin";
            Text = "admin";
            Load += admin_Load;
            panelOnlyDisplay.ResumeLayout(false);
            panelOnlyDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label adminName;
        private Panel panelOnlyDisplay;
        private Button addPatientbutton;
        private Button button2;
        private Button button1;
        private LinkLabel logoutlinkLabel;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown2;
        private Label idLabel;
        private Button addSubmitbutton;
        private NumericUpDown numericUpDownPhone;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Label phonelabel;
        private ComboBox gendercomboBox;
        private Label genderlabel;
        private TextBox lastnametextBox;
        private Label lastnamelabel;
        private TextBox firstnametextBox;
        private Label firstnameLabel;
        private TextBox textBoxPass;
        private Label passLabel;
        private TextBox textBoxEmail;
        private Label emailLabel;
        private PictureBox pictureBox1;
    }
}
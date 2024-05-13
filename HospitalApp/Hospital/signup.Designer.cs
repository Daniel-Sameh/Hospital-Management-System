namespace Hospital
{
    partial class signup
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBoxPass = new TextBox();
            passLabel = new Label();
            textBoxEmail = new TextBox();
            emailLabel = new Label();
            firstnametextBox = new TextBox();
            firstnameLabel = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            lastnametextBox = new TextBox();
            lastnamelabel = new Label();
            genderlabel = new Label();
            gendercomboBox = new ComboBox();
            phonelabel = new Label();
            alertlabel = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            label10 = new Label();
            salarylabel = new Label();
            numericUpDown2 = new NumericUpDown();
            label11 = new Label();
            toolTip1 = new ToolTip(components);
            label12 = new Label();
            specialitytextBox = new TextBox();
            specialitylabel = new Label();
            label13 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericUpDownPhone = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPhone).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(325, 115);
            label2.Name = "label2";
            label2.Size = new Size(105, 34);
            label2.TabIndex = 4;
            label2.Text = "SignUp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(208, 33);
            label1.Name = "label1";
            label1.Size = new Size(379, 69);
            label1.TabIndex = 3;
            label1.Text = "Heal Hospital";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(414, 477);
            button1.Name = "button1";
            button1.Size = new Size(137, 48);
            button1.TabIndex = 12;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(587, 238);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(201, 27);
            textBoxPass.TabIndex = 11;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passLabel.Location = new Point(463, 238);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(120, 31);
            passLabel.TabIndex = 10;
            passLabel.Text = "Password:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(585, 202);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(203, 27);
            textBoxEmail.TabIndex = 9;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Variable Display Semib", 13F, FontStyle.Bold);
            emailLabel.Location = new Point(463, 199);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(71, 30);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // firstnametextBox
            // 
            firstnametextBox.Location = new Point(145, 199);
            firstnametextBox.Name = "firstnametextBox";
            firstnametextBox.Size = new Size(201, 27);
            firstnametextBox.TabIndex = 14;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstnameLabel.Location = new Point(12, 195);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(136, 31);
            firstnameLabel.TabIndex = 13;
            firstnameLabel.Text = "First Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(446, 120);
            label4.Name = "label4";
            label4.Size = new Size(30, 26);
            label4.TabIndex = 15;
            label4.Text = "as";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Patient", "Admin", "Doctor", "Nurse" });
            comboBox1.Location = new Point(497, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Red_Simple_Medical_Health_Logo;
            pictureBox1.Location = new Point(156, -110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 375);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lastnametextBox
            // 
            lastnametextBox.Location = new Point(145, 238);
            lastnametextBox.Name = "lastnametextBox";
            lastnametextBox.Size = new Size(201, 27);
            lastnametextBox.TabIndex = 19;
            // 
            // lastnamelabel
            // 
            lastnamelabel.AutoSize = true;
            lastnamelabel.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastnamelabel.Location = new Point(12, 229);
            lastnamelabel.Name = "lastnamelabel";
            lastnamelabel.Size = new Size(133, 31);
            lastnamelabel.TabIndex = 18;
            lastnamelabel.Text = "Last Name: ";
            // 
            // genderlabel
            // 
            genderlabel.AutoSize = true;
            genderlabel.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genderlabel.Location = new Point(12, 284);
            genderlabel.Name = "genderlabel";
            genderlabel.Size = new Size(95, 31);
            genderlabel.TabIndex = 20;
            genderlabel.Text = "Gender:";
            // 
            // gendercomboBox
            // 
            gendercomboBox.FormattingEnabled = true;
            gendercomboBox.Items.AddRange(new object[] { "Male", "Female" });
            gendercomboBox.Location = new Point(145, 290);
            gendercomboBox.Name = "gendercomboBox";
            gendercomboBox.Size = new Size(201, 28);
            gendercomboBox.TabIndex = 21;
            // 
            // phonelabel
            // 
            phonelabel.AutoSize = true;
            phonelabel.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phonelabel.Location = new Point(12, 330);
            phonelabel.Name = "phonelabel";
            phonelabel.Size = new Size(89, 31);
            phonelabel.TabIndex = 22;
            phonelabel.Text = "Phone: ";
            // 
            // alertlabel
            // 
            alertlabel.AutoSize = true;
            alertlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alertlabel.ForeColor = Color.Red;
            alertlabel.Location = new Point(123, 186);
            alertlabel.Name = "alertlabel";
            alertlabel.Size = new Size(16, 20);
            alertlabel.TabIndex = 24;
            alertlabel.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(529, 195);
            label3.Name = "label3";
            label3.Size = new Size(16, 20);
            label3.TabIndex = 25;
            label3.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(571, 229);
            label5.Name = "label5";
            label5.Size = new Size(16, 20);
            label5.TabIndex = 26;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(102, 284);
            label6.Name = "label6";
            label6.Size = new Size(16, 20);
            label6.TabIndex = 27;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(91, 330);
            label7.Name = "label7";
            label7.Size = new Size(16, 20);
            label7.TabIndex = 28;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(123, 382);
            label8.Name = "label8";
            label8.Size = new Size(16, 20);
            label8.TabIndex = 31;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 388);
            label9.Name = "label9";
            label9.Size = new Size(124, 31);
            label9.TabIndex = 29;
            label9.Text = "BirthDate: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(145, 392);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 32;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(587, 288);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(199, 27);
            numericUpDown1.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(542, 284);
            label10.Name = "label10";
            label10.Size = new Size(16, 20);
            label10.TabIndex = 35;
            label10.Text = "*";
            // 
            // salarylabel
            // 
            salarylabel.AutoSize = true;
            salarylabel.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salarylabel.Location = new Point(463, 284);
            salarylabel.Name = "salarylabel";
            salarylabel.Size = new Size(88, 31);
            salarylabel.TabIndex = 34;
            salarylabel.Text = "Salary: ";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(792, 121);
            numericUpDown2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 36;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(654, 122);
            label11.Name = "label11";
            label11.Size = new Size(132, 26);
            label11.TabIndex = 37;
            label11.Text = "with user ID:";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "you should enter a unique id";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(573, 330);
            label12.Name = "label12";
            label12.Size = new Size(16, 20);
            label12.TabIndex = 40;
            label12.Text = "*";
            // 
            // specialitytextBox
            // 
            specialitytextBox.Location = new Point(587, 345);
            specialitytextBox.Name = "specialitytextBox";
            specialitytextBox.Size = new Size(201, 27);
            specialitytextBox.TabIndex = 39;
            // 
            // specialitylabel
            // 
            specialitylabel.AutoSize = true;
            specialitylabel.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            specialitylabel.Location = new Point(463, 339);
            specialitylabel.Name = "specialitylabel";
            specialitylabel.Size = new Size(126, 31);
            specialitylabel.TabIndex = 38;
            specialitylabel.Text = "Speciality: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(463, 341);
            label13.Name = "label13";
            label13.Size = new Size(182, 31);
            label13.TabIndex = 41;
            label13.Text = "Working Hours: ";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(654, 348);
            numericUpDown3.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(134, 27);
            numericUpDown3.TabIndex = 42;
            // 
            // numericUpDownPhone
            // 
            numericUpDownPhone.Location = new Point(145, 337);
            numericUpDownPhone.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numericUpDownPhone.Name = "numericUpDownPhone";
            numericUpDownPhone.Size = new Size(201, 27);
            numericUpDownPhone.TabIndex = 43;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1065, 584);
            Controls.Add(numericUpDownPhone);
            Controls.Add(numericUpDown3);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(specialitytextBox);
            Controls.Add(specialitylabel);
            Controls.Add(label11);
            Controls.Add(numericUpDown2);
            Controls.Add(label10);
            Controls.Add(salarylabel);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(alertlabel);
            Controls.Add(phonelabel);
            Controls.Add(gendercomboBox);
            Controls.Add(genderlabel);
            Controls.Add(lastnametextBox);
            Controls.Add(lastnamelabel);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(firstnametextBox);
            Controls.Add(firstnameLabel);
            Controls.Add(button1);
            Controls.Add(textBoxPass);
            Controls.Add(passLabel);
            Controls.Add(textBoxEmail);
            Controls.Add(emailLabel);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "signup";
            Text = "signup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPhone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBoxPass;
        private Label passLabel;
        private TextBox textBoxEmail;
        private Label emailLabel;
        private TextBox firstnametextBox;
        private Label firstnameLabel;
        private Label label4;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private TextBox lastnametextBox;
        private Label lastnamelabel;
        private Label genderlabel;
        private ComboBox gendercomboBox;
        private Label phonelabel;
        private Label alertlabel;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private Label label10;
        private Label salarylabel;
        private NumericUpDown numericUpDown2;
        private Label label11;
        private ToolTip toolTip1;
        private Label label12;
        private TextBox specialitytextBox;
        private Label specialitylabel;
        private Label label13;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDownPhone;
    }
}
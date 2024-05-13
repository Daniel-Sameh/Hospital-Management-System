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
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBoxPass = new TextBox();
            passLabel = new Label();
            textBoxEmail = new TextBox();
            emailLabel = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(339, 114);
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
            button1.Location = new Point(339, 370);
            button1.Name = "button1";
            button1.Size = new Size(137, 34);
            button1.TabIndex = 12;
            button1.Text = "enter";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(556, 199);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(201, 27);
            textBoxPass.TabIndex = 11;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passLabel.Location = new Point(432, 199);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(114, 31);
            passLabel.TabIndex = 10;
            passLabel.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(156, 283);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(201, 27);
            textBoxEmail.TabIndex = 9;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(32, 279);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(70, 31);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 193);
            label3.Name = "label3";
            label3.Size = new Size(70, 31);
            label3.TabIndex = 13;
            label3.Text = "Email";
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
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBoxPass);
            Controls.Add(passLabel);
            Controls.Add(textBoxEmail);
            Controls.Add(emailLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signup";
            Text = "signup";
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
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
    }
}
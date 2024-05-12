namespace Hospital
{
    partial class login
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
            emailLabel = new Label();
            textBoxEmail = new TextBox();
            textBoxPass = new TextBox();
            passLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 33);
            label1.Name = "label1";
            label1.Size = new Size(379, 69);
            label1.TabIndex = 1;
            label1.Text = "Heal Hospital";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(339, 123);
            label2.Name = "label2";
            label2.Size = new Size(88, 34);
            label2.TabIndex = 2;
            label2.Text = "LogIn";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(215, 208);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(70, 31);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(339, 212);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(201, 27);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(339, 272);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(201, 27);
            textBoxPass.TabIndex = 6;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passLabel.Location = new Point(215, 272);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(114, 31);
            passLabel.TabIndex = 5;
            passLabel.Text = "Password";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(339, 339);
            button1.Name = "button1";
            button1.Size = new Size(137, 34);
            button1.TabIndex = 7;
            button1.Text = "enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxPass);
            Controls.Add(passLabel);
            Controls.Add(textBoxEmail);
            Controls.Add(emailLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label emailLabel;
        private TextBox textBoxEmail;
        private TextBox textBoxPass;
        private Label passLabel;
        private Button button1;
    }
}
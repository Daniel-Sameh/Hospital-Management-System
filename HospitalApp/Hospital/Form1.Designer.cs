﻿namespace Hospital
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            open = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            reportlinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(243, 51);
            label1.Name = "label1";
            label1.Size = new Size(379, 69);
            label1.TabIndex = 0;
            label1.Text = "Heal Hospital";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(369, 134);
            label2.Name = "label2";
            label2.Size = new Size(141, 34);
            label2.TabIndex = 1;
            label2.Text = "Welcome";
            // 
            // open
            // 
            open.BackColor = Color.MediumBlue;
            open.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            open.ForeColor = SystemColors.ButtonHighlight;
            open.Location = new Point(295, 216);
            open.Name = "open";
            open.Size = new Size(215, 76);
            open.TabIndex = 2;
            open.Text = "Login";
            open.UseVisualStyleBackColor = false;
            open.Click += open_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(295, 330);
            label3.Name = "label3";
            label3.Size = new Size(228, 26);
            label3.TabIndex = 3;
            label3.Text = "Don't have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.RoyalBlue;
            linkLabel1.Location = new Point(436, 367);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 23);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Signup";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Red_Simple_Medical_Health_Logo;
            pictureBox1.Location = new Point(201, -92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 375);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // reportlinkLabel
            // 
            reportlinkLabel.AutoSize = true;
            reportlinkLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportlinkLabel.LinkColor = Color.RoyalBlue;
            reportlinkLabel.Location = new Point(12, 418);
            reportlinkLabel.Name = "reportlinkLabel";
            reportlinkLabel.Size = new Size(137, 23);
            reportlinkLabel.TabIndex = 6;
            reportlinkLabel.TabStop = true;
            reportlinkLabel.Text = "Generate Report";
            reportlinkLabel.LinkClicked += reportlinkLabel_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(reportlinkLabel);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(open);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Heal Hospital";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button open;
        private Label label3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private LinkLabel reportlinkLabel;
    }
}

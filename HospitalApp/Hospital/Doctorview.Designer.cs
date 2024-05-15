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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            DoctorName = new Label();
            Speciality = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.SaddleBrown;
            flowLayoutPanel1.Location = new Point(303, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(502, 451);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 1;
            label1.Text = "Hello Dr.";
            label1.Click += label1_Click;
            // 
            // DoctorName
            // 
            DoctorName.AutoSize = true;
            DoctorName.Font = new Font("Segoe UI", 18F);
            DoctorName.Location = new Point(113, 9);
            DoctorName.Name = "DoctorName";
            DoctorName.Size = new Size(146, 32);
            DoctorName.TabIndex = 0;
            DoctorName.Text = "Doctorname";
            DoctorName.TextAlign = ContentAlignment.BottomLeft;
            DoctorName.Click += DoctorName_Click;
            // 
            // Speciality
            // 
            Speciality.AutoSize = true;
            Speciality.Font = new Font("Segoe UI", 18F);
            Speciality.Location = new Point(12, 64);
            Speciality.Name = "Speciality";
            Speciality.Size = new Size(115, 32);
            Speciality.TabIndex = 0;
            Speciality.Text = "Speciality";
            Speciality.Click += Speciality_Click;
            // 
            // Doctorview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(Speciality);
            Controls.Add(DoctorName);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "Doctorview";
            Text = "Doctorview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label DoctorName;
        private Label Speciality;
    }
}
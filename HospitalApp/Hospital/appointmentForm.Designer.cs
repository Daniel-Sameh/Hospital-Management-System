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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(389, 41);
            label1.TabIndex = 0;
            label1.Text = "Appointment Reservation:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(112, 38);
            label2.TabIndex = 1;
            label2.Text = "Patient:";
            // 
            // patientlabel
            // 
            patientlabel.AutoSize = true;
            patientlabel.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientlabel.Location = new Point(117, 84);
            patientlabel.Name = "patientlabel";
            patientlabel.Size = new Size(65, 30);
            patientlabel.TabIndex = 2;
            patientlabel.Text = "Null";
            // 
            // appointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(patientlabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "appointmentForm";
            Text = "appointmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label patientlabel;
    }
}
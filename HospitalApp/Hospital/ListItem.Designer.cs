namespace Hospital
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Dateandtimelabel = new Label();
            PatientName = new Label();
            makeprescriptionbutton = new Button();
            mediaclbutton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Dateandtimelabel
            // 
            Dateandtimelabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dateandtimelabel.Location = new Point(3, 71);
            Dateandtimelabel.Name = "Dateandtimelabel";
            Dateandtimelabel.Size = new Size(557, 52);
            Dateandtimelabel.TabIndex = 0;
            Dateandtimelabel.Text = "DateandTime";
            // 
            // PatientName
            // 
            PatientName.AutoSize = true;
            PatientName.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientName.Location = new Point(3, 33);
            PatientName.Name = "PatientName";
            PatientName.RightToLeft = RightToLeft.No;
            PatientName.Size = new Size(181, 38);
            PatientName.TabIndex = 1;
            PatientName.Text = "PatientName";
            // 
            // makeprescriptionbutton
            // 
            makeprescriptionbutton.BackColor = Color.FromArgb(0, 0, 64);
            makeprescriptionbutton.Font = new Font("Segoe UI Symbol", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makeprescriptionbutton.ForeColor = SystemColors.ButtonHighlight;
            makeprescriptionbutton.Location = new Point(370, 44);
            makeprescriptionbutton.Margin = new Padding(3, 4, 3, 4);
            makeprescriptionbutton.Name = "makeprescriptionbutton";
            makeprescriptionbutton.Size = new Size(151, 46);
            makeprescriptionbutton.TabIndex = 2;
            makeprescriptionbutton.Text = "MakePrescription";
            makeprescriptionbutton.UseVisualStyleBackColor = false;
            makeprescriptionbutton.Click += makeprescription_Click;
            // 
            // mediaclbutton
            // 
            mediaclbutton.BackColor = Color.FromArgb(0, 0, 64);
            mediaclbutton.Font = new Font("Segoe UI Symbol", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mediaclbutton.ForeColor = SystemColors.ButtonHighlight;
            mediaclbutton.Location = new Point(221, 44);
            mediaclbutton.Margin = new Padding(3, 4, 3, 4);
            mediaclbutton.Name = "mediaclbutton";
            mediaclbutton.Size = new Size(143, 46);
            mediaclbutton.TabIndex = 3;
            mediaclbutton.Text = "Medical History";
            mediaclbutton.UseVisualStyleBackColor = false;
            mediaclbutton.Click += mediaclbutton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(538, 49);
            button1.Name = "button1";
            button1.Size = new Size(57, 37);
            button1.TabIndex = 4;
            button1.Text = "done";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ListItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(button1);
            Controls.Add(mediaclbutton);
            Controls.Add(makeprescriptionbutton);
            Controls.Add(PatientName);
            Controls.Add(Dateandtimelabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListItem";
            Size = new Size(600, 140);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Dateandtimelabel;
        private Label PatientName;
        private Button makeprescriptionbutton;
        private Button mediaclbutton;
        private Button button1;
    }
}

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
            label1 = new Label();
            adminName = new Label();
            panelOnlyDisplay = new Panel();
            addPatientbutton = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            logoutlinkLabel = new LinkLabel();
            panelOnlyDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(14, 40);
            label1.Name = "label1";
            label1.Size = new Size(118, 40);
            label1.TabIndex = 0;
            label1.Text = "Admin:";
            label1.Click += label1_Click;
            // 
            // adminName
            // 
            adminName.AutoSize = true;
            adminName.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminName.ForeColor = Color.AliceBlue;
            adminName.Location = new Point(14, 97);
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
            panelOnlyDisplay.Controls.Add(logoutlinkLabel);
            panelOnlyDisplay.Controls.Add(panel1);
            panelOnlyDisplay.Controls.Add(button2);
            panelOnlyDisplay.Controls.Add(button1);
            panelOnlyDisplay.Controls.Add(addPatientbutton);
            panelOnlyDisplay.Controls.Add(label1);
            panelOnlyDisplay.Controls.Add(adminName);
            panelOnlyDisplay.Location = new Point(-3, 0);
            panelOnlyDisplay.Name = "panelOnlyDisplay";
            panelOnlyDisplay.Size = new Size(256, 451);
            panelOnlyDisplay.TabIndex = 2;
            // 
            // addPatientbutton
            // 
            addPatientbutton.Location = new Point(14, 151);
            addPatientbutton.Name = "addPatientbutton";
            addPatientbutton.Size = new Size(118, 36);
            addPatientbutton.TabIndex = 3;
            addPatientbutton.Text = "Add Patient";
            addPatientbutton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(39, 227);
            button1.Name = "button1";
            button1.Size = new Size(165, 36);
            button1.TabIndex = 4;
            button1.Text = "Show Added Patients";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(112, 302);
            button2.Name = "button2";
            button2.Size = new Size(134, 36);
            button2.TabIndex = 5;
            button2.Text = "Show All Patients";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(252, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 451);
            panel1.TabIndex = 3;
            // 
            // logoutlinkLabel
            // 
            logoutlinkLabel.AutoSize = true;
            logoutlinkLabel.LinkColor = Color.FromArgb(128, 255, 128);
            logoutlinkLabel.Location = new Point(90, 393);
            logoutlinkLabel.Name = "logoutlinkLabel";
            logoutlinkLabel.Size = new Size(53, 20);
            logoutlinkLabel.TabIndex = 3;
            logoutlinkLabel.TabStop = true;
            logoutlinkLabel.Text = "logout";
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panelOnlyDisplay);
            Name = "admin";
            Text = "admin";
            Load += admin_Load;
            panelOnlyDisplay.ResumeLayout(false);
            panelOnlyDisplay.PerformLayout();
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
        private Panel panel1;
    }
}
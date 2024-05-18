namespace Hospital
{
    partial class report
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            dataGridViewSpeciality = new DataGridView();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpeciality).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.report__1_;
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 22);
            label1.Name = "label1";
            label1.Size = new Size(417, 49);
            label1.TabIndex = 1;
            label1.Text = "Heal Hospital Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 121);
            label2.Name = "label2";
            label2.Size = new Size(223, 27);
            label2.TabIndex = 2;
            label2.Text = "- Hospital Income: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label3.Location = new Point(22, 162);
            label3.Name = "label3";
            label3.Size = new Size(320, 27);
            label3.TabIndex = 3;
            label3.Text = "- Number of Appointments: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label4.Location = new Point(22, 200);
            label4.Name = "label4";
            label4.Size = new Size(387, 27);
            label4.TabIndex = 4;
            label4.Text = "- Appointments in the last month: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(127, 71);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label6.Location = new Point(140, 509);
            label6.Name = "label6";
            label6.Size = new Size(291, 27);
            label6.TabIndex = 6;
            label6.Text = "Top 10 most paid doctors";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.LightSteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(22, 549);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.Size = new Size(556, 219);
            dataGridView1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label7.Location = new Point(115, 264);
            label7.Name = "label7";
            label7.Size = new Size(340, 27);
            label7.TabIndex = 8;
            label7.Text = "Frequent Hospital Specialities";
            // 
            // dataGridViewSpeciality
            // 
            dataGridViewSpeciality.AllowUserToAddRows = false;
            dataGridViewSpeciality.AllowUserToDeleteRows = false;
            dataGridViewSpeciality.AllowUserToResizeColumns = false;
            dataGridViewSpeciality.AllowUserToResizeRows = false;
            dataGridViewSpeciality.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewSpeciality.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewSpeciality.BackgroundColor = Color.LightSteelBlue;
            dataGridViewSpeciality.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSpeciality.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewSpeciality.EnableHeadersVisualStyles = false;
            dataGridViewSpeciality.GridColor = SystemColors.HotTrack;
            dataGridViewSpeciality.ImeMode = ImeMode.NoControl;
            dataGridViewSpeciality.Location = new Point(22, 303);
            dataGridViewSpeciality.MultiSelect = false;
            dataGridViewSpeciality.Name = "dataGridViewSpeciality";
            dataGridViewSpeciality.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSpeciality.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSpeciality.RowHeadersVisible = false;
            dataGridViewSpeciality.RowHeadersWidth = 51;
            dataGridViewSpeciality.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSpeciality.RowTemplate.ReadOnly = true;
            dataGridViewSpeciality.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewSpeciality.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewSpeciality.ShowCellErrors = false;
            dataGridViewSpeciality.ShowCellToolTips = false;
            dataGridViewSpeciality.ShowEditingIcon = false;
            dataGridViewSpeciality.ShowRowErrors = false;
            dataGridViewSpeciality.Size = new Size(556, 174);
            dataGridViewSpeciality.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label8.Location = new Point(140, 814);
            label8.Name = "label8";
            label8.Size = new Size(300, 27);
            label8.TabIndex = 10;
            label8.Text = "Top 5 Customers(Patients)";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = Color.LightSteelBlue;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(22, 855);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.RowTemplate.ReadOnly = true;
            dataGridView2.Size = new Size(556, 219);
            dataGridView2.TabIndex = 11;
            // 
            // report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(590, 502);
            Controls.Add(dataGridView2);
            Controls.Add(label8);
            Controls.Add(dataGridViewSpeciality);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "report";
            Text = "Heal Hospital Report";
            Load += report_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpeciality).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Label label7;
        private DataGridView dataGridViewSpeciality;
        private Label label8;
        private DataGridView dataGridView2;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using System.Timers;
using System.Threading.Tasks;

namespace Hospital
{
    public partial class admin : Form
    {
        private decimal id;
        private string fname;
        private string lname;
        private string gender;
        private decimal phone;
        private string email;
        private string password;
        private int salary;
        private bool bOk;

        public admin(decimal id, string fName, string lName, string gender, decimal phone, string email, string password, int salary)
        {

            InitializeComponent();
            adminName.Text = fName + " " + lName;
            this.id = id;
            this.fname = fName;
            this.lname = lName;
            this.gender = gender;
            this.phone = phone;
            this.email = email;
            this.password = password;
            this.salary = salary;

            this.bOk = false;

        }

        private void admin_Load(object sender, EventArgs e)
        {
            //dataGridView = new DataGridView();
            //dataGridView1.Dock = DockStyle.Fill;

        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dataGridView1.Columns["Add Appointment"].Index && e.RowIndex >= 0)
            {
                // Retrieve the data for the selected row
                DataRow selectedRow = ((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem).Row;
                int patientID = Convert.ToInt32(selectedRow["pId"]);
                string name = (string)selectedRow["name"];
                //Appointment To be implemented
                appointmentForm a= new appointmentForm(patientID,name);
                
                a.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoutlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panelOnlyDisplay.Height == 497)
            {
                elapsePanel();
            }
            //this.Controls.Add(dataGridView1);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            //dataGridView1.Dock = DockStyle.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add a button column to the DataGridView
            if (!bOk)
            {
                DataGridViewButtonColumn appointmentButton = new DataGridViewButtonColumn();
                appointmentButton.Name = "Add Appointment";
                appointmentButton.Text = "Add Appointment";
                appointmentButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(appointmentButton);
                bOk = true;
                dataGridView1.CellClick += DataGridView1_CellClick;
            }

            string connectionString = "Data Source =DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=true";
            string query = "SELECT pId as pId, firstname+' '+lastname as name,birthdate as BirthDay, pGender as Gender, pPhone as Phone FROM Patient";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["pId"].Visible = false;
                //dataGridView1.Columns["pId"].Width = 0;
                dataGridView1.AutoResizeColumns();
                //dataGridView1.Dock = DockStyle.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelOnlyDisplay.Height == 497)
            {
                elapsePanel();
            }
            //this.Controls.Add(dataGridView1);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            //dataGridView1.Dock = DockStyle.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add a button column to the DataGridView
            if (!bOk)
            {
                DataGridViewButtonColumn appointmentButton = new DataGridViewButtonColumn();
                appointmentButton.Name = "Add Appointment";
                appointmentButton.Text = "Add Appointment";
                appointmentButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(appointmentButton);
                bOk = true;
                dataGridView1.CellClick += DataGridView1_CellClick;
            }

            string connectionString = "Data Source =DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=true";
            string query = $"SELECT pId as pId,firstname+' '+lastname as name,birthdate as BirthDay, pGender as Gender, pPhone as Phone FROM Patient where eId={id}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["pId"].Visible = false;
                //dataGridView1.Columns["pId"].Width = 0;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();
                //dataGridView1.Dock = DockStyle.Fill;
            }
        }

        private async void elapsePanel()
        {
            int originalHeight = panelOnlyDisplay.Height;
            int targetHeight = originalHeight == 154 ? 497 : 154;
            //MessageBox.Show(targetHeight.ToString());
            int duration = 500;
            int steps = 50; // Number of animation steps

            // Calculate step size
            int stepSize = (targetHeight - originalHeight) / steps;

            // Animate the change in size
            for (int i = 0; i < steps; i++)
            {
                panelOnlyDisplay.Height += stepSize; // Adjust panel height
                await Task.Delay(duration / steps); // Wait for a fraction of the duration
                //MessageBox.Show("Allloooo");
            }

            // Ensure the final height is set correctly
            panelOnlyDisplay.Height = targetHeight;
        }

        private void addPatientbutton_Click(object sender, EventArgs e)
        {
            elapsePanel();
        }

        private void addSubmitbutton_Click(object sender, EventArgs e)
        {
            var pfirstname= firstnametextBox.Text;
            var plastname= lastnametextBox.Text;
            var pEmail= textBoxEmail.Text;
            var pPassword= textBoxPass.Text;
            var pgender = gendercomboBox.Text;
            var pPhone = numericUpDownPhone.Value;
            var pBirthday = dateTimePicker1.Value;
            var pId= numericUpDown2.Value;
            if (id == 0 || string.IsNullOrWhiteSpace(pfirstname) || string.IsNullOrWhiteSpace(pgender) || phone == 0 || pBirthday == DateTime.Today || string.IsNullOrWhiteSpace(pEmail) || string.IsNullOrWhiteSpace(pPassword))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }
            //MessageBox.Show(gender);
            string connectString = "Data Source =DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=true";
            SqlConnection con = new SqlConnection(connectString);
            con.Open();
            string query= $"select * from Patient where pId={pId}";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("Please Enter a unique ID!");
                return;
            }
            rdr.Close();
            query = $"insert into Patient values({pId},{id},'{pfirstname}','{plastname}','{pBirthday}','{pgender}',{pPhone},'{pEmail}','{pPassword}')";
            SqlCommand cmd1 = new SqlCommand(query, con);
            int rowAffected= cmd1.ExecuteNonQuery();
            if (rowAffected > 0)
            {
                MessageBox.Show("Patient Added Successfully");
            }
            else
            {
                MessageBox.Show("Failed to Add Patient!");
            }
        }
    }
}

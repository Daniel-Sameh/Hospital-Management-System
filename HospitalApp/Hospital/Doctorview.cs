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
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;

namespace Hospital
{
    public partial class Doctorview : Form
    {
        private string speciality;
        private decimal id;
        private string fname;
        private string lname;
        private string gender;
        private decimal phone;
        private string email;
        private string password;
        private int salary;
        private string connectString;
        private SqlConnection con;
        private List<int> med;
        private List<int> nur;
        private int pId;
        private bool bok;
        public Doctorview(decimal id, string fName, string lName, string gender, decimal phone, string email, string password, int salary, string speciality)
        {

            InitializeComponent();
            connectString = "Data Source =DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=true";
            con = new SqlConnection(connectString);
            con.Open();
            DoctorName.Text = "Dr." + fName + " " + lName;
            Speciality.Text = speciality;
            this.id = id;
            this.fname = fName;
            this.lname = lName;
            this.gender = gender;
            this.phone = phone;
            this.email = email;
            this.password = password;
            this.salary = salary;
            this.speciality = speciality;
            med = new List<int>();
            nur = new List<int>();
            string query1 = $"select * from medicine;";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {
                med.Add(Convert.ToInt32(rdr1.GetDecimal(0)));
                comboBox1.Items.Add(rdr1.GetString(1));
            }
            rdr1.Close();
            bok = true;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Speciality_Click(object sender, EventArgs e)
        {

        }

        private void DoctorName_Click(object sender, EventArgs e)
        {

        }

        private void Doctorview_Load(object sender, EventArgs e)
        {
            populateItems();
            string query1 = $"select empFirstName+' '+empLastName as name, Employee.eId from Employee join Nurse on Employee.eId= Nurse.eId;";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {
                nur.Add(Convert.ToInt32(rdr1.GetDecimal(1)));
                comboBox2.Items.Add(rdr1.GetString(0));
            }
            rdr1.Close();
        }
        private void populateItems()
        {
            string query1 = $"select appointment.pId, appointment.eId, firstName+' '+lastName as name, apDate as date, aId from Appointment join patient on Appointment.pId= Patient.pId where Appointment.eId={id} order by date;";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            List<ListItem> list = new List<ListItem>();
            decimal ss = 0;
            //var m = rdr1.GetDateTime(5);
            //var l = rdr1.GetDateTime(6);
            while (rdr1.Read())
            {
                //MessageBox.Show(rdr1.GetString(2));
                int aid = Convert.ToInt32(rdr1.GetDecimal(4));
                int pid = Convert.ToInt32(rdr1.GetDecimal(0));

                ListItem l = new ListItem(aid, pid, this);
                l.Patient = rdr1.GetString(2);
                l.DateandTime = rdr1.GetDateTime(3).ToString();

                list.Add(l);

            }
            rdr1.Close();


            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }
            Label nameHeader = new Label
            {
                Text = "UpComing Appointments:",
                AutoSize = true,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.AliceBlue,
                Margin = new Padding(10)
            };
            flowLayoutPanel1.Controls.Add(nameHeader);

            foreach (var item in list)
            {
                if (item != null)
                {
                    flowLayoutPanel1.Controls.Add(item);
                }

            }
            query1 = $"select e.eId as ID,e.empFirstName+' '+e.empLastName as name from Employee as e join Assists as a on e.eId=a.eId join Nurse as n on a.eId=n.eId where a.Doc_eId={id};";
            SqlCommand cmd2 = new SqlCommand(query1, con);
            SqlDataAdapter adapter = new SqlDataAdapter(query1, connectString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (bok)
            {
                DataGridViewButtonColumn appointmentButton = new DataGridViewButtonColumn();
                appointmentButton.Name = "delete";
                appointmentButton.Text = "delete";
                appointmentButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(appointmentButton);
                bok = false;
                dataGridView1.CellClick += DataGridView1_CellClick;
            }

        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                // Retrieve the data for the selected row
                DataRow selectedRow = ((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem).Row;
                int nId = Convert.ToInt32(selectedRow["ID"]);
                string query = $"delete from Assists where eId={nId} and Doc_eId={id}";
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int r = cmd.ExecuteNonQuery();
                //MessageBox.Show("the Prescreption is deleted.", "Prescription Notification");
                populateItems();
            }
        }
        private void logoutlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void prescription(int pId)
        {
            elapsePanel();
            this.pId = pId;
        }
        private async void elapsePanel()
        {
            int originalHeight = hidingpanel.Height;
            int targetHeight = originalHeight == 334 ? 0 : 334;
            //MessageBox.Show(targetHeight.ToString());
            int duration = 200;
            int steps = 50; // Number of animation steps

            // Calculate step size
            int stepSize = (targetHeight - originalHeight) / steps;

            // Animate the change in size
            for (int i = 0; i < steps; i++)
            {
                hidingpanel.Height += stepSize; // Adjust panel height
                await Task.Delay(duration / steps); // Wait for a fraction of the duration
                //MessageBox.Show("Allloooo");
            }

            // Ensure the final height is set correctly
            hidingpanel.Height = targetHeight;
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {

            int mId = comboBox1.SelectedIndex + 1;
            //MessageBox.Show(mId.ToString());
            string dosage = textBox1.Text;
            string details = richTextBox1.Text;
            if (mId == -1 || string.IsNullOrWhiteSpace(dosage) || string.IsNullOrWhiteSpace(details))
            {
                MessageBox.Show("Please fill all the required fields!", "Alert");
                return;
            }
            string query1 = $"insert into Prescription values({id},{pId},{mId},'{details}','{dosage}');";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            int r = cmd1.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Prescription Added Succesfully!", "Prescription");
                elapsePanel();
                comboBox1.SelectedIndex = -1;
                textBox1.Text = string.Empty;
                richTextBox1.Text = string.Empty;
            }
        }

        private void submitbutton_Click_1(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ss = comboBox2.SelectedIndex;
            int nId = nur[ss];
            //MessageBox.Show(nId.ToString()+" "+ss.ToString());
            string query1 = $"insert into Assists values({id},{nId});";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            try
            {
                int r = cmd1.ExecuteNonQuery();
                populateItems();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("You already have this nurse as assistant", "Notification");
            }
            

        }
    }
}

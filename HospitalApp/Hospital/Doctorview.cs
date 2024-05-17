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
        private int pId;
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
            string query1 = $"select * from medicine;";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {
                med.Add(Convert.ToInt32(rdr1.GetDecimal(0)));
                comboBox1.Items.Add(rdr1.GetString(1));
            }
            rdr1.Close();

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

        }
        private void populateItems()
        {
            string query1 = $"select appointment.pId, appointment.eId, firstName+' '+lastName as name, apDate as date, aId from Appointment join patient on Appointment.pId= Patient.pId where Appointment.eId={id};";
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

            foreach (var item in list)
            {
                if (item != null)
                {
                    flowLayoutPanel1.Controls.Add(item);
                }

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

            int mId = comboBox1.SelectedIndex+1;
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
                richTextBox1.Text= string.Empty;
            }
        }

        private void submitbutton_Click_1(object sender, EventArgs e)
        {
           
            
          
        }
    }
}

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
    public partial class appointmentForm : Form
    {
        private int pId;
        private int dId;
        private string name;
        private List<KeyValuePair<int, string>> doctors;
        private Panel tmpPanel;
        private DateTime selectedDate;
        private int hour;
        private bool selectDoctor;

        public appointmentForm(int pId, string name)
        {
            InitializeComponent();
            this.pId = pId;
            this.name = name;
            patientlabel.Text = name;
            doctors = new List<KeyValuePair<int, string>>();
            tmpPanel = new Panel();
            tmpPanel.Dock = DockStyle.Fill;
            tmpPanel.AutoScroll = true;
            selectDoctor = false;
            groupBox1.Controls.Add(tmpPanel);
        }

        private void appointmentForm_Load(object sender, EventArgs e)
        {
            string query = $"select d.eId,d.speciality, e.empFirstName+' '+ e.empLastName as [name] from doctor as d join employee as e on d.eId = e.eId;";
            string connection = "Data Source =DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=true";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            //List<string> doctors = new List<string>();
            while (rdr.Read())
            {
                // Assuming you want to concatenate the columns into one string
                string item = $"{rdr["name"]} ({rdr["speciality"]})";
                int id = Convert.ToInt32(rdr.GetDecimal(0));
                doctors.Add(new KeyValuePair<int, string>(id, item));
                //doctors.Add(new KeyValuePair<int, string>(id, item));
                //doctors.Add(new KeyValuePair<int, string>(id, item));
                //doctors.Add(new KeyValuePair<int, string>(id, item));
            }
            rdr.Close();
            PopulateRadioButtonList();

        }
        private void PopulateRadioButtonList()
        {
            int y = 20; // Initial Y position
            foreach (var pair in doctors)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = pair.Value;
                radioButton.AutoSize = true;
                radioButton.Location = new Point(20, y);
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                //radioButton.ForeColor = Color.AliceBlue;
                radioButton.Font = new Font("Segoe UI Semibold", 10, FontStyle.Regular);
                tmpPanel.Controls.Add(radioButton); // groupBox1 is your GroupBox control
                y += radioButton.Height + 5; // Increase Y position for the next RadioButton
            }
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                string selected = radioButton.Text;
                KeyValuePair<int, string> pair = doctors.FirstOrDefault(p => p.Value == selected);
                dId = pair.Key;
                doctorlabel2.Text = "Doctor/" + selected;
                selectDoctor=true;
                //doctorlabel.Location= new Point(doctorlabel.Location.X-45, doctorlabel.Location.Y);
                //MessageBox.Show(dId.ToString());
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            selectedDate = monthCalendar1.SelectionRange.Start.Date;
            atlabel.Text = "At: " + selectedDate;
            //MessageBox.Show(selectedDate.ToString());

        }
        private async void elapsePanel()
        {
            int originalWidth = panel1.Width;
            int targetWidth = 0;
            //MessageBox.Show(targetHeight.ToString());
            int duration = 500;
            int steps = 50; // Number of animation steps

            // Calculate step size
            int stepSize = (targetWidth - originalWidth) / steps;

            // Animate the change in size
            for (int i = 0; i < steps; i++)
            {
                panel1.Width += stepSize; // Adjust panel height
                panel2.Location = new Point(panel2.Location.X - stepSize, panel2.Location.Y);
                panel2.Width += stepSize;
                await Task.Delay(duration / steps); // Wait for a fraction of the duration
                //MessageBox.Show("Allloooo");
            }

            // Ensure the final height is set correctly
            panel1.Width = targetWidth;
        }

        private void rservebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)||!selectDoctor)
            {
                MessageBox.Show("Please fill in all the required fields!");
                return;
            }
            hour = (int)numericUpDown1.Value;
            if(hour < 6) { hour += 12; }
            TimeSpan selectedTime = new TimeSpan(hour, 0, 0);
            DateTime combinedDateTime = selectedDate.Add(selectedTime);
            string tmpDateTime = combinedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"select * from doctor as d join appointment as a on d.eId=a.eId where a.apDate= '{tmpDateTime}';";
            string connection = "Data Source =DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=true";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read()) {
                MessageBox.Show("The selected date is not available for the doctor, Sorry", "Unavailable Date");
                return;
            }
            rdr.Close();
            string type=textBox1.Text;
            query = $"insert into appointment values({pId},{dId},'{type}',150,'{combinedDateTime}');";
            SqlCommand cmd1 = new SqlCommand(query, con);
            int x = cmd1.ExecuteNonQuery();
            if (x>0)
            {
                elapsePanel();
            }
        }
    }
}

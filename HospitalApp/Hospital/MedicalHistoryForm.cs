using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class MedicalHistoryForm : Form
    {
        decimal patient_id;
        decimal admin_id;
        string details;
        DateTime selectedDate;
        public MedicalHistoryForm(decimal id, decimal aid)
        {
            this.patient_id = id;
            this.admin_id = aid;
            InitializeComponent();
            PATIENTID.Text = id.ToString();
            ADMINID.Text = aid.ToString();

        }

        private void MedicalHistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DETAILS_TextChanged(object sender, EventArgs e)
        {
            //details = DETAILS.Text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            selectedDate = monthCalendar1.SelectionRange.Start.Date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    // Exclude mId from the INSERT statement
                    string query = $"INSERT INTO MedicalRecord (pId, recordDetails, Date) VALUES (@patient_id, @details, @selectedDate)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@details", DETAILS.Text);
                        cmd.Parameters.AddWithValue("@selectedDate", selectedDate);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Record inserted successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

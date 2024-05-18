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
using System.Windows.Forms.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital
{
    public partial class Patient : Form
    {
        decimal patient_id;
        string patient_name;
        decimal patient_phone;
        string patient_email;
        decimal employee_id;
        public Patient(decimal id, decimal empid, string fName, string lName, DateTime DOB, string gender, decimal phone, string email, string password)
        {
            this.patient_name = fName + ' ' + lName;
            this.patient_phone = phone;
            this.patient_email = email;
            this.patient_id = id;
            this.employee_id = empid;
            InitializeComponent();
            Patient_name.Text = patient_name;
            phone_number.Text = patient_phone.ToString();
            Patient_email.Text = email;
            Admin_ID.Text = employee_id.ToString();
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VQSLFTD9;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            string query1 = "SELECT SUM(apPrice) FROM Appointment WHERE pId = @patientId";
            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.Parameters.AddWithValue("@patientId", patient_id);
            app_sum.Text = cmd.ExecuteScalar().ToString();
        

            string query2 = "SELECT SUM(Medicine.price) FROM Medicine JOIN Prescription ON Medicine.medId = Prescription.medId;";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd.Parameters.AddWithValue("@patientId", patient_id);
            pres_sum.Text = cmd2.ExecuteScalar().ToString();

            con.Close();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Make_appoint_Click(object sender, EventArgs e)
        {
            appointmentForm apf = new appointmentForm((int)patient_id, patient_name);
            apf.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mail_label_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void view_appoint_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VQSLFTD9;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = $"select * from Appointment where pId = {patient_id}";
            SqlDataAdapter sqlDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            DataGrid.Columns.Add(deleteButtonColumn);

            DataGrid.DataSource = dt;
        }

        private void View_Medical_History_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=LAPTOP-VQSLFTD9;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");
            //con.Open();
            //string query = $"select * from MedicalRecord where pId = {patient_id}";
            //SqlDataAdapter sqlDA = new SqlDataAdapter(query, con);
            //DataTable dt = new DataTable();
            //sqlDA.Fill(dt);

            //DataGrid.DataSource = dt;
            medicalHistory mh = new medicalHistory((int)patient_id, true);
            mh.Show();

        }

        private void View_Prescriptions_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VQSLFTD9;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = $"select * from Prescription where pId = {patient_id}";
            SqlDataAdapter sqlDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);

            DataGrid.DataSource = dt;
        }

        private void Add_Medical_History_Click(object sender, EventArgs e)
        {
            MedicalHistoryForm MHF = new MedicalHistoryForm(patient_id,employee_id);
            MHF.Show();

        }
    }
}

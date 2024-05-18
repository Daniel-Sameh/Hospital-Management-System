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
        bool bok;
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
            bok = false;
            calcBill();
           
        }
        private void calcBill()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            string query1 = "SELECT SUM(apPrice) FROM Appointment WHERE pId = @patientId";
            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.Parameters.AddWithValue("@patientId", patient_id);
            app_sum.Text = cmd.ExecuteScalar().ToString();
            if (string.IsNullOrWhiteSpace(app_sum.Text))
            {
                app_sum.Text = "0";
            }

            string query2 = $"SELECT SUM(Medicine.price) FROM Medicine JOIN Prescription ON Medicine.medId = Prescription.medId where pId= {patient_id};";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            //cmd.Parameters.AddWithValue("@patientId", patient_id);
           
            pres_sum.Text = cmd2.ExecuteScalar().ToString();
            if (string.IsNullOrWhiteSpace(pres_sum.Text))
            {
                pres_sum.Text = "0";
            }
            //con.Close();
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
            calcBill();
            //view_appoint_Click(sender, e);


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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = $"select a.aId as ID,e.empFirstName+' '+e.empLastName as [Doctor],a.type, apPrice as Price, apDate as [Date]   from Appointment as a join Employee as e on a.eId=e.eId where pId={patient_id}";
            SqlDataAdapter sqlDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            if (!bok)
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.HeaderText = "Delete";
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                //DataGrid.Columns.Add(deleteButtonColumn);
                DataGrid.Columns.Insert(0, deleteButtonColumn);
                bok = true;
            }
            

            DataGrid.DataSource = dt;
            DataGrid.CellClick += DataGrid_CellClick;
            DataGrid.AutoResizeColumns();
            DataGrid.AutoResizeRows();
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            calcBill();
        }

        private void View_Medical_History_Click(object sender, EventArgs e)
        {
            medicalHistory mh = new medicalHistory((int)patient_id, true);
            mh.Show();
        }

        private void View_Prescriptions_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = $"select presId as ID,e.empFirstName+' '+e.empLastName as [Doctor], m.Mname as [Medicine], p.pDetails as Details,p.dosage as Dosage from Prescription as p join Employee as e on p.eId=e.eId join Medicine as m on p.medId=m.medId where p.pId = {patient_id}";
            SqlDataAdapter sqlDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            DataGrid.DataSource = dt;
            DataGrid.AutoResizeColumns();
            DataGrid.AutoResizeRows();
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (!bok)
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.HeaderText = "delete";
                deleteButtonColumn.Name = "delete";
                deleteButtonColumn.Text = "delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                //DataGrid.Columns.Add(deleteButtonColumn);
                DataGrid.Columns.Insert(0, deleteButtonColumn);
                bok = true;
            }
            DataGrid.CellClick += DataGrid_CellClick;
            calcBill();
        }

        private void Add_Medical_History_Click(object sender, EventArgs e)
        {
            MedicalHistoryForm MHF = new MedicalHistoryForm(patient_id,employee_id);
            MHF.Show();

        }
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGrid.Columns["delete"].Index && e.RowIndex >= 0)
            {
                // Retrieve the data for the selected row
                DataRow selectedRow = ((DataRowView)DataGrid.Rows[e.RowIndex].DataBoundItem).Row;
                if (selectedRow.Table.Columns.Contains("Medicine"))
                {
                    int id= Convert.ToInt32(selectedRow["ID"]);
                    string query = $"delete from Prescription where presId={id}";
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    int r = cmd.ExecuteNonQuery();
                    MessageBox.Show("the Prescreption is deleted.","Prescription Notification");
                    View_Prescriptions_Click(sender, e);
                    calcBill();
                    /*if (r > 0)
                    {
                        MessageBox.Show("");
                    }*/


                }
                else
                {
                    int id = Convert.ToInt32(selectedRow["ID"]);
                    string query = $"delete from Appointment where aId={id}";
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    int r = cmd.ExecuteNonQuery();
                    MessageBox.Show("the Appointment is deleted.", "Appointment Notification");
                    view_appoint_Click(sender, e);
                    calcBill();
                }
                
            }
        }
    }
}

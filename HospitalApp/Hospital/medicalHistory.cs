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
    public partial class medicalHistory : Form
    {
        private int pId;
        private bool isPatient;
        private bool bok;
        public medicalHistory(int pId, bool isPatient)
        {
            InitializeComponent();
            this.pId = pId;
            this.isPatient = isPatient;
            if(!isPatient ) { 
                dataGridView1.Enabled = false;
            }
            bok= false; 
        }

        private void medicalHistory_Load(object sender, EventArgs e)
        {
            string connectString = "Data Source =DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=true";
            SqlConnection con = new SqlConnection(connectString);
            con.Open();
            string query = $"select mId as ID , recordDetails, Date from MedicalRecord where pId= {pId} order by Date;";
            if (isPatient) {
                if (!bok)
                {
                    DataGridViewButtonColumn appointmentButton = new DataGridViewButtonColumn();
                    appointmentButton.Name = "delete";
                    appointmentButton.Text = "delete";
                    appointmentButton.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(appointmentButton);
                    dataGridView1.CellClick += DataGridView1_CellClick;
                    bok= true;
                }
                
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("No Medical History to show", "Sorry");
                this.Close();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                DataRow selectedRow = ((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem).Row;
                int id = Convert.ToInt32(selectedRow["ID"]);
                string query = $"delete from MedicalRecord where mId={id}";
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int r = cmd.ExecuteNonQuery();
                MessageBox.Show("the Record is deleted.", "Notification");
                medicalHistory_Load(sender, e);

            }
        }
    }
}

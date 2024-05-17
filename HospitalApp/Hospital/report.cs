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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
            DateTime today = DateTime.Today.Date;
            label5.Text = "generated at "+ today.ToString("d");
        }

        private void report_Load(object sender, EventArgs e)
        {
            string query = $"select sum(apPrice) as income from Appointment";
            string connection = "Data Source =DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=true";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                label2.Text += rdr.GetInt32(0).ToString()+" EGP.";
            }
            rdr.Close();
            query = "select count(*) as num from Appointment;";
            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            if (rdr1.Read())
            {
                label3.Text += rdr1.GetInt32(0).ToString() + ".";
            }
            rdr1.Close();
            query = "select count(*) as num from Appointment where apDate  >= DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0) AND apDate < DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) + 1, 0);";
            SqlCommand cmd2 = new SqlCommand( query, con);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            if(rdr2.Read())
            {
                label4.Text += rdr2.GetInt32(0).ToString() + ".";
            }
            rdr2.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            query = "select top 10 e.empFirstName+' '+e.empLastName as name, d.speciality, e.salary, e.empPhone as phone\r\nfrom doctor as d join Employee as e on d.eId=e.eId\r\norder by e.salary;";
            SqlCommand cmd3 = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            //dataGridView1.Columns["pId"].Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 135;
            }

        }
    }
}

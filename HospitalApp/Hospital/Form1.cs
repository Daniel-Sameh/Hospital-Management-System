using System.Data.SqlClient;
namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void open_Click(object sender, EventArgs e)
        {
            /*string connectString = "Data Source =DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=true";
            SqlConnection con= new SqlConnection(connectString);
            con.Open();
            string query = "select * from employee";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();*/

            /*while(rdr.Read())
            {
                string output= "Emp: " + rdr.GetValue(0) + ", "+rdr.GetValue(1)+" "+rdr.GetValue(2) + ", "+rdr.GetValue(4) + ", "+ rdr.GetValue(7) + ", ";
                MessageBox.Show(output);
            }*/
            this.Hide();
            login loginForm = new();
            loginForm.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signup signForm = new signup();
            signForm.ShowDialog();
            this.Close();
        }
    }
}

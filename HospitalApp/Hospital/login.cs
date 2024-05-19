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
    public partial class login : Form
    {
        private string connectString;
        private SqlConnection con;
        public login()
        {
            InitializeComponent();
            connectString = "Data Source =DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=true";
            con = new SqlConnection(connectString);
            con.Open();
            this.KeyPreview = true;

            // Subscribe to the KeyDown event
            this.KeyDown += key_down_fun;
            textBoxPass.UseSystemPasswordChar = true;
        }
        private void key_down_fun(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"select * from employee where empEmail='{textBoxEmail.Text}' and empPassword='{textBoxPass.Text}'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show($"Welcome {rdr.GetValue(1)} {rdr.GetValue(2)}");
                var id = rdr.GetDecimal(0);
                var fName = rdr.GetString(1);
                var lName = rdr.GetString(2);
                var gender = rdr.GetString(3);
                var phone = rdr.GetDecimal(4);
                var email = rdr.GetString(5);
                var password = rdr.GetString(6);
                var salary = rdr.GetInt32(7);
                query = $"select * from admin where eId={id}";
                SqlCommand cmd1 = new SqlCommand(query, con);
                rdr.Close();
                SqlDataReader rdr1 = cmd1.ExecuteReader();
                if (rdr1.Read())
                {
                    admin a = new admin(id, fName, lName, gender, phone, email, password, salary);
                    this.Hide();
                    a.ShowDialog();
                    this.Close();
                    return;
                }
                rdr1.Close();
                query = $"select * from doctor where eId={id}";
                SqlCommand cmd2= new SqlCommand(query, con);
                SqlDataReader rdr2= cmd2.ExecuteReader();
                if (rdr2.Read())
                {
                    //MessageBox.Show("I am in doctor");
                    Doctorview d= new Doctorview(id, fName, lName,gender, phone, email, password, salary,rdr2.GetString(1));
                    this.Hide();
                    d.ShowDialog();
                    this.Close();
                    return ;
                }
                rdr2.Close();
                query = $"select * from Nurse where eId={id}";
                SqlCommand cmd3= new SqlCommand(query, con);
                SqlDataReader rdr3 = cmd3.ExecuteReader();
                if (rdr3.Read())
                {
                    this.Close();
                    return ;
                }
                rdr3.Close();
                

            }
            else{
                rdr.Close();
                query = $"select * from Patient where pEmail='{textBoxEmail.Text}' and pPassword='{textBoxPass.Text}'";
                SqlCommand cmd9 = new SqlCommand(query, con);
                SqlDataReader rdr5 = cmd9.ExecuteReader();
                if (rdr5.Read())
                {
                    var id = rdr5.GetDecimal(0);
                    var empid = !rdr5.IsDBNull(1)?rdr5.GetDecimal(1):0;
                    var fName = rdr5.GetString(2);
                    var lName = rdr5.GetString(3);
                    var DOB = rdr5.GetDateTime(4);
                    var gender = rdr5.GetString(5);
                    var phone = rdr5.GetDecimal(6);
                    var email = rdr5.GetString(7);
                    var password = rdr5.GetString(8);

                    MessageBox.Show($"Welcome {rdr5.GetValue(2)} {rdr5.GetValue(3)}");
                    Patient p = new Patient(id, empid, fName, lName, DOB, gender, phone, email, password);
                    this.Hide();
                    p.ShowDialog();
                    this.Close();
                    rdr5.Close();
                    return;

                }
                else
                {
                    rdr5.Close() ;
                    MessageBox.Show("Invalid Email or Password!");

                }

            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}

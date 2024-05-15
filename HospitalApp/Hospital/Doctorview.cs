using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            public Doctorview(decimal id, string fName, string lName, string gender, decimal phone, string email, string password, int salary,string speciality)
            {

                InitializeComponent();
                DoctorName.Text = fName + " " + lName;
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
    }
}

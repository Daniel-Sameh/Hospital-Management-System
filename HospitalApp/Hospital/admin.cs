using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital
{
    public partial class admin : Form
    {
        private decimal id;
        private string fname;
        private string lname;
        private string gender;
        private decimal phone;
        private string email;
        private string password;
        private int salary;

        public admin(decimal id, string fName, string lName, string gender, decimal phone, string email, string password, int salary)
        {

            InitializeComponent();
            adminName.Text = fName + " " + lName;
            this.id = id;
            this.fname = fName;
            this.lname = lName;
            this.gender = gender;
            this.phone = phone;
            this.email = email;
            this.password = password;
            this.salary = salary;

        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

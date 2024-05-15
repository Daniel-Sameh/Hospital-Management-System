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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
            //salary hide
            salarylabel.Hide();
            label10.Hide();
            numericUpDown1.Hide();
            specialitylabel.Hide();
            label12.Hide();
            specialitytextBox.Hide();
            label13.Hide();
            numericUpDown3.Hide();

            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedValue = comboBox.SelectedItem.ToString();
            if (selectedValue == "Patient")
            {
                salarylabel.Hide();
                label10.Hide();
                numericUpDown1.Hide();
                specialitylabel.Hide();
                label12.Hide();
                specialitytextBox.Hide();
                label13.Hide();
                numericUpDown3.Hide();

                label9.Show();
                label8.Show();
                dateTimePicker1.Show();
            }
            else
            {
                salarylabel.Show();
                label10.Show();
                numericUpDown1.Show();

                label8.Hide();
                label9.Hide();
                dateTimePicker1.Hide();

                specialitylabel.Hide();
                specialitytextBox.Hide();
                label12.Hide();

                label13.Hide();
                numericUpDown3.Hide();
            }

            if (selectedValue == "Doctor")
            {
                specialitylabel.Show();
                specialitytextBox.Show();
                label12.Show();
            }
            else if (selectedValue == "Nurse")
            {
                label13.Show();
                numericUpDown3.Show();

            }


        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //matelmesehash
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = numericUpDown2.Value;
            /////////////////////////////////////////////////////
            string connectString = "Data Source =DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=true";
            SqlConnection con = new SqlConnection(connectString);
            con.Open();
            string query;
            if(comboBox1.SelectedIndex == 0){
                query = $"select * from Patient where eId={id}";
            }
            else{
                query = $"select * from Employee where eId={id}";
            }
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read()){
                MessageBox.Show("Please Enter a unique ID!");
                return;
            }
            rdr.Close();
            /////////////////////////////////////////////////////
            
            var firstname= firstnametextBox.Text;
            var lastname= lastnametextBox.Text;
            var gender= gendercomboBox.Text;
            var phone = numericUpDownPhone.Value;
            var birthday= dateTimePicker1.Value;
            //MessageBox.Show(phone.ToString());
            var email= textBoxEmail.Text;
            var password= textBoxPass.Text;
            var salary = numericUpDown1.Value;
            var workingHrs= numericUpDown3.Value;
            var speciality= specialitytextBox.Text;
            if (comboBox1.SelectedIndex == 0)
            {
                if (id == 0 || string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(gender) || phone == 0 || birthday == DateTime.Today || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }
            }
            else{

                if (id == 0 || string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(gender) || phone == 0 || salary == 0 || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                if (string.IsNullOrWhiteSpace(speciality))
                {
                    MessageBox.Show("Please enter your medical speciality.");
                    return;
                }
            }else if (comboBox1.SelectedIndex == 3){
                if (workingHrs == 0){
                    MessageBox.Show("Please enter your working hours.");
                }
            }
            ///////////////////////////////////////////////////////////////
            SqlCommand sqlCommand;
            if(comboBox1.SelectedIndex == 0) {
                query = $"insert into Patient(pId, firstName, lastName, birthDate, pGender, pPhone, pEmail, pPassword) values({id},'{firstname}','{lastname}','{birthday}','{gender}',{phone},'{email}','{password}')";
                sqlCommand= new SqlCommand(query,con);
                int rowsAffected=0;
                try
                {
                    rowsAffected = sqlCommand.ExecuteNonQuery();
                    // Check rowsAffected and handle success/failure
                }
                catch (SqlException ex)
                {
                    // Handle the exception, log it, display an error message, etc.
                    MessageBox.Show("Error: " + ex.Message);
                }
                // Check the number of rows affected to verify if the insertion was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Patient added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add patient.");
                }
                return;
            }else{
                query = $"insert into Employee(eId, empFirstName, empLastName,empGender,empPhone, empEmail, empPassword,salary) values({id},'{firstname}','{lastname}','{gender}',{phone},'{email}','{password}',{salary})";
                sqlCommand= new SqlCommand(query,con);
                int ra=sqlCommand.ExecuteNonQuery();
                if (ra == 0){
                    MessageBox.Show("Failed to add user.");
                }
                
            }
            if(comboBox1.SelectedIndex == 1) {
                query = $"insert into Admin values({id})";
                SqlCommand s= new SqlCommand(query,con);
                int ra=s.ExecuteNonQuery();
                if (ra > 0)
                {
                    MessageBox.Show("Admin added successfully.");
                    this.Hide();
                    admin a= new admin(id,firstname,lastname,gender, phone,email,password,(int)salary);
                    a.ShowDialog();
                    con.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add admin.");
                }

            }
            else if(comboBox1.SelectedIndex==2){
                query = $"insert into Doctor values({id},'{speciality}')";
                SqlCommand s = new SqlCommand(query, con);
                int ra = s.ExecuteNonQuery();
                if (ra > 0)
                {
                    MessageBox.Show($"Doctor/{firstname} added successfully.");
                }
                else{
                    MessageBox.Show("Failed to add doctor.");
                }
            }
            else{
                query = $"insert into Nurse values({id},{workingHrs})";
                SqlCommand s = new SqlCommand(query, con);
                int ra= s.ExecuteNonQuery();
                if (ra > 0)
                {
                    MessageBox.Show($"Nurse {firstname} added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add nurse.");
                }
            }


        }
    }
}

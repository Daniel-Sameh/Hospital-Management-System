using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hospital
{
    public partial class ListItem : UserControl
    {
        // private Label patientname;
        //private Label dateandtime;
        private int aId;
        private int pId;
        private Doctorview dv;
        public ListItem(int aId, int pId, Doctorview dv)
        {
            InitializeComponent();
            this.aId = aId;
            this.pId = pId;
            this.dv = dv;
            // InitializeCustomComponents();
        }



        #region Properties

        public string Patient
        {
            get { return PatientName.Text; }
            set { PatientName.Text = value; }
        }

        public string DateandTime
        {
            get { return Dateandtimelabel.Text; }
            set { Dateandtimelabel.Text = value; }
        }

        #endregion

        private void makeprescription_Click(object sender, EventArgs e)
        {
            dv.prescription(pId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string query = $"delete from Appointment where aId= {aId};";
            string connection = "Data Source =DESKTOP-P4RUM8H;Initial Catalog=hospital;Integrated Security=true";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            int rdr = cmd.ExecuteNonQuery();
            if (rdr > 0)
            {
                MessageBox.Show("Appointment with " + PatientName.Text + " ended.");
            }

        }

        private void mediaclbutton_Click(object sender, EventArgs e)
        {
            medicalHistory m = new medicalHistory(pId, false);
            m.Show();
        }
    }
}

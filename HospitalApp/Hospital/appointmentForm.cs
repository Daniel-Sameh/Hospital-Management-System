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
    public partial class appointmentForm : Form
    {
        private int pId;
        private int dId;
        private string name;
        public appointmentForm(int pId,string name)
        {
            InitializeComponent();
            this.pId = pId;
            this.name = name;
            patientlabel.Text = name;
        }
    }
}

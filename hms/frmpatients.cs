using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hms
{
    public partial class frmpatients : Form
    {
        public frmpatients()
        {
            InitializeComponent();
        }
        string q = "select max(id) from tblpatient";
        string query;
        fdata fd = new fdata();
        private void frmpatients_Load(object sender, EventArgs e)
        {            
            fd.dataload(txtloginid, q);
            txtloginid.Enabled = false;
            txtpatientname.Focus();            
            query = "select Name, Contact, Address, Doctor, Appointment_Time as 'Appointment Time' from tblpatient";
            fd.dataload(dgv, query);
            query = "select Name from tbllogin where Design='Doctor'";
            fd.dataload(combodoctor, query);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to save it? ", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                fdata fd = new fdata();
                string query = "insert into tblpatient (Name, Contact, Address, Doctor, Appointment_Time) values '" + txtpatientname.Text + "','" + txtpatientcontact.Text + "','" + txtpatientaddress.Text + "','" + combodoctor.Text + "','" + dateTimePicker1.Text + "','" +"');";
                fd.datasave(query);                
                fd.dataload(dgv, q);
            }
            txtpatientname.Clear();
            fd.dataload(txtloginid, q);
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

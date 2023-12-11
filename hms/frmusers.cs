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
    public partial class frmusers : Form
    {
        public frmusers()
        {
            InitializeComponent();
        }
        string q = "select max(id) from tbllogin";
        string query;
        fdata fd = new fdata();
        private void frmusers_Load(object sender, EventArgs e)
        {
            
           
            fd.dataload(txtloginid, q);
            txtloginid.Enabled = false;
            txtloginname.Focus();            
            query = "select id, username from tbllogin";
            fd.dataload(dgv, query);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to save it? ", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                fdata fd = new fdata();
                string query = "insert into tbllogin (username , password) values( '" + txtloginname.Text + "','" + txtpass.Text + "');";
                fd.datasave(query);
                query = "select id,username from tbllogin";
                fd.dataload(dgv, query);
            }
            txtloginname.Clear();
            txtpass.Clear();
            fd.dataload(txtloginid, q);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fdata fd = new fdata();
            int id= (int)dgv.SelectedRows[0].Cells[0].Value;            
            string query = "delete from tbllogin where id='" + id + "';";
            fd.datadelete(query);
            query = "select id,username from tbllogin";
            fd.dataload(dgv,query);
        }
    }
}

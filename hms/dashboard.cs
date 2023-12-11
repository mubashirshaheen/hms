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
using System.Configuration;
using MySql.Data.MySqlClient;

namespace hms
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            fdata fd = new fdata();
            string query = "SELECT sum(total) FROM tblsale";
            fd.dataload(label1 , query);
            query = "SELECT sum(tradeprice*quantity) FROM tblpurchase";
            fd.dataload(label5, query);
            label2.Text =(Convert.ToInt32( label1.Text) - Convert.ToInt32(label5.Text)).ToString();
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

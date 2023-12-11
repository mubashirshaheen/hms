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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage hp = new homepage();
            fdata fd = new fdata();
            bool tf = fd.checklogin(textBox1.Text.ToString(), textBox2.Text.ToString());
            if (tf)
            {
                MessageBox.Show("Login Succesfully");
                this.Hide();
                hp.ShowDialog();
                this.Close();
            }
            else
            {
                
                MessageBox.Show("wrong username and password");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class homepage : Form1
    {
        private Form activeForm;
        public homepage()
        {
            InitializeComponent();
            
    }
        public void OpenChildForm(Form childForm, Button btnSender)
        {
            if (activeForm != null)
                activeForm.Close();            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(childForm);
            this.panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = btnSender.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button mybtn = sender as Button;
            OpenChildForm(new dashboard(), mybtn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button mybtn = sender as Button;
            OpenChildForm(new purchase(), mybtn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button mybtn = sender as Button;
            OpenChildForm(new frmsale(), mybtn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button mybtn = sender as Button;
            OpenChildForm(new frmstock(), mybtn);        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button mybtn = sender as Button;
            OpenChildForm(new frmusers(), mybtn);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Button mybtn = sender as Button;
            OpenChildForm(new frmpatients(), mybtn);
        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }
    }
}

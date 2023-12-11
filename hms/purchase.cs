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
    public partial class purchase : Form
    {
        
        public purchase()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtinv.Enabled == true)
            {
                fdata fd = new fdata();
                fd.datadel(int.Parse((txtinv.Text)));
                var n = dgv1.Rows.Cast<DataGridViewRow>()
                .Where(row => !(row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value))
                 .Count();

                for (int i = 0; i < n; i++)
                {
                    DateTime dt = DateTime.Parse(dgv1.Rows[0].Cells[2].Value.ToString());
                    string x = dt.ToString("yyyy-MM-dd");
                    string q = "INSERT INTO tblpurchase (invoice,drug_name,batch_no,exp_date,quantity,tradeprice,retailprice) VALUES ('" + txtinv.Text + "','" + dgv1.Rows[i].Cells[0].Value + "','" + dgv1.Rows[i].Cells[1].Value + "','" + x + "','" + dgv1.Rows[i].Cells[3].Value + "','" + dgv1.Rows[i].Cells[4].Value + "','" + dgv1.Rows[i].Cells[5].Value + "'); ";
                    fd.datasave(q);
                   
                }
            }
            
            txtinv.Enabled = true;
            // refreshfrm();
        }

        private void txtinv_KeyUp(object sender, KeyEventArgs e)
        {
           
            
        }

        private void txtinv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                string q = "select drug_name , batch_no, exp_date  , quantity , tradeprice , retailprice from tblpurchase where invoice=" + Convert.ToInt32(txtinv.Text);
                fdata fd = new fdata();
                fd.dataload(dgv1, q);
            }
        }

        private void purchase_Load(object sender, EventArgs e)
        {
            refreshfrm();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                fdata fdp = new fdata();
                dgv2.Visible = true;
                string query = "SELECT product_name , retail_price FROM tblstock where product_name like ('%" + textBox1.Text.ToString() + "%')";
                fdp.dataload(dgv2, query);
            }
            else
            {
                disabledgv();
                
            }
                
            
        }
        public void disabledgv()
        {
            dgv2.Visible = false;
            try
            {
                dgv2.Rows.Clear();
            }
            catch (Exception)
            {

            }
        }
       
        public void refreshfrm()
        {
            dgv1.Rows.Clear();
            dgv1.Rows.Add(10);
            string q = "select max(invoice) from tblpurchase";
            fdata fd = new fdata();
            fd.dataload(txtinv, q);
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtinv.Enabled == false)
            {
                var n = dgv1.Rows.Cast<DataGridViewRow>()
                    .Where(row => !(row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value))
                     .Count();

                DialogResult r = MessageBox.Show("Do you want to save it? ", "Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {

                    for (int i = 0; i < n; i++)
                    {
                        DateTime dt = DateTime.Parse(dgv1.Rows[0].Cells[2].Value.ToString());
                        string x = dt.ToString("yyyy-MM-dd");
                        string q = "INSERT INTO tblpurchase (invoice,drug_name,batch_no,exp_date,quantity,tradeprice,retailprice) VALUES ('" + txtinv.Text + "','" + dgv1.Rows[i].Cells[0].Value + "','" + dgv1.Rows[i].Cells[1].Value + "','" + x + "','" + dgv1.Rows[i].Cells[3].Value + "','" + dgv1.Rows[i].Cells[4].Value + "','" + dgv1.Rows[i].Cells[5].Value + "'); ";
                        fdata fd = new fdata();
                        fd.datasave(q);
                        int id = fd.checkdata(dgv1.Rows[i].Cells[0].Value.ToString());
                        if (id == 0)
                        {
                            q = "INSERT INTO tblstock (product_name,qty,retail_price) VALUES ('" + dgv1.Rows[i].Cells[0].Value + "','" + dgv1.Rows[i].Cells[3].Value + "','" + dgv1.Rows[i].Cells[5].Value + "'); ";
                            fd.datasave(q);
                        }
                        else
                        {
                            q = "UPDATE tblstock SET qty =qty+'" + dgv1.Rows[i].Cells[3].Value + "' WHERE id='" + id + "';";
                            fd.datasave(q);
                            q = "UPDATE tblstock SET retail_price ='" + dgv1.Rows[i].Cells[5].Value + "' WHERE id='" + id + "';";
                            fd.datasave(q);
                        }


                    }
                }
                refreshfrm();
            }
            else
            {
                txtinv.Enabled = false;
                refreshfrm();
            }
        }

        private void dgv2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = dgv2;
                dgv2.Focus();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs ro)
        {

        }

        private void dgv2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.KeyData & Keys.KeyCode) == Keys.Enter))
            {
                base.OnKeyDown(e);
               
            }
            else
            {
                var n = dgv1.Rows.Cast<DataGridViewRow>()
                .Where(row => !(row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value))
                 .Count(); 
              
                dgv1.Rows[n].Cells[0].Value = dgv2.SelectedRows[0].Cells[0].Value;
                dgv1.Rows[n].Cells[5].Value = dgv2.SelectedRows[0].Cells[1].Value;               
                disabledgv();
                txtinv.Select();
            }
              
            
               
        }

        private void dgv1_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}

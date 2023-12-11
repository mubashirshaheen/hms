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
    public partial class frmsale : Form
    {
        int sum = 0;
        public frmsale()
        {
            InitializeComponent();
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = dgv2;
                dgv2.Focus();
            }
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
                dgv1.Rows[n].Cells[2].Value = dgv2.SelectedRows[0].Cells[1].Value;
                disabledgv();
                txtinvc.Select();
            }
        }
        public void refreshfrm()
        {
            fdata fd = new fdata();           
            string q = "select drug_name as Medicine, quantity, retailprice as 'R.P' from tblsale";
            fd.dataload(dgv1, q);           
            q = "select max(sale_id) from tblsale";            
            fd.dataload(txtinvc, q);
        }
        private void frmsale_Load(object sender, EventArgs e)
        {
            // refreshfrm();
            string q = "select max(sale_invoice) from tblsale";
            fdata fd = new fdata();
            fd.dataload(txtinvc, q);
            
            dgv1.Rows.Add(10);
            dgv1.Columns[1].Width = 50;
            dgv1.Columns[2].Width = 50;
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
              //  var n = dgv1.RowCount;               
                var n = dgv1.SelectedRows[0].Cells[1].RowIndex;
                dgv1.SelectedRows[0].Cells[1].Value = txtqty.Text;
                txtqty.Clear();
                dgv1.Rows[n].Selected = false;
                dgv1.Rows[n+1].Selected = true;
            }
        }

        private void dgv1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > -1 && (txtqty !=null || Convert.ToInt32(txtqty.Text)!=0))
            //{
            //    DataGridViewRow row = dgv1.Rows[e.RowIndex];
            //    string valueA = row.Cells[quantity.Index].Value.ToString();
            //    string valueB = row.Cells[rp.Index].Value.ToString();
            //    int result;
            //    if (Int32.TryParse(valueA, out result)
            //        && Int32.TryParse(valueB, out result))
            //    {
            //        row.Cells[total.Index].Value = valueA + valueB;
            //    }
            //}
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sum = 0; 
            var count=dgv1.Rows.Count;
            for(var i = 0; i < count; i++)
            {
                 sum = sum + Convert.ToInt32(dgv1.Rows[i].Cells[2].Value)* Convert.ToInt32(dgv1.Rows[i].Cells[1].Value);
            }
            lblbalance.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int sum = 0;
            var count = dgv1.Rows.Count;
            for (var i = 0; i < count; i++)
            {
                sum = sum + (Convert.ToInt32(dgv1.Rows[i].Cells[2].Value) * Convert.ToInt32(dgv1.Rows[i].Cells[1].Value));
            }

            var n = dgv1.Rows.Cast<DataGridViewRow>()
                .Where(row => !(row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value))
                 .Count();

            DialogResult r = MessageBox.Show("Do you want to Sale it? ", "Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                for (int i = 0; i < n; i++)
                {
                    string q = "INSERT INTO tblsale(sale_invoice, drug_name, quantity, retailprice,total) VALUES ('" + txtinvc.Text + "','" + dgv1.Rows[i].Cells[0].Value + "','" + dgv1.Rows[i].Cells[1].Value + "','" + dgv1.Rows[i].Cells[2].Value + "','"+sum+"'); ";
                    fdata fd = new fdata();
                    fd.datasave(q);
                }
                lblbalance.Text = sum.ToString();
                reportfrm rf = new reportfrm(txtinvc.Text);
                rf.ShowDialog();
            }


        }
    }
}

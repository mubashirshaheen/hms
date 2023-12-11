using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hms
{
    public partial class reportfrm : Form
    {
        string _invoice_id;
        public reportfrm(string id)
        {
            _invoice_id = id;
            InitializeComponent();
        }

        private void reportfrm_Load(object sender, EventArgs e)
        {           
            string ConString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlDataAdapter da = new MySqlDataAdapter("select * from tblsale where sale_invoice = '" + _invoice_id + "'", con);
            sale ds = new sale();
            da.Fill(ds, "DataTable_Invoice");

            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
namespace hms
{
    class fdata
    {
        string constring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        public void dataload(DataGridView d , string q)
        {

            purchase p = new purchase();
            p.dgv1.Rows.Clear();
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(q, con);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
             dt.Load(reader);
            d.DataSource = dt;

            con.Close();
        }

        public void datadel(int invoice)
        {
            using (var sc = new MySqlConnection(constring))
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = "DELETE FROM tblpurchase WHERE invoice = @word";
                cmd.Parameters.AddWithValue("@word", invoice);
                cmd.ExecuteNonQuery();
            }
            
        }
        public void dataload(TextBox t, string q)
        {
            string constring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            MySqlCommand cmd = new MySqlCommand(q, con);

         //when databse return numaric value then use executescalar  

            if (cmd.ExecuteScalar() is DBNull)
            {
                t.Text = 1.ToString();               
            }                
            else
            {
                int max = Convert.ToInt32(cmd.ExecuteScalar());
                t.Text = (max + 1).ToString();
            }
                
            con.Close();
        }
        public void dataload(Label l, string q)
        {
            string constring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            MySqlCommand cmd = new MySqlCommand(q, con);

            if (cmd.ExecuteScalar() is DBNull)
            {
                l.Text = 0.ToString();
            }
            else
            {
                int max = Convert.ToInt32(cmd.ExecuteScalar());
                l.Text = (max).ToString();
            }

            con.Close();
        }
        public void dataload(ComboBox cb, string q)
        {
            using (var con = new MySqlConnection(constring))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(q, con))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cb.DisplayMember = "Name";
                    cb.ValueMember = "id";
                    cb.DataSource = dt;

                }
            }


        }

        public void datasave(string q)
        {
               string constring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                
                using (var con = new MySqlConnection(constring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            
                
         
        }
        public bool checklogin(string user, string pass)
        {
            using (var con = new MySqlConnection(constring))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT username from tbllogin where username='" + user + "';", con);
               
                if (!(cmd.ExecuteScalar() is DBNull || cmd.ExecuteScalar() is null))
                {
                    cmd = new MySqlCommand("SELECT password from tbllogin where password='" + pass + "';", con);
                    if (!(cmd.ExecuteScalar() is DBNull || cmd.ExecuteScalar() is null))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                        
                }
                else
                {
                    return false;
                }
            }
            
        }
        public int checkdata(string Name)
        {
            

            using (var con = new MySqlConnection(constring))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT id from tblstock where product_name ='" + Name + "';", con);                
                if ((cmd.ExecuteScalar() is DBNull)|| (cmd.ExecuteScalar() is null))
                {                    
                    return 0;
                }
                else
                {
                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    return id;
                }                  
            }
        }
       
        public void datadelete(string q)
        {
            DialogResult r = MessageBox.Show("Do you want to Delete it? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                string constring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                using (var con = new MySqlConnection(constring))
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}

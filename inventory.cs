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

namespace Vcafe
{
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=HAZEEB\SQLEXPRESS;Initial Catalog=vcafe_db;Integrated Security=True");

        private void autoin()
        {


            SqlCommand cmd = new SqlCommand("select max(log_id)+1 from inventory_data_log", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            txt_logid.Text = i.ToString();

        }
        private void btn_insert_Click(object sender, EventArgs e)

        {
            con.Open();
            int id = Convert.ToInt32(txt_id.Text);
            int qty = Convert.ToInt32(txt_qty.Text);
            float punit = (float)Convert.ToDouble(txt_uprice.Text);
            float tunit = (float)Convert.ToDouble(txt_tprice.Text);

            string add = "insert into inventory_data_log (id,name,category,date,qty,unit,unit_price,total_price) values ('" + id + "','" + txt_name.Text + "','" + cmb_category.Text + "','" + datet.Value + "','" + qty + "','" + txt_unit.Text + "','" + punit + "','" + tunit + "')";
            SqlCommand cmd = new SqlCommand(add, con);
            cmd.ExecuteNonQuery();


            string queryCheck = "SELECT COUNT(*) FROM stock WHERE id = @Value";

            using (SqlCommand commandCheck = new SqlCommand(queryCheck, con))
            {
           
                commandCheck.Parameters.AddWithValue("@Value", id);

                int count = (int)commandCheck.ExecuteScalar();
                // If the value does not exist, insert the record
                if (count == 0)
                {
                    // Insert code goes here
                    string add_stock = "insert into stock (id,name,category,qty,unit,unit_price,total_price) values ('" + id + "','" + txt_name.Text + "','" + cmb_category.Text + "','" + qty + "','" + txt_unit.Text + "','" + punit + "','" + tunit + "')";
                    SqlCommand cmds = new SqlCommand(add_stock, con);
                    cmds.ExecuteNonQuery();

                    MessageBox.Show("Item Inserted Sucessfully.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    autoin();
                    txt_id.Clear();
                    txt_name.Clear();
                    // cmb_category.SelectedIndex=0;
                    datet.Value = DateTime.Now;
                    txt_qty.Clear();
                    txt_unit.Clear();
                    txt_uprice.Clear();
                    txt_tprice.Clear();

                }
                // If the value does exist, insert the record
                else if (count != 0)
                {
                    string update_qty = "update stock set qty = qty+'" + qty + "' where id ='" + id + "'";
                    SqlCommand cmds = new SqlCommand(update_qty, con);

                    cmds.ExecuteNonQuery();
                    MessageBox.Show("Item Updated Sucessfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    autoin();
                    txt_id.Clear();
                    txt_name.Clear();
                    // cmb_category.SelectedIndex=0;
                    datet.Value = DateTime.Now;
                    txt_qty.Clear();
                    txt_unit.Clear();
                    txt_uprice.Clear();
                    txt_tprice.Clear();
                }
            }



        
            

           
            con.Close();
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            con.Open();
            autoin();
            con.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            con.Open();

            String query_search = "select * from inventory_data_log where log_id ='" + txt_logid.Text + "'";
            SqlCommand cmnd = new SqlCommand(query_search, con);
            SqlDataReader r = cmnd.ExecuteReader();
         

            while (r.Read())
            {

                txt_id.Text = r[1].ToString();
                txt_name.Text = r[2].ToString();
                cmb_category.Text = r[3].ToString();
                DateTime dateValue = r.GetDateTime(4);
                datet.Value = dateValue;
                txt_qty.Text = r[5].ToString();
                txt_unit.Text = r[6].ToString();
                txt_uprice.Text = r[7].ToString();
                txt_tprice.Text = r[8].ToString();


            }
            con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            con.Open();
            autoin();
            con.Close();
            txt_id.Clear();
            txt_name.Clear();
           // cmb_category.SelectedIndex=0;
            datet.Value = DateTime.Now;
            txt_qty.Clear();
            txt_unit.Clear();
            txt_uprice.Clear();
            txt_tprice.Clear();

        }

        private void btn_id_search_Click(object sender, EventArgs e)
        {
            con.Open();

            String query_search = "select * from inventory_data_log where id ='" + txt_id.Text + "'";
            SqlCommand cmnd = new SqlCommand(query_search, con);
            SqlDataReader r = cmnd.ExecuteReader();


            while (r.Read())
            {

                txt_name.Text = r[2].ToString();
                cmb_category.Text = r[3].ToString();
                DateTime dateValue = r.GetDateTime(4);
                datet.Value = dateValue;
                txt_qty.Text = r[5].ToString();
                txt_unit.Text = r[6].ToString();
                txt_uprice.Text = r[7].ToString();
                txt_tprice.Text = r[8].ToString();

            }
            con.Close();
        }
    }
}

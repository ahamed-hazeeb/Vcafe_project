using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Vcafe
{
    public partial class stock : UserControl
    {
        public stock()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=HAZEEB\SQLEXPRESS;Initial Catalog=vcafe_db;Integrated Security=True");
        private static stock _stock_view;
        public static stock _stock
        {
            get
            {
                if (_stock_view == null)
                    _stock_view = new stock();
                return _stock_view;
                {

                }
            }
        }
        private void autoin()
        {
          
            //auto get the max no in the bill information table 
            SqlCommand cmd = new SqlCommand("select max(id)+1 from stock", con); 
            object result = cmd.ExecuteScalar();
            //if the  table bill_no column is not null
            if (result != DBNull.Value)
            {
                int i = Convert.ToInt32(result);
                txt_id.Text = i.ToString();
            }
            //if the  table bill_no column is null
            else
            {
                txt_id.Text = "1";
            }

        }
        public void clear()
        {

            txt_name.Clear();
            txt_qty.Clear();
            txt_unit.Clear();
            txt_uprice.Clear();
           
        }
        void StyleDatagridview()
        {
            dgv_view_stock.BorderStyle = BorderStyle.None;
            dgv_view_stock.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_view_stock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_view_stock.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv_view_stock.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_view_stock.EnableHeadersVisualStyles = false;
            dgv_view_stock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_view_stock.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            dgv_view_stock.RowTemplate.Height = 30;
            dgv_view_stock.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgv_view_stock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_view_stock.BackgroundColor = Color.FromArgb(46, 51, 73);




        }

        private void view_stock_Load(object sender, EventArgs e)
        {
            con.Open();
            stock_dis();
            autoin();
            con.Close();
            StyleDatagridview();
            string position = login.uposition;

            if (position == "Cashier")
            {
                gb_stock.Enabled = false;
            }



        }
        public void stock_dis()
        {
           
            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT * FROM stock ", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            dgv_view_stock.DataSource = dtbl;
          
        }
        
        private void dgv_view_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
           

            con.Open();
            int id = Convert.ToInt32(txt_id.Text);
            float punit = (float)Convert.ToDouble(txt_uprice.Text);
         
            string queryCheck = "SELECT COUNT(*) FROM stock WHERE id = @Value";

            using (SqlCommand commandCheck = new SqlCommand(queryCheck, con))
            {

                commandCheck.Parameters.AddWithValue("@Value", id);

                int count = (int)commandCheck.ExecuteScalar();
                // If the value does not exist, insert the record
                if (count == 0)
                {
                    // Insert code goes here
                    string add_stock = "insert into stock (id,name,category,unit,unit_price) values ('" + id + "','" + txt_name.Text + "','" + cmb_category.Text + "','" + txt_unit.Text + "','" + punit + "')";
                    SqlCommand cmds = new SqlCommand(add_stock, con);
                    cmds.ExecuteNonQuery();

                    MessageBox.Show("Item Inserted Sucessfully.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    autoin();
                    stock_dis();
                    clear();
                 

                }
                // If the value does exist, insert the record
                else if (count != 0)
                {
                    MessageBox.Show("Item Already Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    autoin();
                    clear();
                }
            }
            con.Close();
        }

        private void btn_id_search_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {

                con.Open();
                btn_insert.Enabled = false;
                btn_update.Enabled = true;

                String query_search = "select [name],[category],[qty],[unit],[unit_price] from stock where id ='" + txt_id.Text + "'";
                SqlCommand cmnd = new SqlCommand(query_search, con);
                SqlDataReader r = cmnd.ExecuteReader();


                while (r.Read())
                {

                    txt_name.Text = r[0].ToString();
                    cmb_category.Text = r[1].ToString();
                    txt_qty.Text = r[2].ToString();
                    txt_unit.Text = r[3].ToString();
                    txt_uprice.Text = r[4].ToString();

                }
            
            }
            else
            {
                MessageBox.Show("ENTER THE ID");

             
            }
            con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
            con.Open();
            autoin();
            con.Close();
            btn_update.Enabled = false;
            btn_insert.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "" && txt_name.Text != "" && txt_uprice.Text != "")
            {
                btn_insert.Enabled = true;
                btn_update.Enabled = false;

                int id = Convert.ToInt32(txt_id.Text);
               // int price = Convert.ToInt32(txt_uprice.Text);
                con.Open();
               

                DialogResult rs = MessageBox.Show("Are You sure want to Update", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (rs == DialogResult.Yes)
                {
                    string update_new = "update stock set  [name] = '"+txt_name.Text+"',[category]='"+cmb_category.Text+"',[unit]='"+txt_unit.Text+"',[unit_price]='"+txt_uprice.Text + "'  where id ='" + id + "'";

                    SqlCommand cmd2 = new SqlCommand(update_new, con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Item Updated Sucessfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stock_dis();
                    clear();
                    autoin();

                }
                else if (rs == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Search the Record need to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "" )
            {
                con.Open();
                DialogResult rs = MessageBox.Show("Are You sure want to Delete Item", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (rs == DialogResult.Yes)
                {

                
                    int id = Convert.ToInt32(txt_id.Text);
                    string delete_inven = "delete from stock where id='" + id + "'";
                
                    SqlCommand cmd_del = new SqlCommand(delete_inven, con);
                
                    cmd_del.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    autoin();
                    stock_dis();
                    btn_update.Enabled = false;
                    btn_insert.Enabled = true;

                }
                else if (rs == DialogResult.No)
                {
                    clear();
                    autoin();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Select the record first.", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_filter_search_Click(object sender, EventArgs e)
        {

            con.Open();
           
           
                if (cmb_type.Text == "name")
                {
                    // int id = Convert.ToInt32(txt_search.Text);
                    SqlDataAdapter sqldata = new SqlDataAdapter("SELECT  [id] as ID,[name] as Name,[category] as Category ,[qty] as Qty,[unit] as Unit,[unit_price] as Unit_Price FROM [stock] where  name like '" + txt_search.Text + "%'", con);
                    DataTable dtbl = new DataTable();
                    sqldata.Fill(dtbl);
                    dgv_view_stock.DataSource = dtbl;
                }

                else if (cmb_type.Text == "category")
                {
                    SqlDataAdapter sqldata = new SqlDataAdapter("SELECT  [id] as ID,[name] as Name,[category] as Category,[date] as Date,[qty] as Qty,[unit] as Unit,[unit_price] as Unit_Price FROM [stock]  where  category like '" + txt_search.Text + "%'", con);
                    DataTable dtbl = new DataTable();
                    sqldata.Fill(dtbl);
                    dgv_view_stock.DataSource = dtbl;
                }
           
            con.Close();

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            con.Open();
            stock_dis();
            con.Close();
        }
    }
}


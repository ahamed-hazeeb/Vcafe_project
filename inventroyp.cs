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
    public partial class inventroyp : UserControl
    {
        public inventroyp()
        {
            InitializeComponent();
        }
        private static inventroyp _inventroy;
        public static inventroyp _inven
        {
            get
            {
                if (_inventroy == null)
                    _inventroy = new inventroyp();
                return _inventroy;
                {

                }
            }
        }

        public SqlConnection con = new SqlConnection(@"Data Source=HAZEEB\SQLEXPRESS;Initial Catalog=vcafe_db;Integrated Security=True");

        private void autoin()
        {
            
            //auto get the max no in the bill information table 
            SqlCommand cmd = new SqlCommand("select max(log_id)+1 from inventory_data_log", con);
            object result = cmd.ExecuteScalar();
            //if the  table bill_no column is not null
            if (result != DBNull.Value)
            {
                int i = Convert.ToInt32(result);
                txt_logid.Text = i.ToString();
            }
            //if the  table bill_no column is null
            else
            {
                txt_logid.Text = "1";
            }

        }
        public void stock_update()
        {
            txt_logid.Enabled = true;
            txt_qty.Enabled = true;
            txt_name.Enabled = true;
            txt_unit.Enabled = true;
            cmb_category.Enabled = true;
           
            datet.Enabled = true;
            txt_uprice.Enabled = true;
            btn_insert.Enabled = true;
            btn_update_stock.Enabled = false;
         

        }
        public void inventort_update()
        {
            txt_uprice.Enabled = false;
            txt_logid.Enabled = true;
            txt_qty.Enabled = true;
            txt_name.Enabled = false;
            txt_unit.Enabled = false;
            cmb_category.Enabled = false;
           
            datet.Enabled = false;

            btn_insert.Enabled = false;
            btn_update_stock.Enabled = true;

        }

        public void clear_update()
        {
            txt_uprice.Enabled = true;
            txt_logid.Enabled = true;
            txt_qty.Enabled = true;
            txt_name.Enabled = true;
            txt_unit.Enabled = true;
            cmb_category.Enabled = true;

            datet.Enabled = true;

            btn_insert.Enabled = true;
          

        }
        public void inven_dis()
        {

            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT  [log_id] as LOG_ID,[id] as ID,[name] as Name,[category] as Category,[date] as Date,[qty] as Qty,[unit] as Unit,[unit_price] as Unit_Price FROM[inventory_data_log] ", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            dgv_inven.DataSource = dtbl;

        }
        public void stock_id()
        {
               String query_search = "select id,name,category,qty,unit,unit_price from stock where id ='" + cmb_id.Text + "'";
            con.Open();
            SqlCommand cmnd = new SqlCommand(query_search, con);
                SqlDataReader r = cmnd.ExecuteReader();

                  r.Read();
                if (r.HasRows)
                {
                
                    txt_name.Text = r[1].ToString();
                    cmb_category.Text = r[2].ToString();
                    txt_qty.Text = r[3].ToString();
                    txt_unit.Text = r[4].ToString();
                    txt_uprice.Text = r[5].ToString();



                }
            r.Close();
            con.Close();

            }
        

        private void btn_Search_Click(object sender, EventArgs e)
        {
            clear();
            if (txt_logid.Text != "")
            {
                //con.Open();
                //inven_dis();
                //con.Close();

                inventort_update();
                con.Open();

                String query_search = "select * from inventory_data_log where log_id ='" + txt_logid.Text + "'";
                SqlCommand cmnd = new SqlCommand(query_search, con);
                SqlDataReader r = cmnd.ExecuteReader();


                while (r.Read())
                {

                    cmb_id.Text = r[1].ToString();
                    txt_name.Text = r[2].ToString();
                    cmb_category.Text = r[3].ToString();
                    DateTime dateValue = r.GetDateTime(4);
                    datet.Value = dateValue;
                    txt_qty.Text = r[5].ToString();
                    txt_unit.Text = r[6].ToString();
                    txt_uprice.Text = r[7].ToString();
                   


                }
                r.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("ENTER THE ID");
            }
         
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
           
            con.Open();
            autoin();
            inven_dis();
            con.Close();
            clear();
            
        }

        public void clear()
        {
            
            txt_name.Clear();
            // cmb_category.SelectedIndex=0;
            datet.Value = DateTime.Now;
            txt_qty.Clear();
            txt_unit.Clear();
            txt_uprice.Clear();
            clear_update();
        }
        public void item_id()
        {
            cmb_id.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id from stock ORDER BY id ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmb_id.Items.Add(dr["id"].ToString());


            }
        }
        void StyleDatagridview()
        {
            dgv_inven.BorderStyle = BorderStyle.None;
            dgv_inven.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_inven.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_inven.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv_inven.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_inven.EnableHeadersVisualStyles = false;
            dgv_inven.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_inven.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            dgv_inven.RowTemplate.Height = 30;
            dgv_inven.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgv_inven.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_inven.BackgroundColor = Color.FromArgb(46, 51, 73);




        }
      

        private void btn_insert_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txt_logid.Text !="" && cmb_id.Text != "" && txt_name.Text != "" && txt_qty.Text != "" )
            {
                
         
            int id = Convert.ToInt32(cmb_id.Text);
            int qty = Convert.ToInt32(txt_qty.Text);
            float punit = (float)Convert.ToDouble(txt_uprice.Text);
           

            string add = "insert into inventory_data_log (id,name,category,date,qty,unit,unit_price) values ('" + id + "','" + txt_name.Text + "','" + cmb_category.Text + "','" + datet.Value + "','" + qty + "','" + txt_unit.Text + "','" + punit + "')";
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
                        string add_stock = "insert into stock (id,name,category,qty,unit,unit_price) values ('" + id + "','" + txt_name.Text + "','" + cmb_category.Text + "','" + qty + "','" + txt_unit.Text + "','" + punit + "')";
                        SqlCommand cmds = new SqlCommand(add_stock, con);
                        cmds.ExecuteNonQuery();

                        MessageBox.Show("Item Inserted Sucessfully.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        autoin();
                        
                        txt_name.Clear();
                        // cmb_category.SelectedIndex=0;
                        datet.Value = DateTime.Now;
                        txt_qty.Clear();
                        txt_unit.Clear();
                        txt_uprice.Clear();
                        inven_dis();
                        item_id();

                    }
                    // If the value does exist, insert the record
                    else if (count != 0)
                    {
                        string update_qty = "update stock set qty = qty+'" + qty + "' where id ='" + id + "'";
                        SqlCommand cmds = new SqlCommand(update_qty, con);

                        cmds.ExecuteNonQuery();
                        MessageBox.Show("Item Updated Sucessfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        autoin();
                        inven_dis();
                        txt_name.Clear();
                        // cmb_category.SelectedIndex=0;
                        datet.Value = DateTime.Now;
                        txt_qty.Clear();
                        txt_unit.Clear();
                        txt_uprice.Clear();

                    }
                }
            }
            else
            {
                MessageBox.Show("insert the detatils.", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            con.Close();
        }

        private void inventroyp_Load(object sender, EventArgs e)
        {
          
            con.Open();
            autoin();
            inven_dis();
            item_id();
            con.Close();

            rdb_input.Checked = true;
            StyleDatagridview();

            string position = login.uposition;

            if (position=="Cashier")
            {
                gb_inventory.Enabled = false;
            }


        } 
        private void btn_update_stock_Click(object sender, EventArgs e)
        {
            if (txt_logid.Text != "" && cmb_id.Text != "" && txt_name.Text != "" && txt_qty.Text != "")
            {

                int id = Convert.ToInt32(cmb_id.Text);
                int log_id = Convert.ToInt32(txt_logid.Text);
                int price = Convert.ToInt32(txt_uprice.Text);
                int qty = Convert.ToInt32(txt_qty.Text);
                string update_price_qty = "update inventory_data_log set unit_price = '" + price + "', qty = '" + qty + "' where log_id ='" + log_id + "'";

                string qty_old = "select qty from inventory_data_log where log_id ='" + log_id + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(qty_old, con);
                int old_qty = (int)cmd.ExecuteScalar();


                DialogResult rs = MessageBox.Show("Are You sure want to Update", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (rs == DialogResult.Yes)
                {
                    string update_old = "update stock set qty = qty-'" + old_qty + "' where id ='" + id + "'";
                    string update_new = "update stock set qty = qty+'" + qty + "' where id ='" + id + "'";

                    SqlCommand cmd1 = new SqlCommand(update_old, con);
                    SqlCommand cmd2 = new SqlCommand(update_new, con);
                    SqlCommand cmds = new SqlCommand(update_price_qty, con);
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmds.ExecuteNonQuery();
                    MessageBox.Show("Item Updated Sucessfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    stock_update();

                    inven_dis();
                }
                else if (rs == DialogResult.No)
                {

                    stock_update();
                }
            }
            else
            {
                MessageBox.Show("Search the Record need to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                stock_update();
            }
            con.Close();

        }
        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_logid.Text != "" && cmb_id.Text != "" && txt_qty.Text != "")
            {
                con.Open();
                DialogResult rs = MessageBox.Show("Are You sure want to Delete the Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (rs == DialogResult.Yes)
                {

                    int log_id = Convert.ToInt32(txt_logid.Text);
                    int id = Convert.ToInt32(cmb_id.Text);
                    int qty = Convert.ToInt32(txt_qty.Text);
                    string delete_inven = "delete from inventory_data_log where log_id='" + log_id + "'";
                    string update_qty_delete = "update stock set qty = qty-'" + qty + "' where id ='" + id + "'";

                    SqlCommand cmd_del = new SqlCommand(delete_inven, con);
                    SqlCommand cmd_update = new SqlCommand(update_qty_delete, con);

                    cmd_del.ExecuteNonQuery();
                    cmd_update.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    autoin();
                    item_id();

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
                MessageBox.Show("Select the record first need to Delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
         
           
        }

        private void btn_filter_search_Click(object sender, EventArgs e)
        {
            dgv_inven.Refresh();
            con.Open();
            //  string type = cmb_type.ToString();
            // string value = txt_search.ToString();

            if (rdb_input.Checked)
            {
                if (cmb_type.Text == "name")
                {
                   // int id = Convert.ToInt32(txt_search.Text);
                    SqlDataAdapter sqldata = new SqlDataAdapter("SELECT  [log_id] as LOG_ID,[id] as ID,[name] as Name,[category] as Category,[date] as Date,[qty] as Qty,[unit] as Unit,[unit_price] as Unit_Price FROM[inventory_data_log] where  name like '" + txt_search.Text + "%'", con);
                    DataTable dtbl = new DataTable();
                    sqldata.Fill(dtbl);
                    dgv_inven.DataSource = dtbl;
                }
                
                else if (cmb_type.Text == "category")
                {
                    SqlDataAdapter sqldata = new SqlDataAdapter("SELECT  [log_id] as LOG_ID,[id] as ID,[name] as Name,[category] as Category,[date] as Date,[qty] as Qty,[unit] as Unit,[unit_price] as Unit_Price FROM[inventory_data_log]  where  category like '" + txt_search.Text + "%'", con);
                    DataTable dtbl = new DataTable();
                    sqldata.Fill(dtbl);
                    dgv_inven.DataSource = dtbl;
                }
            }
            else if (rdb_date.Checked)
            {
                SqlDataAdapter sqldata = new SqlDataAdapter("SELECT  [log_id] as LOG_ID,[id] as ID,[name] as Name,[category] as Category,[date] as Date,[qty] as Qty,[unit] as Unit,[unit_price] as Unit_Price FROM[inventory_data_log] where date between '" + dtp_start.Value.ToString("MM/dd/yyyy") + "' and '" + dtp_end.Value.ToString("MM/dd/yyyy") + "'", con);

                DataTable dtbl = new DataTable();
                sqldata.Fill(dtbl);
                dgv_inven.DataSource = dtbl;

            }
            con.Close();

            }

        private void btn_id_search_Click_1(object sender, EventArgs e)
        {
            clear();
            stock_id();
            btn_update_stock.Enabled = false;
        }

        private void rdb_input_CheckedChanged(object sender, EventArgs e)
        {
            txt_search.Enabled = true;
            cmb_type.Enabled = true;
            dtp_start.Enabled = false;
            dtp_end.Enabled = false;
        }

        private void rdb_date_CheckedChanged(object sender, EventArgs e)
        {
            dtp_start.Enabled = true;
            dtp_end.Enabled = true;
            txt_search.Enabled = false;
            cmb_type.Enabled = false;
        }

        private void txt_logid_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

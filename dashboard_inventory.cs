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
    public partial class dashboard_inventory : UserControl
    {
        public dashboard_inventory()
        {
            InitializeComponent();
        }
        private static dashboard_inventory _dashboard_inventory;
        public static dashboard_inventory _dash_inventory
        {
            get
            {
                if (_dashboard_inventory == null)
                    _dashboard_inventory = new dashboard_inventory();
                return _dashboard_inventory;
                {

                }
            }
        }
        public SqlConnection con = new SqlConnection(@"Data Source=HAZEEB\SQLEXPRESS;Initial Catalog=vcafe_db;Integrated Security=True");

        public void sale_profit()
        {
            con.Open();
            string total_sale = "select sum(net_total) from bill_info";
            SqlCommand cmd = new SqlCommand(total_sale, con);
            int sale = Convert.ToInt32(cmd.ExecuteScalar());

            int sum_cost = 0;
            string total_bill_id = "select bill_no from bill_info ";
            SqlCommand cmd_bill_no = new SqlCommand(total_bill_id, con);
            SqlDataReader r = cmd_bill_no.ExecuteReader();
            List<int> bill_no = new List<int>();


            while (r.Read())
            {

                int id = Convert.ToInt32(r["bill_no"]);
                //add the s_id int vlue to the list sIds
                bill_no.Add(id);

            }
            r.Close();
            foreach (int id in bill_no)
            {
                string find_pid = "select p_id from bill_order where bill_no='" + id + "'";
                SqlCommand cmd_pid = new SqlCommand(find_pid, con);
                SqlDataReader r_pid = cmd_pid.ExecuteReader();
                List<int> p_idlist = new List<int>();

                while (r_pid.Read())
                {
                    int p_id = Convert.ToInt32(r_pid["p_id"]);
                    //add the s_id int vlue to the list sIds
                    p_idlist.Add(p_id);
                }
                r_pid.Close();
                foreach (int pid in p_idlist)
                {
                    string f_cost = "select cost from product where p_id='" + pid + "'";
                    SqlCommand cmd_cost = new SqlCommand(f_cost, con);
                    int cost = Convert.ToInt32(cmd_cost.ExecuteScalar());
                    sum_cost += cost;


                }
            }
            int tota_profit = sale - sum_cost;
            lblcus.Text = tota_profit.ToString();
            con.Close();
        }
        public void date_(string start)
        {
            con.Open();
            string total_sale = "select sum(net_total) from bill_info where date between  GETDATE()" + start + " and  GETDATE()";
            SqlCommand cmd = new SqlCommand(total_sale, con);

            object result = cmd.ExecuteScalar();
            //if the  table bill_no column is not null
            if (result != DBNull.Value)
            {
                int sale = Convert.ToInt32(result);
                int sum_cost = 0;
                string total_bill_id = "select bill_no from bill_info where date between  GETDATE()" + start + " and  GETDATE()";

                SqlCommand cmd_bill_no = new SqlCommand(total_bill_id, con);
                SqlDataReader r = cmd_bill_no.ExecuteReader();
                List<int> bill_no = new List<int>();


                while (r.Read())
                {

                    int id = Convert.ToInt32(r["bill_no"]);
                    //add the s_id int vlue to the list sIds
                    bill_no.Add(id);

                }
                r.Close();
                foreach (int id in bill_no)
                {
                    string find_pid = "select p_id from bill_order where bill_no='" + id + "'";
                    SqlCommand cmd_pid = new SqlCommand(find_pid, con);
                    SqlDataReader r_pid = cmd_pid.ExecuteReader();
                    List<int> p_idlist = new List<int>();

                    while (r_pid.Read())
                    {
                        int p_id = Convert.ToInt32(r_pid["p_id"]);
                        //add the s_id int vlue to the list sIds
                        p_idlist.Add(p_id);
                    }
                    r_pid.Close();
                    foreach (int pid in p_idlist)
                    {
                        string f_cost = "select cost from product where p_id='" + pid + "'";
                        SqlCommand cmd_cost = new SqlCommand(f_cost, con);
                        int cost = Convert.ToInt32(cmd_cost.ExecuteScalar());
                        sum_cost += cost;


                    }

                }

                int tota_profit = sale - sum_cost;
                lblcus.Text = tota_profit.ToString();

            }
            //if the  table bill_no column is null
            else
            {
                lblcus.Text = "0";
            }


            con.Close();
        }

        void StyleDatagridview()
        {

            dgv_stock_qty.BorderStyle = BorderStyle.None;
            dgv_stock_qty.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_stock_qty.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_stock_qty.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv_stock_qty.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_stock_qty.EnableHeadersVisualStyles = false;
            dgv_stock_qty.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_stock_qty.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            dgv_stock_qty.RowTemplate.Height = 30;
            dgv_stock_qty.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgv_stock_qty.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_stock_qty.BackgroundColor = Color.FromArgb(46, 51, 73);

            dgv_selling_p.BorderStyle = BorderStyle.None;
            dgv_selling_p.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_selling_p.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_selling_p.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv_selling_p.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_selling_p.EnableHeadersVisualStyles = false;
            dgv_selling_p.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_selling_p.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            dgv_selling_p.RowTemplate.Height = 30;
            dgv_selling_p.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgv_selling_p.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_selling_p.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgv_selling_p.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
        public void stock_dis()
        {


            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT id as ID,name as Name,qty as Qty,unit as Unit  FROM stock where qty <=100", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            dgv_stock_qty.DataSource = dtbl;

        }
        public void selling_dis()
        {

            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT top(8) p_id as ID, name as Name, COUNT(*) as count FROM bill_order GROUP BY p_id, name HAVING COUNT(*) > 1 ORDER BY count DESC", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            dgv_selling_p.DataSource = dtbl;

        }
        private void btn_get_Click(object sender, EventArgs e)
        {

            {
                con.Open();
                string total_sale = "select sum(net_total) from bill_info where date between '" + date_start.Value.ToString("MM/dd/yyyy") + "' and '" + date_end.Value.ToString("MM/dd/yyyy") + "'";
                SqlCommand cmd = new SqlCommand(total_sale, con);
                // int sale = Convert.ToInt32(cmd.ExecuteScalar());

                object result = cmd.ExecuteScalar();
                //if the  table bill_no column is not null
                if (result != DBNull.Value)
                {
                    int sale = Convert.ToInt32(result);
                    int sum_cost = 0;
                    string total_bill_id = "select bill_no from bill_info where date between '" + date_start.Value.ToString("MM/dd/yyyy") + "' and '" + date_end.Value.ToString("MM/dd/yyyy") + "'";
                    SqlCommand cmd_bill_no = new SqlCommand(total_bill_id, con);
                    SqlDataReader r = cmd_bill_no.ExecuteReader();
                    List<int> bill_no = new List<int>();


                    while (r.Read())
                    {

                        int id = Convert.ToInt32(r["bill_no"]);
                        //add the s_id int vlue to the list sIds
                        bill_no.Add(id);

                    }
                    r.Close();
                    foreach (int id in bill_no)
                    {
                        string find_pid = "select p_id from bill_order where bill_no='" + id + "'";
                        SqlCommand cmd_pid = new SqlCommand(find_pid, con);
                        SqlDataReader r_pid = cmd_pid.ExecuteReader();
                        List<int> p_idlist = new List<int>();

                        while (r_pid.Read())
                        {
                            int p_id = Convert.ToInt32(r_pid["p_id"]);
                            //add the s_id int vlue to the list sIds
                            p_idlist.Add(p_id);
                        }
                        r_pid.Close();
                        foreach (int pid in p_idlist)
                        {
                            string f_cost = "select cost from product where p_id='" + pid + "'";
                            SqlCommand cmd_cost = new SqlCommand(f_cost, con);
                            int cost = Convert.ToInt32(cmd_cost.ExecuteScalar());
                            sum_cost += cost;


                        }
                    }

                    int tota_profit = sale - sum_cost;

                    lblcus.Text = tota_profit.ToString();

                }
                //if the  table bill_no column is null
                else
                {
                    lblcus.Text = "0";
                }

                con.Close();
            }

        }

        private void btday_Click(object sender, EventArgs e)
        {
            date_("-1");
        }

        private void btn7day_Click(object sender, EventArgs e)
        {
            date_("-7");
        }

        private void btnmonth_Click(object sender, EventArgs e)
        {
            date_("-30");
        }

        private void dashboard_inventory_Load(object sender, EventArgs e)
        {
            lbl_inven.Text = login.uposition;
            lbl_dstart.Text = date_start.Text;
            lbl_dend.Text = date_end.Text;
            sale_profit();
            stock_dis();
            selling_dis();
            StyleDatagridview();
        }

        private void lbl_dstart_Click(object sender, EventArgs e)
        {
            date_start.Select();
            SendKeys.Send("%{down}");
        }

        private void lbl_dend_Click(object sender, EventArgs e)
        {
            date_start.Select();
            SendKeys.Send("%{down}");
        }

        private void date_start_ValueChanged(object sender, EventArgs e)
        {
            lbl_dstart.Text = date_start.Text;
        }

        private void date_end_ValueChanged(object sender, EventArgs e)
        {
            lbl_dend.Text = date_end.Text;
        }
    }
}

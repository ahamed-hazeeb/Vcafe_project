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
    public partial class dashboard : UserControl
    {
       
        public dashboard()
        {
            InitializeComponent();
        }
        private static dashboard _dashboard;
        public static dashboard _dash
        {
            get
            {
                if (_dashboard == null)
                    _dashboard = new dashboard();
                return _dashboard;
                {

                }
            }
        }
        public SqlConnection con = new SqlConnection(@"Data Source=HAZEEB\SQLEXPRESS;Initial Catalog=vcafe_db;Integrated Security=True");

        void StyleDatagridview()
        {
           
            dgv_user.BorderStyle = BorderStyle.None;
            dgv_user.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_user.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_user.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv_user.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_user.EnableHeadersVisualStyles = false;
            dgv_user.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_user.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            dgv_user.RowTemplate.Height = 30;
            dgv_user.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgv_user.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_user.BackgroundColor = Color.FromArgb(46, 51, 73);

            dgv_user_log.BorderStyle = BorderStyle.None;
            dgv_user_log.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_user_log.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_user_log.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv_user_log.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_user_log.EnableHeadersVisualStyles = false;
            dgv_user_log.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_user_log.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            dgv_user_log.RowTemplate.Height = 30;
            dgv_user_log.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgv_user_log.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_user_log.BackgroundColor = Color.FromArgb(46, 51, 73);
        }
        public void user_dis()
        {
            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT uid as ID,uname as Name,position as Postion FROM login ", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            dgv_user.DataSource = dtbl;
        }
        public void userlog_dis()
        {

            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT id as ID, uname as Name,date as Date,status as Status FROM login_info ", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            dgv_user_log.DataSource = dtbl;

        }
        public void sale_profit()
        {
            con.Open();
            string total_sale = "select sum(net_total) from bill_info";
            SqlCommand cmd = new SqlCommand(total_sale, con);
            int sale = Convert.ToInt32(cmd.ExecuteScalar());
  
            int sum_cost = 0;
            string total_bill_id = "select bill_no from bill_info ";
            SqlCommand cmd_bill_no = new SqlCommand(total_bill_id, con);
            SqlDataReader r= cmd_bill_no.ExecuteReader();
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
        private void dashboard_Load(object sender, EventArgs e)
        {
            lbl_admin.Text = login.uposition;
            lbl_dstart.Text = date_start.Text;
            lbl_dend.Text = date_end.Text;
            sale_profit();
            user_dis();
            userlog_dis();
            StyleDatagridview();
        }

        private void btn_get_Click(object sender, EventArgs e)
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

        private void lbl_dstart_Click(object sender, EventArgs e)
        {
            date_start.Select();
            SendKeys.Send("%{down}");
        }

        private void lbl_dend_Click(object sender, EventArgs e)
        {
            date_end.Select();
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

        private void dgv_user_log_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

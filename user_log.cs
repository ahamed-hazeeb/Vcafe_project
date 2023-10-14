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
    public partial class user_log : UserControl
    {
        public user_log()
        {
            InitializeComponent();
        }
        private static user_log _user_log;
        public static user_log _user
        {
            get
            {
                if (_user_log == null)
                    _user_log = new user_log();
                return _user_log;
                {

                }
            }
        }

        public SqlConnection con = new SqlConnection(@"Data Source=HAZEEB\SQLEXPRESS;Initial Catalog=vcafe_db;Integrated Security=True");

        void StyleDatagridview()
        {
            dgv_log.BorderStyle = BorderStyle.None;
            dgv_log.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_log.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_log.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv_log.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_log.EnableHeadersVisualStyles = false;
            dgv_log.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_log.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            dgv_log.RowTemplate.Height = 30;
            dgv_log.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgv_log.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_log.BackgroundColor = Color.FromArgb(46, 51, 73);




        }
        public void user_dis()
        {

            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT id as ID,uname as Name,date as Date,status as Status FROM login_info ", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            dgv_log.DataSource = dtbl;

        }
        private void rdb_input_Click(object sender, EventArgs e)
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

        private void user_log_Load(object sender, EventArgs e)
        {
            rdb_input.Checked=true;
            con.Open();
            user_dis();
            con.Close();
            StyleDatagridview();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            con.Open();
          //  string type = cmb_type.ToString();
           // string value = txt_search.ToString();

            if (rdb_input.Checked)
            {
                if (cmb_type.Text=="id" && txt_search.Text!="")
                {
                    int id = Convert.ToInt32(txt_search.Text);
                    SqlDataAdapter sqldata = new SqlDataAdapter("SELECT  id as ID,uname as Name,date as Date,status as Status FROM login_info where  id = '" + id + "'", con);
                    DataTable dtbl = new DataTable();
                    sqldata.Fill(dtbl);
                    dgv_log.DataSource = dtbl;
                }
                else if (cmb_type.Text == "uname")
                {
                    SqlDataAdapter sqldata = new SqlDataAdapter("SELECT  id as ID,uname as Name,date as Date,status as Status FROM login_info where  uname like '" + txt_search.Text + "%'", con);
                    DataTable dtbl = new DataTable();
                    sqldata.Fill(dtbl);
                    dgv_log.DataSource = dtbl;
                }
                else if (cmb_type.Text == "status")
                {
                    SqlDataAdapter sqldata = new SqlDataAdapter("SELECT  id as ID,uname as Name,date as Date,status as Status FROM login_info where  status like '" + txt_search.Text + "%'", con);
                    DataTable dtbl = new DataTable();
                    sqldata.Fill(dtbl);
                    dgv_log.DataSource = dtbl;
                }
                else
                {
                    MessageBox.Show("Filled Is Empty", "Fill");
                }




            }
            else if (rdb_date.Checked)
            {
               SqlDataAdapter sqldata = new SqlDataAdapter("SELECT  id as ID,uname as Name,date as Date,status as Status FROM login_info where date between '" + dtp_start.Value.ToString("MM/dd/yyyy") + "' and '" + dtp_end.Value.ToString("MM/dd/yyyy") + "'", con);

                DataTable dtbl = new DataTable();
                sqldata.Fill(dtbl);
                dgv_log.DataSource = dtbl;

            }
            con.Close();
         
        }

        private void rdb_input_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

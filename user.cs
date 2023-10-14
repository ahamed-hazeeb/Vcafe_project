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
    public partial class user : UserControl
    {
        public user()
        {
            InitializeComponent();
        }
        private static user _usercreate;
        public static user _user
        {
            get
            {
                if (_usercreate == null)
                    _usercreate = new user();
                return _usercreate;
                {

                }
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=HAZEEB\SQLEXPRESS;Initial Catalog=vcafe_db;Integrated Security=True");
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
        }
        public void user_dis()
        {
            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT uid as ID,uname as Name,position as Postion FROM login ", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            dgv_user.DataSource = dtbl;
        }
        public void autoid()
        {
            SqlCommand cmd = new SqlCommand("select max(uid)+1 from login ", con);
            int id = (int)cmd.ExecuteScalar();
            txt_id.Text = id.ToString();
        }
        public void clear()
        {
            txt_name.Text = "";
            txt_pass.Text = "";
            txt_confirm_pass.Text = "";
            autoid();
            user_dis();
        }
        private void user_Load(object sender, EventArgs e)
        {
            con.Open();
            autoid();
            user_dis();
            con.Close();
            StyleDatagridview();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string pass = txt_pass.Text;
            string confirm_pass = txt_confirm_pass.Text;
            if (txt_id.Text != "" && txt_name.Text != "" && pass != "" && confirm_pass != "" && cmb_position.Text != "")
            {
                if (pass == confirm_pass)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into login values('" + id + "','" + txt_name.Text + "','" + pass + "','" + cmb_position.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert");
                    clear();
                
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Password Not Matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Input the information", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_id.Text!="")
            {
                btn_add.Enabled = false;
                btn_update.Enabled = true;

                int id = Convert.ToInt32(txt_id.Text);
                con.Open();
                SqlCommand cmd = new SqlCommand("select uname,position from login where uid = '" + id + "'", con);
                SqlDataReader r = cmd.ExecuteReader();
                r.Read();
                if (r.HasRows)
                {
                    txt_name.Text = r["uname"].ToString();
                    cmb_position.Text = r["position"].ToString();
                }
                con.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            con.Open();
            clear();
            con.Close();
            btn_add.Enabled = true;
            btn_update.Enabled = false;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            DialogResult rs = MessageBox.Show("Are You sure want to Delete Record", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (rs == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from login where uid= '" + id + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            
                con.Close();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string pass = txt_pass.Text;
            string confirm_pass = txt_confirm_pass.Text;
            if (txt_id.Text != "" && txt_name.Text != "" && pass != "" && confirm_pass != "" && cmb_position.Text != "")
            {
                if (pass == confirm_pass)
                {
                    btn_add.Enabled = true;
                    SqlCommand cmd = new SqlCommand("update login set uname='"+txt_name.Text+"',upass='"+pass+"',position='"+cmb_position.Text+"' where uid ='"+id+"'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    clear();
                    con.Close();
                    MessageBox.Show("User Details Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Password Not Matched", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Input the information", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    
    }
}

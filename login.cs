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
    public partial class login : Form
    {

        public SqlConnection con = new SqlConnection(@"Data Source=HAZEEB\SQLEXPRESS;Initial Catalog=vcafe_db;Integrated Security=True");


        public static string name = "";
        public static string uposition = "";
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            con.Open();

            SqlCommand userp = new SqlCommand("select uid,uname,upass,position from login where uname='" + username + "'and upass='" + password + "'", con);
         
            SqlDataReader r = userp.ExecuteReader();

            while (r.Read())
            {
                uposition = r["position"].ToString();
            }

            con.Close();

            con.Open();
           

            SqlCommand cmd = new SqlCommand("select uid,uname,upass from login where uname='" + username + "'and upass='" + password + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                
                name = username;
                MessageBox.Show("Welcome " + username + " Login Sucess");
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
                //send data to user log
                string sql = "INSERT INTO login_info  VALUES('" + username + "',getdate(),'login')";
                SqlCommand cmnd = new SqlCommand(sql, con);
                cmnd.ExecuteNonQuery();



            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are You sure want to Close", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (rs == DialogResult.Yes)
            {
               
                Application.Exit();
            }
        }

       

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Form1 _obj;
        bool sliderexp;

        public static Form1 instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return pnl_main; }
            set { pnl_main = value; }
        }

        SqlConnection con = new SqlConnection(@"Data Source=HAZEEB\SQLEXPRESS;Initial Catalog=vcafe_db;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_name.Text = login.name;
            lbl_position.Text = login.uposition;

            if (lbl_position.Text == "Admin")
            {
               
            }
            else if (lbl_position.Text == "Inventory")
            {
                btn_bill.Enabled = false;
                btn_report.Enabled = false;
                btn_user.Enabled = false;
                btn_userlog.Enabled = false;
                btn_product.Enabled = false;
            }
            else if (lbl_position.Text == "Cashier")
            {
                btn_report.Enabled = false;
                btn_user.Enabled = false;
                btn_userlog.Enabled = false;
                btn_product.Enabled = false;
            }
            panel_change();

        }

        private void product1_Load(object sender, EventArgs e)
        {

        }

        private void billing1_Load(object sender, EventArgs e)
        {

        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            btn_bill.BackColor = Color.FromArgb(46, 51, 73);
            if (!pnl_main.Controls.Contains(billing._bill))
            {
                pnl_main.Controls.Add(billing._bill);
                billing._bill.Dock = DockStyle.Fill;
                billing._bill.BringToFront();
            }
            else
            {
                billing._bill.BringToFront();
            }
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            btn_inventory.BackColor= Color.FromArgb(46, 51, 73);
            if (!pnl_main.Controls.Contains(inventroyp._inven))
            {
                pnl_main.Controls.Add(inventroyp._inven);
                inventroyp._inven.Dock = DockStyle.Fill;
                inventroyp._inven.BringToFront();
            }
            else
            {
                inventroyp._inven.BringToFront();
            }
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            btn_product.BackColor = Color.FromArgb(46, 51, 73);
            if (!pnl_main.Controls.Contains(product._productv))
            {
                pnl_main.Controls.Add(product._productv);
                product._productv.Dock = DockStyle.Fill;
                product._productv.BringToFront();
            }
            else
            {
                product._productv.BringToFront();
            }
        }

        private void btn_bill_Leave(object sender, EventArgs e)
        {
            btn_bill.BackColor = Color.FromArgb(50, 30, 54);
        }

        private void btn_inventory_Leave(object sender, EventArgs e)
        {
            btn_inventory.BackColor = Color.FromArgb(50, 30, 54);
        }

        private void btn_product_Leave(object sender, EventArgs e)
        {
            btn_product.BackColor = Color.FromArgb(50, 30, 54);
        }

        private void slide_Tick(object sender, EventArgs e)
        {

            if (sliderexp)
            {


                pnl_menu.Width -= 10;
                //  iconm.Width -= 10;

                if (pnl_menu.Width == pnl_menu.MinimumSize.Width )
                {
                    sliderexp = false;
                   // mname.Visible = false;
                    slide.Stop();

                }
            }
            else
            {
                pnl_menu.Width += 10;
                
                // iconm.Width += 10;
                if (pnl_menu.Width == pnl_menu.MaximumSize.Width )
                {
                    sliderexp = true;
                   // mname.Visible = true;
                    slide.Stop();
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            slide.Start();

            btn_menu.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_menu_Leave(object sender, EventArgs e)
        {
            btn_menu.BackColor = Color.FromArgb(50, 30, 54);
        }

        private void Report_Click(object sender, EventArgs e)
        {
            btn_report.BackColor = Color.FromArgb(46, 51, 73);

            if (!pnl_main.Controls.Contains(view_sales_summery._view_sales))
            {
                pnl_main.Controls.Add(view_sales_summery._view_sales);
                view_sales_summery._view_sales.Dock = DockStyle.Fill;
                view_sales_summery._view_sales.BringToFront();
            }
            else
            {
                view_sales_summery._view_sales.BringToFront();
            }
        }
    

        private void Report_Leave(object sender, EventArgs e)
        {
            btn_report.BackColor = Color.FromArgb(50, 30, 54);

        }

        private void pnl_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            btn_stock.BackColor = Color.FromArgb(46, 51, 73);

            if (!pnl_main.Controls.Contains(stock._stock))
            {
                pnl_main.Controls.Add(stock._stock);
                stock._stock.Dock = DockStyle.Fill;
                stock._stock.BringToFront();
            }
            else
            {
                stock._stock.BringToFront();
            }
        }

        private void btn_stock_Leave(object sender, EventArgs e)
        {
            btn_stock.BackColor = Color.FromArgb(50, 30, 54);
        }

        private void btn_dashbord_Click(object sender, EventArgs e)
        {
            btn_dashbord.BackColor = Color.FromArgb(46, 51, 73);

            if (lbl_position.Text == "Admin")
            {


                if (!pnl_main.Controls.Contains(dashboard._dash))
                {
                    pnl_main.Controls.Add(dashboard._dash);
                    dashboard._dash.Dock = DockStyle.Fill;
                    dashboard._dash.BringToFront();
                }
                else
                {
                    dashboard._dash.BringToFront();
                }
            }
            else if (lbl_position.Text == "Inventory")
            {

                if (!pnl_main.Controls.Contains(dashboard_inventory._dash_inventory))
                {
                    pnl_main.Controls.Add(dashboard_inventory._dash_inventory);
                    dashboard_inventory._dash_inventory.Dock = DockStyle.Fill;
                    dashboard_inventory._dash_inventory.BringToFront();

                }
                else
                {
                    dashboard_inventory._dash_inventory.BringToFront();
                }
            }
            else if (lbl_position.Text == "Cashier")
            {


                if (!pnl_main.Controls.Contains(dashboard_cashier._dash_cahier))
                {
                    pnl_main.Controls.Add(dashboard_cashier._dash_cahier);
                    dashboard_cashier._dash_cahier.Dock = DockStyle.Fill;
                    dashboard_cashier._dash_cahier.BringToFront();
                }
                else
                {
                    dashboard_cashier._dash_cahier.BringToFront();
                }
            }
        }

        private void btn_dashbord_Leave(object sender, EventArgs e)
        {
            btn_dashbord.BackColor = Color.FromArgb(50, 30, 54);
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void btn_userlog_Click(object sender, EventArgs e)
        {
            btn_userlog.BackColor = Color.FromArgb(46, 51, 73);

            if (!pnl_main.Controls.Contains(user_log._user))
            {
                pnl_main.Controls.Add(user_log._user);
                user_log._user.Dock = DockStyle.Fill;
                user_log._user.BringToFront();
            }
            else
            {
                user_log._user.BringToFront();
            }
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            btn_user.BackColor = Color.FromArgb(46, 51, 73);

            if (!pnl_main.Controls.Contains(user._user))
            {
                pnl_main.Controls.Add(user._user);
                user._user.Dock = DockStyle.Fill;
                user._user.BringToFront();
            }
            else
            {
                user._user.BringToFront();
            }
        }

        private void btn_user_Leave(object sender, EventArgs e)
        {
            btn_user.BackColor = Color.FromArgb(50, 30, 54);
        }

        private void btn_userlog_Leave(object sender, EventArgs e)
        {
            btn_userlog.BackColor = Color.FromArgb(50, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are You sure want toLogout", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (rs == DialogResult.Yes)
            {
                con.Open();
                string sql = "INSERT INTO login_info  VALUES('" + lbl_name.Text + "',getdate(),'Logout')";
                SqlCommand cmnd = new SqlCommand(sql, con);
                cmnd.ExecuteNonQuery();
                con.Close();
                this.Hide();
                login login = new login();
                login.Show();
            }
        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {/*
   
            if (lbl_position.Text == "Admin")
            {
               

                if (!pnl_main.Controls.Contains(dashboard._dash))
                {
                    pnl_main.Controls.Add(dashboard._dash);
                    dashboard._dash.Dock = DockStyle.Fill;
                    dashboard._dash.BringToFront();
                }
                else
                {
                    dashboard._dash.BringToFront();
                }
            }
            else if (lbl_position.Text == "Inventory")
            {
              
                if (!pnl_main.Controls.Contains(dashboard_inventory._dash_inventory))
                {
                    pnl_main.Controls.Add(dashboard_inventory._dash_inventory);
                    dashboard_inventory._dash_inventory.Dock = DockStyle.Fill;
                    dashboard_inventory._dash_inventory.BringToFront();
                    
                }
                else
                {
                    dashboard_inventory._dash_inventory.BringToFront();
                }
            }
            else if (lbl_position.Text == "Cashier")
            {
              

                if (!pnl_main.Controls.Contains(dashboard_cashier._dash_cahier))
                {
                    pnl_main.Controls.Add(dashboard_cashier._dash_cahier);
                    dashboard_cashier._dash_cahier.Dock = DockStyle.Fill;
                    dashboard_cashier._dash_cahier.BringToFront();
                }
                else
                {
                    dashboard_cashier._dash_cahier.BringToFront();
                }
            }
            */
        }
        public void panel_change()
        {
            if (lbl_position.Text == "Admin")
            {


                if (!pnl_main.Controls.Contains(dashboard._dash))
                {
                    pnl_main.Controls.Add(dashboard._dash);
                    dashboard._dash.Dock = DockStyle.Fill;
                    dashboard._dash.BringToFront();
                }
                else
                {
                    dashboard._dash.BringToFront();
                }
            }
            else if (lbl_position.Text == "Inventory")
            {

                if (!pnl_main.Controls.Contains(dashboard_inventory._dash_inventory))
                {
                    pnl_main.Controls.Add(dashboard_inventory._dash_inventory);
                    dashboard_inventory._dash_inventory.Dock = DockStyle.Fill;
                    dashboard_inventory._dash_inventory.BringToFront();

                }
                else
                {
                    dashboard_inventory._dash_inventory.BringToFront();
                }
            }
            else if (lbl_position.Text == "Cashier")
            {


                if (!pnl_main.Controls.Contains(dashboard_cashier._dash_cahier))
                {
                    pnl_main.Controls.Add(dashboard_cashier._dash_cahier);
                    dashboard_cashier._dash_cahier.Dock = DockStyle.Fill;
                    dashboard_cashier._dash_cahier.BringToFront();
                }
                else
                {
                    dashboard_cashier._dash_cahier.BringToFront();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are You sure want to Close", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (rs == DialogResult.Yes)
            {
                con.Open();
                string sql = "INSERT INTO login_info  VALUES('" + lbl_name.Text + "',getdate(),'Logout')";
                SqlCommand cmnd = new SqlCommand(sql, con);
                cmnd.ExecuteNonQuery();
                con.Close();
                Application.Exit();
            }
        }
    }
    }


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
    public partial class view_inventory : UserControl
    {
        public view_inventory()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=HAZEEB\SQLEXPRESS;Initial Catalog=vcafe_db;Integrated Security=True");

        private void view_inventory_Load(object sender, EventArgs e)
        {
           inve_dis();
            inv.Start();


        }
        public void inve_dis()
        {
            con.Open();
            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT  * FROM inventory_data_log ", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            dgv_view_in.DataSource = dtbl;
            con.Close();
        }

        private void inv_Tick(object sender, EventArgs e)
        {
            inve_dis();
            inv.Start();

        }
    }
}

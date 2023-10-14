using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vcafe
{
    public partial class View_Invoice : UserControl
    {
        public View_Invoice()
        {
            InitializeComponent();
        }
        connection connect = new connection();
        
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            int bill_num = billing.bill_num;
            List<info_details> _list = new List<info_details>();
            DataSet ds = connect.bill_order(bill_num);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                _list.Add(new info_details
                {
                    p_id = dr["p_id"].ToString(),
                    name = dr["name"].ToString(),
                    price = dr["price"].ToString(),
                    qty = dr["qty"].ToString(),
                    amount = dr["amount"].ToString(),
                });

            }
            DataSet ds1 = connect.bill_info(bill_num);
            foreach (DataRow dr1 in ds1.Tables[0].Rows)
            {
                invoice1.SetDataSource(_list);
                invoice1.SetParameterValue("o_bill_no", dr1["bill_no"].ToString());
                invoice1.SetParameterValue("o_subtotal", dr1["sub_total"].ToString());
                invoice1.SetParameterValue("o_dis", dr1["discount"].ToString());
                invoice1.SetParameterValue("o_net", dr1["net_total"].ToString());
                invoice1.SetParameterValue("o_paid", dr1["paid_amount"].ToString());
                invoice1.SetParameterValue("o_bc", dr1["balance"].ToString());
                 invoice1.SetParameterValue("o_date",dr1["date"].ToString());
                invoice1.SetParameterValue("o_items", dr1["no_items"].ToString());
            }
            crystalReportViewer1.ReportSource = invoice1;

        }
       
    }
}

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
    public partial class view_sales_summery : UserControl
    {
        public view_sales_summery()
        {
            InitializeComponent();
        }
        connection connect = new connection();
        private static view_sales_summery _view_sales_summery;
        public static view_sales_summery _view_sales
        {
            get
            {
                if (_view_sales_summery == null)
                    _view_sales_summery = new view_sales_summery();
                return _view_sales_summery;
                {

                }
            }
        }


        private void view_sales_summery_Load(object sender, EventArgs e)
        {

            
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_search_bill_Click(object sender, EventArgs e)
        {
            List<sales_summery> _list = new List<sales_summery>();
            DataSet ds = connect.sales_summmery(dtp_start.Value,dtp_end.Value);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                _list.Add(new sales_summery
                {
                    bill_no = dr["bill_no"].ToString(),
                    no_items = dr["no_items"].ToString(),
                    sub_total = dr["sub_total"].ToString(),
                    discount = dr["discount"].ToString(),
                    net_total = dr["net_total"].ToString(),
                    paid_amount = dr["paid_amount"].ToString(),
                    balance = dr["balance"].ToString()

                });

            }

            int sum = connect.sales_summmery_max(dtp_start.Value, dtp_end.Value);
            sales_summery_report1.SetDataSource(_list);
            sales_summery_report1.SetParameterValue("sum_total", sum.ToString());
            sales_summery_report1.SetParameterValue("s_date", dtp_start.Value.ToString("MM/dd/yyyy"));
            sales_summery_report1.SetParameterValue("e_date", dtp_end.Value.ToString("MM/dd/yyyy"));
            crystalReportViewer1.ReportSource = sales_summery_report1;

        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            gb_sale.Visible = true;
            gb_inven.Visible = false;
            gb_stock.Visible = false;
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            gb_sale.Visible = false;
            gb_inven.Visible = true;
            gb_stock.Visible = false;
            rdb_inven_qty.Checked = true;
        }

        private void btn_inven_searc_Click(object sender, EventArgs e)
        {
            if (rdb_inven_qty.Checked)
            {

                List<inventpry_report> _list = new List<inventpry_report>();
                int qty = Convert.ToInt32(txt_inven_qty.Text);
                DataSet ds = connect.inventory_summery_qty(qty);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DateTime dateFromDatabase = Convert.ToDateTime(dr["date"]);
                    string date = dateFromDatabase.ToShortDateString();
                    _list.Add(new inventpry_report
                    {

                        Date = date,
                        Log_id = dr["log_id"].ToString(),
                        Id = dr["id"].ToString(),
                        Name = dr["name"].ToString(),
                        Category = dr["category"].ToString(),
                        Qty = dr["qty"].ToString(),
                        Unit = dr["unit"].ToString(),
                        Unit_price = dr["unit_price"].ToString()

                    });

                }

                inventory_report_1.SetDataSource(_list);
                
                inventory_report_1.SetParameterValue("qty",txt_inven_qty.Text);
                inventory_report_1.SetParameterValue("s_date"," ");
                inventory_report_1.SetParameterValue("e_date", " ");

                crystalReportViewer1.ReportSource = inventory_report_1;

            }
            else if (rdb_inven_date.Checked)
            {

                List<inventpry_report> _list = new List<inventpry_report>();
                DataSet ds = connect.inventory_summery(dtp_invent_start.Value, dtp_invent_end.Value);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DateTime dateFromDatabase = Convert.ToDateTime(dr["date"]);
                    string date = dateFromDatabase.ToShortDateString();
                    _list.Add(new inventpry_report
                    {

                        Date = date,
                        Log_id = dr["log_id"].ToString(),
                        Id = dr["id"].ToString(),
                        Name = dr["name"].ToString(),
                        Category = dr["category"].ToString(),
                        Qty = dr["qty"].ToString(),
                        Unit = dr["unit"].ToString(),
                        Unit_price = dr["unit_price"].ToString()

                    });

                }

                //int sum = connect.sales_summmery_max(dtp_start.Value, dtp_end.Value);
                inventory_report_1.SetDataSource(_list);
                // sales_summery_report1.SetParameterValue("sum_total", sum.ToString());
                inventory_report_1.SetParameterValue("qty", " ");
                inventory_report_1.SetParameterValue("s_date", dtp_invent_start.Value.ToString("MM/dd/yyyy"));
                inventory_report_1.SetParameterValue("e_date", dtp_invent_end.Value.ToString("MM/dd/yyyy"));
                crystalReportViewer1.ReportSource = inventory_report_1;

            }
        }

        private void btn_stock_search_Click(object sender, EventArgs e)
        {
            if (rdb_all.Checked)
            {
                List<inventpry_report> _list = new List<inventpry_report>();
               
                DataSet ds = connect.stock_summery_all();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    _list.Add(new inventpry_report
                    {


                        Id = dr["id"].ToString(),
                        Name = dr["name"].ToString(),
                        Category = dr["category"].ToString(),
                        Qty = dr["qty"].ToString(),
                        Unit = dr["unit"].ToString(),
                        Unit_price = dr["unit_price"].ToString()

                    });

                }

                stock_report1.SetDataSource(_list);
                stock_report1.SetParameterValue("qty","");
                crystalReportViewer1.ReportSource = stock_report1;

            }
            else if (rdb_qty.Checked)
            {
                List<inventpry_report> _list = new List<inventpry_report>();
                int qty = Convert.ToInt32(txt_qty.Text);
                DataSet ds = connect.stock_summery(qty);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    _list.Add(new inventpry_report
                    {


                        Id = dr["id"].ToString(),
                        Name = dr["name"].ToString(),
                        Category = dr["category"].ToString(),
                        Qty = dr["qty"].ToString(),
                        Unit = dr["unit"].ToString(),
                        Unit_price = dr["unit_price"].ToString()

                    });

                }
                stock_report1.SetDataSource(_list);
                stock_report1.SetParameterValue("qty",txt_qty.Text );
                crystalReportViewer1.ReportSource = stock_report1;

            }
          

        }

        private void rdb_all_CheckedChanged(object sender, EventArgs e)
        {
           
            txt_qty.Enabled = false;

        }

        private void rdb_qty_CheckedChanged(object sender, EventArgs e)
        {
       
            txt_qty.Enabled = true;

        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            gb_stock.Visible = true;
            gb_inven.Visible = false;
            gb_sale.Visible = false;

            rdb_all.Checked = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdb_inven_qty_CheckedChanged(object sender, EventArgs e)
        {
            dtp_invent_start.Enabled = false;
            dtp_invent_end.Enabled = false;
            txt_inven_qty.Enabled = true;
        }

        private void rdb_inven_date_CheckedChanged(object sender, EventArgs e)
        {

            dtp_invent_start.Enabled = true;
            dtp_invent_end.Enabled = true;
            txt_inven_qty.Enabled = false;
        }
    }
}

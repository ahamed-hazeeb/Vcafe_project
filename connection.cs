using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Vcafe
{
    class connection
    {

        SqlConnection con = new SqlConnection(@"Data Source=HAZEEB\SQLEXPRESS;Initial Catalog=vcafe_db;Integrated Security=True");

        public DataSet bill_info(int bill_no)
        {
            SqlCommand cmd = new SqlCommand("SELECT  [bill_no],[no_items],[sub_total],[discount],[net_total],[paid_amount],[balance],date FROM [bill_info] where  [bill_no]= @bill_no", con);
            cmd.Parameters.AddWithValue("@bill_no", bill_no);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet bill_order(int bill_no)
        {
            SqlCommand cmd = new SqlCommand("SELECT [order_no],[p_id],[name],[price],[qty],[amount] FROM [bill_order] where  [bill_no]= @bill_no", con);
            cmd.Parameters.AddWithValue("@bill_no", bill_no);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet sales_summmery(DateTime dstart_date, DateTime dend_date)
        {

            SqlCommand cmd = new SqlCommand("SELECT [bill_no],[no_items],[sub_total],[discount],[net_total],[paid_amount],[balance]FROM[bill_info] where date between '" + dstart_date.ToString("MM/dd/yyyy") + "' and '" + dend_date.ToString("MM/dd/yyyy") + "'", con);
            //  SqlCommand cmd = new SqlCommand("SELECT [order_no],[p_id],[name],[price],[qty],[amount] FROM [bill_order] where  [bill_no]= @bill_no", con);
            // cmd.Parameters.AddWithValue("@bill_no", bill_no);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public int sales_summmery_max(DateTime dstart_date, DateTime dend_date)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select sum(net_total) from bill_info where date between '" + dstart_date.ToString("MM/dd/yyyy") + "' and '" + dend_date.ToString("MM/dd/yyyy") + "'", con);
            object result = cmd.ExecuteScalar();
            int i=0;
            if (result != DBNull.Value)
            {
                 i = Convert.ToInt32(result);
          
            }
            else
            {
                
            }

            con.Close();
            // cmd.Parameters.AddWithValue("@bill_no", bill_no);
            return i;

        }
        public DataSet inventory_summery(DateTime dstart_date, DateTime dend_date)
        {
            SqlCommand cmd = new SqlCommand("SELECT  [log_id] ,[id] as ID,[name] ,[category] ,[date] ,[qty] ,[unit] ,[unit_price]  FROM[inventory_data_log] where date between '" + dstart_date.ToString("MM/dd/yyyy") + "' and '" + dend_date.ToString("MM/dd/yyyy") + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet inventory_summery_qty(int qty)
        {
            // SqlDataAdapter sqldata = new SqlDataAdapter("SELECT  [log_id] as LOG_ID,[id] as ID,[name] as Name,[category] as Category,[date] as Date,[qty] as Qty,[unit] as Unit,[unit_price] as Unit_Price FROM[inventory_data_log] where date between '" + dtp_start.Value.ToString("MM/dd/yyyy") + "' and '" + dtp_end.Value.ToString("MM/dd/yyyy") + "'", con);


            SqlCommand cmd = new SqlCommand("SELECT  [log_id] ,[id] as ID,[name] ,[category] ,[date] ,[qty] ,[unit] ,[unit_price]  FROM[inventory_data_log] where qty >='"+qty+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet stock_summery(int qty)
        {
            SqlCommand cmd = new SqlCommand("SELECT  [id] as ID,[name] ,[category] ,[qty] ,[unit] ,[unit_price]  FROM [stock] where qty >='"+qty+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet stock_summery_all()
        {

            SqlCommand cmd = new SqlCommand("SELECT  [id] as ID,[name] ,[category] ,[qty] ,[unit] ,[unit_price]  FROM [stock] ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


    }
}

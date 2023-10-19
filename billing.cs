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
using System.IO;
namespace Vcafe
{
    public partial class billing : UserControl
    {
        private List<Item> items;

        public billing()
        {
            InitializeComponent();
            StyleDatagridview();

        }
        int index;
        public static int bill_num = 0;
        public SqlConnection con = new SqlConnection(@"Data Source=HAZEEB\SQLEXPRESS;Initial Catalog=vcafe_db;Integrated Security=True");

        private static billing _billing;
        public static billing _bill
        {
            get
            {
                if (_billing == null)
                    _billing = new billing();
                return _billing;
                {

                }
            }
        }
        public void getlist(string cate)
        {
            list.Controls.Clear();
            SqlCommand cmd = con.CreateCommand();
            string item = "select p_id,name,price,img from product where category='" + cate.ToString() + "'";

            cmd.CommandText = item;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    card cd = new card();
                    cd.pid = Convert.ToInt32(reader["p_id"]);
                    cd.name = reader["name"].ToString();
                    cd.price = reader["price"].ToString();

                    byte[] imageData = (byte[])reader["img"];
                    if (imageData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            cd.Img = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        cd.Img = null; // Set to null if no image data is retrieved from the database
                    }


                    list.Controls.Add(cd);

                    cd.Click += new System.EventHandler(this.userc_click);

                }


            }
            reader.Close();

        }
        void userc_click(object sender, EventArgs e)
        {
            card ob = (card)sender;
            lbl_pid.Text = ob.pid.ToString();
            lbl_bname.Text = ob.name;
            lbl_bprice.Text = ob.price;
            pic_oimg.Image = ob.Img;
            cshow();
            hide_update();
        }
        private void cshow()
        {

            //to show the order select panel 
            panel1.Visible = true;
        }
        private void chide()
        {
            //to hide the order select panel form window
            panel1.Visible = false;
        }
        public void autobill_no()
        {   //auto get the max no in the bill information table 
            SqlCommand cmd = new SqlCommand("select max(bill_no)+1 from bill_order", con);
            object result = cmd.ExecuteScalar();
            //if the  table bill_no column is not null
            if (result != DBNull.Value)
            {
                int i = Convert.ToInt32(result);
                lbl_billNo.Text = i.ToString();
            }
            //if the  table bill_no column is null
            else
            {
                lbl_billNo.Text = "1";
            }
        }
        public void hide_update()
        {
            btn_oupdate.Visible = false;
        }

        public void show_update()
        {
            btn_oupdate.Visible = true;
        }
       
        private void placeorder(int oqty, char val)
        {
        }


        public void qty_limit_check(int pid,int oqty,string name)
        {
           

            //to get the recipty s_id  from the table and get only the contain only the product pid is applied in it  
            string queryCheck = "SELECT s_id FROM stock s, recipy r, product p WHERE s.id = r.s_id AND p.p_id = r.p_id AND p.p_id = @pid";

            using (SqlCommand commandCheck = new SqlCommand(queryCheck, con))
            {

                commandCheck.Parameters.AddWithValue("@pid", pid);
                //read the s_id from applied only the product pid
                using (SqlDataReader reader = commandCheck.ExecuteReader())
                {

                    //create a list to store the s_id record
                    List<int> sIds = new List<int>();
                    //loop the read the s_id list
                    while (reader.Read())
                    {
                        //get the s_id and convert it to int
                        int id = Convert.ToInt32(reader["s_id"]);

                        //add the s_id int vlue to the list sIds
                        sIds.Add(id);
                    }
                    //cloese the SqlDataReader otherwise SqlCommand can not execuite
                    reader.Close();
                    //foreach loop to read the list in sids
                    int sum = 0;
                    foreach (int id in sIds)
                    {
                        //check the recipt s_id from the list and one by one 
                        //update the stock qty = deduct the recipy qty from it form the id   
                        SqlCommand cmd = new SqlCommand("select qty  from stock where id = @id", con);
                        SqlCommand rec = new SqlCommand("select qty*" + oqty + "  from recipy where s_id = @id", con);
                        cmd.Parameters.AddWithValue("@id", id);
                        rec.Parameters.AddWithValue("@id", id);



                        //execute the update cmd query
                        int stock_qty = (int)cmd.ExecuteScalar();
                        int rec_qty = (int)rec.ExecuteScalar();
                        if (stock_qty > 100 && stock_qty >= rec_qty)
                        {

                            sum = 1;
                        }
                        else
                        {
                            sum += 2;
                            break;
                        }

                    }
                    if (sum == 1)
                    {

                        //to get the recipty s_id  from the table and get only the contain only the product pid is applied in it  
                        string Check = "SELECT s_id FROM stock s, recipy r, product p WHERE s.id = r.s_id AND p.p_id = r.p_id AND p.p_id = @pid";

                        using (SqlCommand command = new SqlCommand(Check, con))
                        {

                            command.Parameters.AddWithValue("@pid", pid);
                            //read the s_id from applied only the product pid
                            using (SqlDataReader exe = command.ExecuteReader())
                            {

                                //create a list to store the s_id record
                                List<int> sId = new List<int>();
                                //loop the read the s_id list
                                while (exe.Read())
                                {
                                    //get the s_id and convert it to int
                                    int id = Convert.ToInt32(exe["s_id"]);
                                    //add the s_id int vlue to the list sIds
                                    sId.Add(id);
                                }
                                //cloese the SqlDataReader otherwise SqlCommand can not execuite
                                exe.Close();
                                //foreach loop to read the list in sids
                                foreach (int id in sId)
                                {
                                    //check the recipt s_id from the list and one by one 
                                    //update the stock qty = deduct the recipy qty from it form the id   
                                    SqlCommand cmd = new SqlCommand("UPDATE stock SET stock.qty = s.qty - (r.qty*'" + oqty + "') FROM stock s, recipy r, product p WHERE s.id = r.s_id AND p.p_id = r.p_id AND s.id = @id AND p.p_id = @pid", con);
                                    cmd.Parameters.AddWithValue("@id", id);
                                    cmd.Parameters.AddWithValue("@pid", pid);
                                    //execute the update cmd query
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }


                        //add to the datagrid view dgv_order
                        int price = Convert.ToInt32(lbl_bprice.Text);
                        int amount = price * oqty;

                        SqlCommand cmnd = new SqlCommand("insert into bill_order values('" + lbl_billNo.Text + "','" + lbl_order.Text + "','" + pid + "','" + name + "','" + price + "','" + oqty + "','" + amount + "')", con);
                        cmnd.ExecuteNonQuery();


                        bill_dis();
                        auto_order_no();
                        sub_total();
                        qty_check.Start();
                        lbl_items.Text = "0";
                        item_no();
                        con.Close();
                        clear_order_items();

                    }
                    else
                    {
                        MessageBox.Show("out of stock");
                    }

                }
            
            }
        }
        private void rollback(string val)
        {


            //get the product id in to a int value pid
            int pid = Convert.ToInt32(txt_pid.Text);
            //get the qty in to a int value oqty
            int oqty = Convert.ToInt32(txt_qty.Text);
            int order_no = Convert.ToInt32(lbl_order.Text);
            int bill_no = Convert.ToInt32(lbl_billNo.Text);


            //to get the recipty s_id  from the table and get only the contain only the product pid is applied in it  
            string queryCheck = "SELECT s_id FROM stock s, recipy r, product p WHERE s.id = r.s_id AND p.p_id = r.p_id AND p.p_id = @pid";

            using (SqlCommand commandCheck = new SqlCommand(queryCheck, con))
            {

                commandCheck.Parameters.AddWithValue("@pid", pid);
                //read the s_id from applied only the product pid
                using (SqlDataReader reader = commandCheck.ExecuteReader())
                {
                    //create a list to store the s_id record
                    List<int> sIds = new List<int>();
                    //loop the read the s_id list
                    while (reader.Read())
                    {
                        //get the s_id and convert it to int
                        int id = Convert.ToInt32(reader["s_id"]);
                        //add the s_id int vlue to the list sIds
                        sIds.Add(id);
                    }
                    //cloese the SqlDataReader otherwise SqlCommand can not execuite
                    reader.Close();
                    //foreach loop to read the list in sids
                    foreach (int id in sIds)
                    {
                        //check the recipt s_id from the list and one by one 
                        //update the stock qty = deduct the recipy qty from it form the id   
                        SqlCommand cmd = new SqlCommand("UPDATE stock SET stock.qty = s.qty "+val.ToString()+" (r.qty*bo.qty) FROM stock s, recipy r, product p ,bill_order bo WHERE s.id = r.s_id AND p.p_id = r.p_id AND s.id = @id AND p.p_id = @pid and (bo.order_no = '" + order_no + "' and bo.bill_no = '" + bill_no + "')", con);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@pid", pid);
                        //execute the update cmd query
                        cmd.ExecuteNonQuery();
                    }
                    bill_dis();
                }
            }
        }
        public void bill_dis()
        {
            int bill_no = Convert.ToInt32(lbl_billNo.Text);
            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT order_no as NO,p_id as PRODUCT_ID,name AS NAME,price AS PRICE ,qty AS QTY,amount AS AMOUNT FROM bill_order where bill_no='" + bill_no + "' ", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            dgv_order.DataSource = dtbl;
        }
        // auto ge the order no to the list dattagrid view
        public void auto_order_no()
        {
            int bill_no = Convert.ToInt32(lbl_billNo.Text);
            SqlCommand cmd = new SqlCommand("select count(order_no)+1 from bill_order where bill_no='" + bill_no + "'", con);
            int order_no = (int)cmd.ExecuteScalar();
            lbl_order.Text = order_no.ToString();
        }
        public void clear_order_items()
        {
            txt_pid.Text = "";
            txt_name.Text = "";
            txt_price.Text = "";
            txt_qty.Text = "";
        }
        private void clear_invoice_list()
        {
            txt_subtotal.Text = "";
            txt_dis.Text = "0";
            txt_nettotal.Text = "";
            txt_paidamount.Text = "";
            txt_balance.Text = "";
            // dgv_order.Refresh();
        }

        public void sub_total()
        {
            int bill_no = Convert.ToInt32(lbl_billNo.Text);
            SqlCommand sub = new SqlCommand("select sum(amount) from bill_order where bill_no = '" + bill_no + "'", con);
            object res = sub.ExecuteScalar();
            txt_subtotal.Text = res.ToString();
            txt_nettotal.Text = res.ToString();
        }

        private List<Item> getqty()
        {
            List<Item> listitem = new List<Item>();
            con.Open();

            SqlCommand cmd = new SqlCommand("select id, name,qty from stock ", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                string name = (string)reader["name"];
                int qty = (int)reader["qty"];

                Item item = new Item(id, name, qty);
                listitem.Add(item);

            }
            reader.Close();
            con.Close();
            return listitem;

        }

        public void item_no()
        {

          
            int item_no_ = 0;
            item_no_ = dgv_order.Rows.Count-1;
            lbl_items.Text = item_no_.ToString();
        }

        void StyleDatagridview()
        {
            dgv_order.BorderStyle = BorderStyle.None;
            dgv_order.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_order.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_order.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv_order.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_order.EnableHeadersVisualStyles = false;
            dgv_order.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_order.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);

            dgv_order.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgv_order.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void billing_Load(object sender, EventArgs e)
        {
            con.Open();
            getlist("food");
            autobill_no();
            bill_dis();
            auto_order_no();


            con.Close();


        }


        private void btn_border_Click(object sender, EventArgs e)
        {
          /*  txt_name.Text = lbl_bname.Text;
            txt_price.Text = lbl_bprice.Text;
            txt_pid.Text = lbl_pid.Text;
            txt_qty.Text = numup_qty.Value.ToString();
            numup_qty.Value = 1;
            */
            if (numup_qty.Text == "" || numup_qty.Text == "0")
            {
                MessageBox.Show("SELECT THE QTY");
            }

            else if (numup_qty.Text != "")

            {

                con.Open();
                //get the product id in to a int value pid
                int pid = Convert.ToInt32(lbl_pid.Text);
                int oqty = Convert.ToInt32(numup_qty.Text);
                //add to the datagrid view dgv_order
                string name = lbl_bname.Text;
                qty_limit_check(pid,oqty,name);

                con.Close();

            }


            chide();
            hide_update();
            qty_check.Stop();
        }

        private void btn_placeorder_Click(object sender, EventArgs e)
        {


            if (txt_pid.Text == "")
            {
                MessageBox.Show("SELECT THE ORDER FIRST");
            }
            else if (txt_pid.Text != "")
            {
              
            }
        }

        private void dgv_order_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgv_order.Rows[index];
            lbl_order.Text = row.Cells[0].Value.ToString();
            txt_pid.Text = row.Cells[1].Value.ToString();
            txt_name.Text = row.Cells[2].Value.ToString();
            txt_price.Text = row.Cells[3].Value.ToString();
            txt_qty.Text = row.Cells[4].Value.ToString();
            show_update();
        }


        private void btn_delete_order_Click(object sender, EventArgs e)
        {

            qty_check.Stop();

            if (txt_pid.Text == "")
            {
                MessageBox.Show("SELECT THE ITEM NEED TO DELETE FIRST");
            }
            else if (txt_pid.Text != "")
            {

                con.Open();
                // change the stock qty to orginal sate  
                rollback("+");

                int order_no = Convert.ToInt32(lbl_order.Text);
                int bill_no = Convert.ToInt32(lbl_billNo.Text);

                SqlCommand cmnd = new SqlCommand("delete from bill_order where bill_no = '" + bill_no + "' and order_no ='" + order_no + "'", con);
                cmnd.ExecuteNonQuery();
                MessageBox.Show("record delete");
                int items_no = Convert.ToInt32(lbl_items.Text);

                if (items_no > 0)
                {

                    items_no = items_no - 1;
                    lbl_items.Text = items_no.ToString();

                }
                bill_dis();
                sub_total();
                con.Close();
                txt_balance.Text = "";
                txt_dis.Text = "0";
                txt_paidamount.Text = "";
                clear_order_items();
            }
        }
     
        private void btn_oupdate_Click(object sender, EventArgs e)
        {
            qty_check.Stop();
            if (txt_qty.Text == "" || txt_qty.Text == "0")
            {
                MessageBox.Show("SELECT THE QTY");
            }
            else if (txt_pid.Text != "" || txt_qty.Text != "0")
            {
                con.Open();
                // change the stock qty to orginal sate     
                rollback("+");
                int oqty = Convert.ToInt32(txt_qty.Text);
                int pid = Convert.ToInt32(txt_pid.Text);
                //to get the recipty s_id  from the table and get only the contain only the product pid is applied in it  
                string queryCheck = "SELECT s_id FROM stock s, recipy r, product p WHERE s.id = r.s_id AND p.p_id = r.p_id AND p.p_id = @pid";

                using (SqlCommand commandCheck = new SqlCommand(queryCheck, con))
                {
                    commandCheck.Parameters.AddWithValue("@pid", pid);
                    //read the s_id from applied only the product pid
                    using (SqlDataReader reader = commandCheck.ExecuteReader())
                    {
                        //create a list to store the s_id record
                        List<int> sIds = new List<int>();
                        //loop the read the s_id list
                        while (reader.Read())
                        {
                            //get the s_id and convert it to int
                            int id = Convert.ToInt32(reader["s_id"]);
                            //add the s_id int vlue to the list sIds
                            sIds.Add(id);
                        }
                        //cloese the SqlDataReader otherwise SqlCommand can not execuite
                        reader.Close();
                        //foreach loop to read the list in sids
                        int count = 0;
                        foreach (int id in sIds)
                        {
                            //check the recipt s_id from the list and one by one 
                            //update the stock qty = deduct the recipy qty from it form the id   
                            SqlCommand cmd = new SqlCommand("select qty  from stock where id = @id", con);
                            SqlCommand rec = new SqlCommand("select qty*" + oqty + "  from recipy where s_id = @id", con);
                            cmd.Parameters.AddWithValue("@id", id);
                            rec.Parameters.AddWithValue("@id", id);

                            //execute the update cmd query
                            int stock_qty = (int)cmd.ExecuteScalar();
                            int rec_qty = (int)rec.ExecuteScalar();
                            if (stock_qty > 100 && stock_qty >= rec_qty)
                            {
                                
                                    count =1;

                            }
                            else
                            {
                                count +=2;
                                break;
                            }

                        }
                        if (count == 1)
                        {  
                            //add to the datagrid view dgv_order
                            string name = txt_name.Text;
                            int price = Convert.ToInt32(txt_price.Text);
                            int amount = price * oqty;

                            //to get the recipty s_id  from the table and get only the contain only the product pid is applied in it  
                            string Check = "SELECT s_id FROM stock s, recipy r, product p WHERE s.id = r.s_id AND p.p_id = r.p_id AND p.p_id = @pid";

                            using (SqlCommand command = new SqlCommand(Check, con))
                            {

                                command.Parameters.AddWithValue("@pid", pid);
                                //read the s_id from applied only the product pid
                                using (SqlDataReader exe = command.ExecuteReader())
                                {

                                    //create a list to store the s_id record
                                    List<int> sId = new List<int>();
                                    //loop the read the s_id list
                                    while (exe.Read())
                                    {
                                        //get the s_id and convert it to int
                                        int id = Convert.ToInt32(exe["s_id"]);
                                        //add the s_id int vlue to the list sIds
                                        sId.Add(id);
                                    }
                                    //cloese the SqlDataReader otherwise SqlCommand can not execuite
                                    exe.Close();
                                    //foreach loop to read the list in sids
                                    foreach (int id in sId)
                                    {
                                        //check the recipt s_id from the list and one by one 
                                        //update the stock qty = deduct the recipy qty from it form the id   
                                        SqlCommand cmd = new SqlCommand("UPDATE stock SET stock.qty = s.qty - (r.qty*'" + oqty + "') FROM stock s, recipy r, product p WHERE s.id = r.s_id AND p.p_id = r.p_id AND s.id = @id AND p.p_id = @pid", con);
                                        cmd.Parameters.AddWithValue("@id", id);
                                        cmd.Parameters.AddWithValue("@pid", pid);
                                        //execute the update cmd query
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                            int order_no = Convert.ToInt32(lbl_order.Text);
                            int bill_no = Convert.ToInt32(lbl_billNo.Text);
                            SqlCommand cmnd = new SqlCommand("update bill_order set amount='" + amount + "' , qty='" + oqty + "'  where bill_no = '" + bill_no + "' and order_no ='" + order_no + "'", con);
                            cmnd.ExecuteNonQuery();
                            MessageBox.Show("record updated");
                            item_no();
                            bill_dis();
                            sub_total();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Out of Stock");
                            // change the stock qty if the record do not change    
                            rollback("-");
                        }

                        clear_order_items();
                        hide_update();
                    }
                }
                con.Close();
            }
        }
        private void txt_paidamount_KeyUp(object sender, KeyEventArgs e)
        {   //paid_amount textbox can not be emplty
            if (txt_paidamount.Text != "")
            {
                //get the nettotal  value from the textbox and convert to int
                int net_total = Convert.ToInt32(txt_nettotal.Text);
                //get the txt_paidamount  value from the textbox and convert to int
                int paid_amount = Convert.ToInt32(txt_paidamount.Text);
                //dedut paid amount fromm the net total into balance int type varible
                int balance = paid_amount - net_total;
                //get the value from the balace and convert to string and assign to txt_balance textbox
                txt_balance.Text = balance.ToString();
            }
            //textbox paid amount empty or ther
            else
            {
                //clear the balance the txt_balace textbox
                txt_balance.Text = "";

            }


        }

        private void qty_check_Tick(object sender, EventArgs e)
        {
            items = getqty();

            foreach (var item in items)
            {
                if (item.Qty < 100)
                {
                    MessageBox.Show($"Item {item.Name} quantity is less than 100. Please review.");

                }
            }
        }


        private void btn_fooditem_Click(object sender, EventArgs e)
        {
            con.Open();
            getlist("food");
            con.Close();
        }

        private void btn_drintitem_Click(object sender, EventArgs e)
        {
            con.Open();
            getlist("drink");
            con.Close();
        }

        private void btn_order_pnlclose_Click(object sender, EventArgs e)
        {
            chide();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            float sub_total = (float)Convert.ToDouble(txt_subtotal.Text);
            float discount = (float)Convert.ToDouble(txt_dis.Text);
            float net_total = (float)Convert.ToDouble(txt_nettotal.Text);
            float paid_amount = (float)Convert.ToDouble(txt_paidamount.Text);
            float balance = (float)Convert.ToDouble(txt_balance.Text);
            // [bill_no],[no_items],[sub_total],[discount],[net_total],[paid_amount],[balance],[date],[user] FROM [vcafe_db].[dbo].[bill_info]
            if (txt_paidamount.Text !="" && txt_balance.Text != "")
            {
                if (balance >= 0)
                {

                    con.Open();


                    SqlCommand cmnd = new SqlCommand("insert into bill_info ([bill_no],[no_items],[sub_total],[discount],[net_total],[paid_amount],[balance],[date]) values('" + lbl_billNo.Text + "','" + lbl_items.Text + "', '" + sub_total + "', '" + discount + "', '" + net_total + "', '" + paid_amount + "', '" + balance + "', '" + DateTime.Now + "')", con);
                    cmnd.ExecuteNonQuery();
                    con.Close();
                    lbl_items.Text = "0";
                    txt_dis.Text = "0";
                    MessageBox.Show("Order Placed");


                    view_invoie_();
                    clear_invoice_list();
                    con.Open();
                    autobill_no();
                    bill_dis();
                    auto_order_no();
                    con.Close();
                }
                else{
                    MessageBox.Show("Payment not enough");
                }
            }
            else
            {
                MessageBox.Show("Get the order First");
            }

        }
        public void view_invoie_()
        {//view_invice_report

            int bill_no = Convert.ToInt32(lbl_billNo.Text);
            View_Invoice invoice = new View_Invoice();
            bill_num = bill_no;
            Form popupForm = new Form();
            popupForm.Text = "Popup Window";
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            popupForm.Size = new Size(800, 500);
            View_Invoice popup = new View_Invoice();
            popup.Dock = DockStyle.Fill;

            popupForm.Controls.Add(popup);
            popupForm.ShowDialog();
        }

        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Qty { get; set; }

            public Item(int id, string name, int qty)
            {
                Id = Id;
                Name = name;
                Qty = qty;
            }
        }

        private void txt_dis_KeyUp(object sender, KeyEventArgs e)
        {

            //paid_amount textbox can not be emplty
            if (txt_dis.Text != "")
            {
                int dis = Convert.ToInt32(txt_dis.Text);
                //get the nettotal  value from the textbox and convert to int
                int sub_total = Convert.ToInt32(txt_subtotal.Text);
             
                //dedut paid amount fromm the net total into balance int type varible
                int disount = sub_total - dis;
                //get the value from the balace and convert to string and assign to txt_balance textbox
                txt_nettotal.Text = disount.ToString();
            }
            //textbox paid amount empty or ther
            else
            {
                //clear the balance the txt_balace textbox
               txt_nettotal.Text = "";

            }
        }
    }
}

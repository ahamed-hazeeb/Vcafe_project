using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace Vcafe
{
    public partial class product : UserControl
    {
        public product()
        {
            InitializeComponent();
            StyleDatagridview();
        }

        private static product _product;
        public static product _productv
        {
            get
            {
                if (_product == null)
                    _product = new product();
                return _product;
                {

                }
            }
        }

        SqlConnection con = new SqlConnection(@"Data Source=HAZEEB\SQLEXPRESS;Initial Catalog=vcafe_db;Integrated Security=True");
      public  String imgloc = "";
        int index;
        int index1;

        private void btn_pinsert_Click(object sender, EventArgs e)
        {

            int p_id = Convert.ToInt32(cmb_pid.Text);
            float price = (float)Convert.ToDouble(txt_pprice.Text);
            SqlCommand cmnd = con.CreateCommand();

            string queryCheck = "SELECT COUNT(*) FROM product WHERE p_id = @Value";

            using (SqlCommand commandCheck = new SqlCommand(queryCheck, con))
            {
                con.Open();
                commandCheck.Parameters.AddWithValue("@Value", p_id);

                int count = (int)commandCheck.ExecuteScalar();
                // If the value does exist, insert the record
                if (count == 0)
                {
                    byte[] imageData = null;
                    FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    imageData = br.ReadBytes((int)fs.Length);

                    string add = "insert into product (p_id,name,price,img,category) values ('" + p_id + "','" + txt_pname.Text + "','" + price + "', CONVERT(varbinary(max), @image),'" + cmb_category.Text+"')";
            
                    cmnd = new SqlCommand(add, con);
                    cmnd.Parameters.AddWithValue("@image", imageData);
                    int x = cmnd.ExecuteNonQuery();

                    //     rec_dis();

                    MessageBox.Show(" Inserted Sucessfully.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    p_clear();
                    product_dis();
                    autoin();
                    product_id();

                
                }
                else
                {
                    MessageBox.Show("Already exiest", "Error");
                }
                

            }
            con.Close();
        }

        private void btn_radd_Click(object sender, EventArgs e)
        {
            if (cmb_pid.Text != "" && txt_sid.Text != "" && txt_sname.Text != "" && txt_sqty.Text != "" && txtsunit.Text != "")
            {
                int pid = Convert.ToInt32(cmb_pid.Text);
            int sid = Convert.ToInt32(txt_sid.Text);
            string name = txt_sname.Text;
            int qty = Convert.ToInt32(txt_sqty.Text);
            string unit = txtsunit.Text;

           


                string queryCheck = "SELECT COUNT(*) FROM recipy WHERE s_id = '"+sid+"' and p_id='"+pid+"'";

                using (SqlCommand commandCheck = new SqlCommand(queryCheck, con))
                {
                    con.Open();
                    //commandCheck.Parameters.AddWithValue("@Value", sid);
                    //commandCheck.Parameters.AddWithValue("@val", pid);
                    int count = (int)commandCheck.ExecuteScalar();
                    // If the value does exist, insert the record
                    if (count == 0)
                    {

                        string query = "insert into[recipy] values('" + pid + "','" + sid + "','" + name + "','" + qty + "','" + unit + "')";


                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.ExecuteNonQuery();

                        rec_dis();

                        txt_sid.Text = "";
                        txt_sname.Text = "";
                        txt_sqty.Text = "";
                        txtsunit.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Record Already Exists", "Error");
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Field can't be Empty", "Empty");
            }
        }

        

        private void product_Load(object sender, EventArgs e)
        {
            con.Open();
            product_id();
            product_dis();
            autoin();
            p_category();
            con.Close();
        


        }
        public void product_id()
        {
            cmb_pid.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select p_id from product ORDER BY p_id ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmb_pid.Items.Add(dr["p_id"].ToString());


            }
        }
        
        public void rec_dis()
        {

            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT s_id,name,qty,unit FROM recipy where p_id='" + cmb_pid.Text + "' ", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            dgv_rec.DataSource = dtbl;
            
        }
        public void product_dis()
        {

            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT p_id,name,price,category,img FROM product ORDER BY p_id ASC  ", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);

            dgv_product.DataSource = dtbl;

        }
        private void autoin()
        {


            SqlCommand cmd = new SqlCommand("select max(p_id)+1 from product", con);
      
            object result = cmd.ExecuteScalar();
            //if the  table bill_no column is not null
            if (result != DBNull.Value)
            {
                int i = Convert.ToInt32(result);
                cmb_pid.Text = i.ToString();
            }
            //if the  table bill_no column is null
            else
            {
                cmb_pid.Text = "1";
            }

        }
        private void p_clear()
        {
            
            txt_pname.Text = "";
            txt_pprice.Text = "";
            pb_pimg.Image = null;
        }

        public void recipy_auto()
        {
            cmb_sget.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stock";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (cmb_rtype.Text == "Item ID")
            {
                lbltype.Text = "Item ID";

                foreach (DataRow dr in dt.Rows)
                {
                    cmb_sget.Items.Add(dr["id"].ToString());

                }
            }
            else if (cmb_rtype.Text == "Name")
            {
                lbltype.Text = "Name";

                foreach (DataRow dr in dt.Rows)
                {
                    cmb_sget.Items.Add(dr["name"].ToString());


                }
            }
        }

        void StyleDatagridview()
        {
            dgv_product.BorderStyle = BorderStyle.None;
            dgv_product.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_product.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_product.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv_product.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_product.EnableHeadersVisualStyles = false;
            dgv_product.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_product.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            dgv_product.RowTemplate.Height = 40;
            dgv_product.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgv_product.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_product.BackgroundColor = Color.FromArgb(46, 51, 73);

            dgv_rec.BorderStyle = BorderStyle.None;
            dgv_rec.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_rec.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_rec.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv_rec.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_rec.EnableHeadersVisualStyles = false;
            dgv_rec.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_rec.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            
            dgv_rec.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgv_rec.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_rec.BackgroundColor = Color.FromArgb(46, 51, 73);



        }
        public void p_category()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select DISTINCT category from product";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmb_category.Items.Add(dr["category"].ToString());


            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void btn_pimg_Click(object sender, EventArgs e)
        {
            pb_pimg.Enabled = true;
            OpenFileDialog img = new OpenFileDialog();
            img.FileName = "";
            img.Filter = "Supported image| *.jpg; *.png; *jpeg";
            if (img.ShowDialog() == DialogResult.OK)
            {
                imgloc = img.FileName.ToString();

                pb_pimg.ImageLocation = imgloc ;
            }
        }

        private void dgv_rec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_rec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgv_rec.Rows[index];
            txt_sid.Text = row.Cells[0].Value.ToString();
            txt_sname.Text = row.Cells[1].Value.ToString();
            txt_sqty.Text = row.Cells[2].Value.ToString();
            txtsunit.Text = row.Cells[3].Value.ToString();
         
        }

        private void btn_rupdate_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(txt_sid.Text);
            string name = txt_sname.Text; 
            int qty = Convert.ToInt32(txt_sqty.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE recipy SET [qty] ='"+qty+"'  ,name='" + name + "',unit='"+txtsunit.Text+"' WHERE s_id = '"+sid+"'", con);
          
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated !");
            rec_dis();
            txt_sid.Text = "";
            txt_sname.Text = "";
            txt_sqty.Text = "";
            txtsunit.Text = "";
            con.Close();
        }

        private void btn_rremove_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are You sure want to Delete Record", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (rs == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmnd = new SqlCommand("Delete from recipy where [s_id] ='" + txt_sid.Text + "'", con);
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Removed !! ");
                rec_dis();
                con.Close();
                txt_sid.Text = "";
                txt_sname.Text = "";
                txt_sqty.Text = "";
                txtsunit.Text = "";
                con.Close();
            }
        }

        private void cmb_pid_SelectedIndexChanged(object sender, EventArgs e)
        {
            pb_pimg.Enabled = false;
          
            con.Open();
            rec_dis();
            String query_search = "select name,price,category,img from product where p_id ='" + cmb_pid.Text + "'";
            SqlCommand cmnd = new SqlCommand(query_search, con);
            SqlDataReader r = cmnd.ExecuteReader();
            

            r.Read();
            if (r.HasRows)
            {
                txt_pname.Text = r[0].ToString();

                txt_pprice.Text = r[1].ToString();
                cmb_category.Text = r[2].ToString();

                byte[] imgData = (byte[])r["img"];

                if (imgData != null && imgData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        pb_pimg.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                else
                {
                    pb_pimg.Image = null;
                }
            }
            else
            {
                // Handle case when no data is found for the selected product ID
               // ClearFields();
                MessageBox.Show("No data found for the selected product ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            r.Close();
        

        con.Close();

        }
        //without this also working
        //private byte[] GetImageData(SqlDataReader reader)
        //{
        //    const int imageColumnIndex = 3; // Assuming the image data is stored in the fourth column (index 3)

        //    if (!reader.IsDBNull(imageColumnIndex))
        //    {
        //        long byteLength = reader.GetBytes(imageColumnIndex, 0, null, 0, 0); // Get the length of the binary data
        //        byte[] imgData = new byte[byteLength];
        //        reader.GetBytes(imageColumnIndex, 0, imgData, 0, (int)byteLength); // Read the binary data into the byte array

        //        return imgData;
        //    }

        //    return null;
        //}
        private void btn_pupdate_Click(object sender, EventArgs e)
        {

            int pid = Convert.ToInt32(cmb_pid.Text);
            string name = txt_pname.Text;
            string category = cmb_category.Text;
            int price = Convert.ToInt32(txt_pprice.Text);
            if (pb_pimg.Enabled==true)
            {
                byte[] imageData = null;
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imageData = br.ReadBytes((int)fs.Length);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE product SET name='" + name + "',price='" + price + "' ,img = CONVERT(varbinary(max), @img) ,category = '" + category + "' WHERE p_id = '" + pid + "'", con);
                cmd.Parameters.Add(new SqlParameter("@img", imageData));
                int x = cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated !");
                p_clear();
                product_dis();
                autoin();


            }
            else if (pb_pimg.Enabled == false)
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE product SET name='" + name + "',price='" + price + "'  ,category = '" + category + "' WHERE p_id = '" + pid + "'", con);
                
                int x = cmd.ExecuteNonQuery();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated !");
                p_clear();
               product_dis();
                autoin();
            }
            con.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //disable the enable of the picurebox
            pb_pimg.Enabled = false;

            index1 = e.RowIndex;
            DataGridViewRow row = dgv_product.Rows[index1];
            cmb_pid.Text = row.Cells[0].Value.ToString();
            txt_pname.Text = row.Cells[1].Value.ToString();
            txt_pprice.Text = row.Cells[2].Value.ToString();
            cmb_category.Text = row.Cells[3].Value.ToString();
            byte[] imgData = (byte[])row.Cells[4].Value;
            MemoryStream ms2 = new MemoryStream(imgData);
            pb_pimg.Image = System.Drawing.Image.FromStream(ms2);



        }
        private void btn_premove_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are You sure want to Delete Record", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (rs == DialogResult.Yes)
            {
                int pid = Convert.ToInt32(cmb_pid.Text);
                string remove_product = "delete from product where p_id='" + pid + "'";
                string remove_recipy = "delete from recipy where p_id='" + pid + "'";
                SqlCommand cmnd = new SqlCommand(remove_product, con);
                SqlCommand cmnd1 = new SqlCommand(remove_recipy, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                cmnd1.ExecuteNonQuery();
                con.Close();
                p_clear();
            }
        }

        private void cmb_sget_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            con.Open();

            if (cmb_rtype.Text == "Item ID")
            {

                String query_search = "select id,name,unit from stock where id ='" + cmb_sget.Text+ "'";
                SqlCommand cmnd = new SqlCommand(query_search, con);
                SqlDataReader r = cmnd.ExecuteReader();


                r.Read();
                if (r.HasRows)
                {
                    txt_sid.Text = r[0].ToString();
                    txt_sname.Text = r[1].ToString();

                    txtsunit.Text = r[2].ToString();


                }

            }
            else if (cmb_rtype.Text == "Name")
            {

                String query_search = "select id,name,unit from stock where name ='" + cmb_sget.Text + "'";
                SqlCommand cmnd = new SqlCommand(query_search, con);
                SqlDataReader r = cmnd.ExecuteReader();


                r.Read();
                if (r.HasRows)
                {
                    txt_sid.Text = r[0].ToString();
                    txt_sname.Text = r[1].ToString();
                    txtsunit.Text = r[2].ToString();


                }

            }
            con.Close();
        }

        private void cmb_rtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            recipy_auto();
            con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            con.Open();
            p_clear();
            product_id();
            autoin();
            con.Close();
        }

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    } 

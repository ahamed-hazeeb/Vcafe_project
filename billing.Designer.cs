namespace Vcafe
{
    partial class billing
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.list = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numup_qty = new System.Windows.Forms.NumericUpDown();
            this.pic_oimg = new System.Windows.Forms.PictureBox();
            this.btn_order_pnlclose = new System.Windows.Forms.Button();
            this.lbl_pid = new System.Windows.Forms.Label();
            this.btn_border = new System.Windows.Forms.Button();
            this.lbl_bprice = new System.Windows.Forms.Label();
            this.lbl_bname = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_pid = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_billNo = new System.Windows.Forms.Label();
            this.txt_dis = new System.Windows.Forms.TextBox();
            this.txt_paidamount = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.txt_nettotal = new System.Windows.Forms.TextBox();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.btn_delete_order = new System.Windows.Forms.Button();
            this.btn_oupdate = new System.Windows.Forms.Button();
            this.lbl_order = new System.Windows.Forms.Label();
            this.qty_check = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_drintitem = new System.Windows.Forms.Button();
            this.btn_fooditem = new System.Windows.Forms.Button();
            this.lbl_items = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numup_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_oimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.AutoScroll = true;
            this.list.Location = new System.Drawing.Point(4, 59);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(579, 380);
            this.list.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numup_qty);
            this.panel1.Controls.Add(this.pic_oimg);
            this.panel1.Controls.Add(this.btn_order_pnlclose);
            this.panel1.Controls.Add(this.lbl_pid);
            this.panel1.Controls.Add(this.btn_border);
            this.panel1.Controls.Add(this.lbl_bprice);
            this.panel1.Controls.Add(this.lbl_bname);
            this.panel1.Location = new System.Drawing.Point(443, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 198);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(185, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rs  : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numup_qty
            // 
            this.numup_qty.BackColor = System.Drawing.Color.DimGray;
            this.numup_qty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numup_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numup_qty.Location = new System.Drawing.Point(302, 97);
            this.numup_qty.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numup_qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numup_qty.Name = "numup_qty";
            this.numup_qty.Size = new System.Drawing.Size(46, 20);
            this.numup_qty.TabIndex = 10;
            this.numup_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pic_oimg
            // 
            this.pic_oimg.Location = new System.Drawing.Point(0, 0);
            this.pic_oimg.Name = "pic_oimg";
            this.pic_oimg.Size = new System.Drawing.Size(173, 195);
            this.pic_oimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_oimg.TabIndex = 9;
            this.pic_oimg.TabStop = false;
            // 
            // btn_order_pnlclose
            // 
            this.btn_order_pnlclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order_pnlclose.ForeColor = System.Drawing.Color.DimGray;
            this.btn_order_pnlclose.Location = new System.Drawing.Point(323, 0);
            this.btn_order_pnlclose.Name = "btn_order_pnlclose";
            this.btn_order_pnlclose.Size = new System.Drawing.Size(44, 23);
            this.btn_order_pnlclose.TabIndex = 8;
            this.btn_order_pnlclose.Text = "Close";
            this.btn_order_pnlclose.UseVisualStyleBackColor = true;
            this.btn_order_pnlclose.Click += new System.EventHandler(this.btn_order_pnlclose_Click);
            // 
            // lbl_pid
            // 
            this.lbl_pid.AutoSize = true;
            this.lbl_pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_pid.Location = new System.Drawing.Point(241, 0);
            this.lbl_pid.Name = "lbl_pid";
            this.lbl_pid.Size = new System.Drawing.Size(38, 25);
            this.lbl_pid.TabIndex = 5;
            this.lbl_pid.Text = "no";
            this.lbl_pid.Visible = false;
            // 
            // btn_border
            // 
            this.btn_border.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_border.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_border.ForeColor = System.Drawing.Color.DimGray;
            this.btn_border.Location = new System.Drawing.Point(235, 136);
            this.btn_border.Name = "btn_border";
            this.btn_border.Size = new System.Drawing.Size(81, 37);
            this.btn_border.TabIndex = 4;
            this.btn_border.Text = "order";
            this.btn_border.UseVisualStyleBackColor = true;
            this.btn_border.Click += new System.EventHandler(this.btn_border_Click);
            // 
            // lbl_bprice
            // 
            this.lbl_bprice.AutoSize = true;
            this.lbl_bprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_bprice.Location = new System.Drawing.Point(231, 98);
            this.lbl_bprice.Name = "lbl_bprice";
            this.lbl_bprice.Size = new System.Drawing.Size(52, 18);
            this.lbl_bprice.TabIndex = 3;
            this.lbl_bprice.Text = "label4";
            this.lbl_bprice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_bname
            // 
            this.lbl_bname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_bname.Location = new System.Drawing.Point(179, 26);
            this.lbl_bname.Name = "lbl_bname";
            this.lbl_bname.Size = new System.Drawing.Size(189, 57);
            this.lbl_bname.TabIndex = 2;
            this.lbl_bname.Text = "label3";
            this.lbl_bname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Enabled = false;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_name.ForeColor = System.Drawing.Color.DimGray;
            this.txt_name.Location = new System.Drawing.Point(93, 516);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(77, 16);
            this.txt_name.TabIndex = 2;
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Enabled = false;
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_price.ForeColor = System.Drawing.Color.DimGray;
            this.txt_price.Location = new System.Drawing.Point(199, 516);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(67, 16);
            this.txt_price.TabIndex = 3;
            // 
            // txt_pid
            // 
            this.txt_pid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_pid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pid.Enabled = false;
            this.txt_pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_pid.ForeColor = System.Drawing.Color.DimGray;
            this.txt_pid.Location = new System.Drawing.Point(27, 516);
            this.txt_pid.Name = "txt_pid";
            this.txt_pid.Size = new System.Drawing.Size(48, 16);
            this.txt_pid.TabIndex = 5;
            // 
            // txt_qty
            // 
            this.txt_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_qty.ForeColor = System.Drawing.Color.DimGray;
            this.txt_qty.Location = new System.Drawing.Point(285, 516);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(63, 16);
            this.txt_qty.TabIndex = 6;
            this.txt_qty.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(290, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qty";
            // 
            // lbl_billNo
            // 
            this.lbl_billNo.AutoSize = true;
            this.lbl_billNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_billNo.Location = new System.Drawing.Point(1089, 3);
            this.lbl_billNo.Name = "lbl_billNo";
            this.lbl_billNo.Size = new System.Drawing.Size(61, 20);
            this.lbl_billNo.TabIndex = 7;
            this.lbl_billNo.Text = "bill_no";
            // 
            // txt_dis
            // 
            this.txt_dis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_dis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dis.Location = new System.Drawing.Point(953, 380);
            this.txt_dis.Name = "txt_dis";
            this.txt_dis.Size = new System.Drawing.Size(65, 17);
            this.txt_dis.TabIndex = 9;
            this.txt_dis.Text = "0";
            this.txt_dis.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dis_KeyUp);
            // 
            // txt_paidamount
            // 
            this.txt_paidamount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_paidamount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_paidamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paidamount.Location = new System.Drawing.Point(918, 442);
            this.txt_paidamount.Name = "txt_paidamount";
            this.txt_paidamount.Size = new System.Drawing.Size(100, 17);
            this.txt_paidamount.TabIndex = 11;
            this.txt_paidamount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_paidamount_KeyUp);
            // 
            // btn_confirm
            // 
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.DimGray;
            this.btn_confirm.Location = new System.Drawing.Point(1075, 505);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(162, 51);
            this.btn_confirm.TabIndex = 13;
            this.btn_confirm.Text = "Confirm Order";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(808, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sub Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(808, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(808, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Net Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(808, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Paid Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(809, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Balace";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal.Location = new System.Drawing.Point(918, 349);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 17);
            this.txt_subtotal.TabIndex = 19;
            // 
            // txt_nettotal
            // 
            this.txt_nettotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_nettotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nettotal.Enabled = false;
            this.txt_nettotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nettotal.Location = new System.Drawing.Point(918, 411);
            this.txt_nettotal.Name = "txt_nettotal";
            this.txt_nettotal.Size = new System.Drawing.Size(100, 17);
            this.txt_nettotal.TabIndex = 20;
            // 
            // txt_balance
            // 
            this.txt_balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_balance.Enabled = false;
            this.txt_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.Location = new System.Drawing.Point(918, 473);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(100, 17);
            this.txt_balance.TabIndex = 21;
            // 
            // dgv_order
            // 
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Location = new System.Drawing.Point(608, 34);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.ReadOnly = true;
            this.dgv_order.Size = new System.Drawing.Size(644, 295);
            this.dgv_order.TabIndex = 22;
            this.dgv_order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellClick_1);
            // 
            // btn_delete_order
            // 
            this.btn_delete_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_order.ForeColor = System.Drawing.Color.DimGray;
            this.btn_delete_order.Location = new System.Drawing.Point(1130, 335);
            this.btn_delete_order.Name = "btn_delete_order";
            this.btn_delete_order.Size = new System.Drawing.Size(107, 40);
            this.btn_delete_order.TabIndex = 23;
            this.btn_delete_order.Text = "DELETE";
            this.btn_delete_order.UseVisualStyleBackColor = true;
            this.btn_delete_order.Click += new System.EventHandler(this.btn_delete_order_Click);
            // 
            // btn_oupdate
            // 
            this.btn_oupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oupdate.ForeColor = System.Drawing.Color.DimGray;
            this.btn_oupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_oupdate.Location = new System.Drawing.Point(474, 504);
            this.btn_oupdate.Name = "btn_oupdate";
            this.btn_oupdate.Size = new System.Drawing.Size(75, 38);
            this.btn_oupdate.TabIndex = 24;
            this.btn_oupdate.Text = "Update";
            this.btn_oupdate.UseVisualStyleBackColor = true;
            this.btn_oupdate.Visible = false;
            this.btn_oupdate.Click += new System.EventHandler(this.btn_oupdate_Click);
            // 
            // lbl_order
            // 
            this.lbl_order.AutoSize = true;
            this.lbl_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_order.Location = new System.Drawing.Point(1167, 6);
            this.lbl_order.Name = "lbl_order";
            this.lbl_order.Size = new System.Drawing.Size(81, 20);
            this.lbl_order.TabIndex = 25;
            this.lbl_order.Text = "order_no";
            this.lbl_order.Visible = false;
            // 
            // qty_check
            // 
            this.qty_check.Interval = 50000;
            this.qty_check.Tick += new System.EventHandler(this.qty_check_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_drintitem);
            this.panel2.Controls.Add(this.btn_fooditem);
            this.panel2.Controls.Add(this.list);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 442);
            this.panel2.TabIndex = 26;
            // 
            // btn_drintitem
            // 
            this.btn_drintitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_drintitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_drintitem.ForeColor = System.Drawing.Color.DimGray;
            this.btn_drintitem.Location = new System.Drawing.Point(4, 3);
            this.btn_drintitem.Name = "btn_drintitem";
            this.btn_drintitem.Size = new System.Drawing.Size(71, 45);
            this.btn_drintitem.TabIndex = 7;
            this.btn_drintitem.Text = "Drink";
            this.btn_drintitem.UseVisualStyleBackColor = true;
            this.btn_drintitem.Click += new System.EventHandler(this.btn_drintitem_Click);
            // 
            // btn_fooditem
            // 
            this.btn_fooditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fooditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fooditem.ForeColor = System.Drawing.Color.DimGray;
            this.btn_fooditem.Location = new System.Drawing.Point(99, 3);
            this.btn_fooditem.Name = "btn_fooditem";
            this.btn_fooditem.Size = new System.Drawing.Size(71, 45);
            this.btn_fooditem.TabIndex = 6;
            this.btn_fooditem.Text = "Food";
            this.btn_fooditem.UseVisualStyleBackColor = true;
            this.btn_fooditem.Click += new System.EventHandler(this.btn_fooditem_Click);
            // 
            // lbl_items
            // 
            this.lbl_items.AutoSize = true;
            this.lbl_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_items.Location = new System.Drawing.Point(1126, 411);
            this.lbl_items.Name = "lbl_items";
            this.lbl_items.Size = new System.Drawing.Size(73, 20);
            this.lbl_items.TabIndex = 27;
            this.lbl_items.Text = "item_no";
            // 
            // billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.lbl_items);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_order);
            this.Controls.Add(this.btn_oupdate);
            this.Controls.Add(this.btn_delete_order);
            this.Controls.Add(this.dgv_order);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.txt_nettotal);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_paidamount);
            this.Controls.Add(this.txt_dis);
            this.Controls.Add(this.lbl_billNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_pid);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_name);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "billing";
            this.Size = new System.Drawing.Size(1257, 567);
            this.Load += new System.EventHandler(this.billing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numup_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_oimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel list;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_border;
        private System.Windows.Forms.Label lbl_bprice;
        private System.Windows.Forms.Label lbl_bname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_pid;
        private System.Windows.Forms.TextBox txt_pid;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_billNo;
        private System.Windows.Forms.TextBox txt_dis;
        private System.Windows.Forms.TextBox txt_paidamount;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_nettotal;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.Button btn_delete_order;
        private System.Windows.Forms.Button btn_oupdate;
        private System.Windows.Forms.Label lbl_order;
        private System.Windows.Forms.Timer qty_check;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_drintitem;
        private System.Windows.Forms.Button btn_fooditem;
        private System.Windows.Forms.Button btn_order_pnlclose;
        private System.Windows.Forms.PictureBox pic_oimg;
        private System.Windows.Forms.NumericUpDown numup_qty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_items;
    }
}

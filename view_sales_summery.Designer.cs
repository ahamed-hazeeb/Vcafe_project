namespace Vcafe
{
    partial class view_sales_summery
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_inven = new System.Windows.Forms.GroupBox();
            this.rdb_inven_date = new System.Windows.Forms.RadioButton();
            this.rdb_inven_qty = new System.Windows.Forms.RadioButton();
            this.txt_inven_qty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_invent_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_invent_end = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_inven_searc = new System.Windows.Forms.Button();
            this.gb_stock = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdb_all = new System.Windows.Forms.RadioButton();
            this.rdb_qty = new System.Windows.Forms.RadioButton();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_stock_search = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.gb_sale = new System.Windows.Forms.GroupBox();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search_bill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sale = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inventory_report_1 = new Vcafe.inventory_report_();
            this.sales_summery_report1 = new Vcafe.sales_summery_report();
            this.stock_report1 = new Vcafe.stock_report();
            this.panel1.SuspendLayout();
            this.gb_inven.SuspendLayout();
            this.gb_stock.SuspendLayout();
            this.gb_sale.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowPageNavigateButtons = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(994, 408);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.gb_stock);
            this.panel1.Controls.Add(this.gb_inven);
            this.panel1.Controls.Add(this.btn_stock);
            this.panel1.Controls.Add(this.btn_inventory);
            this.panel1.Controls.Add(this.gb_sale);
            this.panel1.Controls.Add(this.btn_sale);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 116);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gb_inven
            // 
            this.gb_inven.Controls.Add(this.rdb_inven_date);
            this.gb_inven.Controls.Add(this.rdb_inven_qty);
            this.gb_inven.Controls.Add(this.txt_inven_qty);
            this.gb_inven.Controls.Add(this.label8);
            this.gb_inven.Controls.Add(this.dtp_invent_start);
            this.gb_inven.Controls.Add(this.dtp_invent_end);
            this.gb_inven.Controls.Add(this.label3);
            this.gb_inven.Controls.Add(this.label5);
            this.gb_inven.Controls.Add(this.btn_inven_searc);
            this.gb_inven.ForeColor = System.Drawing.Color.DimGray;
            this.gb_inven.Location = new System.Drawing.Point(301, 28);
            this.gb_inven.Name = "gb_inven";
            this.gb_inven.Size = new System.Drawing.Size(664, 78);
            this.gb_inven.TabIndex = 1;
            this.gb_inven.TabStop = false;
            this.gb_inven.Text = "Inventory";
            this.gb_inven.Visible = false;
            // 
            // rdb_inven_date
            // 
            this.rdb_inven_date.AutoSize = true;
            this.rdb_inven_date.Location = new System.Drawing.Point(10, 51);
            this.rdb_inven_date.Name = "rdb_inven_date";
            this.rdb_inven_date.Size = new System.Drawing.Size(14, 13);
            this.rdb_inven_date.TabIndex = 9;
            this.rdb_inven_date.TabStop = true;
            this.rdb_inven_date.UseVisualStyleBackColor = true;
            this.rdb_inven_date.CheckedChanged += new System.EventHandler(this.rdb_inven_date_CheckedChanged);
            // 
            // rdb_inven_qty
            // 
            this.rdb_inven_qty.AutoSize = true;
            this.rdb_inven_qty.Location = new System.Drawing.Point(10, 23);
            this.rdb_inven_qty.Name = "rdb_inven_qty";
            this.rdb_inven_qty.Size = new System.Drawing.Size(14, 13);
            this.rdb_inven_qty.TabIndex = 8;
            this.rdb_inven_qty.TabStop = true;
            this.rdb_inven_qty.UseVisualStyleBackColor = true;
            this.rdb_inven_qty.CheckedChanged += new System.EventHandler(this.rdb_inven_qty_CheckedChanged);
            // 
            // txt_inven_qty
            // 
            this.txt_inven_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_inven_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_inven_qty.Enabled = false;
            this.txt_inven_qty.ForeColor = System.Drawing.Color.DimGray;
            this.txt_inven_qty.Location = new System.Drawing.Point(103, 16);
            this.txt_inven_qty.Name = "txt_inven_qty";
            this.txt_inven_qty.Size = new System.Drawing.Size(159, 20);
            this.txt_inven_qty.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(57, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Qty";
            // 
            // dtp_invent_start
            // 
            this.dtp_invent_start.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp_invent_start.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dtp_invent_start.Enabled = false;
            this.dtp_invent_start.Location = new System.Drawing.Point(102, 45);
            this.dtp_invent_start.Name = "dtp_invent_start";
            this.dtp_invent_start.Size = new System.Drawing.Size(200, 20);
            this.dtp_invent_start.TabIndex = 1;
            this.dtp_invent_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // dtp_invent_end
            // 
            this.dtp_invent_end.Enabled = false;
            this.dtp_invent_end.Location = new System.Drawing.Point(376, 45);
            this.dtp_invent_end.Name = "dtp_invent_end";
            this.dtp_invent_end.Size = new System.Drawing.Size(200, 20);
            this.dtp_invent_end.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(308, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(26, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Start Date";
            // 
            // btn_inven_searc
            // 
            this.btn_inven_searc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inven_searc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inven_searc.ForeColor = System.Drawing.Color.DimGray;
            this.btn_inven_searc.Location = new System.Drawing.Point(583, 16);
            this.btn_inven_searc.Name = "btn_inven_searc";
            this.btn_inven_searc.Size = new System.Drawing.Size(75, 34);
            this.btn_inven_searc.TabIndex = 3;
            this.btn_inven_searc.Text = "Search";
            this.btn_inven_searc.UseVisualStyleBackColor = true;
            this.btn_inven_searc.Click += new System.EventHandler(this.btn_inven_searc_Click);
            // 
            // gb_stock
            // 
            this.gb_stock.Controls.Add(this.label6);
            this.gb_stock.Controls.Add(this.rdb_all);
            this.gb_stock.Controls.Add(this.rdb_qty);
            this.gb_stock.Controls.Add(this.txt_qty);
            this.gb_stock.Controls.Add(this.label7);
            this.gb_stock.Controls.Add(this.btn_stock_search);
            this.gb_stock.ForeColor = System.Drawing.Color.DimGray;
            this.gb_stock.Location = new System.Drawing.Point(301, 28);
            this.gb_stock.Name = "gb_stock";
            this.gb_stock.Size = new System.Drawing.Size(664, 78);
            this.gb_stock.TabIndex = 5;
            this.gb_stock.TabStop = false;
            this.gb_stock.Text = "Stock";
            this.gb_stock.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(176, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "All the Stock";
            // 
            // rdb_all
            // 
            this.rdb_all.AutoSize = true;
            this.rdb_all.Location = new System.Drawing.Point(156, 14);
            this.rdb_all.Name = "rdb_all";
            this.rdb_all.Size = new System.Drawing.Size(14, 13);
            this.rdb_all.TabIndex = 6;
            this.rdb_all.TabStop = true;
            this.rdb_all.UseVisualStyleBackColor = true;
            this.rdb_all.CheckedChanged += new System.EventHandler(this.rdb_all_CheckedChanged);
            // 
            // rdb_qty
            // 
            this.rdb_qty.AutoSize = true;
            this.rdb_qty.Location = new System.Drawing.Point(156, 39);
            this.rdb_qty.Name = "rdb_qty";
            this.rdb_qty.Size = new System.Drawing.Size(14, 13);
            this.rdb_qty.TabIndex = 5;
            this.rdb_qty.TabStop = true;
            this.rdb_qty.UseVisualStyleBackColor = true;
            this.rdb_qty.CheckedChanged += new System.EventHandler(this.rdb_qty_CheckedChanged);
            // 
            // txt_qty
            // 
            this.txt_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qty.ForeColor = System.Drawing.Color.DimGray;
            this.txt_qty.Location = new System.Drawing.Point(222, 32);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 20);
            this.txt_qty.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(176, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Qty";
            // 
            // btn_stock_search
            // 
            this.btn_stock_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock_search.ForeColor = System.Drawing.Color.DimGray;
            this.btn_stock_search.Location = new System.Drawing.Point(583, 16);
            this.btn_stock_search.Name = "btn_stock_search";
            this.btn_stock_search.Size = new System.Drawing.Size(75, 34);
            this.btn_stock_search.TabIndex = 3;
            this.btn_stock_search.Text = "Search";
            this.btn_stock_search.UseVisualStyleBackColor = true;
            this.btn_stock_search.Click += new System.EventHandler(this.btn_stock_search_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.ForeColor = System.Drawing.Color.DimGray;
            this.btn_stock.Location = new System.Drawing.Point(193, 49);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(89, 37);
            this.btn_stock.TabIndex = 77;
            this.btn_stock.Text = "Stock";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventory.ForeColor = System.Drawing.Color.DimGray;
            this.btn_inventory.Location = new System.Drawing.Point(98, 49);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(89, 37);
            this.btn_inventory.TabIndex = 76;
            this.btn_inventory.Text = "Inventroy";
            this.btn_inventory.UseVisualStyleBackColor = true;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // gb_sale
            // 
            this.gb_sale.Controls.Add(this.dtp_start);
            this.gb_sale.Controls.Add(this.dtp_end);
            this.gb_sale.Controls.Add(this.label1);
            this.gb_sale.Controls.Add(this.btn_search_bill);
            this.gb_sale.Controls.Add(this.label2);
            this.gb_sale.ForeColor = System.Drawing.Color.DimGray;
            this.gb_sale.Location = new System.Drawing.Point(301, 28);
            this.gb_sale.Name = "gb_sale";
            this.gb_sale.Size = new System.Drawing.Size(664, 67);
            this.gb_sale.TabIndex = 1;
            this.gb_sale.TabStop = false;
            this.gb_sale.Text = "Sale";
            this.gb_sale.Visible = false;
            // 
            // dtp_start
            // 
            this.dtp_start.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp_start.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dtp_start.Location = new System.Drawing.Point(86, 30);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(200, 20);
            this.dtp_start.TabIndex = 1;
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(360, 30);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(200, 20);
            this.dtp_end.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date";
            // 
            // btn_search_bill
            // 
            this.btn_search_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_bill.ForeColor = System.Drawing.Color.DimGray;
            this.btn_search_bill.Location = new System.Drawing.Point(580, 16);
            this.btn_search_bill.Name = "btn_search_bill";
            this.btn_search_bill.Size = new System.Drawing.Size(75, 34);
            this.btn_search_bill.TabIndex = 3;
            this.btn_search_bill.Text = "Search";
            this.btn_search_bill.UseVisualStyleBackColor = true;
            this.btn_search_bill.Click += new System.EventHandler(this.btn_search_bill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(292, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Date";
            // 
            // btn_sale
            // 
            this.btn_sale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sale.ForeColor = System.Drawing.Color.DimGray;
            this.btn_sale.Location = new System.Drawing.Point(25, 50);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(67, 37);
            this.btn_sale.TabIndex = 75;
            this.btn_sale.Text = "Sale";
            this.btn_sale.UseVisualStyleBackColor = true;
            this.btn_sale.Click += new System.EventHandler(this.btn_sale_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 31);
            this.label4.TabIndex = 74;
            this.label4.Text = "Summery Reports";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.crystalReportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 408);
            this.panel2.TabIndex = 2;
            // 
            // view_sales_summery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "view_sales_summery";
            this.Size = new System.Drawing.Size(994, 524);
            this.Load += new System.EventHandler(this.view_sales_summery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_inven.ResumeLayout(false);
            this.gb_inven.PerformLayout();
            this.gb_stock.ResumeLayout(false);
            this.gb_stock.PerformLayout();
            this.gb_sale.ResumeLayout(false);
            this.gb_sale.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private sales_summery_report sales_summery_report1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search_bill;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private inventory_report_ inventory_report_1;
        private System.Windows.Forms.GroupBox gb_inven;
        private System.Windows.Forms.DateTimePicker dtp_invent_start;
        private System.Windows.Forms.DateTimePicker dtp_invent_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_inven_searc;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.GroupBox gb_sale;
        private System.Windows.Forms.Button btn_sale;
        private System.Windows.Forms.GroupBox gb_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_stock_search;
        private stock_report stock_report1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdb_all;
        private System.Windows.Forms.RadioButton rdb_qty;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.RadioButton rdb_inven_date;
        private System.Windows.Forms.RadioButton rdb_inven_qty;
        private System.Windows.Forms.TextBox txt_inven_qty;
        private System.Windows.Forms.Label label8;
    }
}

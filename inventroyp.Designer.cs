namespace Vcafe
{
    partial class inventroyp
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_logid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.Label();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.datet = new System.Windows.Forms.DateTimePicker();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.txt_uprice = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update_stock = new System.Windows.Forms.Button();
            this.dgv_inven = new System.Windows.Forms.DataGridView();
            this.cmb_id = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_date = new System.Windows.Forms.RadioButton();
            this.rdb_input = new System.Windows.Forms.RadioButton();
            this.btn_filter_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_id_search = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.gb_inventory = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inven)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_inventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.DimGray;
            this.btn_clear.Location = new System.Drawing.Point(265, 373);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(99, 34);
            this.btn_clear.TabIndex = 42;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Search.Location = new System.Drawing.Point(231, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(156, 31);
            this.btn_Search.TabIndex = 41;
            this.btn_Search.Text = "Search From Inventry";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_logid
            // 
            this.txt_logid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_logid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_logid.Location = new System.Drawing.Point(85, 14);
            this.txt_logid.Name = "txt_logid";
            this.txt_logid.Size = new System.Drawing.Size(100, 20);
            this.txt_logid.TabIndex = 40;
            this.txt_logid.TextChanged += new System.EventHandler(this.txt_logid_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(4, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "LOG ID";
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.unit.ForeColor = System.Drawing.Color.DimGray;
            this.unit.Location = new System.Drawing.Point(6, 255);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(34, 18);
            this.unit.TabIndex = 38;
            this.unit.Text = "Unit";
            // 
            // txt_unit
            // 
            this.txt_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_unit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_unit.Location = new System.Drawing.Point(85, 249);
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Size = new System.Drawing.Size(100, 20);
            this.txt_unit.TabIndex = 37;
            // 
            // btn_insert
            // 
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_insert.ForeColor = System.Drawing.Color.DimGray;
            this.btn_insert.Location = new System.Drawing.Point(16, 374);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(99, 33);
            this.btn_insert.TabIndex = 36;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // datet
            // 
            this.datet.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.datet.Location = new System.Drawing.Point(85, 171);
            this.datet.Name = "datet";
            this.datet.Size = new System.Drawing.Size(181, 20);
            this.datet.TabIndex = 35;
            // 
            // cmb_category
            // 
            this.cmb_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(85, 131);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(121, 21);
            this.cmb_category.TabIndex = 34;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // txt_uprice
            // 
            this.txt_uprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_uprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_uprice.Location = new System.Drawing.Point(85, 288);
            this.txt_uprice.Name = "txt_uprice";
            this.txt_uprice.Size = new System.Drawing.Size(100, 20);
            this.txt_uprice.TabIndex = 31;
            // 
            // txt_qty
            // 
            this.txt_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qty.Location = new System.Drawing.Point(85, 210);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 20);
            this.txt_qty.TabIndex = 30;
            this.txt_qty.Text = "0";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Location = new System.Drawing.Point(85, 92);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(4, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Unit price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(4, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Quntity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(2, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(4, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(4, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.DimGray;
            this.btn_delete.Location = new System.Drawing.Point(288, 158);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(99, 33);
            this.btn_delete.TabIndex = 44;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update_stock
            // 
            this.btn_update_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_update_stock.ForeColor = System.Drawing.Color.DimGray;
            this.btn_update_stock.Location = new System.Drawing.Point(133, 374);
            this.btn_update_stock.Name = "btn_update_stock";
            this.btn_update_stock.Size = new System.Drawing.Size(103, 34);
            this.btn_update_stock.TabIndex = 46;
            this.btn_update_stock.Text = "Update Stock";
            this.btn_update_stock.UseVisualStyleBackColor = true;
            this.btn_update_stock.Click += new System.EventHandler(this.btn_update_stock_Click);
            // 
            // dgv_inven
            // 
            this.dgv_inven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inven.Location = new System.Drawing.Point(6, 88);
            this.dgv_inven.Name = "dgv_inven";
            this.dgv_inven.Size = new System.Drawing.Size(844, 352);
            this.dgv_inven.TabIndex = 47;
            // 
            // cmb_id
            // 
            this.cmb_id.FormattingEnabled = true;
            this.cmb_id.Location = new System.Drawing.Point(85, 52);
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.Size = new System.Drawing.Size(121, 21);
            this.cmb_id.TabIndex = 48;
            this.cmb_id.SelectedIndexChanged += new System.EventHandler(this.cmb_id_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_date);
            this.groupBox1.Controls.Add(this.rdb_input);
            this.groupBox1.Controls.Add(this.btn_filter_search);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.dgv_inven);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.dtp_start);
            this.groupBox1.Controls.Add(this.cmb_type);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(405, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 450);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // rdb_date
            // 
            this.rdb_date.AutoSize = true;
            this.rdb_date.Location = new System.Drawing.Point(94, 52);
            this.rdb_date.Name = "rdb_date";
            this.rdb_date.Size = new System.Drawing.Size(14, 13);
            this.rdb_date.TabIndex = 15;
            this.rdb_date.TabStop = true;
            this.rdb_date.UseVisualStyleBackColor = true;
            this.rdb_date.CheckedChanged += new System.EventHandler(this.rdb_date_CheckedChanged);
            // 
            // rdb_input
            // 
            this.rdb_input.AutoSize = true;
            this.rdb_input.Location = new System.Drawing.Point(94, 28);
            this.rdb_input.Name = "rdb_input";
            this.rdb_input.Size = new System.Drawing.Size(14, 13);
            this.rdb_input.TabIndex = 16;
            this.rdb_input.TabStop = true;
            this.rdb_input.UseVisualStyleBackColor = true;
            this.rdb_input.CheckedChanged += new System.EventHandler(this.rdb_input_CheckedChanged);
            // 
            // btn_filter_search
            // 
            this.btn_filter_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_filter_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filter_search.ForeColor = System.Drawing.Color.DimGray;
            this.btn_filter_search.Location = new System.Drawing.Point(604, 20);
            this.btn_filter_search.Name = "btn_filter_search";
            this.btn_filter_search.Size = new System.Drawing.Size(85, 46);
            this.btn_filter_search.TabIndex = 14;
            this.btn_filter_search.Text = "Search";
            this.btn_filter_search.UseVisualStyleBackColor = false;
            this.btn_filter_search.Click += new System.EventHandler(this.btn_filter_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Enabled = false;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txt_search.ForeColor = System.Drawing.Color.DimGray;
            this.txt_search.Location = new System.Drawing.Point(339, 15);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 21);
            this.txt_search.TabIndex = 13;
            // 
            // dtp_end
            // 
            this.dtp_end.Enabled = false;
            this.dtp_end.Location = new System.Drawing.Point(371, 49);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(200, 22);
            this.dtp_end.TabIndex = 12;
            // 
            // dtp_start
            // 
            this.dtp_start.Enabled = false;
            this.dtp_start.Location = new System.Drawing.Point(165, 49);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(200, 22);
            this.dtp_start.TabIndex = 11;
            // 
            // cmb_type
            // 
            this.cmb_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cmb_type.Enabled = false;
            this.cmb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cmb_type.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "name",
            "category"});
            this.cmb_type.Location = new System.Drawing.Point(194, 14);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(121, 23);
            this.cmb_type.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(125, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(125, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Trype";
            // 
            // btn_id_search
            // 
            this.btn_id_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_id_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_id_search.ForeColor = System.Drawing.Color.DimGray;
            this.btn_id_search.Location = new System.Drawing.Point(231, 52);
            this.btn_id_search.Name = "btn_id_search";
            this.btn_id_search.Size = new System.Drawing.Size(156, 31);
            this.btn_id_search.TabIndex = 50;
            this.btn_id_search.Text = "Search From Stock";
            this.btn_id_search.UseVisualStyleBackColor = true;
            this.btn_id_search.Click += new System.EventHandler(this.btn_id_search_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(13, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 31);
            this.label10.TabIndex = 73;
            this.label10.Text = "Inevntory";
            // 
            // gb_inventory
            // 
            this.gb_inventory.Controls.Add(this.btn_update_stock);
            this.gb_inventory.Controls.Add(this.label1);
            this.gb_inventory.Controls.Add(this.btn_id_search);
            this.gb_inventory.Controls.Add(this.label2);
            this.gb_inventory.Controls.Add(this.label3);
            this.gb_inventory.Controls.Add(this.cmb_id);
            this.gb_inventory.Controls.Add(this.label4);
            this.gb_inventory.Controls.Add(this.label5);
            this.gb_inventory.Controls.Add(this.btn_delete);
            this.gb_inventory.Controls.Add(this.label6);
            this.gb_inventory.Controls.Add(this.btn_clear);
            this.gb_inventory.Controls.Add(this.txt_name);
            this.gb_inventory.Controls.Add(this.btn_Search);
            this.gb_inventory.Controls.Add(this.txt_qty);
            this.gb_inventory.Controls.Add(this.txt_logid);
            this.gb_inventory.Controls.Add(this.txt_uprice);
            this.gb_inventory.Controls.Add(this.label8);
            this.gb_inventory.Controls.Add(this.cmb_category);
            this.gb_inventory.Controls.Add(this.unit);
            this.gb_inventory.Controls.Add(this.datet);
            this.gb_inventory.Controls.Add(this.txt_unit);
            this.gb_inventory.Controls.Add(this.btn_insert);
            this.gb_inventory.Location = new System.Drawing.Point(5, 67);
            this.gb_inventory.Name = "gb_inventory";
            this.gb_inventory.Size = new System.Drawing.Size(394, 447);
            this.gb_inventory.TabIndex = 74;
            this.gb_inventory.TabStop = false;
            // 
            // inventroyp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.gb_inventory);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "inventroyp";
            this.Size = new System.Drawing.Size(1262, 519);
            this.Load += new System.EventHandler(this.inventroyp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inven)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_inventory.ResumeLayout(false);
            this.gb_inventory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_logid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DateTimePicker datet;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.TextBox txt_uprice;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update_stock;
        private System.Windows.Forms.DataGridView dgv_inven;
        private System.Windows.Forms.ComboBox cmb_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_date;
        private System.Windows.Forms.RadioButton rdb_input;
        private System.Windows.Forms.Button btn_filter_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_id_search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gb_inventory;
    }
}

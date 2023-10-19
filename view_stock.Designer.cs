namespace Vcafe
{
    partial class stock
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
            this.dgv_view_stock = new System.Windows.Forms.DataGridView();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_id_search = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.unit = new System.Windows.Forms.Label();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.txt_uprice = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_filter_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_stock = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_stock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_stock.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_view_stock
            // 
            this.dgv_view_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_view_stock.Location = new System.Drawing.Point(9, 67);
            this.dgv_view_stock.Name = "dgv_view_stock";
            this.dgv_view_stock.Size = new System.Drawing.Size(646, 286);
            this.dgv_view_stock.TabIndex = 0;
            this.dgv_view_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_view_stock_CellContentClick);
            // 
            // btn_remove
            // 
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_remove.ForeColor = System.Drawing.Color.DimGray;
            this.btn_remove.Location = new System.Drawing.Point(248, 108);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(99, 33);
            this.btn_remove.TabIndex = 69;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_id_search
            // 
            this.btn_id_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_id_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_id_search.ForeColor = System.Drawing.Color.DimGray;
            this.btn_id_search.Location = new System.Drawing.Point(241, 33);
            this.btn_id_search.Name = "btn_id_search";
            this.btn_id_search.Size = new System.Drawing.Size(156, 31);
            this.btn_id_search.TabIndex = 68;
            this.btn_id_search.Text = "Search From Stock";
            this.btn_id_search.UseVisualStyleBackColor = true;
            this.btn_id_search.Click += new System.EventHandler(this.btn_id_search_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.DimGray;
            this.btn_clear.Location = new System.Drawing.Point(285, 294);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(86, 34);
            this.btn_clear.TabIndex = 67;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.unit.ForeColor = System.Drawing.Color.DimGray;
            this.unit.Location = new System.Drawing.Point(30, 202);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(34, 18);
            this.unit.TabIndex = 63;
            this.unit.Text = "Unit";
            // 
            // txt_unit
            // 
            this.txt_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_unit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_unit.ForeColor = System.Drawing.Color.DimGray;
            this.txt_unit.Location = new System.Drawing.Point(105, 201);
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Size = new System.Drawing.Size(100, 20);
            this.txt_unit.TabIndex = 62;
            // 
            // btn_insert
            // 
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_insert.ForeColor = System.Drawing.Color.DimGray;
            this.btn_insert.Location = new System.Drawing.Point(33, 294);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(81, 33);
            this.btn_insert.TabIndex = 61;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // cmb_category
            // 
            this.cmb_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cmb_category.ForeColor = System.Drawing.Color.DarkGray;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(105, 120);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(121, 21);
            this.cmb_category.TabIndex = 59;
            // 
            // txt_uprice
            // 
            this.txt_uprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_uprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_uprice.ForeColor = System.Drawing.Color.DimGray;
            this.txt_uprice.Location = new System.Drawing.Point(105, 233);
            this.txt_uprice.Name = "txt_uprice";
            this.txt_uprice.Size = new System.Drawing.Size(100, 20);
            this.txt_uprice.TabIndex = 56;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.ForeColor = System.Drawing.Color.DimGray;
            this.txt_name.Location = new System.Drawing.Point(105, 85);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 54;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.ForeColor = System.Drawing.Color.DimGray;
            this.txt_id.Location = new System.Drawing.Point(105, 40);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(24, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 52;
            this.label6.Text = "Unit price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(24, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(24, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Quntity";
            // 
            // txt_qty
            // 
            this.txt_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qty.Enabled = false;
            this.txt_qty.ForeColor = System.Drawing.Color.DimGray;
            this.txt_qty.Location = new System.Drawing.Point(105, 166);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 20);
            this.txt_qty.TabIndex = 55;
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.DimGray;
            this.btn_update.Location = new System.Drawing.Point(140, 294);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 34);
            this.btn_update.TabIndex = 70;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.btn_filter_search);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.cmb_type);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dgv_view_stock);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(429, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 379);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btn_filter_search
            // 
            this.btn_filter_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_filter_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filter_search.ForeColor = System.Drawing.Color.DimGray;
            this.btn_filter_search.Location = new System.Drawing.Point(427, 25);
            this.btn_filter_search.Name = "btn_filter_search";
            this.btn_filter_search.Size = new System.Drawing.Size(88, 35);
            this.btn_filter_search.TabIndex = 14;
            this.btn_filter_search.Text = "Search";
            this.btn_filter_search.UseVisualStyleBackColor = false;
            this.btn_filter_search.Click += new System.EventHandler(this.btn_filter_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txt_search.ForeColor = System.Drawing.Color.DimGray;
            this.txt_search.Location = new System.Drawing.Point(261, 32);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 21);
            this.txt_search.TabIndex = 13;
            // 
            // cmb_type
            // 
            this.cmb_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cmb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cmb_type.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "name",
            "category"});
            this.cmb_type.Location = new System.Drawing.Point(116, 31);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(121, 23);
            this.cmb_type.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(47, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Trype";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 72;
            this.label4.Text = "Stock";
            // 
            // gb_stock
            // 
            this.gb_stock.Controls.Add(this.btn_clear);
            this.gb_stock.Controls.Add(this.label1);
            this.gb_stock.Controls.Add(this.btn_update);
            this.gb_stock.Controls.Add(this.label2);
            this.gb_stock.Controls.Add(this.btn_remove);
            this.gb_stock.Controls.Add(this.label3);
            this.gb_stock.Controls.Add(this.btn_id_search);
            this.gb_stock.Controls.Add(this.label5);
            this.gb_stock.Controls.Add(this.label6);
            this.gb_stock.Controls.Add(this.unit);
            this.gb_stock.Controls.Add(this.txt_id);
            this.gb_stock.Controls.Add(this.txt_unit);
            this.gb_stock.Controls.Add(this.txt_name);
            this.gb_stock.Controls.Add(this.btn_insert);
            this.gb_stock.Controls.Add(this.txt_qty);
            this.gb_stock.Controls.Add(this.cmb_category);
            this.gb_stock.Controls.Add(this.txt_uprice);
            this.gb_stock.Location = new System.Drawing.Point(19, 52);
            this.gb_stock.Name = "gb_stock";
            this.gb_stock.Size = new System.Drawing.Size(404, 379);
            this.gb_stock.TabIndex = 73;
            this.gb_stock.TabStop = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.DimGray;
            this.btn_refresh.Location = new System.Drawing.Point(552, 25);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(88, 35);
            this.btn_refresh.TabIndex = 15;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.gb_stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "stock";
            this.Size = new System.Drawing.Size(1119, 485);
            this.Load += new System.EventHandler(this.view_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_stock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_stock.ResumeLayout(false);
            this.gb_stock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_view_stock;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_id_search;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.TextBox txt_uprice;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_filter_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb_stock;
        private System.Windows.Forms.Button btn_refresh;
    }
}

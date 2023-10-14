namespace Vcafe
{
    partial class inventory
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_uprice = new System.Windows.Forms.TextBox();
            this.txt_tprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.datet = new System.Windows.Forms.DateTimePicker();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.unit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_logid = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_id_search = new System.Windows.Forms.Button();
            this.view_inventory1 = new Vcafe.view_inventory();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quntity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unit price";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(157, 48);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 6;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(157, 92);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 7;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(157, 213);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 20);
            this.txt_qty.TabIndex = 8;
            // 
            // txt_uprice
            // 
            this.txt_uprice.Location = new System.Drawing.Point(157, 280);
            this.txt_uprice.Name = "txt_uprice";
            this.txt_uprice.Size = new System.Drawing.Size(100, 20);
            this.txt_uprice.TabIndex = 9;
            // 
            // txt_tprice
            // 
            this.txt_tprice.Location = new System.Drawing.Point(157, 322);
            this.txt_tprice.Name = "txt_tprice";
            this.txt_tprice.Size = new System.Drawing.Size(100, 20);
            this.txt_tprice.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Price";
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(157, 127);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(121, 21);
            this.cmb_category.TabIndex = 12;
            // 
            // datet
            // 
            this.datet.Location = new System.Drawing.Point(157, 173);
            this.datet.Name = "datet";
            this.datet.Size = new System.Drawing.Size(181, 20);
            this.datet.TabIndex = 13;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(274, 203);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(99, 33);
            this.btn_insert.TabIndex = 14;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_unit
            // 
            this.txt_unit.Location = new System.Drawing.Point(157, 248);
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Size = new System.Drawing.Size(100, 20);
            this.txt_unit.TabIndex = 15;
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Location = new System.Drawing.Point(85, 251);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(26, 13);
            this.unit.TabIndex = 16;
            this.unit.Text = "Unit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "LOG ID";
            // 
            // txt_logid
            // 
            this.txt_logid.Location = new System.Drawing.Point(157, 12);
            this.txt_logid.Name = "txt_logid";
            this.txt_logid.Size = new System.Drawing.Size(100, 20);
            this.txt_logid.TabIndex = 18;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(274, 10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 19;
            this.btn_Search.Text = "Log Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(274, 251);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_id_search
            // 
            this.btn_id_search.Location = new System.Drawing.Point(274, 50);
            this.btn_id_search.Name = "btn_id_search";
            this.btn_id_search.Size = new System.Drawing.Size(75, 23);
            this.btn_id_search.TabIndex = 21;
            this.btn_id_search.Text = "ID Search";
            this.btn_id_search.UseVisualStyleBackColor = true;
            this.btn_id_search.Click += new System.EventHandler(this.btn_id_search_Click);
            // 
            // view_inventory1
            // 
            this.view_inventory1.Location = new System.Drawing.Point(369, -32);
            this.view_inventory1.Name = "view_inventory1";
            this.view_inventory1.Size = new System.Drawing.Size(666, 328);
            this.view_inventory1.TabIndex = 22;
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 524);
            this.Controls.Add(this.view_inventory1);
            this.Controls.Add(this.btn_id_search);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_logid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.txt_unit);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.datet);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tprice);
            this.Controls.Add(this.txt_uprice);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "inventory";
            this.Text = "inventory";
            this.Load += new System.EventHandler(this.inventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_uprice;
        private System.Windows.Forms.TextBox txt_tprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.DateTimePicker datet;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_logid;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_id_search;
        private view_inventory view_inventory1;
    }
}
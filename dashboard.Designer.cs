namespace Vcafe
{
    partial class dashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_dend = new System.Windows.Forms.Label();
            this.lbl_dstart = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.btn_get = new System.Windows.Forms.Button();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.btday = new System.Windows.Forms.Button();
            this.btnmonth = new System.Windows.Forms.Button();
            this.btn7day = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.dgv_user_log = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_log)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btday);
            this.panel2.Controls.Add(this.btnmonth);
            this.panel2.Controls.Add(this.btn7day);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblcus);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(101, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 147);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_dend);
            this.groupBox1.Controls.Add(this.lbl_dstart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.date_end);
            this.groupBox1.Controls.Add(this.btn_get);
            this.groupBox1.Controls.Add(this.date_start);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(171, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search from Date";
            // 
            // lbl_dend
            // 
            this.lbl_dend.Location = new System.Drawing.Point(91, 52);
            this.lbl_dend.Name = "lbl_dend";
            this.lbl_dend.Size = new System.Drawing.Size(96, 20);
            this.lbl_dend.TabIndex = 10;
            this.lbl_dend.Click += new System.EventHandler(this.lbl_dend_Click);
            // 
            // lbl_dstart
            // 
            this.lbl_dstart.Location = new System.Drawing.Point(91, 24);
            this.lbl_dstart.Name = "lbl_dstart";
            this.lbl_dstart.Size = new System.Drawing.Size(96, 20);
            this.lbl_dstart.TabIndex = 9;
            this.lbl_dstart.Click += new System.EventHandler(this.lbl_dstart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(21, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(21, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "From";
            // 
            // date_end
            // 
            this.date_end.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_end.Location = new System.Drawing.Point(91, 53);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(96, 20);
            this.date_end.TabIndex = 7;
            this.date_end.Value = new System.DateTime(2023, 7, 25, 0, 0, 0, 0);
            this.date_end.ValueChanged += new System.EventHandler(this.date_end_ValueChanged);
            // 
            // btn_get
            // 
            this.btn_get.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.btn_get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get.ForeColor = System.Drawing.Color.DimGray;
            this.btn_get.Location = new System.Drawing.Point(211, 15);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(82, 45);
            this.btn_get.TabIndex = 6;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = false;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // date_start
            // 
            this.date_start.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.date_start.Checked = false;
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_start.Location = new System.Drawing.Point(91, 25);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(96, 20);
            this.date_start.TabIndex = 7;
            this.date_start.Value = new System.DateTime(2023, 7, 25, 13, 58, 8, 0);
            this.date_start.ValueChanged += new System.EventHandler(this.date_start_ValueChanged);
            // 
            // btday
            // 
            this.btday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.btday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btday.ForeColor = System.Drawing.Color.DimGray;
            this.btday.Location = new System.Drawing.Point(482, 36);
            this.btday.Name = "btday";
            this.btday.Size = new System.Drawing.Size(73, 55);
            this.btday.TabIndex = 6;
            this.btday.Text = "last day";
            this.btday.UseVisualStyleBackColor = false;
            this.btday.Click += new System.EventHandler(this.btday_Click);
            // 
            // btnmonth
            // 
            this.btnmonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.btnmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmonth.ForeColor = System.Drawing.Color.DimGray;
            this.btnmonth.Location = new System.Drawing.Point(682, 35);
            this.btnmonth.Name = "btnmonth";
            this.btnmonth.Size = new System.Drawing.Size(93, 54);
            this.btnmonth.TabIndex = 6;
            this.btnmonth.Text = "Last Moth";
            this.btnmonth.UseVisualStyleBackColor = false;
            this.btnmonth.Click += new System.EventHandler(this.btnmonth_Click);
            // 
            // btn7day
            // 
            this.btn7day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.btn7day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7day.ForeColor = System.Drawing.Color.DimGray;
            this.btn7day.Location = new System.Drawing.Point(565, 35);
            this.btn7day.Name = "btn7day";
            this.btn7day.Size = new System.Drawing.Size(108, 54);
            this.btn7day.TabIndex = 6;
            this.btn7day.Text = "Last 7 Days";
            this.btn7day.UseVisualStyleBackColor = false;
            this.btn7day.Click += new System.EventHandler(this.btn7day_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(21, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rs :";
            // 
            // lblcus
            // 
            this.lblcus.AutoSize = true;
            this.lblcus.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcus.ForeColor = System.Drawing.Color.DimGray;
            this.lblcus.Location = new System.Drawing.Point(72, 74);
            this.lblcus.Name = "lblcus";
            this.lblcus.Size = new System.Drawing.Size(0, 24);
            this.lblcus.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = " Profit";
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_admin.Location = new System.Drawing.Point(16, 12);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(60, 24);
            this.lbl_admin.TabIndex = 6;
            this.lbl_admin.Text = "label1";
            // 
            // dgv_user
            // 
            this.dgv_user.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgv_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(68, 240);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.Size = new System.Drawing.Size(341, 148);
            this.dgv_user.TabIndex = 8;
            // 
            // dgv_user_log
            // 
            this.dgv_user_log.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgv_user_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_user_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user_log.Location = new System.Drawing.Point(457, 240);
            this.dgv_user_log.Name = "dgv_user_log";
            this.dgv_user_log.Size = new System.Drawing.Size(465, 195);
            this.dgv_user_log.TabIndex = 9;
            this.dgv_user_log.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_log_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(531, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "User Log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(74, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Accounts";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_user_log);
            this.Controls.Add(this.dgv_user);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.panel2);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(967, 504);
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_dend;
        private System.Windows.Forms.Label lbl_dstart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.Button btday;
        private System.Windows.Forms.Button btnmonth;
        private System.Windows.Forms.Button btn7day;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcus;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.DataGridView dgv_user_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

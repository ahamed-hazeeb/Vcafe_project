namespace Vcafe
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_user = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_userlog = new System.Windows.Forms.Button();
            this.lbl_position = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            this.btn_dashbord = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.slide = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnl_menu.Controls.Add(this.btn_user);
            this.pnl_menu.Controls.Add(this.button1);
            this.pnl_menu.Controls.Add(this.btn_userlog);
            this.pnl_menu.Controls.Add(this.lbl_position);
            this.pnl_menu.Controls.Add(this.lbl_name);
            this.pnl_menu.Controls.Add(this.btn_menu);
            this.pnl_menu.Controls.Add(this.btn_stock);
            this.pnl_menu.Controls.Add(this.btn_report);
            this.pnl_menu.Controls.Add(this.btn_product);
            this.pnl_menu.Controls.Add(this.btn_inventory);
            this.pnl_menu.Controls.Add(this.btn_bill);
            this.pnl_menu.Controls.Add(this.btn_dashbord);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.MaximumSize = new System.Drawing.Size(120, 900);
            this.pnl_menu.MinimumSize = new System.Drawing.Size(55, 900);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(55, 900);
            this.pnl_menu.TabIndex = 0;
            this.pnl_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_menu_Paint);
            // 
            // btn_user
            // 
            this.btn_user.FlatAppearance.BorderSize = 0;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.ForeColor = System.Drawing.Color.White;
            this.btn_user.Image = global::Vcafe.Properties.Resources.user;
            this.btn_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user.Location = new System.Drawing.Point(0, 454);
            this.btn_user.MaximumSize = new System.Drawing.Size(140, 40);
            this.btn_user.MinimumSize = new System.Drawing.Size(70, 40);
            this.btn_user.Name = "btn_user";
            this.btn_user.Padding = new System.Windows.Forms.Padding(5);
            this.btn_user.Size = new System.Drawing.Size(140, 40);
            this.btn_user.TabIndex = 7;
            this.btn_user.Text = "     Account";
            this.btn_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            this.btn_user.Leave += new System.EventHandler(this.btn_user_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Vcafe.Properties.Resources.logout;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 611);
            this.button1.MaximumSize = new System.Drawing.Size(140, 40);
            this.button1.MinimumSize = new System.Drawing.Size(70, 40);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "           Log Out";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_userlog
            // 
            this.btn_userlog.FlatAppearance.BorderSize = 0;
            this.btn_userlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userlog.ForeColor = System.Drawing.Color.White;
            this.btn_userlog.Image = global::Vcafe.Properties.Resources.log_file;
            this.btn_userlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_userlog.Location = new System.Drawing.Point(0, 501);
            this.btn_userlog.MaximumSize = new System.Drawing.Size(140, 40);
            this.btn_userlog.MinimumSize = new System.Drawing.Size(70, 40);
            this.btn_userlog.Name = "btn_userlog";
            this.btn_userlog.Padding = new System.Windows.Forms.Padding(5);
            this.btn_userlog.Size = new System.Drawing.Size(140, 40);
            this.btn_userlog.TabIndex = 6;
            this.btn_userlog.Text = "      User Log";
            this.btn_userlog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_userlog.UseVisualStyleBackColor = true;
            this.btn_userlog.Click += new System.EventHandler(this.btn_userlog_Click);
            this.btn_userlog.Leave += new System.EventHandler(this.btn_userlog_Leave);
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Location = new System.Drawing.Point(12, 88);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(43, 13);
            this.lbl_position.TabIndex = 4;
            this.lbl_position.Text = "position";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(3, 57);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(46, 19);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "name";
            // 
            // btn_menu
            // 
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = global::Vcafe.Properties.Resources.menu;
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(2, 113);
            this.btn_menu.MaximumSize = new System.Drawing.Size(140, 40);
            this.btn_menu.MinimumSize = new System.Drawing.Size(70, 40);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Padding = new System.Windows.Forms.Padding(5);
            this.btn_menu.Size = new System.Drawing.Size(140, 40);
            this.btn_menu.TabIndex = 2;
            this.btn_menu.Text = "      Menu";
            this.btn_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            this.btn_menu.Leave += new System.EventHandler(this.btn_menu_Leave);
            // 
            // btn_stock
            // 
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.ForeColor = System.Drawing.Color.White;
            this.btn_stock.Image = ((System.Drawing.Image)(resources.GetObject("btn_stock.Image")));
            this.btn_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stock.Location = new System.Drawing.Point(2, 313);
            this.btn_stock.MaximumSize = new System.Drawing.Size(140, 40);
            this.btn_stock.MinimumSize = new System.Drawing.Size(70, 40);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Padding = new System.Windows.Forms.Padding(5);
            this.btn_stock.Size = new System.Drawing.Size(140, 40);
            this.btn_stock.TabIndex = 3;
            this.btn_stock.Text = "      Stock";
            this.btn_stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            this.btn_stock.Leave += new System.EventHandler(this.btn_stock_Leave);
            // 
            // btn_report
            // 
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Image = ((System.Drawing.Image)(resources.GetObject("btn_report.Image")));
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Location = new System.Drawing.Point(3, 407);
            this.btn_report.MaximumSize = new System.Drawing.Size(140, 40);
            this.btn_report.MinimumSize = new System.Drawing.Size(70, 40);
            this.btn_report.Name = "btn_report";
            this.btn_report.Padding = new System.Windows.Forms.Padding(5);
            this.btn_report.Size = new System.Drawing.Size(140, 40);
            this.btn_report.TabIndex = 5;
            this.btn_report.Text = "      Report";
            this.btn_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.Report_Click);
            this.btn_report.Leave += new System.EventHandler(this.Report_Leave);
            // 
            // btn_product
            // 
            this.btn_product.FlatAppearance.BorderSize = 0;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.ForeColor = System.Drawing.Color.White;
            this.btn_product.Image = global::Vcafe.Properties.Resources.product;
            this.btn_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.Location = new System.Drawing.Point(3, 360);
            this.btn_product.MaximumSize = new System.Drawing.Size(140, 40);
            this.btn_product.MinimumSize = new System.Drawing.Size(70, 40);
            this.btn_product.Name = "btn_product";
            this.btn_product.Padding = new System.Windows.Forms.Padding(5);
            this.btn_product.Size = new System.Drawing.Size(140, 40);
            this.btn_product.TabIndex = 4;
            this.btn_product.Text = "      Product";
            this.btn_product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            this.btn_product.Leave += new System.EventHandler(this.btn_product_Leave);
            // 
            // btn_inventory
            // 
            this.btn_inventory.FlatAppearance.BorderSize = 0;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.ForeColor = System.Drawing.Color.White;
            this.btn_inventory.Image = ((System.Drawing.Image)(resources.GetObject("btn_inventory.Image")));
            this.btn_inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventory.Location = new System.Drawing.Point(0, 266);
            this.btn_inventory.MaximumSize = new System.Drawing.Size(140, 40);
            this.btn_inventory.MinimumSize = new System.Drawing.Size(70, 40);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Padding = new System.Windows.Forms.Padding(5);
            this.btn_inventory.Size = new System.Drawing.Size(140, 40);
            this.btn_inventory.TabIndex = 2;
            this.btn_inventory.Text = "      Inventory";
            this.btn_inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inventory.UseVisualStyleBackColor = true;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            this.btn_inventory.Leave += new System.EventHandler(this.btn_inventory_Leave);
            // 
            // btn_bill
            // 
            this.btn_bill.FlatAppearance.BorderSize = 0;
            this.btn_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill.ForeColor = System.Drawing.Color.White;
            this.btn_bill.Image = global::Vcafe.Properties.Resources.billing;
            this.btn_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bill.Location = new System.Drawing.Point(0, 219);
            this.btn_bill.MaximumSize = new System.Drawing.Size(140, 40);
            this.btn_bill.MinimumSize = new System.Drawing.Size(70, 40);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Padding = new System.Windows.Forms.Padding(5);
            this.btn_bill.Size = new System.Drawing.Size(140, 40);
            this.btn_bill.TabIndex = 1;
            this.btn_bill.Text = "      Billing";
            this.btn_bill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bill.UseVisualStyleBackColor = true;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            this.btn_bill.Leave += new System.EventHandler(this.btn_bill_Leave);
            // 
            // btn_dashbord
            // 
            this.btn_dashbord.FlatAppearance.BorderSize = 0;
            this.btn_dashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashbord.ForeColor = System.Drawing.Color.White;
            this.btn_dashbord.Image = global::Vcafe.Properties.Resources.dashboard;
            this.btn_dashbord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashbord.Location = new System.Drawing.Point(0, 172);
            this.btn_dashbord.MaximumSize = new System.Drawing.Size(140, 40);
            this.btn_dashbord.MinimumSize = new System.Drawing.Size(70, 40);
            this.btn_dashbord.Name = "btn_dashbord";
            this.btn_dashbord.Padding = new System.Windows.Forms.Padding(5);
            this.btn_dashbord.Size = new System.Drawing.Size(140, 40);
            this.btn_dashbord.TabIndex = 0;
            this.btn_dashbord.Text = "      Dashbord";
            this.btn_dashbord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dashbord.UseVisualStyleBackColor = true;
            this.btn_dashbord.Click += new System.EventHandler(this.btn_dashbord_Click);
            this.btn_dashbord.Leave += new System.EventHandler(this.btn_dashbord_Leave);
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(55, 36);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1243, 619);
            this.pnl_main.TabIndex = 2;
            this.pnl_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_main_Paint);
            // 
            // slide
            // 
            this.slide.Interval = 30;
            this.slide.Tick += new System.EventHandler(this.slide_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(55, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 36);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 655);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_menu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.Button btn_dashbord;
        private System.Windows.Forms.Timer slide;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_userlog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_user;
    }
}


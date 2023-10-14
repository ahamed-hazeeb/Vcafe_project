namespace Vcafe
{
    partial class card
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_pid = new System.Windows.Forms.Label();
            this.pic_pro = new System.Windows.Forms.PictureBox();
            this.btn_click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_name.Location = new System.Drawing.Point(3, 120);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(124, 36);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "name";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_price.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_price.Location = new System.Drawing.Point(49, 165);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(35, 13);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "price";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pid
            // 
            this.lbl_pid.AutoSize = true;
            this.lbl_pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_pid.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_pid.Location = new System.Drawing.Point(165, 20);
            this.lbl_pid.Name = "lbl_pid";
            this.lbl_pid.Size = new System.Drawing.Size(0, 25);
            this.lbl_pid.TabIndex = 4;
            // 
            // pic_pro
            // 
            this.pic_pro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_pro.Location = new System.Drawing.Point(0, 1);
            this.pic_pro.Name = "pic_pro";
            this.pic_pro.Size = new System.Drawing.Size(130, 116);
            this.pic_pro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pro.TabIndex = 5;
            this.pic_pro.TabStop = false;
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(30, 186);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(75, 23);
            this.btn_click.TabIndex = 6;
            this.btn_click.Text = "Click";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.pic_pro);
            this.Controls.Add(this.lbl_pid);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_name);
            this.Name = "card";
            this.Size = new System.Drawing.Size(130, 215);
            this.Load += new System.EventHandler(this.card_Load);
            this.Click += new System.EventHandler(this.card_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pic_pro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_pid;
        private System.Windows.Forms.PictureBox pic_pro;
        public System.Windows.Forms.Button btn_click;
    }
}

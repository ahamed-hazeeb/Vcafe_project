namespace Vcafe
{
    partial class view_inventory
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
            this.dgv_view_in = new System.Windows.Forms.DataGridView();
            this.inv = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_in)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_view_in
            // 
            this.dgv_view_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_view_in.Location = new System.Drawing.Point(0, 58);
            this.dgv_view_in.Name = "dgv_view_in";
            this.dgv_view_in.Size = new System.Drawing.Size(626, 325);
            this.dgv_view_in.TabIndex = 0;
            // 
            // inv
            // 
            this.inv.Enabled = true;
            this.inv.Interval = 5000;
            this.inv.Tick += new System.EventHandler(this.inv_Tick);
            // 
            // view_inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_view_in);
            this.Name = "view_inventory";
            this.Size = new System.Drawing.Size(632, 481);
            this.Load += new System.EventHandler(this.view_inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_in)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_view_in;
        private System.Windows.Forms.Timer inv;
    }
}

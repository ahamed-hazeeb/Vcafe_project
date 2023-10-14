using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vcafe
{
    public partial class card : UserControl
    {
        private int _pid;
        private string _name;
        private string _price;
        
        public card()
        {
            InitializeComponent();

            

        }
       
        public string name {
            get { return _name; }
            set { _name = value; lbl_name.Text = value; } 
        }
        public string price
        {
            get { return _price; }
            set { _price = value; lbl_price.Text = value; }
        }

        public int pid
        {
            get { return _pid; }
            set { _pid = value; lbl_pid.Text = value.ToString(); }
        }
        private byte[] _imageData;
        public byte[] ImageData
        {
            get { return _imageData; }
            set
            {
                _imageData = value;
                if (_imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(_imageData))
                    {
                        Img = Image.FromStream(ms);
                    }
                }
                else
                {
                    Img = null; // Clear the PictureBox if no image data is set
                }
            }
        }

        private Image _img;
        public Image Img
        {
            get { return _img; }
            set
            {
                _img = value;
                pic_pro.Image = value;
            }


        }
        

        private void card_Click(object sender, EventArgs e)
        {

        }

        private void card_Load(object sender, EventArgs e)
        {

        }

        private void btn_click_Click(object sender, EventArgs e)
        {
           OnClick(EventArgs.Empty);
        }
    }
}

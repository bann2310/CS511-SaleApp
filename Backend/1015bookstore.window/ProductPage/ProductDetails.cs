using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _1015bookstore.window.MainPage.Products
{
    public partial class ProductDetails : UserControl
    {
        private string _motasanpham;
        public ProductDetails()
        {
            InitializeComponent();

            Load_Motasanpham();
        }

        public void Load_Motasanpham()
        {
            int totallength = motasanpham.Text.Length;
            int wordperline = 220;
            int x = (totallength / wordperline);

            if (x >= 2)
            {
                motasanpham.Height = (x) * 24;
            }

            else
                motasanpham.Height = 50;

            this.Height = motasanpham.Bottom;
        }
    }
}

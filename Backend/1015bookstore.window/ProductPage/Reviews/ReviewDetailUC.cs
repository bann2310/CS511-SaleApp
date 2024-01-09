using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1015bookstore.window.ProductPage.Reviews
{
    public partial class ReviewDetailUC : UserControl
    {
        public ReviewDetailUC()
        {
            InitializeComponent();

            Load_binhluan();
        }

        public void Load_binhluan()
        {
            int totallength = binhluan.Text.Length;
            int wordperline = 386;
            int x = (totallength / wordperline);

            if (x >= 2)
                binhluan.Height = (x) * 26;

            else
                binhluan.Height = 50;

            this.Height = binhluan.Bottom;
        }
    }
}

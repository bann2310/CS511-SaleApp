using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1015bookstore.window.TrendingPage
{
    public partial class TrendingUC : UserControl
    {
        public TrendingUC()
        {
            InitializeComponent();
        }

        private void addtheloai(string str)
        {
            label2 = new Label();
            label2.Text = str;

            theloai.Controls.Add(label2);
            theloai.Height += label2.Height + 10;
            panel3.Height = theloai.Bottom + 10;
        }
    }
}

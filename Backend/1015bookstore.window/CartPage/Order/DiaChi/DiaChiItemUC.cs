using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1015bookstore.window.CartPage.Order.DiaChi
{
    public partial class DiaChiItemUC : UserControl
    {
        public DiaChiItemUC()
        {
            InitializeComponent();
            update();
        }

        private void update()
        {
            label2.Location = new Point(hoten.Right + 10, 10);
            sodienthoai.Location = new Point(label2.Right + 10, 10);
        }
    }
}

using _1015bookstore.window.CartPage.Order.DiaChi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1015bookstore.window.CartPage.Order
{
    public partial class DiaChiUC : UserControl
    {
        public DiaChiUC()
        {
            InitializeComponent();
            for(int i = 0; i < 5; i++) 
            {
                adddiachi();
            }
            
        }
        private void adddiachi()
        {
            DiaChiItemUC item = new DiaChiItemUC();
            this.diachi.Controls.Add(item);
            this.diachi.Height += item.Height - 10;

            this.huybo.Location = new Point(200, diachi.Bottom + 5);
            this.xacnhan.Location = new Point(340, diachi.Bottom + 5);

            this.Height = huybo.Bottom + 5;
        }

    }
}

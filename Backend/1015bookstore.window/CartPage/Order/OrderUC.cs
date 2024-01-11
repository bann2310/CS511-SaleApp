using _1015bookstore.window.CartPage.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1015bookstore.window.CartPage.Payment
{
    public partial class OrderUC : UserControl
    {
        private string _hoten, _sodienthoai;
        public OrderUC()
        {
            InitializeComponent();
            for(int i = 0; i < 5; i++) 
            {
                addorder();
            }
        }

        private void voucher_TextChanged(object sender, EventArgs e)
        {   
            string str = voucher.Text;
            // Kiểm tra xem dấu Enter có ở đầu không
            if (str.StartsWith(Environment.NewLine))
            {
                // Xóa dấu Enter và đặt lại vị trí con trỏ
                str = str.TrimStart('\r', '\n', ' ');
            }

            int totallength = str.Length;
            // Kiểm tra số lượng ký tự không quá 255
            if (totallength > 20)
            {
                // Giới hạn số lượng ký tự không quá 255
                str = str.Substring(0, 20);
            }
        }

        private void doidiachi_Click(object sender, EventArgs e)
        {

        }

        private void addorder()
        {
            OrderItemUC item = new OrderItemUC();
            this.order.Controls.Add(item);
            this.order.Height += item.Height;

            voucher_panel.Location = new Point(0, order.Bottom + 10);
            total_panel.Location = new Point(0, voucher_panel.Bottom + 10);
            this.Height = total_panel.Bottom;
        }
    }
}

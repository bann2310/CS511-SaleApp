using _1015bookstore.window.ProductPage.Reviews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1015bookstore.window.CartPage
{
    public partial class CartUC : UserControl
    {
        public CartUC()
        {
            InitializeComponent();
            addgiohang();
            addgiohang();
            addgiohang();
            addgiohang();
            addgiohang();
        }

        private void addgiohang()
        {
            CartItemUC item = new CartItemUC();
            this.giohang.Controls.Add(item);
            this.giohang.Height += item.Height;
            
            panel2.Location = new Point(0, giohang.Bottom + 10);
            hethang.Location = new Point(0, panel2.Bottom);
            this.Height = giohang.Bottom + panel2.Height + hethang.Height ;

        }
    }
}

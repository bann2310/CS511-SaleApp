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
            for(int i = 0; i < 4; i++)
            {
                addgiohang();
                addgiohangOOS();
                addgiohangOOService();
            }    
        }

        private void addgiohang()
        {
            CartItemUC item = new CartItemUC();
            this.giohang.Controls.Add(item);
            this.giohang.Height += item.Height;
            
            panel2.Location = new Point(0, giohang.Bottom + 10);
            hethang.Location = new Point(0, panel2.Bottom);
            this.Height = giohang.Bottom + panel2.Height + hethang.Height + panel3.Height + ngunghoatdong.Height + 10;
        }
        private void addgiohangOOS()
        {
            CartItemOOSUC item = new CartItemOOSUC();
            this.hethang.Controls.Add(item);
            this.hethang.Height += item.Height;

            panel3.Location = new Point(0, hethang.Bottom + 10);
            ngunghoatdong.Location = new Point(0, panel3.Bottom);
            this.Height = giohang.Bottom + panel2.Height + hethang.Height + panel3.Height + ngunghoatdong.Height;
        }

        private void addgiohangOOService()
        {
            CartItemOOSUC item = new CartItemOOSUC();
            this.ngunghoatdong.Controls.Add(item);
            this.ngunghoatdong.Height += item.Height;

            //panel3.Location = new Point(0, hethang.Bottom + 10);
            //ngunghoatdong.Location = new Point(0, panel3.Bottom);
            this.Height = giohang.Bottom + panel2.Height + hethang.Height + panel3.Height + ngunghoatdong.Height;
        }
    }
}

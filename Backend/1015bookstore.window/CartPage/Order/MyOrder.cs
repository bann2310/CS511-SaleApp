using _1015bookstore.window.ViewModel.Catalog.Orders;
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
    public partial class MyOrder : UserControl
    {
        OrderViewModel order;
        public MyOrder(OrderViewModel order)
        {
            InitializeComponent();
           this.order = order;
        }


    }
}

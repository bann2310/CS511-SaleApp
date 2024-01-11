using _1015bookstore.window.Business;
using _1015bookstore.window.MainPage;
using _1015bookstore.window.ViewModel.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1015bookstore.window.CartPage.Cart
{
    public partial class MyCart : UserControl
    {
        private readonly CartAPIClient client;
        private List<CartViewModel> list;
        private decimal total = 0;

        //public event EventHandler AddressLoadingCompleted;

        public MyCart()
        {
            InitializeComponent();
            client = new CartAPIClient();
            GetCart();
        }

        //public async Task LoadAddressAsync()
        //{

        //    await Task.Delay(3000);

        //    OnAddressLoadingCompleted();
        //}
        //protected virtual void OnAddressLoadingCompleted()
        //{
        //    AddressLoadingCompleted?.Invoke(this, EventArgs.Empty);
        //}

        private async void GetCart()
        {
            var response = await client.GetCart(Properties.Settings.Default.session, Properties.Settings.Default.id);
            if (response.Status)
            {
                list = response.Data;
                int count = 0;
                foreach (var item in response.Data)
                {
                    count++;
                    var cartitem = new CartItemUC(item);
                    cartitem.Name = item.iCart_id.ToString();
                    giohang.Controls.Add(cartitem);
                    cartitem.Show();

                    if (count != 1)
                    {
                        giohang.Height += 150;
                    }    
                    
                }
            }
            if (giohang.Bottom > 1000)
            {
                this.Height = giohang.Bottom + 400 + 20;
            }    
        }

        public void AddTotal(decimal tong)
        {
            total += tong;
            tongtien.Text = String.Format("{0:0.##}", total) + " đ";
        }
        public void SubTotal(decimal tong)
        {
            total -= tong;
            tongtien.Text = String.Format("{0:0.##}", total) + " đ";
        }

        private void CreateOrder()
        {
            var listchoose = new List<int>();

            foreach (var item in giohang.Controls) 
            {
                var cart = item as CartItemUC;
                if (cart.IsChoose())
                {
                    listchoose.Add(Convert.ToInt32(cart.Name));
                }    
            }

            if (listchoose.Count > 0)
            {

            }
        }

        private void thanhtoan_Click(object sender, EventArgs e)
        {
            CreateOrder();
        }
    }
}

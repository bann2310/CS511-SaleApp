using _1015bookstore.window.Business;
using _1015bookstore.window.MainPage;
using _1015bookstore.window.ViewModel.UserAddresses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1015bookstore.window.InformationPage
{
    public partial class InforAddress : UserControl
    {
        private Guid user_id;
        private UserAddressAPIClient client;
        public InforAddress(Guid user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            client = new UserAddressAPIClient();
            GetListAddress();
        }

        private async void GetListAddress()
        {
            var response = await client.GetAddressByUser(Properties.Settings.Default.session, user_id);
            if (response.Status) 
            {
                foreach (var item in response.Data)
                {
                    var address = new AddressViewModel
                    { 
                        id = item.id,
                        address_detail = item.address_detail,
                        city = item.city,
                        district = item.district,
                        is_default = item.is_default,
                        receiver_name = item.receiver_name,
                        receiver_phone = item.receiver_phone,
                        sub_district = item.sub_district,
                        user_id = item.user_id,
                    };
                    var addressdetail = new AddressDetail(address);
                    flowLayoutPanel1.Controls.Add(addressdetail);
                    addressdetail.Show();
                }
            }
        }
        
    }
}

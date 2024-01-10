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
    public partial class AddressUpdate : UserControl
    {
        private AddressViewModel address;
        public AddressUpdate(AddressViewModel address)
        {
            InitializeComponent();
            this.address = address;
            SetData();
        }

        private void SetData()
        {
            ten.Text = address.receiver_name;
            sdt.Text = address.receiver_phone;
            tinhthanh.Text = address.city;
            quanhuyen.Text = address.district;
            phuongxa.Text = address.sub_district;
            detail.Text = address.address_detail;
            setdafault.Checked = address.is_default;
        }

        private void close_Click(object sender, EventArgs e)
        {
            var form = this.TopLevelControl as MainA;
            form.close_updateaddress();
        }
    }
}

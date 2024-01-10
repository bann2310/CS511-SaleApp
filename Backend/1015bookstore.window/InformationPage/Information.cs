using _1015bookstore.window.Business;
using _1015bookstore.window.InformationPage;
using _1015bookstore.window.Login;
using _1015bookstore.window.ViewModel.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1015bookstore.window.MainPage.Informations
{
    public partial class Information : UserControl
    {
        private Guid user_id;
        private UserControl currentUC;
        private UserAPIClient _userAPIClient;
        public Information(Guid user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            _userAPIClient = new UserAPIClient();
            GetUserInformationAsync();
        }
        private async void GetUserInformationAsync()
        {
            var session = Properties.Settings.Default.session;
            var userResponse = await _userAPIClient.GetUserById(session, user_id);

            if (userResponse.Status)
            {
                var userViewModel = userResponse.Data;

                var infordetail = new InforDetail(userViewModel);
                infordetail.Location = new Point(380, 30);
                this.Controls.Add(infordetail);
                infordetail.BringToFront();
                infordetail.Show();

                currentUC = infordetail;
            }
            else
            {
                MessageBox.Show($"Error: {userResponse.Message}");
            }
        }
    }
}

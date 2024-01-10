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
            if (currentUC != null)
            { 
                this.Controls.Remove(currentUC);
                currentUC = null;
            }

            var userResponse = await _userAPIClient.GetUserById(Properties.Settings.Default.session, user_id);

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
    
        private void GetUserAddress()
        {
            this.Controls.Remove(currentUC);
            currentUC = null;

            var addressUC = new InforAddress(user_id);
            addressUC.Location = new Point(380, 30);
            this.Controls.Add(addressUC);
            addressUC.BringToFront();
            addressUC.Show();

            currentUC = addressUC;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            GetUserInformationAsync();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            GetUserAddress();
        }

        private void Label_MouseHover(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.FromArgb(48, 207, 130);
            label.Font = new Font("Roboto", 9, FontStyle.Bold);
        }
        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.FromArgb(140, 140, 140);
            label.Font = new Font("Roboto", 9, FontStyle.Regular);
        }
    }
}

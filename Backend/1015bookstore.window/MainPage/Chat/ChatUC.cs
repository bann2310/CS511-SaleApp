using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _1015bookstore.window.MainPage.Chat
{
    public partial class ChatUC : UserControl
    {
        public ChatUC()
        {
            InitializeComponent();
            content_setup();
        }

        private void content_setup()
        {
            content.Height = 27;
            panel2.Height = content.Height;
            this.Height = panel2.Bottom;
        }
        private void content_TextChanged(object sender, EventArgs e)
        {
            string str = content.Text;
            // Kiểm tra xem dấu Enter có ở đầu không
            if (str.StartsWith(Environment.NewLine))
            {
                // Xóa dấu Enter và đặt lại vị trí con trỏ
                str = str.TrimStart('\r', '\n');
            }

            int totallength = str.Length;
            // Kiểm tra số lượng ký tự không quá 255
            if (totallength > 287)
            {
                // Giới hạn số lượng ký tự không quá 255
                str = str.Substring(0, 287);
            }  
            else
            {            
                int wordperline = 47;
                int x = (totallength / wordperline) + ((totallength % wordperline) > 0 ? 1 : 0);
                
                if (x > 1)
                {
                    content.Height = x * 27;             
                }
                else
                {
                    content.Height = 27;
                }
                panel2.Height = content.Height - 5 * (x > 1 ? x : 0);

                this.Height = panel2.Bottom;
            }

            content.Text = str;
            content.SelectionStart = str.Length;
        }

        private void content_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                //uctText uct = new uctText(this.cmt.Text);
                //this.CommentBoard.Controls.Add(uct);

                //if (boyBtt.Checked == true && girlBtt.Checked == false)
                //    uct.Content(cmt.Text, Image.FromFile(boyPath));
                //else
                //    uct.Content(cmt.Text, Image.FromFile(girlPath));

                ////uct.Location = new System.Drawing.Point(0, y);
                ////uct.Size = new System.Drawing.Size(700, 51);
                ////y = y + 50;
                this.content.Clear();
                this.content.SelectionStart = 0;
                this.content.SelectionLength = 0;
            }
        }
    }
}

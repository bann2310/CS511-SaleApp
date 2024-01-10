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
    public partial class CartItemUC : UserControl
    {
        string _tensanpham, _dongia, _soluong, _sotien;
        public CartItemUC()
        {
            InitializeComponent();

            uncheck.Visible = true;
            check.Visible = false;
        }

        private void soluong_TextChanged(object sender, EventArgs e)
        {
            int sl = 1;
            // Loại bỏ các ký tự phi số
            string text = new string(soluong.Text.Where(char.IsDigit).ToArray());
            // Loại bỏ 0 ở đầu
            if (text.StartsWith("0"))
                text = text.TrimStart('0');

            if (!string.IsNullOrEmpty(text))
            {
                sl = int.Parse(text);

                if (sl > 99)
                    sl = 99;
            }

            soluong.Text = sl.ToString();
        }

        // Xử lý nút cộng, trừ số lượng
        private void cong_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(soluong.Text);

            if (sl < 99)
                sl++;
            else
                sl = 1;

            soluong.Text = sl.ToString();
        }

        private void tru_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(soluong.Text);

            if (sl > 1)
                sl--;
            else
                sl = 99;

            soluong.Text = sl.ToString();
        }

        private void uncheck_Click(object sender, EventArgs e)
        {
            check.Visible = true;
            uncheck.Visible = false;
        }

        private void check_Click(object sender, EventArgs e)
        {
            uncheck.Visible = true;
            check.Visible = false;
        }
    }
}

using _1015bookstore.window.ViewModel.Catalog.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1015bookstore.window.ProductPage.ProductCateAndSearch
{
    public partial class CateAndSearchItem : UserControl
    {

        private string filepath = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())), @"Img\user-content");
        private ProductViewModel product;
        public CateAndSearchItem(ProductViewModel product)
        {
            InitializeComponent();
            this.product = product;
            SetPicture();
            SetPrice();
            SetName(); SetCountBuy(); SetFlashSalse();
        }

        private void SetFlashSalse()
        {
            if (product.bProduct_flashsale)
            {
                label2.Visible = true;
            }
        }

        private void SetPicture()
        {
            if (product.sImage_pathThumbnail == null)
            {
                string url = Path.Combine(filepath, "default.png");
                Image image = Image.FromFile(url);
                avatar.Image = image;
            }
            else
            {
                string url = Path.Combine(filepath, product.sImage_pathThumbnail);
                Image image = Image.FromFile(url);
                avatar.Image = image;
            }

            

        }
        private void SetPrice()
        {
            dongia.Text = product.vProduct_price.ToString();
        }
        private void SetName()
        {
            var name_ = product.sProduct_name;
            if (name_.Length >= 33)
            {
                for (int i = 34 - 1; i >= 0; i--)
                {
                    if (name_[i] == ' ')
                    {
                        name_ = name_.Insert(i, "\n");
                        break;
                    }
                }
            }
            if (name_.Length >= 50)
            {
                for (int i = 50 - 1; i >= 0; i--)
                {
                    if (name_[i] == ' ')
                    {
                        name_ = new string(name_.Take(i).ToArray()) + new string('.', 3);
                        break;
                    }
                }
            }
            tensanpham.Text = name_;
        }

        private void SetCountBuy()
        {
            buy.Text = product.iProduct_buy_count.ToString();
        }
    }
}

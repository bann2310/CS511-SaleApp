﻿using _1015bookstore.window.ViewModel.Catalog.Products;
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

namespace _1015bookstore.window.MainPage.Products
{
    public partial class ProductDetails : UserControl
    {
        private ProductViewModel product;
        public ProductDetails(ProductViewModel product)
        {
            InitializeComponent();
            this.product = product;
            Setdata();
            Load_Motasanpham();
        }

        public void Setdata()
        {
            thuonghieu.Text = product.sProduct_brand;
            nhaxuatban.Text = product.sProduct_nop;
            nhacungcap.Text = product.sProduct_supplier;
            tacgia.Text = product.sProduct_author;
            namxuatban.Text = product.iProduct_yop.ToString();
            khohang.Text = product.iProduct_quantity.ToString();
            motasanpham.Text = product.sProduct_description;
        }

        public void Load_Motasanpham()
        {
            int totallength = motasanpham.Text.Length;
            int wordperline = 220;
            int x = (totallength / wordperline);

            if (x >= 2)
            {
                motasanpham.Height = (x) * 24;
            }

            else
                motasanpham.Height = 50;

            this.Height = motasanpham.Bottom;
        }
    }
}

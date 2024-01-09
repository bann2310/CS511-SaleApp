using _1015bookstore.window.ProductPage.Reviews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1015bookstore.window.ProductPage
{
    public partial class ReviewUC : UserControl
    {
        public ReviewDetailUC review;
        public ReviewUC()
        {
            InitializeComponent();
            
            for(int i = 0; i < 6; i++)
                addComment(review);
    
        }

        void addComment(ReviewDetailUC review)
        {
            review = new ReviewDetailUC();
            this.commentpanel.Controls.Add(review);
            this.commentpanel.Height += review.Height;

            this.Height = commentpanel.Bottom + 50;
        }
    }
}

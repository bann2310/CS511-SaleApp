namespace _1015bookstore.window.CartPage.Review
{
    partial class ReviewItemUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewItemUC));
            this.tensanpham = new System.Windows.Forms.Label();
            this.avatarsanpham = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatarsanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // tensanpham
            // 
            this.tensanpham.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensanpham.ForeColor = System.Drawing.Color.Black;
            this.tensanpham.Location = new System.Drawing.Point(60, 5);
            this.tensanpham.Name = "tensanpham";
            this.tensanpham.Size = new System.Drawing.Size(484, 40);
            this.tensanpham.TabIndex = 26;
            this.tensanpham.Text = "Bài Tập Trắc Nghiệm Tiếng Anh 9 Theo Chương Trình Thí Điểm (Không Đáp Án)";
            // 
            // avatarsanpham
            // 
            this.avatarsanpham.Image = ((System.Drawing.Image)(resources.GetObject("avatarsanpham.Image")));
            this.avatarsanpham.Location = new System.Drawing.Point(5, 0);
            this.avatarsanpham.Name = "avatarsanpham";
            this.avatarsanpham.Size = new System.Drawing.Size(50, 50);
            this.avatarsanpham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarsanpham.TabIndex = 25;
            this.avatarsanpham.TabStop = false;
            // 
            // ReviewItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tensanpham);
            this.Controls.Add(this.avatarsanpham);
            this.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReviewItemUC";
            this.Size = new System.Drawing.Size(600, 55);
            ((System.ComponentModel.ISupportInitialize)(this.avatarsanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tensanpham;
        private System.Windows.Forms.PictureBox avatarsanpham;
    }
}
